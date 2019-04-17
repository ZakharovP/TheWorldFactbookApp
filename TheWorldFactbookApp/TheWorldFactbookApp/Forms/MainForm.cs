using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TheWorldFactbookLib;

namespace TheWorldFactbookApp.Forms
{
    public partial class MainForm : Form
    {
        DataTable table = new DataTable();
        private const string ResourcesFolder = "Resources";
        private const string AllCountriesFile = "CIACountries.xml";
        private const string Title = "The World Factbook";
        private const string NewTag = "New...";
        private static string ResourcesFolderFull = Path.GetFullPath(ResourcesFolder);
        private static string DefaultFile = Path.GetFullPath(Path.Combine(ResourcesFolder, AllCountriesFile));
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            table.Columns.Add(Country.NameLabel, typeof(string));
            table.Columns.Add(Country.CapitalLabel, typeof(string));
            table.Columns.Add(Geography.TotalAreaLabel, typeof(long));
            table.Columns.Add(Population.AmountLabel, typeof(long));
            table.Columns.Add(Economy.GDPNominalLabel, typeof(long));
            table.Columns.Add(Economy.GDPpppLabel, typeof(long));
            countLabel.Text = "0";
        }

        private void UpdateCountLabel()
        {
            countLabel.Text = table.Rows.Count.ToString();
        }

        private void Form_load(object sender, EventArgs e)
        {
            string filename = Utils.GetLastFile(DefaultFile);
            Utils.SetCountries2Table(Utils.ReadCountries(filename), table);
            UpdateCountLabel();
        }
        
        private void addbutton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
            if (form.Country == null) return;
            DataRow dr = table.NewRow();
            Utils.UpdateDataRow(dr, form.Country);
            table.Rows.Add(dr);
            UpdateCountLabel();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id73114955");
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ZakharovP/TheWorldFactbookApp");
        }

        private void cIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cia.gov/library/publications/resources/the-world-factbook/");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"You clicked New button!!!", @"Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRow[] dataRows = new DataRow[dataGridView1.SelectedRows.Count];
                for (int i = 0; i< dataGridView1.SelectedRows.Count; i++)
                {
                    dataRows[i] = ((DataRowView)dataGridView1.SelectedRows[i].DataBoundItem).Row;
                }
                for (int i = 0; i < dataRows.Length; i++)
                {
                    table.Rows.Remove(dataRows[i]) ;
                }
                UpdateCountLabel();
            } 
            else
            {
                MessageBox.Show(@"Delete: please select at least one row", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Update: please select one row", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show(@"Update: please select one row (not many)", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataRow selRow = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
                Country c = Utils.DataRow2Country(selRow);
                UpdateForm form = new UpdateForm(c);
                form.ShowDialog();
                if (form.Country == null) return;
                Utils.UpdateDataRow(selRow, form.Country);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            Country min = new Country()
            {
                Geography = new Geography()
                {
                    TotalArea = long.MaxValue
                },
                Population = new Population()
                {
                    Amount = long.MaxValue
                },
                Economy = new Economy()
                {
                    GDPnominal = long.MaxValue,
                    GDPppp = long.MaxValue
                }
            };
            Country max = new Country()
            {
                Geography = new Geography()
                {
                    TotalArea = long.MinValue
                },
                Population = new Population()
                {
                    Amount = long.MinValue
                },
                Economy = new Economy()
                {
                    GDPnominal = long.MinValue,
                    GDPppp = long.MinValue
                }
            };
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Country c = Utils.DataRow2Country(table.Rows[i]);
                min.Geography.TotalArea = Math.Min(c.Geography.TotalArea, min.Geography.TotalArea);
                max.Geography.TotalArea = Math.Max(c.Geography.TotalArea, max.Geography.TotalArea);
                min.Population.Amount = Math.Min(c.Population.Amount, min.Population.Amount);
                max.Population.Amount = Math.Max(c.Population.Amount, max.Population.Amount);
                min.Economy.GDPnominal = Math.Min(c.Economy.GDPnominal, min.Economy.GDPnominal);
                max.Economy.GDPnominal = Math.Max(c.Economy.GDPnominal, max.Economy.GDPnominal);
                min.Economy.GDPppp = Math.Min(c.Economy.GDPppp, min.Economy.GDPppp);
                max.Economy.GDPppp = Math.Max(c.Economy.GDPppp, max.Economy.GDPppp);
            }
            FilterForm form = new FilterForm(min, max);
            form.ShowDialog();
            if (form.min == null || form.max == null)
            {
                return;
            }
            List<DataRow> dataRows = new List<DataRow>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Country c = Utils.DataRow2Country(table.Rows[i]);
                if (min.Geography.TotalArea > c.Geography.TotalArea ||
                    max.Geography.TotalArea < c.Geography.TotalArea ||
                    min.Population.Amount > c.Population.Amount ||
                    max.Population.Amount < c.Population.Amount ||
                    min.Economy.GDPnominal > c.Economy.GDPnominal ||
                    max.Economy.GDPnominal < c.Economy.GDPnominal ||
                    min.Economy.GDPppp > c.Economy.GDPppp ||
                    max.Economy.GDPppp < c.Economy.GDPppp
                    )
                {
                    dataRows.Add(table.Rows[i]);
                }
            }
            for (int i = 0; i < dataRows.Count; i++)
            {
                table.Rows.Remove(dataRows[i]);
            }
            UpdateCountLabel();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "xml";
            openFileDialog.Filter = "XML file (*.xml)|*.xml";
            openFileDialog.InitialDirectory = ResourcesFolderFull;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = Path.GetFullPath(openFileDialog.FileName);
                string foldername = Path.GetDirectoryName(filename);
                string resourcefolder = Path.GetFullPath(ResourcesFolder);
                if (foldername != ResourcesFolderFull)
                {
                    MessageBox.Show($@"Open: please open file from {ResourcesFolderFull}", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Utils.SetLastFile(filename);
                Utils.SetCountries2Table(Utils.ReadCountries(filename), table);
                UpdateCountLabel();
            }
        }

        private void clearRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ClearRegistry();
            MessageBox.Show(@"Clear Registry: done", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


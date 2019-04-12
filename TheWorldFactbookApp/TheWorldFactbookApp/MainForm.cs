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

namespace TheWorldFactbookApp
{
    public partial class MainForm : Form
    {
        DataTable table = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Capital", typeof(string));
            table.Columns.Add("Total Area (sq km)", typeof(long));
            table.Columns.Add("Population", typeof(long));
            table.Columns.Add("GDP nominal (mln usd)", typeof(long));
            table.Columns.Add("GDP ppp (usd)", typeof(long));
            countLabel.Text = "0";
        }
        private void Form_load(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Country[]));

            String filename = Path.Combine("Resources", "CIACountries.xml");
            Country[] countries;
            using (StreamReader reader = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read)))
            {
                countries = (Country[])formatter.Deserialize(reader);
            }
            for (int i = 0; i<countries.Length; i++)
            {
                DataRow dr = table.NewRow();
                dr["Name"] = countries[i].Name;
                dr["Capital"] = countries[i].Capital;
                dr["Total Area (sq km)"] = countries[i].Geography.TotalArea;
                dr["Population"] = countries[i].Population.Amount;
                dr["GDP nominal (mln usd)"] = countries[i].Economy.GDPnominal;
                dr["GDP ppp (usd)"] = countries[i].Economy.GDPppp;
                table.Rows.Add(dr);
            }
            countLabel.Text = countries.Length.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

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
                countLabel.Text = table.Rows.Count.ToString();
            } 
            else
            {
                MessageBox.Show(@"Delete: please select at least one row", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

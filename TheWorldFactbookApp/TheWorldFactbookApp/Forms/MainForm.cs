﻿using System;
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
                UpdateDataRow(dr, countries[i]);
                table.Rows.Add(dr);
            }
            countLabel.Text = countries.Length.ToString();
        }
        private void UpdateDataRow(DataRow dr, Country c)
        {
            dr[Country.NameLabel] = c.Name;
            dr[Country.CapitalLabel] = c.Capital;
            dr[Geography.TotalAreaLabel] = c.Geography.TotalArea;
            dr[Population.AmountLabel] = c.Population.Amount;
            dr[Economy.GDPNominalLabel] = c.Economy.GDPnominal;
            dr[Economy.GDPpppLabel] = c.Economy.GDPppp;
        }
        private Country DataRow2Country(DataRow dr)
        {
            Country c = new Country()
            {
                Name = (string)dr[Country.NameLabel],
                Capital = (string)dr[Country.CapitalLabel],
                Geography = new Geography()
                {
                    TotalArea = (long)dr[Geography.TotalAreaLabel]
                },
                Population = new Population()
                {
                    Amount = (long)dr[Population.AmountLabel]
                },
                Economy = new Economy()
                {
                    GDPnominal = (long)dr[Economy.GDPNominalLabel],
                    GDPppp = (long)dr[Economy.GDPpppLabel]
                }
            };
            return c;
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
            if (form.Country == null) return;
            DataRow dr = table.NewRow();
            UpdateDataRow(dr, form.Country);
            table.Rows.Add(dr);
            countLabel.Text = table.Rows.Count.ToString();
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
                Country c = DataRow2Country(selRow);
                UpdateForm form = new UpdateForm(c);
                form.ShowDialog();
                if (form.Country == null) return;
                UpdateDataRow(selRow, form.Country);
            }
        }
    }
}

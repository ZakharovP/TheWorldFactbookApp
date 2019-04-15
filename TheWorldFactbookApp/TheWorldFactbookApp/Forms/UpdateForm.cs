using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWorldFactbookLib;

namespace TheWorldFactbookApp.Forms
{
    public partial class UpdateForm : Form
    {
        public Country Country = null;
        public UpdateForm(Country c)
        {
            InitializeComponent();
            NameTextBox.Text = c.Name;
            CapitalTextBox.Text = c.Capital;
            AreaTextBox.Text = c.Geography.TotalArea.ToString();
            PopulationTextBox.Text = c.Population.Amount.ToString();
            GDPNominalTextBox.Text = c.Economy.GDPnominal.ToString();
            GDPpppTextBox.Text = c.Economy.GDPppp.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show(@"Update: please write country's name", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(AreaTextBox.Text, out long area))
            {
                MessageBox.Show($@"Update: cannot parse '{Geography.TotalAreaLabel}' - '{AreaTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(PopulationTextBox.Text, out long population))
            {
                MessageBox.Show($@"Update: cannot parse '{Population.AmountLabel}' - '{PopulationTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(GDPNominalTextBox.Text, out long nominal))
            {
                MessageBox.Show($@"Update: cannot parse '{Economy.GDPNominalLabel}' - '{GDPNominalTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(GDPpppTextBox.Text, out long ppp))
            {
                MessageBox.Show($@"Update: cannot parse '{Economy.GDPpppLabel}' - '{GDPpppTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Country = new Country()
            {
                Name = NameTextBox.Text,
                Capital = CapitalTextBox.Text,
                Geography = new Geography()
                {
                    TotalArea = area
                },
                Population = new Population()
                {
                    Amount = population
                },
                Economy = new Economy()
                {
                    GDPnominal = nominal,
                    GDPppp = ppp,
                }
            };
            Close();
        }
    }
}

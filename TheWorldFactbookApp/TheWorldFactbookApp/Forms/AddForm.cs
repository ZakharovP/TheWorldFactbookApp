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
    public partial class AddForm : Form
    {
        public Country Country = null;
        public AddForm()
        {
            InitializeComponent();
            AreaTextBox.Text = "0";
            PopulationTextBox.Text = "0";
            GDPNominalTextBox.Text = "0";
            GDPpppTextBox.Text = "0";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show(@"Add: please write country's name", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(AreaTextBox.Text, out long area))
            {
                MessageBox.Show($@"Add: cannot parse '{Geography.TotalAreaLabel}' - '{AreaTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(PopulationTextBox.Text, out long population))
            {
                MessageBox.Show($@"Add: cannot parse '{Population.AmountLabel}' - '{PopulationTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(GDPNominalTextBox.Text, out long nominal))
            {
                MessageBox.Show($@"Add: cannot parse '{Economy.GDPNominalLabel}' - '{GDPNominalTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(GDPpppTextBox.Text, out long ppp))
            {
                MessageBox.Show($@"Add: cannot parse '{Economy.GDPpppLabel}' - '{GDPpppTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

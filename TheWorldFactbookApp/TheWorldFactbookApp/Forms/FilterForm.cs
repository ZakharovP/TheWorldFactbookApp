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
    public partial class FilterForm : Form
    {
        public Country min;
        public Country max;
        public FilterForm(Country min, Country max)
        {
            InitializeComponent();
            this.min = min;
            this.max = max;
            AreaFromTextBox.Text = min.Geography.TotalArea.ToString();
            PopulationFromTextBox.Text = min.Population.Amount.ToString();
            GDPNominalFromTextBox.Text = min.Economy.GDPnominal.ToString();
            GDPpppFromTextBox.Text = min.Economy.GDPppp.ToString();
            AreaToTextBox.Text = max.Geography.TotalArea.ToString();
            PopulationToTextBox.Text = max.Population.Amount.ToString();
            GDPNominalToTextBox.Text = max.Economy.GDPnominal.ToString();
            GDPpppToTextBox.Text = max.Economy.GDPppp.ToString();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(AreaFromTextBox.Text, out min.Geography.TotalArea))
            {
                MessageBox.Show($@"Filter: cannot parse '{Geography.TotalAreaLabel}' - '{AreaFromTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            if (!long.TryParse(AreaToTextBox.Text, out max.Geography.TotalArea))
            {
                MessageBox.Show($@"Filter: cannot parse '{Geography.TotalAreaLabel}' - '{AreaToTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            if (!long.TryParse(PopulationFromTextBox.Text, out min.Population.Amount))
            {
                MessageBox.Show($@"Filter: cannot parse '{Population.AmountLabel}' - '{PopulationFromTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            if (!long.TryParse(PopulationToTextBox.Text, out max.Population.Amount))
            {
                MessageBox.Show($@"Filter: cannot parse '{Population.AmountLabel}' - '{PopulationToTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            if (!long.TryParse(GDPNominalFromTextBox.Text, out min.Economy.GDPnominal))
            {
                MessageBox.Show($@"Filter: cannot parse '{Economy.GDPNominalLabel}' - '{GDPNominalFromTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            if (!long.TryParse(GDPNominalToTextBox.Text, out max.Economy.GDPnominal))
            {
                MessageBox.Show($@"Filter: cannot parse '{Economy.GDPNominalLabel}' - '{GDPNominalToTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            if (!long.TryParse(GDPpppFromTextBox.Text, out min.Economy.GDPppp))
            {
                MessageBox.Show($@"Filter: cannot parse '{Economy.GDPpppLabel}' - '{GDPpppFromTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            if (!long.TryParse(GDPpppToTextBox.Text, out max.Economy.GDPppp))
            {
                MessageBox.Show($@"Filter: cannot parse '{Economy.GDPpppLabel}' - '{GDPpppToTextBox.Text}'", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                min = null; max = null;
                return;
            }
            Close();
        }
    }
}

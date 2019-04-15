namespace TheWorldFactbookApp.Forms
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AreaFromTextBox = new System.Windows.Forms.TextBox();
            this.PopulationFromTextBox = new System.Windows.Forms.TextBox();
            this.GDPNominalFromTextBox = new System.Windows.Forms.TextBox();
            this.GDPpppFromTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.AreaToTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PopulationToTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GDPNominalToTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GDPpppToTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Area (sq km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Population";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "GDP nominal (mln usd)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "GDP ppp (usd)";
            // 
            // AreaFromTextBox
            // 
            this.AreaFromTextBox.Location = new System.Drawing.Point(171, 12);
            this.AreaFromTextBox.Name = "AreaFromTextBox";
            this.AreaFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaFromTextBox.TabIndex = 8;
            // 
            // PopulationFromTextBox
            // 
            this.PopulationFromTextBox.Location = new System.Drawing.Point(171, 80);
            this.PopulationFromTextBox.Name = "PopulationFromTextBox";
            this.PopulationFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.PopulationFromTextBox.TabIndex = 9;
            // 
            // GDPNominalFromTextBox
            // 
            this.GDPNominalFromTextBox.Location = new System.Drawing.Point(171, 147);
            this.GDPNominalFromTextBox.Name = "GDPNominalFromTextBox";
            this.GDPNominalFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.GDPNominalFromTextBox.TabIndex = 10;
            // 
            // GDPpppFromTextBox
            // 
            this.GDPpppFromTextBox.Location = new System.Drawing.Point(171, 214);
            this.GDPpppFromTextBox.Name = "GDPpppFromTextBox";
            this.GDPpppFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.GDPpppFromTextBox.TabIndex = 11;
            // 
            // FilterButton
            // 
            this.FilterButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FilterButton.Location = new System.Drawing.Point(0, 265);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(310, 74);
            this.FilterButton.TabIndex = 12;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // AreaToTextBox
            // 
            this.AreaToTextBox.Location = new System.Drawing.Point(171, 38);
            this.AreaToTextBox.Name = "AreaToTextBox";
            this.AreaToTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaToTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(277, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(277, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "to";
            // 
            // PopulationToTextBox
            // 
            this.PopulationToTextBox.Location = new System.Drawing.Point(171, 106);
            this.PopulationToTextBox.Name = "PopulationToTextBox";
            this.PopulationToTextBox.Size = new System.Drawing.Size(100, 20);
            this.PopulationToTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(277, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(277, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "from";
            // 
            // GDPNominalToTextBox
            // 
            this.GDPNominalToTextBox.Location = new System.Drawing.Point(171, 173);
            this.GDPNominalToTextBox.Name = "GDPNominalToTextBox";
            this.GDPNominalToTextBox.Size = new System.Drawing.Size(100, 20);
            this.GDPNominalToTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(277, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "to";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(277, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "from";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(277, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "to";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(277, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "from";
            // 
            // GDPpppToTextBox
            // 
            this.GDPpppToTextBox.Location = new System.Drawing.Point(171, 239);
            this.GDPpppToTextBox.Name = "GDPpppToTextBox";
            this.GDPpppToTextBox.Size = new System.Drawing.Size(100, 20);
            this.GDPpppToTextBox.TabIndex = 24;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(310, 339);
            this.Controls.Add(this.GDPpppToTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GDPNominalToTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PopulationToTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreaToTextBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.GDPpppFromTextBox);
            this.Controls.Add(this.GDPNominalFromTextBox);
            this.Controls.Add(this.PopulationFromTextBox);
            this.Controls.Add(this.AreaFromTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.ShowIcon = false;
            this.Text = "Filter Countries";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AreaFromTextBox;
        private System.Windows.Forms.TextBox PopulationFromTextBox;
        private System.Windows.Forms.TextBox GDPNominalFromTextBox;
        private System.Windows.Forms.TextBox GDPpppFromTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox AreaToTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PopulationToTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GDPNominalToTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GDPpppToTextBox;
    }
}
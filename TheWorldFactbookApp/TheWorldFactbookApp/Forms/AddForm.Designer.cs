using TheWorldFactbookLib;

namespace TheWorldFactbookApp.Forms
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CapitalTextBox = new System.Windows.Forms.TextBox();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.PopulationTextBox = new System.Windows.Forms.TextBox();
            this.GDPNominalTextBox = new System.Windows.Forms.TextBox();
            this.GDPpppTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Area (sq km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Population";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "GDP nominal (mln usd)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "GDP ppp (usd)";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(171, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // CapitalTextBox
            // 
            this.CapitalTextBox.Location = new System.Drawing.Point(171, 70);
            this.CapitalTextBox.Name = "CapitalTextBox";
            this.CapitalTextBox.Size = new System.Drawing.Size(100, 20);
            this.CapitalTextBox.TabIndex = 7;
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(171, 108);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaTextBox.TabIndex = 8;
            // 
            // PopulationTextBox
            // 
            this.PopulationTextBox.Location = new System.Drawing.Point(171, 146);
            this.PopulationTextBox.Name = "PopulationTextBox";
            this.PopulationTextBox.Size = new System.Drawing.Size(100, 20);
            this.PopulationTextBox.TabIndex = 9;
            // 
            // GDPNominalTextBox
            // 
            this.GDPNominalTextBox.Location = new System.Drawing.Point(171, 184);
            this.GDPNominalTextBox.Name = "GDPNominalTextBox";
            this.GDPNominalTextBox.Size = new System.Drawing.Size(100, 20);
            this.GDPNominalTextBox.TabIndex = 10;
            // 
            // GDPpppTextBox
            // 
            this.GDPpppTextBox.Location = new System.Drawing.Point(171, 222);
            this.GDPpppTextBox.Name = "GDPpppTextBox";
            this.GDPpppTextBox.Size = new System.Drawing.Size(100, 20);
            this.GDPpppTextBox.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddButton.Location = new System.Drawing.Point(0, 265);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(310, 74);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(310, 339);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GDPpppTextBox);
            this.Controls.Add(this.GDPNominalTextBox);
            this.Controls.Add(this.PopulationTextBox);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.CapitalTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.Text = "Add New Country";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CapitalTextBox;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.TextBox PopulationTextBox;
        private System.Windows.Forms.TextBox GDPNominalTextBox;
        private System.Windows.Forms.TextBox GDPpppTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}
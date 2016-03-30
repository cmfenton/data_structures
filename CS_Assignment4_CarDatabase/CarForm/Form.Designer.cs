namespace CarForm
{
    partial class Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.gbxCar = new System.Windows.Forms.GroupBox();
            this.specialInputVIN = new CustomControl.SpecialInput();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtbxYear = new System.Windows.Forms.TextBox();
            this.txtbxMake = new System.Windows.Forms.TextBox();
            this.txtbxModel = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbxCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            this.printingToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.printingToolStripMenuItem.Text = "Printing";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(13, 25);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Language";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "English",
            "French"});
            this.cbxLanguage.Location = new System.Drawing.Point(74, 22);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbxLanguage.TabIndex = 2;
            // 
            // gbxCar
            // 
            this.gbxCar.Controls.Add(this.specialInputVIN);
            this.gbxCar.Controls.Add(this.cbxType);
            this.gbxCar.Controls.Add(this.txtbxYear);
            this.gbxCar.Controls.Add(this.txtbxMake);
            this.gbxCar.Controls.Add(this.txtbxModel);
            this.gbxCar.Controls.Add(this.lblType);
            this.gbxCar.Controls.Add(this.lblYear);
            this.gbxCar.Controls.Add(this.lblMake);
            this.gbxCar.Controls.Add(this.lblModel);
            this.gbxCar.Location = new System.Drawing.Point(12, 49);
            this.gbxCar.Name = "gbxCar";
            this.gbxCar.Size = new System.Drawing.Size(402, 154);
            this.gbxCar.TabIndex = 3;
            this.gbxCar.TabStop = false;
            this.gbxCar.Text = "Car";
            // 
            // specialInputVIN
            // 
            this.specialInputVIN.limit = 12;
            this.specialInputVIN.Location = new System.Drawing.Point(228, 19);
            this.specialInputVIN.Name = "specialInputVIN";
            this.specialInputVIN.Size = new System.Drawing.Size(161, 27);
            this.specialInputVIN.TabIndex = 11;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "C",
            "T",
            "P"});
            this.cbxType.Location = new System.Drawing.Point(62, 121);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 4;
            // 
            // txtbxYear
            // 
            this.txtbxYear.Location = new System.Drawing.Point(62, 88);
            this.txtbxYear.Name = "txtbxYear";
            this.txtbxYear.Size = new System.Drawing.Size(121, 20);
            this.txtbxYear.TabIndex = 10;
            // 
            // txtbxMake
            // 
            this.txtbxMake.Location = new System.Drawing.Point(62, 55);
            this.txtbxMake.Name = "txtbxMake";
            this.txtbxMake.Size = new System.Drawing.Size(121, 20);
            this.txtbxMake.TabIndex = 9;
            // 
            // txtbxModel
            // 
            this.txtbxModel.Location = new System.Drawing.Point(62, 22);
            this.txtbxModel.Name = "txtbxModel";
            this.txtbxModel.Size = new System.Drawing.Size(121, 20);
            this.txtbxModel.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.Blue;
            this.lblType.Location = new System.Drawing.Point(6, 124);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Blue;
            this.lblYear.Location = new System.Drawing.Point(6, 91);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.ForeColor = System.Drawing.Color.Blue;
            this.lblMake.Location = new System.Drawing.Point(6, 58);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 5;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.Blue;
            this.lblModel.Location = new System.Drawing.Point(6, 25);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 215);
            this.Controls.Add(this.gbxCar);
            this.Controls.Add(this.cbxLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "Car Detail";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxCar.ResumeLayout(false);
            this.gbxCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.GroupBox gbxCar;
        internal System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtbxYear;
        private System.Windows.Forms.TextBox txtbxMake;
        private System.Windows.Forms.TextBox txtbxModel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private CustomControl.SpecialInput specialInputVIN;
    }
}


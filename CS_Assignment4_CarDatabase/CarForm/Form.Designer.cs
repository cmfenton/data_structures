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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.gbxCar = new System.Windows.Forms.GroupBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtbxYear = new System.Windows.Forms.TextBox();
            this.txtbxMake = new System.Windows.Forms.TextBox();
            this.txtbxModel = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTrimCode = new System.Windows.Forms.Label();
            this.txtbxTrimCode = new System.Windows.Forms.TextBox();
            this.specialInputVIN = new CustomControl.SpecialInput();
            this.lblAxles = new System.Windows.Forms.Label();
            this.txtbxAxles = new System.Windows.Forms.TextBox();
            this.lblTonnage = new System.Windows.Forms.Label();
            this.txtbxTonnage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.gbxCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(502, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
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
            this.gbxCar.Controls.Add(this.txtbxTonnage);
            this.gbxCar.Controls.Add(this.lblTonnage);
            this.gbxCar.Controls.Add(this.txtbxAxles);
            this.gbxCar.Controls.Add(this.lblAxles);
            this.gbxCar.Controls.Add(this.specialInputVIN);
            this.gbxCar.Controls.Add(this.txtbxTrimCode);
            this.gbxCar.Controls.Add(this.lblTrimCode);
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
            // lblTrimCode
            // 
            this.lblTrimCode.AutoSize = true;
            this.lblTrimCode.ForeColor = System.Drawing.Color.Teal;
            this.lblTrimCode.Location = new System.Drawing.Point(214, 58);
            this.lblTrimCode.Name = "lblTrimCode";
            this.lblTrimCode.Size = new System.Drawing.Size(52, 13);
            this.lblTrimCode.TabIndex = 12;
            this.lblTrimCode.Text = "TrimCode";
            // 
            // txtbxTrimCode
            // 
            this.txtbxTrimCode.Location = new System.Drawing.Point(272, 55);
            this.txtbxTrimCode.Name = "txtbxTrimCode";
            this.txtbxTrimCode.Size = new System.Drawing.Size(121, 20);
            this.txtbxTrimCode.TabIndex = 13;
            // 
            // specialInputVIN
            // 
            this.specialInputVIN.limit = 12;
            this.specialInputVIN.Location = new System.Drawing.Point(245, 17);
            this.specialInputVIN.Name = "specialInputVIN";
            this.specialInputVIN.Size = new System.Drawing.Size(151, 25);
            this.specialInputVIN.TabIndex = 14;
            this.specialInputVIN.valid = true;
            // 
            // lblAxles
            // 
            this.lblAxles.AutoSize = true;
            this.lblAxles.ForeColor = System.Drawing.Color.Red;
            this.lblAxles.Location = new System.Drawing.Point(231, 91);
            this.lblAxles.Name = "lblAxles";
            this.lblAxles.Size = new System.Drawing.Size(32, 13);
            this.lblAxles.TabIndex = 15;
            this.lblAxles.Text = "Axles";
            // 
            // txtbxAxles
            // 
            this.txtbxAxles.Location = new System.Drawing.Point(272, 88);
            this.txtbxAxles.Name = "txtbxAxles";
            this.txtbxAxles.Size = new System.Drawing.Size(121, 20);
            this.txtbxAxles.TabIndex = 16;
            // 
            // lblTonnage
            // 
            this.lblTonnage.AutoSize = true;
            this.lblTonnage.ForeColor = System.Drawing.Color.Red;
            this.lblTonnage.Location = new System.Drawing.Point(213, 124);
            this.lblTonnage.Name = "lblTonnage";
            this.lblTonnage.Size = new System.Drawing.Size(50, 13);
            this.lblTonnage.TabIndex = 17;
            this.lblTonnage.Text = "Tonnage";
            // 
            // txtbxTonnage
            // 
            this.txtbxTonnage.Location = new System.Drawing.Point(272, 121);
            this.txtbxTonnage.Name = "txtbxTonnage";
            this.txtbxTonnage.Size = new System.Drawing.Size(121, 20);
            this.txtbxTonnage.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(420, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 215);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxCar);
            this.Controls.Add(this.cbxLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form";
            this.Text = "Car Detail";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbxCar.ResumeLayout(false);
            this.gbxCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
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
        private System.Windows.Forms.TextBox txtbxTrimCode;
        private System.Windows.Forms.Label lblTrimCode;
        private CustomControl.SpecialInput specialInputVIN;
        private System.Windows.Forms.TextBox txtbxAxles;
        private System.Windows.Forms.Label lblAxles;
        private System.Windows.Forms.TextBox txtbxTonnage;
        private System.Windows.Forms.Label lblTonnage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
    }
}


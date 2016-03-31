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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.gbxCar = new System.Windows.Forms.GroupBox();
            this.txtbxTonnage = new System.Windows.Forms.TextBox();
            this.lblTonnage = new System.Windows.Forms.Label();
            this.txtbxAxles = new System.Windows.Forms.TextBox();
            this.lblAxles = new System.Windows.Forms.Label();
            this.txtbxTrimCode = new System.Windows.Forms.TextBox();
            this.lblTrimCode = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtbxYear = new System.Windows.Forms.TextBox();
            this.txtbxMake = new System.Windows.Forms.TextBox();
            this.txtbxModel = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.specialInputVIN = new CustomControl.SpecialInput();
            this.menuStrip.SuspendLayout();
            this.gbxCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printingToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            resources.ApplyResources(this.printingToolStripMenuItem, "printingToolStripMenuItem");
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            resources.GetString("cbxLanguage.Items"),
            resources.GetString("cbxLanguage.Items1")});
            resources.ApplyResources(this.cbxLanguage, "cbxLanguage");
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
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
            resources.ApplyResources(this.gbxCar, "gbxCar");
            this.gbxCar.Name = "gbxCar";
            this.gbxCar.TabStop = false;
            // 
            // txtbxTonnage
            // 
            resources.ApplyResources(this.txtbxTonnage, "txtbxTonnage");
            this.txtbxTonnage.Name = "txtbxTonnage";
            // 
            // lblTonnage
            // 
            resources.ApplyResources(this.lblTonnage, "lblTonnage");
            this.lblTonnage.ForeColor = System.Drawing.Color.Red;
            this.lblTonnage.Name = "lblTonnage";
            // 
            // txtbxAxles
            // 
            resources.ApplyResources(this.txtbxAxles, "txtbxAxles");
            this.txtbxAxles.Name = "txtbxAxles";
            // 
            // lblAxles
            // 
            resources.ApplyResources(this.lblAxles, "lblAxles");
            this.lblAxles.ForeColor = System.Drawing.Color.Red;
            this.lblAxles.Name = "lblAxles";
            // 
            // txtbxTrimCode
            // 
            resources.ApplyResources(this.txtbxTrimCode, "txtbxTrimCode");
            this.txtbxTrimCode.Name = "txtbxTrimCode";
            // 
            // lblTrimCode
            // 
            resources.ApplyResources(this.lblTrimCode, "lblTrimCode");
            this.lblTrimCode.ForeColor = System.Drawing.Color.Teal;
            this.lblTrimCode.Name = "lblTrimCode";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            resources.GetString("cbxType.Items"),
            resources.GetString("cbxType.Items1"),
            resources.GetString("cbxType.Items2")});
            resources.ApplyResources(this.cbxType, "cbxType");
            this.cbxType.Name = "cbxType";
            // 
            // txtbxYear
            // 
            resources.ApplyResources(this.txtbxYear, "txtbxYear");
            this.txtbxYear.Name = "txtbxYear";
            // 
            // txtbxMake
            // 
            resources.ApplyResources(this.txtbxMake, "txtbxMake");
            this.txtbxMake.Name = "txtbxMake";
            // 
            // txtbxModel
            // 
            resources.ApplyResources(this.txtbxModel, "txtbxModel");
            this.txtbxModel.Name = "txtbxModel";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.ForeColor = System.Drawing.Color.Blue;
            this.lblType.Name = "lblType";
            // 
            // lblYear
            // 
            resources.ApplyResources(this.lblYear, "lblYear");
            this.lblYear.ForeColor = System.Drawing.Color.Blue;
            this.lblYear.Name = "lblYear";
            // 
            // lblMake
            // 
            resources.ApplyResources(this.lblMake, "lblMake");
            this.lblMake.ForeColor = System.Drawing.Color.Blue;
            this.lblMake.Name = "lblMake";
            // 
            // lblModel
            // 
            resources.ApplyResources(this.lblModel, "lblModel");
            this.lblModel.ForeColor = System.Drawing.Color.Blue;
            this.lblModel.Name = "lblModel";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // specialInputVIN
            // 
            this.specialInputVIN.limit = 12;
            resources.ApplyResources(this.specialInputVIN, "specialInputVIN");
            this.specialInputVIN.Name = "specialInputVIN";
            this.specialInputVIN.valid = true;
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}


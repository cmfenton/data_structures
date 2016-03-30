using System.ComponentModel;

namespace CustomControl
{
    partial class SpecialInput
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVin = new System.Windows.Forms.Label();
            this.txtbxVin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVin
            // 
            this.lblVin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVin.AutoSize = true;
            this.lblVin.ForeColor = System.Drawing.Color.Blue;
            this.lblVin.Location = new System.Drawing.Point(-3, 6);
            this.lblVin.Margin = new System.Windows.Forms.Padding(0);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(25, 13);
            this.lblVin.TabIndex = 0;
            this.lblVin.Text = "VIN";
            // 
            // txtbxVin
            // 
            this.txtbxVin.Location = new System.Drawing.Point(27, 3);
            this.txtbxVin.Name = "txtbxVin";
            this.txtbxVin.Size = new System.Drawing.Size(121, 20);
            this.txtbxVin.TabIndex = 1;
            this.txtbxVin.TextChanged += new System.EventHandler(this.txtbxVin_TextChanged);
            // 
            // SpecialInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbxVin);
            this.Controls.Add(this.lblVin);
            this.Name = "SpecialInput";
            this.Size = new System.Drawing.Size(151, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.TextBox txtbxVin;
    }
}

using System.Globalization;
using System;
using System.Windows.Forms;

namespace CustomControl
{
    [ProvideToolboxControl("CustomControl.VINControl", false)]
    public partial class SpecialInput : UserControl
    {
        public SpecialInput()
        {
            InitializeComponent();
        }

        public int limit { get; set; }
        public bool valid { get; set; }
        public EventHandler textLimit;      

        //checks if the text goes over the limit
        private void txtbxVin_TextChanged(object sender, EventArgs e)
        {
            if (txtbxVin.Text.Length > limit)
            {
                this.valid = false;
                txtbxVin.BackColor = System.Drawing.Color.Red;
                textLimit(sender, e);
            }
            else
            {
                txtbxVin.BackColor = System.Drawing.SystemColors.Window;
                this.valid = true;                
            }
        }
    }
}

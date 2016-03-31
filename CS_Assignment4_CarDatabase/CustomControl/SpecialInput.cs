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
        public override string Text { get; set; }
        public EventHandler textLimit;      

        //checks if the text goes over the limit
        private void txtbxVin_TextChanged(object sender, EventArgs e)
        {
            Text = txtbxVin.Text;

            if (txtbxVin.Text.Length > limit)
            {
                this.valid = false;
                txtbxVin.BackColor = System.Drawing.Color.Red;
                textLimit(sender, e);
            }
            else
            {
                this.valid = true;
                txtbxVin.BackColor = System.Drawing.SystemColors.Window;
                textLimit(sender, e);
            }
        }

        public void ClearTxt()
        {
            txtbxVin.Text = "";
        }
    }
}

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
        public EventHandler textLimit;      

        //checks if the text goes over the limit
        private void txtbxVin_TextChanged(object sender, EventArgs e)
        {
            if (txtbxVin.Text.Length > limit)
            {
                txtbxVin.BackColor = System.Drawing.Color.Red;
                textLimit(sender, e);
            }
        }
    }
}

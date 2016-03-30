using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Event;
namespace CarForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        TextLimit errorHandler = new TextLimit();

        private void Form_Load(object sender, EventArgs e)
        {
            errorHandler.handler += showError;
            specialInputVIN.textLimit += textLimitReached;
        }

        public void textLimitReached(object sender, EventArgs e)
        {
            errorHandler.handle();
        }

        public void showError(String data)
        {
            if (!specialInputVIN.valid)
            {
                MessageBox.Show(data);

                //disable buttons

            }
        }
    }
}

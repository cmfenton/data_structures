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
        TextLimit textLimit = new TextLimit();

        private void Form_Load(object sender, EventArgs e)
        {
            textLimit.handler += fire;
            specialInputVIN.textLimit += textLimitReached;
        }

        public void textLimitReached(object sender, EventArgs e)
        {
            textLimit.handle(true);
        }

        public void fire(String data)
        {
            MessageBox.Show(data);
        }
    }
}

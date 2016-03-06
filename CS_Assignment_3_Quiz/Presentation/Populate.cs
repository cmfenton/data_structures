using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Populate : Form
    {
        public Populate()
        {
            InitializeComponent();
        }

        private void examineeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examineeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDataSet);

        }

        private void Populate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examDataSet.Option' table. You can move, or remove it, as needed.
            this.optionTableAdapter.Fill(this.examDataSet.Option);
            // TODO: This line of code loads data into the 'examDataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.examDataSet.Question);
            // TODO: This line of code loads data into the 'examDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.examDataSet.Quiz);
            // TODO: This line of code loads data into the 'examDataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.examDataSet.Examinee);
            // TODO: This line of code loads data into the 'examDataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.examDataSet.Examinee);
            // TODO: This line of code loads data into the 'examDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.examDataSet.Quiz);
            // TODO: This line of code loads data into the 'examDataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.examDataSet.Question);
            // TODO: This line of code loads data into the 'examDataSet.Option' table. You can move, or remove it, as needed.
            this.optionTableAdapter.Fill(this.examDataSet.Option);
            // TODO: This line of code loads data into the 'examDataSet.Option' table. You can move, or remove it, as needed.
            this.optionTableAdapter.Fill(this.examDataSet.Option);
            // TODO: This line of code loads data into the 'examDataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.examDataSet.Question);
            // TODO: This line of code loads data into the 'examDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.examDataSet.Quiz);
            // TODO: This line of code loads data into the 'examDataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.examDataSet.Examinee);
            // TODO: This line of code loads data into the 'examDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.examDataSet.Quiz);
            // TODO: This line of code loads data into the 'examDataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.examDataSet.Examinee);

        }

        private void examineeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.examineeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDataSet);

        }

        private void optionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.optionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDataSet);

        }

        private void examineeBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.examineeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDataSet);

        }
    }
}

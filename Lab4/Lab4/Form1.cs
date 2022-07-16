using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Retriever retriever = new Retriever();
            
            List<Retriever> list = new List<Retriever>();
            list.Add(retriever);


            if (string.IsNullOrEmpty(numberTxt.Text))
            {
                errorProvider1.SetError(numberTxt,"Number is empty");
            }
            if (string.IsNullOrEmpty(countTxt.Text))
            {
                errorProvider1.SetError(countTxt, "Count is empty");
            }
             if (string.IsNullOrEmpty(dateTxt.Text))
            {
                errorProvider1.SetError(dateTxt, "Date is empty");
            }
            if (string.IsNullOrEmpty(objectNameTxt.Text))
            {
                errorProvider1.SetError(objectNameTxt, "Numberis empty");
            }
            if (string.IsNullOrEmpty(priceTxt.Text))
            {
                errorProvider1.SetError(priceTxt, "Price is empty");
            }
            if (string.IsNullOrEmpty(inventTxt.Text))
            {
                errorProvider1.SetError(inventTxt, "Inventory is empty");
            }

        }

        private void numberTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}

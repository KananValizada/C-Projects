using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameCombo.SelectedItem.ToString() == "Latte")
            {
                if (typeCombo.SelectedItem.ToString() == "Frapp")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 9000).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "Ice")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 7000).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "Hot")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 5000).ToString();
                }
                dataGridView1.Rows.Add(idText.Text, nameCombo.Text, typeCombo.Text, quantityCombo.Text, paymentText.Text);
            }else if(nameCombo.SelectedItem.ToString() == "Chappuchino")
            {
                if (typeCombo.SelectedItem.ToString() == "Frapp")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 8000).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "Ice")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 6500).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "Hot")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 4000).ToString();
                }
                dataGridView1.Rows.Add(idText.Text, nameCombo.Text, typeCombo.Text, quantityCombo.Text, paymentText.Text);
            }
            else if (nameCombo.SelectedItem.ToString() == "Chocolate")
            {
                if (typeCombo.SelectedItem.ToString() == "Frapp")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 7500).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "Ice")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 6000).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "Hot")
                {
                    paymentText.Text = (float.Parse(quantityCombo.Text) * 3500).ToString();
                }
                dataGridView1.Rows.Add(idText.Text, nameCombo.Text, typeCombo.Text, quantityCombo.Text, paymentText.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            nameCombo.Text = "";
            typeCombo.Text = "";
            quantityCombo.Text = "";
            paymentText.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

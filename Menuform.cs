using System;
using System.Windows.Forms;

namespace Login_Form_Application
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void namecom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(idtext.Text, namecom.Text, tipecom.Text, paytext.Text,
            telefonotext.Text, correotext.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecom.Text = "";
            tipecom.Text = "";
            paytext.Text = "";
            telefonotext.Text = "";
            correotext.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanitycom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
        }
    }
    }


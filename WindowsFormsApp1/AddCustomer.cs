using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddCustomer : Form
    {
        public Form RefToForm6 { get; set; }
        public CustomerRecords RefToForm3 { get; set; }
        public Form RefToForm9 { get; set; }
        public string language;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // change display text based on user language
            if (language == "English")
            {
                label1.Text = "Customer ID";
                label2.Text = "Customer Name";
                label3.Text = "Address";
                label4.Text = "City";
                label10.Text = "Country";
                label6.Text = "Phone Number";
                label9.Text = "Apt/Unit";
                label5.Text = "ZIP Code";
                button2.Text = "Back";
            }
            if (language == "Spanish")
            {
                label1.Text = "ID de Cliente";
                label2.Text = "Nombre de Cliente";
                label3.Text = "Dirección";
                label4.Text = "Ciudad";
                label10.Text = "País";
                label6.Text = "Numero de Teléfono";
                label9.Text = "Apt/Unit";
                label5.Text = "Código Postal";
                button2.Text = "Volver";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form references many differrent forms, find which form was referenced and then return to it
            if (RefToForm6 != null)
                RefToForm6.Show();
            if (RefToForm3 != null)
                RefToForm3.Show();
            if (RefToForm9 != null)
                RefToForm9.Show();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //confirmation
            DialogResult result = DialogResult.No;
            if (textBox10.Text.Length < 1 || textBox11.Text.Length < 2
            || textBox4.Text.Length < 2 || textBox5.Text.Length < 2 || textBox6.Text.Length < 2
            || textBox7.Text.Length < 2 || textBox8.Text.Length < 2)
            {
                if (language == "English")
                {
                    MessageBox.Show("All values must be fully filled");
                }
                if (language == "Spanish")
                {
                    MessageBox.Show("Todos los valores deben estar completamente llenos");
                }
            }
            else
            {
                if (language == "English")
                {
                    result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
                }
                if (language == "Spanish")
                {
                    result = MessageBox.Show("Quieres guardar los cambios?", "Confirmacion", MessageBoxButtons.YesNo);
                }

                if (result == DialogResult.Yes)
                {
                    RefToForm3.add(this);
                    CustomerRecords updated = new CustomerRecords();
                    updated.currentUser = RefToForm3.currentUser;
                    updated.ReftoForm2 = RefToForm3.ReftoForm2;
                    updated.language = language;
                    RefToForm3.Close();
                    Hide();
                    updated.Show();
                }
            }
        }
    }
}

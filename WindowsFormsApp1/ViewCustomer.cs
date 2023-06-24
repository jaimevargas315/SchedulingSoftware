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
    public partial class ViewCustomer : Form
    {
        public Form RefToForm6 { get; set; }
        public Form RefToForm3 { get; set; }
        public Form RefToForm9 { get; set; }
        public string language;

        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
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
            if (RefToForm6 != null)
                RefToForm6.Show();
            if (RefToForm3 != null)
                RefToForm3.Show();
            if (RefToForm9 != null)
                RefToForm9.Show();

            Hide();
        }
    }
}

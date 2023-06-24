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
    public partial class NewAppointment : Form
    {
        public Appointments RefToForm5 { get; set; }
        public string language;
        public ClassLibrary3.user currentuser;

        public NewAppointment()
        {
            InitializeComponent();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            // change display text based on user language
            if (language == "English")
            {
                label1.Text = "Customer ID";
                label2.Text = "Customer Name";
                label3.Text = "Title";
                label4.Text = "Description";
                label5.Text = "URL";
                label6.Text = "Contact";
                label7.Text = "Type";
                label8.Text = "End";
                label9.Text = "Start";
                label10.Text = "Location";
                button1.Text = "Save";
                button2.Text = "Cancel";
            }
            if (language == "Spanish")
            {
                label1.Text = "ID de Cliente";
                label2.Text = "Nombre de Cliente";
                label3.Text = "Título";
                label4.Text = "Descripción";
                label5.Text = "URL";
                label6.Text = "Contacto";
                label7.Text = "Tipo";
                label8.Text = "Fin";
                label9.Text = "Inicio";
                label10.Text = "Ubicación";
                button1.Text = "Salvar";
                button2.Text = "Cancelar";
            }

            // created custom format to be able to use both date and time at once
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            RefToForm5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // user confirmation
            DialogResult result = DialogResult.No;
            if (comboBox1.Text.Length < 1 || comboBox2.Text.Length < 2 
             || textBox4.Text.Length < 2 || textBox5.Text.Length < 2 || textBox6.Text.Length < 2
             || textBox7.Text.Length < 2 || textBox2.Text.Length < 2)
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
            if(language == "Spanish")
            {
                result = MessageBox.Show("Quieres guardar los cambios?", "Confirmacion", MessageBoxButtons.YesNo);
            }

                if (result == DialogResult.Yes)
                {

                    bool successful = RefToForm5.add(this);
                    Appointments updated = new Appointments();
                    updated.RefToForm2 = RefToForm5.RefToForm2;
                    updated.currentUser = currentuser;
                    updated.language = language;
                    if (successful)
                    {
                        RefToForm5.Close();
                        Hide();
                        updated.Show();
                    }
                }
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ClassLibrary3.customer q in RefToForm5.dbcontext.customer)
            {
                if(q.customerId.ToString() == comboBox1.Text)
                {
                    textBox8.Text = q.customerName;
                }
            }
        }
    }
}

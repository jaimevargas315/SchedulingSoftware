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
    public partial class ViewAppointment : Form
    {
        public ClassLibrary3.client_scheduleEntities1 dbcontext =
        new ClassLibrary3.client_scheduleEntities1();
        public Form RefToForm5 { get; set; }
        public string language;

        public ViewAppointment()
        {
            InitializeComponent();
        }

        private void ViewAppointment_Load(object sender, EventArgs e)
        {
            if (language == "English")
            {
                label1.Text = "Appointment ID";
                label2.Text = "Customer ID";
                label3.Text = "Title";
                label4.Text = "Description";
                label5.Text = "URL";
                label6.Text = "Contact";
                label7.Text = "Type";
                label8.Text = "End";
                label9.Text = "Start";
                label10.Text = "Location";
                button3.Text = "View Customer";
                button2.Text = "Back";
            }
            if (language == "Spanish")
            {
                label1.Text = "ID de Cita";
                label2.Text = "ID de Cliente";
                label3.Text = "Título";
                label4.Text = "Descripción";
                label5.Text = "URL";
                label6.Text = "Contacto";
                label7.Text = "Tipo";
                label8.Text = "Fin";
                label9.Text = "Inicio";
                label10.Text = "Ubicación";
                button3.Text = "Ver Cliente";
                button2.Text = "Volver";
            }

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

        private void button3_Click(object sender, EventArgs e)
        {
            ViewCustomer view = new ViewCustomer();
            view.RefToForm3 = this;
            view.language = language;
            ClassLibrary3.customer cust = new ClassLibrary3.customer();
            ClassLibrary3.address add = new ClassLibrary3.address();
            ClassLibrary3.city city = new ClassLibrary3.city();
            ClassLibrary3.country country = new ClassLibrary3.country();

            foreach (ClassLibrary3.customer x in dbcontext.customer)
            {
                if (x.customerId.ToString() == textBox8.Text)
                {
                    cust = x;
                }
            }

            foreach (ClassLibrary3.address y in dbcontext.address)
            {
                if (y.addressId == cust.addressId)
                {
                    add = y;
                }
            }
            foreach (ClassLibrary3.city z in dbcontext.city)
            {
                if (add.cityId == z.cityId)
                {
                    city = z;
                }
            }
            foreach (ClassLibrary3.country q in dbcontext.country)
            {
                if (city.countryId == q.countryId)
                {
                    country = q;
                }
            }
            view.textBox1.Text = cust.customerId.ToString();
            view.textBox8.Text = cust.customerName;
            view.textBox7.Text = add.address1;
            view.textBox6.Text = city.city1;
            view.textBox5.Text = country.country1;
            view.textBox4.Text = add.phone;
            view.textBox10.Text = add.address2;
            view.textBox11.Text = add.postalCode;

            Hide();
            view.Show();
        }
        
    }
}

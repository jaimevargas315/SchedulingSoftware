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
    
    public partial class Main : Form
    {
        public ClassLibrary3.user currentUser;
        public string language;
        public ClassLibrary3.client_scheduleEntities1 dbcontext =
        new ClassLibrary3.client_scheduleEntities1();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (language == "English")
            {
                label1.Text = "Main Menu";
                button1.Text = "View Customer Records";
                button2.Text = "View Appointments";
                button3.Text = "Exit";
                button6.Text = "View Reports";
            }
            if (language == "Spanish")
            {
                label1.Text = "Menú Principal";
                button1.Text = "Ver Registros de Clientes";
                button2.Text = "Ver Citas";
                button3.Text = "Salida";
                button6.Text = "Ver Informes";
            }

            foreach(ClassLibrary3.appointment appt in dbcontext.appointment)
            {
                if(currentUser.userId == appt.userId)
                {
                    // appointment data is saved in UNIVERSAL time. translate that to local time
                    // then if an appointment is starting within 15 minutes, display a notice
                    if (appt.start.ToLocalTime() <= DateTime.Now.AddMinutes(15)
                        && appt.start.ToLocalTime() >= DateTime.Now)
                    {
                        if(language == "English")
                        {
                            MessageBox.Show("Notice: upcoming appointment scheduled within 15 minutes", "Notice");
                        }

                        if(language == "Spanish")
                        {
                            MessageBox.Show("Aviso: próxima cita programada dentro de los 15 minutos", "Aviso");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointments appointment = new Appointments();
            appointment.RefToForm2 = this;
            appointment.language = language;
            appointment.currentUser = currentUser;
            Hide();
            appointment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerRecords Records = new CustomerRecords();
            Records.ReftoForm2 = this;
            Records.language = language;
            Records.currentUser = currentUser;
            Hide();
            Records.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // change language then reload current form
        private void button5_Click(object sender, EventArgs e)
        {
            language = "English";
            Main_Load(this, null);
        }
        // change language then reload current form
        private void button4_Click(object sender, EventArgs e)
        {
            language = "Spanish";
            Main_Load(this, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ReftoForm2 = this;
            reports.language = language;
            reports.currentUser = currentUser;
            Hide();
            reports.Show();
        }
    }
}

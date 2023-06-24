using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Reports : Form
    {
        public Main ReftoForm2;
        public string language;
        public ClassLibrary3.user currentUser;
        public ClassLibrary3.client_scheduleEntities1 dbcontext =
        new ClassLibrary3.client_scheduleEntities1();
        public Reports()
        {
            InitializeComponent();
        }

        private int countConsultation = 0;
        private int countTroubleshooting = 0;
        private int countInitial = 0;
        private int countInformational = 0;
        private int countStatus = 0;
        private int countMarketing = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ClassLibrary3.appointment appt in dbcontext.appointment)
            {
                if (appt.type.Contains("Consultation"))
                    countConsultation++;
                if (appt.type.Contains("Troubleshooting"))
                    countTroubleshooting++;
                if (appt.type.Contains("Initial"))
                    countInitial++;
                if (appt.type.Contains("Informational"))
                    countInformational++;
                if (appt.type.Contains("Status"))
                    countStatus++;
                if (appt.type.Contains("Marketing"))
                    countMarketing++;
            }
            DataTable dt = new DataTable();
            DataColumn dtColumn;
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "Consultation Count";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "Troubleshooting Count";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "Initial Count";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "Informational Count";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "Status Update Count";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "Marketing Count";
            dt.Columns.Add(dtColumn);

            dt.Rows.Add(countConsultation, countTroubleshooting, countInitial, countInformational, countStatus, countMarketing);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbcontext.appointment
            .OrderBy(appointment => appointment.appointmentId) // using LINQ lambda to sort by appointment ID
            .Load();
            dataGridView1.DataSource = dbcontext.appointment.Local;
            dataGridView1.Columns.RemoveAt(15);
            dataGridView1.Columns.RemoveAt(15);
            
            if (language == "English")
            {
                dataGridView1.Columns[0].HeaderText = "Appointment ID";
                dataGridView1.Columns[1].HeaderText = "Customer ID";
                dataGridView1.Columns[2].HeaderText = "User ID";
                dataGridView1.Columns[3].HeaderText = "Title";
                dataGridView1.Columns[4].HeaderText = "Description";
                dataGridView1.Columns[5].HeaderText = "Location";
                dataGridView1.Columns[6].HeaderText = "Contact";
                dataGridView1.Columns[7].HeaderText = "Type";
                dataGridView1.Columns[8].HeaderText = "URL";
                dataGridView1.Columns[9].HeaderText = "Start";
                dataGridView1.Columns[10].HeaderText = "End";
                dataGridView1.Columns[11].HeaderText = "Create Date";
                dataGridView1.Columns[12].HeaderText = "Created By";
                dataGridView1.Columns[13].HeaderText = "Last Update";
                dataGridView1.Columns[14].HeaderText = "Last Update By";
            }
            if (language == "Spanish")
            {
                dataGridView1.Columns[0].HeaderText = "ID de Cita";
                dataGridView1.Columns[1].HeaderText = "ID de Cliente";
                dataGridView1.Columns[2].HeaderText = "ID de Usario";
                dataGridView1.Columns[3].HeaderText = "Titulo";
                dataGridView1.Columns[4].HeaderText = "Descripción";
                dataGridView1.Columns[5].HeaderText = "Ubicación";
                dataGridView1.Columns[6].HeaderText = "Contacto";
                dataGridView1.Columns[7].HeaderText = "Tipo";
                dataGridView1.Columns[8].HeaderText = "URL";
                dataGridView1.Columns[9].HeaderText = "Empezar";
                dataGridView1.Columns[10].HeaderText = "Fin";
                dataGridView1.Columns[11].HeaderText = "Fecha de creación";
                dataGridView1.Columns[12].HeaderText = "Creado Por";
                dataGridView1.Columns[13].HeaderText = "Última actualización";
                dataGridView1.Columns[14].HeaderText = "Última actualización Por"; 
            } 
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            if (language == "English")
            {
                button1.Text = "Show amount per type";
                button2.Text = "Show all schedules";
                button3.Text = "Show appointment totals";
                button4.Text = "Go back";
            }

            if (language == "Spanish")
            {
                button1.Text = "Mostrar cantidad por tipo";
                button2.Text = "Mostrar todos los horarios";
                button3.Text = "Mostrar totales de citas";
                button4.Text = "Volver";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(ClassLibrary3.appointment appt in dbcontext.appointment)
            {
                total++;
            }
            DataTable dt = new DataTable();
            DataColumn dtColumn;
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "Total appointments";
            dt.Columns.Add(dtColumn);
            dt.Rows.Add(total);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            ReftoForm2.Show();
        }
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Validation;


namespace WindowsFormsApp1
{
    public partial class Appointments : Form
    {
        public Form RefToForm2 { get; set; }
        public string language;
        public ClassLibrary3.user currentUser;
        public int[] comboItems2;

        public ClassLibrary3.client_scheduleEntities1 dbcontext =
            new ClassLibrary3.client_scheduleEntities1();
        DataTable dt = new DataTable();

        DataColumn dtColumn;


        public Appointments()
        {
            InitializeComponent();

           
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            
            if (dt.Columns.Count == 0) // form gets reloaded a few times, so only does the following code 
                                       // if the data table is empty, its only empty when the form hasnt 
                                       // been loaded for its first time
            {

                // initialize data table
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(Int32);
                dtColumn.ColumnName = "appointmentId";
                dtColumn.Caption = "Appointment ID";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(int);
                dtColumn.ColumnName = "customerId";
                dtColumn.Caption = "Customer ID";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(int);
                dtColumn.ColumnName = "userId";
                dtColumn.Caption = "User ID";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "title";
                dtColumn.Caption = "Title";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "description";
                dtColumn.Caption = "Description";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "location";
                dtColumn.Caption = "Location";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "contact";
                dtColumn.Caption = "Contact";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "type";
                dtColumn.Caption = "Type";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "url";
                dtColumn.Caption = "URL";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(DateTime);
                dtColumn.ColumnName = "start";
                dtColumn.Caption = "Start";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(DateTime);
                dtColumn.ColumnName = "end";
                dtColumn.Caption = "End";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(DateTime);
                dtColumn.ColumnName = "createDate";
                dtColumn.Caption = "Create Date";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "createdBy";
                dtColumn.Caption = "Created By";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(DateTime);
                dtColumn.ColumnName = "lastUpdate";
                dtColumn.Caption = "Last Update";
                dt.Columns.Add(dtColumn);

                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(string);
                dtColumn.ColumnName = "lastUpdateBy";
                dtColumn.Caption = "Last Update By";
                dt.Columns.Add(dtColumn);
            }
            DataRow myDataRow;
            // populate data table
            foreach (ClassLibrary3.appointment apt in dbcontext.appointment)
            {
                if (apt.userId == currentUser.userId)
                {
                    myDataRow = dt.NewRow();
                    myDataRow[0] = apt.appointmentId;
                    myDataRow[1] = apt.customerId;
                    myDataRow[2] = apt.userId;
                    myDataRow[3] = apt.title;
                    myDataRow[4] = apt.description;
                    myDataRow[5] = apt.location;
                    myDataRow[6] = apt.contact;
                    myDataRow[7] = apt.type;
                    myDataRow[8] = apt.url;
                    myDataRow[9] = apt.start.ToLocalTime();
                    myDataRow[10] = apt.end.ToLocalTime();
                    myDataRow[11] = apt.createDate.ToLocalTime();
                    myDataRow[12] = apt.createdBy;
                    myDataRow[13] = apt.lastUpdate.ToLocalTime();
                    myDataRow[14] = apt.lastUpdateBy;

                    dt.Rows.Add(myDataRow);
                    dt.AcceptChanges();
                }
            }
            if (language == "English")
            {
                label1.Text = "All appointments must be between 9AM - 5PM Central Time ";
                button1.Text = "Add new";
                button2.Text = "Back";
                button3.Text = "Edit Selected";
                button4.Text = "View Selected";
                button7.Text = "Show All";
                button5.Text = "Current Week";
                button6.Text = "Current Month";
                button8.Text = "Delete Selected";
                dt.Columns[0].ColumnName = "Appointment ID";
                dt.Columns[1].ColumnName = "Customer ID";
                dt.Columns[2].ColumnName = "User ID";
                dt.Columns[3].ColumnName = "Title";
                dt.Columns[4].ColumnName = "Description";
                dt.Columns[5].ColumnName = "Location";
                dt.Columns[6].ColumnName = "Contact";
                dt.Columns[7].ColumnName = "Type";
                dt.Columns[8].ColumnName = "URL";
                dt.Columns[9].ColumnName = "Start";
                dt.Columns[10].ColumnName = "End";
                dt.Columns[11].ColumnName = "Create Date";
                dt.Columns[12].ColumnName = "Created By";
                dt.Columns[13].ColumnName = "Last Update";
                dt.Columns[14].ColumnName = "Last Update By";
                dt.AcceptChanges();
                dataGridView1.DataSource = dt;
            }
            if (language == "Spanish")
            {
                label1.Text = "Todas las citas deben ser entre las 9 a.m. y las 5 p.m., hora central.";
                button1.Text = "Añadir Nuevo";
                button2.Text = "Volver";
                button3.Text = "Editar Seleccionado";
                button4.Text = "Ver Seleccionado";
                button7.Text = "Mostrar todo";
                button5.Text = "Semana actual";
                button6.Text = "Mez actual";
                button8.Text = "Eliminar seleccionado";
                dt.Columns[0].ColumnName = "ID de Cita";
                dt.Columns[1].ColumnName = "ID de Cliente";
                dt.Columns[2].ColumnName = "ID de Usario";
                dt.Columns[3].ColumnName = "Titulo";
                dt.Columns[4].ColumnName = "Descripción";
                dt.Columns[5].ColumnName = "Ubicación";
                dt.Columns[6].ColumnName = "Contacto";
                dt.Columns[7].ColumnName = "Tipo";
                dt.Columns[8].ColumnName = "URL";
                dt.Columns[9].ColumnName = "Empezar";
                dt.Columns[10].ColumnName = "Fin";
                dt.Columns[11].ColumnName = "Fecha de creación";
                dt.Columns[12].ColumnName = "Creado Por";
                dt.Columns[13].ColumnName = "Última actualización";
                dt.Columns[14].ColumnName = "Última actualización Por";
                dt.AcceptChanges();
                dataGridView1.DataSource = dt;
            }
            // create combobox array named comboitems and assign array values to all customers
            int index = 0;
            int length = dbcontext.customer.Count();
            int[] ComboItems1 = new int[length];
            comboItems2 = ComboItems1;
            foreach (ClassLibrary3.customer q in dbcontext.customer)
            {
                ComboItems1[index] = (q.customerId);
                index++;
            }
        }
        public bool update(EditAppointment x)
        {
            bool success = false;
            ClassLibrary3.appointment appointment = new ClassLibrary3.appointment();
            // search database for matching appointment and assign our local one to it
            foreach (ClassLibrary3.appointment q in dbcontext.appointment.Local)
            {
                if (x.textBox1.Text.ToString() == q.appointmentId.ToString())
                {
                    q.lastUpdateBy = currentUser.userName;
                    q.title = x.textBox7.Text.ToString();
                    q.description = x.textBox6.Text.ToString();
                    q.location = x.textBox5.Text.ToString();
                    q.contact = x.textBox4.Text.ToString();
                    q.type = x.comboBox1.Text.ToString();
                    q.url = x.textBox2.Text.ToString();
                    q.start = x.dateTimePicker1.Value.ToUniversalTime();
                    q.end = x.dateTimePicker2.Value.ToUniversalTime();
                    q.userId = currentUser.userId;

                    //check to see that appointment falls within business hours 
                    // (9am to 5pm central time)
                    //needs to account for daylight saving time, which adds an extra hour
                    if (q.start.IsDaylightSavingTime() == true)
                    {
                        //hour values are in universal time
                        if (q.start.ToUniversalTime().Hour < 14 || q.end.ToUniversalTime().Hour > 22)
                        {
                            if (language == "English")
                            {
                                MessageBox.Show("Appointment not within business hours");
                            }
                            if (language == "Spanish")
                            {
                                MessageBox.Show("Cita no dentro del horario comercial");
                            }
                            return success;
                        }
                    }

                    if (q.start.IsDaylightSavingTime() == false)
                    {
                        if (q.start.ToUniversalTime().Hour < 15 || q.end.ToUniversalTime().Hour > 23)
                        {
                            if (language == "English")
                            {
                                MessageBox.Show("Appointment not within business hours");
                            }
                            if (language == "Spanish")
                            {
                                MessageBox.Show("Cita no dentro del horario comercial");
                            }
                            return success;
                        }
                    }
                    
                    foreach (ClassLibrary3.appointment appt in dbcontext.appointment)
                    {
                        if (appt.userId == q.userId)
                        {
                            if (appt.appointmentId == q.appointmentId) { }

                            else if (q.start <= appt.end
                            && q.end >= appt.start)
                            {
                                if (language == "English")
                                {
                                    MessageBox.Show("Cannot schedule overlapping appointments");
                                }
                                if (language == "Spanish")
                                {
                                    MessageBox.Show("No se pueden programar citas superpuestas");
                                }
                                return success;
                            }
                        }
                    } 
                }
            }
            
            try
            {
                // save database changes
                dbcontext.SaveChanges();
            }
            //catch any type of validation exception and display it to the console
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
            Appointments_Load(this, null);
            success = true;
            return success;
        }
        

        public bool add(NewAppointment x)
        {
            // add works the same as update but always creates a new appointment even if all values are already found
            bool success = false;
            ClassLibrary3.appointment appointment = new ClassLibrary3.appointment();

            foreach (ClassLibrary3.customer q in dbcontext.customer.Local)
            {
                if (x.comboBox1.Text.ToString() == q.customerId.ToString())
                {
                    appointment.customerId = q.customerId;
                }
            }
            appointment.createdBy = currentUser.userName;
            appointment.createDate = DateTime.Now;
            appointment.lastUpdateBy = currentUser.userName;
            appointment.title = x.textBox7.Text.ToString();
            appointment.description = x.textBox6.Text.ToString();
            appointment.location = x.textBox5.Text.ToString();
            appointment.contact = x.textBox4.Text.ToString();
            appointment.type = x.comboBox2.Text.ToString();
            appointment.url = x.textBox2.Text.ToString();
            appointment.start = x.dateTimePicker1.Value.ToUniversalTime();
            appointment.end = x.dateTimePicker2.Value.ToUniversalTime();
            appointment.userId = currentUser.userId;

            if (appointment.start.IsDaylightSavingTime() == true)
            {
                if (appointment.start.ToUniversalTime().Hour <= 14 || appointment.end.ToUniversalTime().Hour > 22)
                {
                    if (language == "English")
                    {
                        MessageBox.Show("Appointment not within business hours");
                    }
                    if (language == "Spanish")
                    {
                        MessageBox.Show("Cita no dentro del horario comercial");
                    }
                    return success;
                }
            }

            if (appointment.start.IsDaylightSavingTime() == false)
            {
                if (appointment.start.ToUniversalTime().Hour <= 13 || appointment.end.ToUniversalTime().Hour > 21)
                {
                    if (language == "English")
                    {
                        MessageBox.Show("Appointment not within business hours");
                    }
                    if (language == "Spanish")
                    {
                        MessageBox.Show("Cita no dentro del horario comercial");
                    }
                    return success;
                }
            }
            foreach(ClassLibrary3.appointment appt in dbcontext.appointment)
            {
                if (appt.userId == appointment.userId)
                {
                    if (appointment.start <= appt.end
                    && appointment.end >= appt.start)
                    {
                        if (language == "English")
                        {
                            MessageBox.Show("Cannot schedule overlapping appointments");
                        }
                        if (language == "Spanish")
                        {
                            MessageBox.Show("No se pueden programar citas superpuestas");
                        }
                        return success;
                    }
                }
            }
            try
            {
                dbcontext.appointment.Add(appointment); // <- add function instead of our update lambda expression
                dbcontext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
            // reload to update datatable
            Appointments_Load(this, null);
            success = true;

            return success;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RefToForm2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NewAppointment newAppointment = new NewAppointment();
            newAppointment.RefToForm5 = this;
            newAppointment.language = language;
            newAppointment.currentuser = currentUser;
            newAppointment.comboBox1.DataSource = comboItems2;

            Hide();
            newAppointment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) // <- doesnt allow processing for null values
            {

                EditAppointment editAppointment = new EditAppointment();
                editAppointment.RefToForm5 = this;
                editAppointment.language = language;
                editAppointment.currentuser = currentUser;

                editAppointment.textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                editAppointment.textBox8.Text = dataGridView1.SelectedCells[1].Value.ToString();
                editAppointment.textBox7.Text = dataGridView1.SelectedCells[3].Value.ToString();
                editAppointment.textBox6.Text = dataGridView1.SelectedCells[4].Value.ToString();
                editAppointment.textBox5.Text = dataGridView1.SelectedCells[5].Value.ToString();
                editAppointment.textBox4.Text = dataGridView1.SelectedCells[6].Value.ToString();
                editAppointment.comboBox1.Text = dataGridView1.SelectedCells[7].Value.ToString();
                editAppointment.textBox2.Text = dataGridView1.SelectedCells[8].Value.ToString();
                editAppointment.dateTimePicker1.Text = dataGridView1.SelectedCells[9].Value.ToString();
                editAppointment.dateTimePicker2.Text = dataGridView1.SelectedCells[10].Value.ToString();


                Hide();
                editAppointment.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ViewAppointment viewAppointment = new ViewAppointment();
                viewAppointment.RefToForm5 = this;
                viewAppointment.language = language;

                viewAppointment.textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                viewAppointment.textBox8.Text = dataGridView1.SelectedCells[1].Value.ToString();
                viewAppointment.textBox7.Text = dataGridView1.SelectedCells[2].Value.ToString();
                viewAppointment.textBox6.Text = dataGridView1.SelectedCells[3].Value.ToString();
                viewAppointment.textBox5.Text = dataGridView1.SelectedCells[4].Value.ToString();
                viewAppointment.textBox4.Text = dataGridView1.SelectedCells[5].Value.ToString();
                viewAppointment.textBox3.Text = dataGridView1.SelectedCells[6].Value.ToString();
                viewAppointment.textBox2.Text = dataGridView1.SelectedCells[7].Value.ToString();
                viewAppointment.dateTimePicker1.Text = dataGridView1.SelectedCells[9].Value.ToString();
                viewAppointment.dateTimePicker2.Text = dataGridView1.SelectedCells[10].Value.ToString();

                Hide();
                viewAppointment.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = dt.Copy();
            dt2.Clear();
            Calendar cal = CultureInfo.CurrentCulture.Calendar; // creates localized calendar
            // get week of year returns the week number
            int week = cal.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);

            // loop through the data table1  
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ( // if week number matches
                     cal.GetWeekOfYear
                     ( DateTime.Parse(dt.Rows[i][9].ToString()),
                     CalendarWeekRule.FirstDay, 
                     CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                     == week)
                {
                    dt2.ImportRow(dt.Rows[i]); // copy row into new data table
                }
            }
            dataGridView1.DataSource = dt2; // new data table is new data source
        }


        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = dt.Copy();
            dt2.Clear();
            Calendar cal = CultureInfo.CurrentCulture.Calendar;
            
            for (int i =0; i < dt.Rows.Count; i++)
            {
                // search for matching month to current month
                DateTime record = DateTime.Parse(dt.Rows[i][9].ToString());
                if (record.Month == DateTime.Now.Month)
                {
                    dt2.ImportRow(dt.Rows[i]); // assign to new data table
                }
            }
            dataGridView1.DataSource = dt2; // new data table is new data source
        }
        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) // <- prevents null values
            {
                // user confirmation
                DialogResult result = DialogResult.No;
                if (language == "English")
                {
                    result = MessageBox.Show("Delete selected row?", "Confirmation", MessageBoxButtons.YesNo);
                }
                if (language == "Spanish")
                {
                    result = MessageBox.Show("Eliminar la fila seleccionada?", "Confirmacion", MessageBoxButtons.YesNo);
                }
                if (result == DialogResult.Yes)
                {
                    // find matching appointment by id in database then remove
                    foreach (ClassLibrary3.appointment appt in dbcontext.appointment)
                    {
                        if (appt.appointmentId.ToString() == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            dbcontext.appointment.Remove(appt);
                        }
                    }
                    // then remove from data table
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString() == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            dt.Rows.RemoveAt(i);

                        }
                    }
                }
                // update data table and data base
                dt.AcceptChanges();
                dbcontext.SaveChanges();
                dataGridView1.DataSource = dt;
            }
        }
    }
}


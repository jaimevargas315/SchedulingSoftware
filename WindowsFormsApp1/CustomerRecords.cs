using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class CustomerRecords : Form
    {
        public Form ReftoForm2 { get; set; }
        public string language;
        public ClassLibrary3.user currentUser;

        public ClassLibrary3.client_scheduleEntities1 dbcontext =
        new ClassLibrary3.client_scheduleEntities1();

        public CustomerRecords()
        {
            InitializeComponent();
        }
        private void CustomerRecords_Load(object sender, EventArgs e)
        {
            //translations based on user language
            


            // initialize data table 
            DataTable dt = new DataTable();

            DataColumn dtColumn;
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "customerId";
            dtColumn.Caption = "Customer ID";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "customerName";
            dtColumn.Caption = "Customer Name";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "address";
            dtColumn.Caption = "Address";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "address2";
            dtColumn.Caption = "Address 2";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "postalCode";
            dtColumn.Caption = "Postal Code";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "phone";
            dtColumn.Caption = "Phone #";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "city";
            dtColumn.Caption = "City";
            dt.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "country";
            dtColumn.Caption = "Country";
            dt.Columns.Add(dtColumn);
            var query =
                (from customer in dbcontext.customer
                join q in dbcontext.address on customer.addressId equals q.addressId
                join x in dbcontext.city on q.cityId equals x.cityId
                join y in dbcontext.country on x.countryId equals y.countryId
                orderby customer.customerId
                select new
                {
                    customer.customerId,
                    customer.customerName,
                    q.address1,
                    q.address2,
                    q.postalCode,
                    q.phone,
                    x.city1,
                    y.country1
                });
            DataRow myDataRow;
            foreach(var row in query)
            {
                myDataRow = dt.NewRow();
                myDataRow[0] = row.customerId.ToString();
                myDataRow[1] = row.customerName;
                myDataRow[2] = row.address1;
                myDataRow[3] = row.address2;
                myDataRow[4] = row.postalCode;
                myDataRow[5] = row.phone;
                myDataRow[6] = row.city1;
                myDataRow[7] = row.country1;

                dt.Rows.Add(myDataRow);
                dt.AcceptChanges();
            }
            dataGridView1.DataSource = dt;

            if (language == "English")
            {
                button5.Text = "Delete Selected";
                button4.Text = "Go Back";
                button3.Text = "Add New";
                button2.Text = "Edit Selected";
                button1.Text = "View Selected";
                dataGridView1.Columns[0].HeaderText = "Customer ID";
                dataGridView1.Columns[1].HeaderText = "Customer Name";
                dataGridView1.Columns[2].HeaderText = "Address";
                dataGridView1.Columns[3].HeaderText = "Address 2";
                dataGridView1.Columns[4].HeaderText = "Postal Code";
                dataGridView1.Columns[5].HeaderText = "Phone #";
                dataGridView1.Columns[6].HeaderText = "City";
                dataGridView1.Columns[7].HeaderText = "Country";


            }
            if (language == "Spanish")
            {
                button5.Text = "Eliminar Seleccionado";
                button4.Text = "Volver";
                button3.Text = "Añadir Nuevo";
                button2.Text = "Editar Seleccionado";
                button1.Text = "Ver Seleccionado";

                dataGridView1.Columns[0].HeaderText = "ID de Cliente";
                dataGridView1.Columns[1].HeaderText = "Nombre de Cliente";
                dataGridView1.Columns[2].HeaderText = "Dirección";
                dataGridView1.Columns[3].HeaderText = "Dirección 2";
                dataGridView1.Columns[4].HeaderText = "Código Postal";
                dataGridView1.Columns[5].HeaderText = "Número de Teléfono";
                dataGridView1.Columns[6].HeaderText = "Ciudad";
                dataGridView1.Columns[7].HeaderText = "País";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // create the view form then pass grid data from current form to each textbox
            if (dataGridView1.Rows.Count > 0) // <- doesnt allow any processing if the grid is empty, prevents errors
            {
                ViewCustomer view = new ViewCustomer();
                view.RefToForm3 = this; // allows current form to be referenced 
                view.language = language; // pass language value for translation

                view.textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                view.textBox8.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                view.textBox7.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                view.textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                view.textBox5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                view.textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                view.textBox10.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                view.textBox11.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Hide();
                view.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // create edit customer form then pass grid data from current form to each textbox
            if (dataGridView1.Rows.Count > 0)
            {
                EditCustomer edit = new EditCustomer();
                edit.RefToForm3 = this;
                edit.language = language;

                edit.textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                edit.textBox8.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                edit.textBox7.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                edit.textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                edit.textBox5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                edit.textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                edit.textBox10.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                edit.textBox11.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                Hide();
                edit.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.RefToForm3 = this;
            add.language = language;
            Hide();
            add.Show();

        }
        public void update(EditCustomer x)
        {
            ClassLibrary3.customer Customer = new ClassLibrary3.customer();

            //find matching customer within the database and assign that customer to our newly created one
            foreach (ClassLibrary3.customer q in dbcontext.customer)
            {
                if (x.textBox1.Text.ToString() == q.customerId.ToString())
                {
                    Customer = q;
                }
            }
            Customer.lastUpdateBy = currentUser.userName;
            Customer.customerName = x.textBox8.Text.ToString();
            bool foundAddress = false;
            bool foundCity = false;
            bool foundCountry = false;
            ClassLibrary3.address a = new ClassLibrary3.address();

            // search through database for matching address
            foreach (ClassLibrary3.address addy in dbcontext.address)
            {
                if ((addy.address1.ToString().ToLower() == x.textBox7.Text.ToString().ToLower())
                && (addy.address2.ToString().ToLower() == x.textBox10.Text.ToString().ToLower()))
                {
                    // assign that value to our local classes
                    Customer.address = addy;
                    a.addressId = addy.addressId;
                    foundAddress = true;
                }
            }
            // not found? then create new one in the database and also assign it to our local customer
            if (!foundAddress)
            {
                a.address1 = x.textBox7.Text.ToString();
                a.address2 = x.textBox10.Text.ToString();
                a.postalCode = x.textBox11.Text.ToString();
                a.phone = x.textBox4.Text.ToString();
                a.createdBy = currentUser.userName;
                a.lastUpdateBy = currentUser.userName;
                Customer.address = a;
                dbcontext.address.Add(a);
            }


            // search for city in database
            foreach (ClassLibrary3.city cit in dbcontext.city)
            {
                // if found then assign that found value to local address
                if (cit.city1.ToString() == x.textBox7.Text.ToString())
                {
                    a.city = cit;
                    foundCity = true;
                }
            }
            ClassLibrary3.city c = new ClassLibrary3.city();
            // city not found? create one and also assign it to our local address
            if (!foundCity)
            {
                c.city1 = x.textBox7.Text.ToString();
                c.createDate = DateTime.Now;
                c.createdBy = currentUser.userName;
                c.lastUpdateBy = currentUser.userName;
                a.city = c;
                dbcontext.city.Add(c);
            }
            //repeat same process for country
            foreach (ClassLibrary3.country coun in dbcontext.country)
            {
                if (coun.country1.ToLower().ToString() == x.textBox5.Text.ToLower().ToString())
                {
                    c.country = coun;
                    foundCountry = true;
                }
            }
            ClassLibrary3.country z = new ClassLibrary3.country();
            if (!foundCountry)
            {
                z.country1 = x.textBox5.Text.ToString();
                z.createDate = DateTime.Now;
                z.createdBy = currentUser.userName;
                z.lastUpdateBy = currentUser.userName;
                c.country = z;
                dbcontext.country.Add(z);
            }
            try
            {
                // use lambda expression to find matching customer in database based on our local customer
                var update = dbcontext.customer.First(g => g.customerId == Customer.customerId);
                // assign that found customer in the database to the same values as our local customer,
                // updating it with all our updated data
                update = Customer;
                //save changes to database
                dbcontext.SaveChanges();
            }
            //catch any validation exceptions and display it to console
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
            dataGridView1.Update();

        }

        public void add(AddCustomer x)
        {
            // the add function works almost the same as the update function. we search for any matching data in the 
            // database and assign that to our local customer. if its not found then create new data.
            // the only difference is since this function is used for ADDING 
            // then a new customer is added regardless if all the data has a found match
            ClassLibrary3.customer Customer = new ClassLibrary3.customer();
            Customer.active = true;
            Customer.createDate = DateTime.Now;
            Customer.createdBy = currentUser.userName;
            Customer.lastUpdateBy = currentUser.userName;
            Customer.customerName = x.textBox8.Text.ToString();
            bool foundAddress = false;
            bool foundCity = false;
            bool foundCountry = false;
            ClassLibrary3.address a = new ClassLibrary3.address();

            foreach (ClassLibrary3.address addy in dbcontext.address)
            {
                if ((addy.address1.ToString().ToLower() == x.textBox7.Text.ToString().ToLower())
                && (addy.address2.ToString().ToLower() == x.textBox10.Text.ToString().ToLower()))
                {
                    Customer.address = addy;
                    a.addressId = addy.addressId;
                    foundAddress = true;
                }
            }
            if (!foundAddress)
            {
                a.address1 = x.textBox7.Text.ToString();
                a.address2 = x.textBox10.Text.ToString();
                a.postalCode = x.textBox11.Text.ToString();
                a.phone = x.textBox4.Text.ToString();
                a.createdBy = currentUser.userName;
                a.lastUpdateBy = currentUser.userName;
                Customer.address = a;
                dbcontext.address.Add(a);
            }



            foreach (ClassLibrary3.city cit in dbcontext.city)
            {
                if (cit.city1.ToString() == x.textBox7.Text.ToString())
                {
                    a.city = cit;
                    foundCity = true;
                }
            }
            ClassLibrary3.city c = new ClassLibrary3.city();
            if (!foundCity)
            {
                c.city1 = x.textBox7.Text.ToString();
                c.createDate = DateTime.Now;
                c.createdBy = currentUser.userName;
                c.lastUpdateBy = currentUser.userName;
                a.city = c;
                dbcontext.city.Add(c);
            }
            foreach (ClassLibrary3.country coun in dbcontext.country)
            {
                if (coun.country1.ToLower().ToString() == x.textBox5.Text.ToLower().ToString())
                {
                    c.country = coun;
                    foundCountry = true;
                }
            }
            ClassLibrary3.country z = new ClassLibrary3.country();
            if (!foundCountry)
            {
                z.country1 = x.textBox5.Text.ToString();
                z.createDate = DateTime.Now;
                z.createdBy = currentUser.userName;
                z.lastUpdateBy = currentUser.userName;
                c.country = z;
                dbcontext.country.Add(z);
            }
            try
            {
                // here we use the add function instead of our update lambda expression
                dbcontext.customer.Add(Customer);
                Validate();
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
            dataGridView1.Update();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            ReftoForm2.Show();
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.custviewTableAdapter.FillBy(this.client_scheduleDataSet.custview);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.Rows.Count > 0) // prevents trying to delete a null value
            {
                // translated messagebox with result buttons
                DialogResult result;
                if (language == "English")
                {
                    result = MessageBox.Show("Delete selected row?", "Confirmation", MessageBoxButtons.YesNo);
                }
                else
                {
                    result = MessageBox.Show("Eliminar la fila seleccionada?", "Confirmacion", MessageBoxButtons.YesNo);
                }
                if (result == DialogResult.Yes) // only deletes on yes click
                {
                    // loop through database for matching ID, then delete
                    foreach (ClassLibrary3.customer cust in dbcontext.customer)
                    {
                        if (cust.customerId.ToString() == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            dbcontext.customer.Remove(cust);
                        }
                    }

                    // also update the data grid 
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    dbcontext.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // get user's general location and language by accessing the system's culture region settings
            string culture = CultureInfo.CurrentCulture.EnglishName;
            Form1InitializeLanguage(culture);


        }
        public ClassLibrary3.user currentUser = new ClassLibrary3.user();
        private ClassLibrary3.client_scheduleEntities1 dbcontext =
            new ClassLibrary3.client_scheduleEntities1();

        // set default language to english
        public string lang = "English";

        // able to switch between English and Spanish 
        public void Form1InitializeLanguage(string x)
        {
            if (x.ToLower().Contains("english"))
            {
                lang = "English";
            }
            if (x.ToLower().Contains("spanish"))
            {
                lang = "Spanish";
            }

        }

        //translates form's text to match user's regional language
        private void Form1_Load(object sender, EventArgs e)
        {
            if (lang == "English")
            {
                label1.Text = "User Log In";
                label2.Text = "Username:";
                label3.Text = "Password:";
                button1.Text = "Log in";
            }

            if (lang == "Spanish")
            {
                label1.Text = "Todocoleccion";
                label2.Text = "Nombre de usario:";
                label3.Text = "Contraseña:";
                button1.Text = "Inicia sesión";
            }
        }

        private void button1_click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0) // only works if user enters login data
            { }
            else
            {
                bool found = false;
                // find matching user info in database
                foreach (ClassLibrary3.user x in dbcontext.user)
                {
                    if ((x.userName == textBox1.Text) && (x.password == textBox2.Text))
                    {
                        currentUser = x;
                        // send language and current user to main form
                        Main MainMenu = new Main();
                        MainMenu.language = lang;
                        MainMenu.currentUser = currentUser;
                        //logon history file adds new logon data upon successful logon
                        File.AppendAllText(@"C:\Users\LabUser\source\repos\ClassLibrary3\WindowsFormsApp1\LogonHistory.txt",
                                           "USERNAME: " + x.userName + " TIME: " + DateTime.Now + Environment.NewLine);
                        Hide();
                        MainMenu.Show();

                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    if(lang == "English")
                    MessageBox.Show("Username and password combination is incorrect");
                    if (lang == "Spanish")
                        MessageBox.Show("La combinación de nombre de usuario y contraseña es incorrecta");
                }

            }

        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lang = "English";
            Form1_Load(this, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lang = "Spanish";
            Form1_Load(this, null);
        }
    }


}

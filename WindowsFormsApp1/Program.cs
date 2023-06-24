using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // get user's general location by accessing the system's regional language settings
            string culture = CultureInfo.CurrentCulture.EnglishName;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login LogIn = new Login();
            Application.Run(LogIn);
            
        }

        
    }

   
}

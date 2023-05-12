using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Settings
{
    public class ApplicationSettings
    {
        public string ConnectionString { get; set; } = @" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Павел\Desktop\WindowsFormsApp2\WindowsFormsApp2\Database1.mdf;Integrated Security = True";
    }
}

using WindowsFormsApp2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Settings;

namespace WindowsFormsApp2.Database
{
    public class DbRepository
    {
        private readonly string conectionString;

        public DbRepository()
        {
        }

        public DbRepository(ApplicationSettings settings)
        {
            this.conectionString = settings.ConnectionString;

        }
        public bool GetUser(string userName, string password)
        {
            var cn = new SqlConnection(conectionString);
            var command = new SqlCommand("select * from Table where Username=@userName and Password=@password", cn);

            command.Parameters.AddWithValue(nameof(userName), userName);
            command.Parameters.AddWithValue(nameof(password), password);

            cn.Open();
            var dr = command.ExecuteReader();
            return dr.Read();
        }

    }
}


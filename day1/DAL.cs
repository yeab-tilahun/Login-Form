using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace day1
{
    class DAL
    {
        public void saveUser(User u)
        {
            string query = "INSERT INTO tblUser VALUES (' " + u.ID + " ', '" + u.fname + "','" + u.mname + "" +
                " ', '" + u.Username + " ', '" + u.password + " ', '" + u.Role +"')";
            MessageBox.Show(query);
            //
            string constr= "Server=YEABS;   database=cslab; integrated security=true; ";
            using(SqlConnection con= new SqlConnection(constr)){
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                    MessageBox.Show("Save Sucessful");
                con.Close();

            }
        }
    }
}


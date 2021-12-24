using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace day1
{
    class DAL
    {
        public void saveUser(User u)
        {
            string query = "INSERT INTO tblUser VALUES (' " + u.ID + " ', '" + u.fname + "','" + u.mname + "" +
                " ', '" + u.Username + " ', '" + u.password + " ', '" + u.Role + " ', '" + u.Photo + "')";
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

            string constr = "Server=YEABS;   database=cslab; integrated security=true; ";
        public void saveUserByStoreProc(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", u.ID);
                    cmd.Parameters.AddWithValue("@mname", u.mname);
                    cmd.Parameters.AddWithValue("@fname", u.fname);
                    cmd.Parameters.AddWithValue("@Username", u.Username);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@Role", u.Role);
                    cmd.Parameters.AddWithValue("@Photo", u.Photo);
                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                        MessageBox.Show("Save Sucessful");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DelUserByStoreProc(String id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                        MessageBox.Show("Delete Sucessful");
                    else
                        MessageBox.Show("uSucessful");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void updateUserByStoreProc(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", u.ID);
                    cmd.Parameters.AddWithValue("@mname", u.mname);
                    cmd.Parameters.AddWithValue("@fname", u.fname);
                    cmd.Parameters.AddWithValue("@Username", u.Username);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@Role", u.Role);
                    cmd.Parameters.AddWithValue("@Photo", u.Photo);
                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                        MessageBox.Show("Save Sucessful");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable getUser(string fn, string ln)
            {
                SqlConnection con = new SqlConnection(constr);
                SqlDataAdapter da = new SqlDataAdapter("spGetUser", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fn", fn);
                da.SelectCommand.Parameters.AddWithValue("@ln", ln);

                DataSet ds = new DataSet();
                da.Fill(ds, "tblUser");
                DataTable dt = ds.Tables["tblUser"];
                return dt;

            }
        }
    }


    



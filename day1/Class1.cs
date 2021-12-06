using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day1
{
    class User
    {
        public string ID;
        public string fname;
        public string mname;
        public string Username;
        public string password;
        public string Role;

        public User(string id, string fname, string mname, string Username, string password, string Role)
        {
            this.ID = id;
            this.fname = fname;
            this.mname = mname;
            this.Username = Username;
            this.password = password;
            this.Role = Role;
        }
        public void saveUSer()
        {
            MessageBox.Show(this.ID + " " + this.fname + " " + this.mname + " " + this.Username
                + " " + this.password + " " + this.Role + " ");
            DAL layer2 = new DAL();
            layer2.saveUser(this);
        }
    }
}

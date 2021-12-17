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
        public byte[] Photo;

        public string id1;

        public User(string id, string fname, string mname, string Username, string password, string Role,byte [] Photo)
        {
            this.ID = id;
            this.fname = fname;
            this.mname = mname;
            this.Username = Username;
            this.password = password;
            this.Role = Role;
            this.Photo = Photo;
        }

        //constractor to allow creation of user object with out parameter
        public User() { }
        public void saveUSer()
        {
            MessageBox.Show(this.ID + " " + this.fname + " " + this.mname + " " + this.Username
                + " " + this.password + " " + this.Role + " " + this.Photo + " ");
            DAL layer3 = new DAL();
            layer3.saveUserByStoreProc(this);
        }
        public void updateUSer()
        {
            MessageBox.Show(this.ID + " " + this.fname + " " + this.mname + " " + this.Username
                + " " + this.password + " " + this.Role + " ");
            DAL layer3 = new DAL();
            layer3.updateUserByStoreProc(this);
        }
        public void deleteUser(string id)
        {
            DialogResult res = MessageBox.Show("Are you sure !", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
         
            DAL layer3 = new DAL();
            layer3.DelUserByStoreProc(id);
           
        }
    }
}

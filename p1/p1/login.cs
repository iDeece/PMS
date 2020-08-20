using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace p1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            int ep = 0;
            if (txt_username.Text == "")
            {
                ep = 1;
                ep1.SetError(txt_username, "Please Enter Username!");
            }
            if (txt_password.Text == "")
            {
                ep = 1;
                ep1.SetError(txt_password, "Please Enter Password!");
            }
            if(ep==0)
            {
                int key;
                Model m = new Model();
                DataTable usr = m.GetData($"Select authlevel,empid from Employee where name= '{txt_username.Text}' AND password = '{txt_password.Text}'");
                int eid = 0;
                try {
                    key = int.Parse(usr.Rows[0][0].ToString());
                    eid = int.Parse(usr.Rows[0][1].ToString());
                }
                catch (Exception) {
                    key = 0;
                }
                
                switch (key)
                {
                    case 3:
                        this.Hide();
                        PMform frm = new PMform();
                        frm.Show();
                        break;
                    case 2:
                        this.Hide();
                        TLform frm1 = new TLform(eid);
                        frm1.Show();
                        break;
                    case 1:
                        try
                        {
                            this.Hide();
                            Eform frm2 = new Eform(eid);
                            frm2.Show();
                        }
                        catch (Exception) {
                            MessageBox.Show("This Employee is currently not assigned to any team!");
                            this.Show();
                        }
                        break;
                    case 0:
                        MessageBox.Show("Invalid User Logon!");
                        break;
                    default:
                        break;
                }
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

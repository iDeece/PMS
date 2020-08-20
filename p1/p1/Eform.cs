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

namespace p1
{
    public partial class Eform : Form
    {
        int empid;
        int taskid;
        int teamid;
        string teamlead;
        string tskname;
        string tskdesc;
        string projectname;
        DateTime startdate;
        DateTime estdtime;
        Model m = new Model();
        public Eform(int eid)
        {
            DataTable DTpname = m.GetData("SELECT p.projectname from project p INNER JOIN employee e ON e.project_projectid=p.projectid WHERE" +
                                    $" empid={eid}");
            projectname = DTpname.Rows[0][0].ToString();

            DataTable DTteamid = m.GetData($"SELECT team_teamid from employee WHERE empid={eid}");
            teamid = int.Parse(DTteamid.Rows[0][0].ToString());

            DataTable DTtaskid = m.GetData($"SELECT task_taskid from team where teamid={teamid}");
            taskid = int.Parse(DTtaskid.Rows[0][0].ToString());

            DataTable DTteamlead = m.GetData($"SELECT name from employee where team_teamid={teamid} and authlevel='2'");
            teamlead = DTteamlead.Rows[0][0].ToString();

            DataTable DTtskname = m.GetData($"SELECT taskname from task where taskid={taskid}");
            tskname = DTtskname.Rows[0][0].ToString();

            DataTable DTtskdesc = m.GetData($"SELECT taskdesc from task where taskid={taskid}");
            tskdesc = DTtskdesc.Rows[0][0].ToString();

            DataTable DTstartdate = m.GetData($"SELECT startdate from task where taskid={taskid}");
            startdate = Convert.ToDateTime(DTstartdate.Rows[0][0].ToString());

            DataTable DTestdtime = m.GetData($"SELECT estdtime from task where taskid={taskid}");
            estdtime = Convert.ToDateTime(DTestdtime.Rows[0][0].ToString());

            empid = eid;

            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Model.connstr))
            {
                conn.Open();
                string update = $"UPDATE task SET taskdesc='{rtd_desc.Text}' WHERE taskid={taskid}";
                SqlCommand command = new SqlCommand(update, conn);
                command.ExecuteNonQuery();
            }
        }

        private void Eform_Load(object sender, EventArgs e)
        {
            lbl_pname.Text = $"Project: '{projectname}'";
            lbl_teamlead.Text = $"Team Lead: '{teamlead}'";
            lbl_task.Text = $"Task #{taskid} {tskname}";
            dtp_startdate.Value = startdate;
            dtp_estdtime.Value = estdtime;
            rtd_desc.Text = tskdesc;

            DateTime today = DateTime.Today;
            if (today >= startdate)
            {
                pn1.BackColor = Color.Cyan;
            }
            if (today <= estdtime && today >= startdate)
            {
                pn2.BackColor = Color.LimeGreen;
            }
            else if (today > estdtime)
            {
                pn2.BackColor = Color.OrangeRed;
            }
        }

        private void Eform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LL_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new login()).Show();
        }
    }
}

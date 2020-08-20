using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Model
    {
        
        public static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tayyab\Desktop\Project\last\p1\p1\p1\testdb.mdf;Integrated Security=True";

        //GETTING DATA
        public DataTable GetData(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(sql, connstr);
            dad.Fill(table);
            return table;
        }

        //DELETING PROJECT
        public void DeleteProjectfromDb(string del)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(del, conn);
                comm.ExecuteNonQuery();
            }
        }

        //GETTING CLIENT ID
        public int Getclientid(string cn)
        {
            DataTable table = new DataTable();
            string sql = $"Select clientid from client where clientname= '{cn}'";
            SqlDataAdapter dad1 = new SqlDataAdapter(sql, connstr);
            dad1.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }

        //UPDATING PROJECTS
        public void UpdateProject(int pid,string pn,string pd,DateTime sd,DateTime et,int cid)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string sql = $"UPDATE project SET projectname='{pn}', projectdesc='{pd}', startdate=@sd, estdtime=@et, client_clientid={cid} " +
                    $"WHERE projectid='{pid}'";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue(@"sd", sd);
                comm.Parameters.AddWithValue(@"et", et);
                comm.ExecuteNonQuery();
            }
        }

        //GETTING PROJECT NAME
        public string GetProjectName(int pid)
        {
            DataTable table = new DataTable();
            string sql = $"Select projectname from project where projectid= '{pid}'";
            SqlDataAdapter dad1 = new SqlDataAdapter(sql, connstr);
            dad1.Fill(table);
            return table.Rows[0][0].ToString();
        }

        //GETTING AVAILABLE EMPLOYEES FOR TEAMLEAD
        public List<string> GetEmployeeswithDepartment()
        {
            DataTable table = new DataTable();
            string sql = $"Select e.empid AS EmployeeID, e.name AS Name,d.deptname AS Department from employee e INNER JOIN department d ON e.department_deptid=d.deptid WHERE e.authlevel= '1'";
            SqlDataAdapter dad1 = new SqlDataAdapter(sql, connstr);
            dad1.Fill(table);
            List<string> str = new List<string>();
            foreach (DataRow dr in table.Rows)
                str.Add($"{dr["EmployeeID"]} | {dr["Name"]} | {dr["Department"]}");
            return str;
        }

        //CREATE TEAM LEAD
        public void SetTeamLead(int pid, int tsid, int eid, int upd)
        {
            if (upd == 1)
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string delOldteam = $"Delete from team WHERE task_taskid = '{tsid}'";
                    SqlCommand command = new SqlCommand(delOldteam, conn);
                    command.ExecuteNonQuery();

                }
            }
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string insert = $"INSERT INTO team VALUES ({pid},{tsid})";
                SqlCommand command = new SqlCommand(insert, conn);
                command.ExecuteNonQuery();

            }
            DataTable table = new DataTable();
            string sql = $"Select teamid from team where project_projectid= '{pid}' and task_taskid='{tsid}'";
            SqlDataAdapter dad1 = new SqlDataAdapter(sql, connstr);
            dad1.Fill(table);
            int tid = int.Parse(table.Rows[0][0].ToString());
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string updtask = $"UPDATE task set team_teamid ={tid} where taskid = '{tsid}'";
                SqlCommand command = new SqlCommand(updtask, conn);
                command.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string update = $"UPDATE employee SET authlevel=2,project_projectid={pid},team_teamid={tid} WHERE empid='{eid}'";
                SqlCommand command = new SqlCommand(update, conn);
                command.ExecuteNonQuery();
            }
        }
        //Update Task
        public void UpdateTask(int taskid,string tname,string tdesc,DateTime estdtime,DateTime stdDate) {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string sql = $"UPDATE task SET taskname='{tname}', taskdesc='{tdesc}', startdate=@sd, estdtime=@et " +
                    $"WHERE taskid='{taskid}'";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue(@"sd", stdDate);
                comm.Parameters.AddWithValue(@"et", estdtime);
                comm.ExecuteNonQuery();
            }
        }

        //Get Team Leader ID for Task
        public int GetTeamLeadID(int tid) {
            DataTable table = new DataTable();
            string sql = $"Select empid from employee where team_teamid ='{tid}' AND authlevel = '2'";
            SqlDataAdapter dad = new SqlDataAdapter(sql,connstr);
            dad.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }
        //Update Old Team Members(Set their auth back to 1)
        public void updateOldTeamMembers(int tid) {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string insert = $"Update Employee SET authlevel = 1,project_projectID = Null Where team_teamid = '{tid}'";
                SqlCommand command = new SqlCommand(insert, conn);
                command.ExecuteNonQuery();

            }
        }
        //LAST TASK ID
        public int GetTaskIdLast()
        {
            DataTable table = new DataTable();
            string sql = $"SELECT TOP 1 * FROM task ORDER BY taskid DESC";     
            SqlDataAdapter dad1 = new SqlDataAdapter(sql, connstr);
            dad1.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }

        //DELETE TASK
        public void DeleteTask(int tsid, int tid)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string insert = $"Update Employee SET authlevel = 1,project_projectID = Null Where team_teamid = '{tid}'";
                SqlCommand command = new SqlCommand(insert, conn);
                command.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string delOldteam = $"Delete from team WHERE task_taskid = '{tsid}'";
                SqlCommand command = new SqlCommand(delOldteam, conn);
                command.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string insert = $"Delete from task where taskid = '{tsid}'";
                SqlCommand command = new SqlCommand(insert, conn);
                command.ExecuteNonQuery();
            }
        }
    }
}

using System;
using System.Data;

namespace data12
{
    public partial class DisconnectedArchitecture : Form

    {

        DataColumn dc;
        DataRow dr;
        DataTable dt;
        static void Main(string[] args)
        {
            
        }
            private DataTable GetEmployeeTable()
            {
                dt = new DataTable("Employee");

                dc = new DataColumn("EmpId", typeof(int));
                dt.Columns.Add(dc);
                dt.PrimaryKey = new DataColumn[] { dc };        //here we can pass multiple columns seperated by comma

                dc = new DataColumn("EmpName", typeof(string));
                dt.Columns.Add(dc);

                dc = new DataColumn("DeptId", typeof(int));
                dt.Columns.Add(dc);

                dr = dt.NewRow();
                dr[0] = 1;
                dr[1] = "Lakshmi";
                dr[2] = 105;
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = 1;
                dr[1] = "Nandini";
                dr[2] = 106;
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = 3;
                dr[1] = "lavanya";
                dr[2] = 107;
                dt.Rows.Add(dr);

                return dt;
            }

            public DisconnectedArchitecture()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }
            private void DisconnectedArchitecture_Load(object sender, EventArgs e)
            {
                DataTable EmpTable = GetEmployeeTable();

            }
        }
    
}

public class Form
{
}

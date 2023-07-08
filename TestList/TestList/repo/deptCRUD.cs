using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TestList.Models;

namespace TestList.repo
{
    public class deptCRUD
    {
        static string constr = ConfigurationManager.ConnectionStrings["sqlcon"].ToString();
        SqlConnection conn = new SqlConnection(constr);
        public List<department> getDepartments()
        {
            try
            {
                conn.Open();
                IList<department> dept_list = SqlMapper.Query<department>(conn, "viewdept").ToList();
                conn.Close();
                return dept_list.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void getStatus(int id)
        {
            try
            {
                conn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("id", id);
                conn.Execute("toggleIsActive", param, commandType: System.Data.CommandType.StoredProcedure);
                conn.Close();
            }
            catch
            {
                throw;
            }
        }
    }
}
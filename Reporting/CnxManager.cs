using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    public static class CnxManager
    {
        public static bool CheckERPConnection()
        {
            using (SqlConnection cnxERP = new SqlConnection(Properties.Settings.Default.ERPConnectionString))
            {
                try
                {
                    cnxERP.Open();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }
                finally
                {
                    cnxERP.Close();
                }
            }
        }

        public static bool CheckERPConnection(ref SqlErrorCollection sqlErrorCollection)
        {
            SqlConnection cnx = new SqlConnection();
            bool err = false;
            try
            {
                cnx = new SqlConnection(Properties.Settings.Default.ERPConnectionString);
                cnx.Open();
            }
            catch (SqlException sqlEx)
            {
                err = true;
                sqlErrorCollection = sqlEx.Errors;
                //throw;
            }
            finally
            {
                cnx.Close();
            }
            return !err;
        }

        public static bool CheckLocalConnection()
        {
            using (SqlConnection cnxLocal = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
            {
                try
                {
                    cnxLocal.Open();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }
                finally
                {
                    cnxLocal.Close();
                }
            }
        }

        public static bool CheckLocalConnection(ref SqlErrorCollection sqlErrorCollection)
        {
            SqlConnection cnx = new SqlConnection();
            bool err = false;
            try
            {
                cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString);
                cnx.Open();
            }
            catch (SqlException sqlEx)
            {
                err = true;
                sqlErrorCollection = sqlEx.Errors;
                //throw;
            }
            finally
            {
                cnx.Close();
            }
            return !err;
        }
    }
}

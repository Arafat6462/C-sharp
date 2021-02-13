using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source = DESKTOP-3D0MFQ3\\ARAFAT; database = Restro; integrated security = True";
            return sqlConnection;
        }


        // fetch the data
        public DataSet getData(String query)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = query;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            return dataSet;
        }

        // for insert update and delete
         public void setData(String query)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Data Processed Successfuly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}

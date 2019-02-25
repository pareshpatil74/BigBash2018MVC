using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class BigBashBusinessLayer
    {


        public void AddBibBashInfo(AddBigBash bigBash)
        {

            string constrings = ConfigurationManager.ConnectionStrings["BigBashContex"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(constrings))
            {
                SqlCommand command = new SqlCommand("Add_BigBash", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parMatch_Name = new SqlParameter();
                parMatch_Name.ParameterName = "@Match_Name";
                parMatch_Name.Value = bigBash.Match_Name;
                command.Parameters.Add(parMatch_Name);


                SqlParameter parMatch_Date = new SqlParameter();
                parMatch_Date.ParameterName = "@Match_Date";
                parMatch_Date.Value = bigBash.Match_Date;
                command.Parameters.Add(parMatch_Date);

                SqlParameter par6_Number = new SqlParameter();
                par6_Number.ParameterName = "@6_Number";
                par6_Number.Value = bigBash.Six_Number;
                command.Parameters.Add(par6_Number);


                SqlParameter par7_Number = new SqlParameter();
                par7_Number.ParameterName = "@7_Number";
                par7_Number.Value = bigBash.Seven_Number;
                command.Parameters.Add(par7_Number);


                SqlParameter par8_Number = new SqlParameter();
                par8_Number.ParameterName = "@8_Number";
                par8_Number.Value = bigBash.Eight_Number;
                command.Parameters.Add(par8_Number);

                SqlParameter par9_Number = new SqlParameter();
                par9_Number.ParameterName = "@9_Number";
                par9_Number.Value = bigBash.Nine_Number;
                command.Parameters.Add(par9_Number);



                SqlParameter par6_NumberAmount = new SqlParameter();
                par6_NumberAmount.ParameterName = "@6_Amount";
                par6_NumberAmount.Value = bigBash.Six_Number_amount;
                command.Parameters.Add(par6_NumberAmount);


                SqlParameter par7_NumberAmount = new SqlParameter();
                par7_NumberAmount.ParameterName = "@7_Amount";
                par7_NumberAmount.Value = bigBash.Seven_Number_amount;
                command.Parameters.Add(par7_NumberAmount);


                SqlParameter par8_NumberAmount = new SqlParameter();
                par8_NumberAmount.ParameterName = "@8_Amount";
                par8_NumberAmount.Value = bigBash.Eight_Number_amount;
                command.Parameters.Add(par8_NumberAmount);

                SqlParameter par9_NumberAmount = new SqlParameter();
                par9_NumberAmount.ParameterName = "@9_Amount";
                par9_NumberAmount.Value = bigBash.Nine_Number_amount;
                command.Parameters.Add(par9_NumberAmount);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<GetBigBashTable> GetBigBashInfo
        {
            get
            {

                string constrings = ConfigurationManager.ConnectionStrings["BigBashContex"].ConnectionString;
                List<GetBigBashTable> GetGetGigBashList = new List<GetBigBashTable>();

                using (SqlConnection connection = new SqlConnection(constrings))
                {

                    SqlCommand command = new SqlCommand("sp_BigBashInfo", connection);
                    command.CommandType = CommandType.StoredProcedure;



                    connection.Open();
                    SqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        GetBigBashTable GetGigBashInfo = new GetBigBashTable();
                        GetGigBashInfo.Match_Name = rdr["Match_Name"].ToString();
                        GetGigBashInfo.Match_Date = Convert.ToDateTime(rdr["Match_Date"].ToString());
                        GetGigBashInfo.Six_Number = rdr["6_Number"].ToString();
                        GetGigBashInfo.Six_Number_amount = rdr["6_Amount"].ToString();
                        GetGigBashInfo.Seven_Number = rdr["7_Number"].ToString();
                        GetGigBashInfo.Seven_Number_amount = rdr["7_Amount"].ToString();
                        GetGigBashInfo.Eight_Number = rdr["8_Number"].ToString();
                        GetGigBashInfo.Eight_Number_amount = rdr["8_Amount"].ToString();
                        GetGigBashInfo.Nine_Number = rdr["9_Number"].ToString();
                        GetGigBashInfo.Nine_Number_amount = rdr["9_Amount"].ToString();


                        GetGetGigBashList.Add(GetGigBashInfo);
                    }
                    //command.CommandType=
                    connection.Close();
                }
                return GetGetGigBashList;
            }

        }


        public IEnumerable<GetBigBashTableNew> GetBigBashInfoNew
        {
            get
            {

                string constrings = ConfigurationManager.ConnectionStrings["BigBashContex"].ConnectionString;
                List<GetBigBashTableNew> GetGetGigBashListNew = new List<GetBigBashTableNew>();

                using (SqlConnection connection = new SqlConnection(constrings))
                {

                    SqlCommand command = new SqlCommand("sp_BigBashInfoNew", connection);
                    command.CommandType = CommandType.StoredProcedure;



                    connection.Open();
                    SqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        GetBigBashTableNew GetGigBashInfoNew = new GetBigBashTableNew();
                        GetGigBashInfoNew.Match_Name_New = rdr["Match_Name_New"].ToString();
                        GetGigBashInfoNew.Match_Date_New = Convert.ToDateTime(rdr["Match_Date_Name"].ToString());
                        GetGigBashInfoNew.Name = rdr["Name"].ToString();
                        GetGigBashInfoNew.Rank = Convert.ToInt32(rdr["Rank"].ToString());
                        GetGigBashInfoNew.Amount_new = Convert.ToInt32(rdr["Amount_New"].ToString());


                        GetGetGigBashListNew.Add(GetGigBashInfoNew);
                    }
                    //command.CommandType=
                    connection.Close();
                }
                return GetGetGigBashListNew;
            }

        }


        public int GetSubTotal(string strName)
        {
            int iSubTotal = 0;

            string constrings = ConfigurationManager.ConnectionStrings["BigBashContex"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(constrings))
            {

                SqlCommand command = new SqlCommand("sp_GetSubTotal", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter subtotal = new SqlParameter();
                subtotal.ParameterName = "@Name";
                subtotal.Value = strName;
                command.Parameters.Add(subtotal);

                connection.Open();
                SqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {

                    iSubTotal = Convert.ToInt32(rdr["subtotal"].ToString());

                }

                connection.Close();
            }
            return iSubTotal;

        }

        public void AddBibBashInfoNew(AddBigBashNew bigBash)
        {

            string constrings = ConfigurationManager.ConnectionStrings["BigBashContex"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(constrings))
            {
                SqlCommand command = new SqlCommand("Add_BigBashNew", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parMatch_Name = new SqlParameter();
                parMatch_Name.ParameterName = "@Match_Name";
                parMatch_Name.Value = bigBash.Match_Name_New;
                command.Parameters.Add(parMatch_Name);


                SqlParameter parMatch_Date = new SqlParameter();
                parMatch_Date.ParameterName = "@Match_Date";
                parMatch_Date.Value = bigBash.Match_Date_New;
                command.Parameters.Add(parMatch_Date);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Name";
                Name.Value = bigBash.Name;
                command.Parameters.Add(Name);


                SqlParameter Rank = new SqlParameter();
                Rank.ParameterName = "@Rank";
                Rank.Value = bigBash.Rank;
                command.Parameters.Add(Rank);


                SqlParameter Amount = new SqlParameter();
                Amount.ParameterName = "@Amount";
                Amount.Value = bigBash.Amount_new;
                command.Parameters.Add(Amount);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}

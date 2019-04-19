using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Diagnostics;
using EnquireTourLeadCost.Models;

namespace EnquireTourLeadCost.DB
{
    public class TourLeaderData : Data
    {
        public static TourLead GetTourLeaderById(int id)
        {
            TourLead tourlead = null;

            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();

                string sql = @"SELECT * from TourLeaderDTOes
                             WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tourlead = new TourLead()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Rank = (string)reader["Rank"]

                    };
                }

                conn.Close();
            }
            return tourlead;
        }
    }
}

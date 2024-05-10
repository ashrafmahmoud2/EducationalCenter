using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterDataAccess
{
    public class clsGraduationDegreesData
    {
        public static bool GetGraduationDegreInfoByID(int GradID, ref string DegreeName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand("SP_GetGraduationDegreInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@GradID", GradID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    IsFound = true;

                   //GradID = (int)reader["GradID"];
                    DegreeName = (string)reader["DegreeName"];
                }
                else
                {
                    // The record was not found
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddNewGraduationDegre(string DegreeName)
        {
            int GraduationDegreID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SP_AddNewGraduationDegre", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@DegreeName", DegreeName);
                ;

                SqlParameter outputParam = new SqlParameter("@NewGraduationDegreID", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    GraduationDegreID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return GraduationDegreID;
        }
        public static bool UpdateGraduationDegre(int GradID, string DegreeName)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_UpdateGraduationDegre", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@GradID", GradID);
            command.Parameters.AddWithValue("@DegreeName", DegreeName);
            ;

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static bool DeleteGraduationDegre(int GraduationDegreID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_DeleteGraduationDegre", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@GraduationDegreID", GraduationDegreID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static DataTable GetAllGraduationDegre()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_GetAllGraduationDegrees", connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool DoesGraduationDegreExist(int GraduationDegreID)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT TOP 1 found = 1 FROM Students WHERE StudentID = @GraduationDegreID", connection);

                    command.Parameters.AddWithValue("@GraduationDegreID", GraduationDegreID);

                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        exists = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return exists;
        }

    }
}

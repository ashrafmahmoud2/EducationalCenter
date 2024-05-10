using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterDataAccess
{
    public class clsStudentsData
    {
        public static bool GetStudentInfoByID(int StudentID, ref int PersonID, ref int GradID, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand("SP_GetStudentInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    IsFound = true;

                // StudentID = (int)reader["StudentID"];
                    PersonID = (int)reader["PersonID"];
                    GradID = (int)reader["GradID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewStudent(int PersonID, int GradID, int CreatedByUserID)
        {
            int StudentID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SP_AddNewStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@GradID", GradID);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                ;

                SqlParameter outputParam = new SqlParameter("@NewStudentID", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    StudentID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return StudentID;
        }
        public static bool UpdateStudent(int StudentID, int PersonID, int GradID, int CreatedByUserID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_UpdateStudent", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@GradID", GradID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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

        public static bool DeleteStudent(int StudentID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_DeleteStudent", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@StudentID", StudentID);

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

        public static DataTable GetAllStudent()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_GetAllStudent", connection);
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
        
        public static bool DoesStudentExist(int StudentID)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT TOP 1 found = 1 FROM Students WHERE StudentID = @StudentID", connection);

                    command.Parameters.AddWithValue("@StudentID", StudentID);

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

        public static bool DoesStudentExistbyPersonID(int PersonID)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT TOP 1 found = 1 FROM Students WHERE PersonID = @PersonID", connection);

                    command.Parameters.AddWithValue("@PersonID", PersonID);

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

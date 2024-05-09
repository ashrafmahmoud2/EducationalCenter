using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterDataAccess
{
    public class clsPeopleData
    {
        public static bool GetPeopleInfoByID(int PersonID, ref string Name, ref bool Gender, ref int Age, ref DateTime DateOfBirth, ref string Phone, ref string Email, ref string Address)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand("SP_GetPeopleInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    Name = (string)reader["Name"];
                    Gender = (bool)reader["Gender"];
                    Age = (int)reader["Age"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
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

        public static int AddNewPeople(string Name, bool Gender, int Age, DateTime DateOfBirth, string Phone, string Email, string Address)
        {
            int PersonID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SP_AddNewPeople", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", Address);
                ;

                SqlParameter outputParam = new SqlParameter("@NewPersonID", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    PersonID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return PersonID;
        }
        public static bool UpdatePeople(int PersonID, string Name, bool Gender, int Age, DateTime DateOfBirth, string Phone, string Email, string Address)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_UpdatePeople", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
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

        public static bool DeletePeople(int PersonID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_DeletePeople", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_GetAllPeople", connection);
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

        public static bool DoesPeopleExist(int PersonID)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT TOP 1 found = 1 FROM Students WHERE StudentID = @PersonID", connection);

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

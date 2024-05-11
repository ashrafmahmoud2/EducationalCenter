using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterDataAccess
{
    public class clsTeachersData
    {
        public static bool GetTeacherInfoByID(int TeacherID, ref int PersonID, ref int CreatedByUserID, ref string TeachingExperience, ref int EducationLevelID, ref string Certifications)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand("SP_GetTeacherInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@TeacherID", TeacherID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    IsFound = true;

                    TeacherID = (int)reader["TeacherID"];
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    TeachingExperience = (string)reader["TeachingExperience"];
                    EducationLevelID = (int)reader["EducationLevelID"];
                    Certifications = (string)reader["Certifications"];
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

        public static int AddNewTeacher(int PersonID, int CreatedByUserID, string TeachingExperience, int EducationLevelID, string Certifications)
        {
            int TeacherID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SP_AddNewTeacher", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@TeachingExperience", TeachingExperience);
                command.Parameters.AddWithValue("@EducationLevelID", EducationLevelID);
                command.Parameters.AddWithValue("@Certifications", Certifications);
                ;

                SqlParameter outputParam = new SqlParameter("@NewTeacherID", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    TeacherID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return TeacherID;
        }
        public static bool UpdateTeacher(int TeacherID, int PersonID, int CreatedByUserID, string TeachingExperience, int EducationLevelID, string Certifications)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_UpdateTeacher", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@TeacherID", TeacherID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@TeachingExperience", TeachingExperience);
            command.Parameters.AddWithValue("@EducationLevelID", EducationLevelID);
            command.Parameters.AddWithValue("@Certifications", Certifications);
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

        public static bool DeleteTeacher(int TeacherID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_DeleteTeacher", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@TeacherID", TeacherID);

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

        public static DataTable GetAllTeacher()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;


            SqlCommand command = new SqlCommand("SP_GetAllTeachers", connection);
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

        public static bool DoesTeacherExist(int TeacherID)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT TOP 1 found = 1 FROM Students WHERE StudentID = @TeacherID", connection);

                    command.Parameters.AddWithValue("@TeacherID", TeacherID);

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

using EducationalCenterDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterBusinessLayer
{
    public class clsTeachers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;
        public int TeacherID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public string TeachingExperience { get; set; }
        public int EducationLevelID { get; set; }
        public string Certifications { get; set; }
        public clsTeachers()
        {
            this.TeacherID = 0;
            this.PersonID = 0;
            this.CreatedByUserID = 0;
            this.TeachingExperience = "";
            this.EducationLevelID = 0;
            this.Certifications = "";
            this.Mode = enMode.AddNew;
        }
        private clsTeachers(int TeacherID, int PersonID, int CreatedByUserID, string TeachingExperience, int EducationLevelID, string Certifications)
        {
            this.TeacherID = TeacherID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.TeachingExperience = TeachingExperience;
            this.EducationLevelID = EducationLevelID;
            this.Certifications = Certifications;
            this.Mode = enMode.Update;
        }
        public static clsTeachers Find(int TeacherID)
        {
            int PersonID = 0;
            int CreatedByUserID = 0;
            string TeachingExperience = "";
            int EducationLevelID = 0;
            string Certifications = "";

            bool IsFound = clsTeachersData.GetTeacherInfoByID(TeacherID, ref PersonID, ref CreatedByUserID, ref TeachingExperience, ref EducationLevelID, ref Certifications);

            return (IsFound) ? (new clsTeachers(TeacherID, PersonID, CreatedByUserID, TeachingExperience, EducationLevelID, Certifications)) : null;
        }
        public bool _AddNewTeachers()
        {
            this.TeacherID = clsTeachersData.
                AddNewTeacher(this.PersonID, this.CreatedByUserID, this.TeachingExperience, this.EducationLevelID, this.Certifications);
            return (this.TeacherID != -1);
        }

        private bool _UpdateTeachers()
        {
            return clsTeachersData.UpdateTeacher(this.TeacherID, this.PersonID, this.CreatedByUserID, this.TeachingExperience, this.EducationLevelID, this.Certifications);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTeachers())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateTeachers();
            }
            return false;
        }
        public static bool DeleteTeachers(int TeacherID)
        {
            return clsTeachersData.DeleteTeacher(TeacherID);
        }
        public static DataTable GetAllTeachers()
        {
            return clsTeachersData.GetAllTeacher();
        }
        public static bool DoesTeachersExist(int TeachersID)
        {
            return clsTeachersData.DoesTeacherExist(TeachersID);
        }
        static void Main(string[] args) 
        {
            TestAddTeachers();
            //TestFindTeachers();
         //  TestUpdateTeachers();
          // TestDeleteTeachers();
            Console.ReadLine();
        }
        static void TestAddTeachers()
        {
            clsTeachers teacher = new clsTeachers();
            teacher.PersonID = 71;
            teacher.CreatedByUserID = 4;
            teacher.TeachingExperience = "more the 27";
            teacher.EducationLevelID = 3;
            teacher.Certifications = "from SPET";
            ;

            if (teacher.Save())
            {
                Console.WriteLine("Teachers added successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add Teachers.");
            }
        }
        static void TestFindTeachers()
        {
            int TeachersIdToFind = 7; // Replace with the actual Teachers ID to find

            clsTeachers foundTeachers = clsTeachers.Find(TeachersIdToFind);



            if (foundTeachers != null)
            {
                 Console.WriteLine($"Found Teachers: TeachersID={foundTeachers.TeacherID}, Notes={foundTeachers.Certifications}");
            }
            else
            {
                Console.WriteLine("Teachers not found.");
            }
        }
        static void TestUpdateTeachers()
        {
            int TeachersIdToUpdate = 7; // Replace with the actual Teachers ID to update

            clsTeachers Teachers = clsTeachers.Find(TeachersIdToUpdate);

            Teachers.Certifications = "Spae";

            if (Teachers != null)
            {
                Console.WriteLine($"Current Notes: "+ Teachers.Certifications);

                // Modify the properties

                if (Teachers.Save())
                {
                    Console.WriteLine("Teachers updated successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to update Teachers.");
                }
            }
            else
            {
                Console.WriteLine("Teachers not found.");
            }
        }
        static void TestDeleteTeachers()
        {
            int TeachersIdToDelete = 15; // Replace with the actual Teachers ID to delete

            if (clsTeachers.DeleteTeachers(TeachersIdToDelete))
            {
                Console.WriteLine("Teachers deleted successfully!");
            }
            else
            {
                Console.WriteLine("Failed to delete Teachers.");
            }
        }
    }
}

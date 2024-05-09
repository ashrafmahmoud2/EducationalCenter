using EducationalCenterDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterBusinessLayer 
{
    public  class clsStudents: clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;
        public int StudentID { get; set; }
        public int PersonID { get; set; }
        public   int GradID { get; set; }
        public int CreatedByUserID { get; set; }

        public String GradName {  get; set; }
       

             
        public clsStudents() 
        {
            this.StudentID = 0;
            this.PersonID = 0;
            this.GradID = 0;
            this.CreatedByUserID = 0;
            this.GradName = clsGraduationDegrees.Find(GradID).DegreeName;

            this.Mode = enMode.AddNew;
        }
        private clsStudents(int StudentID, int PersonID, int GradID, int CreatedByUserID)
        {
            this.StudentID = StudentID;
            this.PersonID = PersonID;
            this.GradID = GradID;
            this.CreatedByUserID = CreatedByUserID;
            this.GradName = clsGraduationDegrees.Find(GradID).DegreeName;
            this.Mode = enMode.Update;
        }
        public static clsStudents Find(int StudentID)
        {
            int PersonID = 0;
            int GradID = 0;
            int CreatedByUserID = 0;



            bool IsFound = clsStudentsData.GetStudentInfoByID(StudentID, ref PersonID, ref GradID, ref CreatedByUserID);

            return (IsFound) ? (new clsStudents(StudentID, PersonID, GradID, CreatedByUserID)) : null;
        }
        public bool _AddNewStudents()
        {
            this.StudentID = clsStudentsData.AddNewStudent(this.PersonID, this.GradID, this.CreatedByUserID);
            return (this.StudentID != -1);
        }

        private bool _UpdateStudents()
        {
            return clsStudentsData.UpdateStudent(this.StudentID, this.PersonID, this.GradID, this.CreatedByUserID);
        }

        public bool Save()
        {


            if (!base.Save())
            {
                return false; // If base.Save() returns false, return false immediately
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewStudents())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateStudents();
            }
            

            return false;
        }
        public static bool DeleteStudents(int StudentID)
        {
            return clsStudentsData.DeleteStudent(StudentID);
        }
        public static DataTable GetAllStudents()
        {
            return clsStudentsData.GetAllStudent();
        }
        public static bool DoesStudentsExist(int StudentsID)
        {
            return clsStudentsData.DoesStudentExist(StudentsID);
        }
        //static void Main(string[] args)
        //{
         
        //   // TestAddStudents();
        //  //  TestFindStudents();
        //  // TestUpdateStudents();
        //   //  TestDeleteStudents();
        //    Console.ReadLine();
        //}
        static void TestAddStudents()
        {
            clsStudents student = new clsStudents();
           // student.StudentID = ;
            student.PersonID = 2;
            student.GradID = 2;
            student.CreatedByUserID = 4;
            ;

            if (student.Save())
            {
                Console.WriteLine("Students added successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add Students.");
            }
        }
        static void TestFindStudents()
        {
            int StudentsIdToFind = 27; // Replace with the actual Students ID to find

            clsStudents foundStudents = clsStudents.Find(StudentsIdToFind);

            if (foundStudents != null)
            {
                //  Console.WriteLine($"Found Students: StudentsID={foundStudents.StudentID}, Notes={foundStudents.Notes}");
            }
            else
            {
                Console.WriteLine("Students not found.");
            }
        }
        static void TestUpdateStudents()
        {
            int StudentsIdToUpdate = 1; // Replace with the actual Students ID to update


            clsStudents Students = clsStudents.Find(StudentsIdToUpdate);

            Students.GradID = 12;

            if (Students != null)
            {
                //  Console.WriteLine($"Current Notes: StudentsID}");

                // Modify the properties

                if (Students.Save())
                {
                    Console.WriteLine("Students updated successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to update Students.");
                }
            }
            else
            {
                Console.WriteLine("Students not found.");
            }
        }
        static void TestDeleteStudents()
        {
            int StudentsIdToDelete = 17; // Replace with the actual Students ID to delete

            if (clsStudents.DeleteStudents(StudentsIdToDelete))
            {
                Console.WriteLine("Students deleted successfully!");
            }
            else
            {
                Console.WriteLine("Failed to delete Students.");
            }
        }
    }
}

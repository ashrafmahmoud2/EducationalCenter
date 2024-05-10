using EducationalCenterDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterBusinessLayer
{
    public class clsGraduationDegrees
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;
        public int GradID { get; set; }
        public string DegreeName { get; set; }
        public clsGraduationDegrees()
        {
            this.GradID = 0;
            this.DegreeName = "";
            this.Mode = enMode.AddNew;
        }
        private clsGraduationDegrees(int GradID, string DegreeName)
        {
            this.GradID = GradID;
            this.DegreeName = DegreeName;
            this.Mode = enMode.Update;
        }
        public static clsGraduationDegrees Find(int GradID)
        {
            string DegreeName = "";


            bool IsFound = clsGraduationDegreesData.GetGraduationDegreInfoByID(GradID, ref DegreeName);

            return (IsFound) ? (new clsGraduationDegrees(GradID, DegreeName)) : null;
        }
        public bool _AddNewGraduationDegrees()
        {
            this.GradID = clsGraduationDegreesData.AddNewGraduationDegre(this.DegreeName);
            return (this.GradID != -1);
        }

        private bool _UpdateGraduationDegrees()
        {
            return clsGraduationDegreesData.UpdateGraduationDegre(this.GradID, this.DegreeName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGraduationDegrees())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateGraduationDegrees();
            }
            return false;
        }
        public static bool DeleteGraduationDegrees(int GradID)
        {
            return clsGraduationDegreesData.DeleteGraduationDegre(GradID);
        }
        public static DataTable GetAllGraduationDegrees()
        {
            return clsGraduationDegreesData.GetAllGraduationDegre();
        }
        public static bool DoesGraduationDegreesExist(int GraduationDegreesID)
        {
            return clsGraduationDegreesData.DoesGraduationDegreExist(GraduationDegreesID);
        }
        //static void Main(string[] args)
        //{
        //  //  TestAddGraduationDegrees();
        //    TestFindGraduationDegrees();
        //    //TestUpdateGraduationDegrees();
        //    //TestDeleteGraduationDegrees();
        //    Console.ReadLine();
        //}
        static void TestAddGraduationDegrees()
        {
            clsGraduationDegrees grad = new clsGraduationDegrees();
            grad.GradID = 0;
            grad.DegreeName = null;
            ;

            if (grad.Save())
            {
                Console.WriteLine("GraduationDegrees added successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add GraduationDegrees.");
            }
        }
        static void TestFindGraduationDegrees()
        {
            int GraduationDegreesIdToFind = 10; // Replace with the actual GraduationDegrees ID to find

            clsGraduationDegrees foundGraduationDegrees = clsGraduationDegrees.Find(GraduationDegreesIdToFind);

            if (foundGraduationDegrees != null)
            {
                Console.WriteLine($"Found GraduationDegrees: GraduationDegreesID={foundGraduationDegrees.GradID}, Notes={foundGraduationDegrees.DegreeName}");
            }
            else
            {
                Console.WriteLine("GraduationDegrees not found.");
            }
        }
        static void TestUpdateGraduationDegrees()
        {
            int GraduationDegreesIdToUpdate = 27; // Replace with the actual GraduationDegrees ID to update

            clsGraduationDegrees GraduationDegrees = clsGraduationDegrees.Find(GraduationDegreesIdToUpdate);

            if (GraduationDegrees != null)
            {
                //  Console.WriteLine($"Current Notes: GraduationDegreesID}");

                // Modify the properties

                if (GraduationDegrees.Save())
                {
                    Console.WriteLine("GraduationDegrees updated successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to update GraduationDegrees.");
                }
            }
            else
            {
                Console.WriteLine("GraduationDegrees not found.");
            }
        }
        static void TestDeleteGraduationDegrees()
        {
            int GraduationDegreesIdToDelete = 36; // Replace with the actual GraduationDegrees ID to delete

            if (clsGraduationDegrees.DeleteGraduationDegrees(GraduationDegreesIdToDelete))
            {
                Console.WriteLine("GraduationDegrees deleted successfully!");
            }
            else
            {
                Console.WriteLine("Failed to delete GraduationDegrees.");
            }
        }
    }
}

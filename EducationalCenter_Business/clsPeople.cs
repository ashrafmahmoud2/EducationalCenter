using EducationalCenterDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenterBusinessLayer
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;
        public int PersonID { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public clsPeople()
        {
            this.PersonID = 0;
            this.Name = "";
            this.Gender = false;
            this.Age = 0;
            this.DateOfBirth = DateTime.Now;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.Mode = enMode.AddNew;
        }
        private clsPeople(int PersonID, string Name, bool Gender, int Age, DateTime DateOfBirth, string Phone, string Email, string Address)
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.Mode = enMode.Update;
        }
        public static clsPeople Find(int PersonID)
        {
            string Name = "";
            bool Gender = false;
            int Age = 0;
            DateTime DateOfBirth = DateTime.Now;
            string Phone = "";
            string Email = "";
            string Address = "";


            bool IsFound = clsPeopleData.GetPeopleInfoByID (PersonID, ref Name, ref Gender, ref Age, ref DateOfBirth, ref Phone, ref Email, ref Address);

            return (IsFound) ? (new clsPeople(PersonID, Name, Gender, Age, DateOfBirth, Phone, Email, Address)) : null;
        }
        public bool _AddNewPeople()
        {
            this.PersonID = clsPeopleData.AddNewPeople(this.Name, this.Gender, this.Age, this.DateOfBirth, this.Phone, this.Email, this.Address);
            return (this.PersonID != -1);
        }

        private bool _UpdatePeople()
        {
            return clsPeopleData.UpdatePeople(this.PersonID, this.Name, this.Gender, this.Age, this.DateOfBirth, this.Phone, this.Email, this.Address);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPeople())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePeople();
            }
            return false;
        }
        public static bool DeletePeople(int PersonID)
        {
            return clsPeopleData.DeletePeople(PersonID);
        }
        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }
        public static bool DoesPeopleExist(int PeopleID)
        {
            return clsPeopleData.DoesPeopleExist(PeopleID);
        }
        //static void Main(string[] args)
        //{
        //   TestAddPeople();
        //   TestFindPeople();
        //   TestUpdatePeople();
        //   TestDeletePeople();
        //   Console.ReadLine();
        //}
        static void TestAddPeople()
        {
            clsPeople person = new clsPeople();
            person.PersonID = 0;
            person.Name = null;
            person.Gender = false;
            person.Age = 0;
            person.DateOfBirth = DateTime.Now;
            person.Phone = null;
            person.Email = null;
            person.Address = null;
            ;

            if (person.Save())
            {
                Console.WriteLine("People added successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add People.");
            }
        }
        static void TestFindPeople()
        {
            int PeopleIdToFind = 27; // Replace with the actual People ID to find

            clsPeople foundPeople = clsPeople.Find(PeopleIdToFind);

            if (foundPeople != null)
            {
                //  Console.WriteLine($"Found People: PeopleID={foundPeople.PersonID}, Notes={foundPeople.Notes}");
            }
            else
            {
                Console.WriteLine("People not found.");
            }
        }
        static void TestUpdatePeople()
        {
            int PeopleIdToUpdate = 27; // Replace with the actual People ID to update

            clsPeople People = clsPeople.Find(PeopleIdToUpdate);

            if (People != null)
            {
                //  Console.WriteLine($"Current Notes: PeopleID}");

                // Modify the properties

                if (People.Save())
                {
                    Console.WriteLine("People updated successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to update People.");
                }
            }
            else
            {
                Console.WriteLine("People not found.");
            }
        }
        static void TestDeletePeople()
        {
            int PeopleIdToDelete = 36; // Replace with the actual People ID to delete

            if (clsPeople.DeletePeople(PeopleIdToDelete))
            {
                Console.WriteLine("People deleted successfully!");
            }
            else
            {
                Console.WriteLine("Failed to delete People.");
            }
        }
    }
}

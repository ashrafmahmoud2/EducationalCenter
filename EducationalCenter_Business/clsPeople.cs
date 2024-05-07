using EducationalCenter_Data;
using EducationalCenterDataAccess;
using System;
using System.Data;

namespace EducationalCenterBusiness
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? PersonID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsPerson()
        {
            PersonID = null;
            Name = string.Empty;
            Gender = string.Empty;
            Age = -1;
            DateOfBirth = DateTime.Now;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsPerson(int? personID, string name, string gender, int age, DateTime dateOfBirth, string phone, string email, string address)
        {
            PersonID = personID;
            Name = name;
            Gender = gender;
            Age = age;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Address = address;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            PersonID = clsPersonData.Add(Name, Gender, Age, DateOfBirth, Phone, Email, Address);

            return (PersonID.HasValue);
        }

        private bool _Update()
        {
            return clsPersonData.Update(PersonID, Name, Gender, Age, DateOfBirth, Phone, Email, Address);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsPerson Find(int? personID)
        {
            string name = string.Empty;
            string gender = string.Empty;
            int age = -1;
            DateTime dateOfBirth = DateTime.Now;
            string phone = string.Empty;
            string email = string.Empty;
            string address = string.Empty;

            bool isFound = clsPersonData.GetInfoByID(personID, ref name, ref gender, ref age, ref dateOfBirth, ref phone, ref email, ref address);

            return (isFound) ? (new clsPerson(personID, name, gender, age, dateOfBirth, phone, email, address)) : null;
        }

        public static bool Delete(int? personID)
        => clsPersonData.Delete(personID);

        public static bool Exists(int? personID)
        => clsPersonData.Exists(personID);

        public static DataTable All()
        => clsPersonData.All();
    }
}
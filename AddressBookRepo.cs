using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBook_LINQ
{
    public class AddressBookRepo
    {
        /// <summary>
        /// uc-1
        /// Creating Data Table
        /// </summary>
        DataTable dataTable = new DataTable();
        /// <summary>
        /// UC-2
        /// Adding data into datatable
        /// </summary>
        public void AddData()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));
            ///UC-3
            dataTable.Rows.Add("Krunal", "pandya", "thomas road", "Delhi", "Delhi", "123456", "9876543210", "krunal@yahoo.com");
            dataTable.Rows.Add("Hardik", "pandya", "mount road", "Mumbai", "Maharashtra", "987654", "9123456780", "hardik@gmail.com");
            dataTable.Rows.Add("myanak", "agarwal", "church road", "Bangalore", "Karnataka", "09876", "9121763450", "myank@gmail.com");
            dataTable.Rows.Add("joe", "biden", "arch road", "Saanfransisco", "USA", "143599", "9891283121", "joe@yahoo.com");
            dataTable.Rows.Add("tony", "stark", "north street", "vegas", "USA", "908734", "9872162562", "tony@gmail.com");
            dataTable.Rows.Add("peter", "son", "south street", "los angles", "America", "987152", "098216767231", "peter@gmail.com");
        }
        public void DisplayData()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col] + " ");
                }
                Console.WriteLine();
            }
        }
        public void EditContact(string firstName, string lastName, string address, string city, string state, string zipcode, string phoneNumber, string email)
        {
            var recordedData = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == firstName).FirstOrDefault();
            if (recordedData != null)
            {
                recordedData.SetField("LastName", lastName);
                recordedData.SetField("Address", address);
                recordedData.SetField("City", city);
                recordedData.SetField("State", state);
                recordedData.SetField("ZipCode", zipcode);
                recordedData.SetField("EmailID", email);
                recordedData.SetField("State", state);
                Console.WriteLine("Contact edited successfully");
            }
            else
            {
                Console.WriteLine("No Contact Found");
            }
        }
        public void DeleteContact(string name)
        {
            var deleteRow = dataTable.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals(name)).FirstOrDefault();
            if (deleteRow != null)
            {
                deleteRow.Delete();
                Console.WriteLine("Contact deleted");
            }
        }
    }
}

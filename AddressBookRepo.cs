using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBook_LINQ
{
    public class AddressBookRepo
    {
        /// <summary>
        /// uc-1
        /// Creating Data Table
        /// </summary>
        readonly DataTable dataTable = new DataTable();
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
        }
    }
}

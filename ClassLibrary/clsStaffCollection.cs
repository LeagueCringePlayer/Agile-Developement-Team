using System.Collections.Generic;
using System;

namespace ClassLibrary

{
    public class clsStaffCollection
    {
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        // Public property to hold a list of staff
        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }


        // Public property to hold the count of staff items
        public int Count
        {
            get { return mStaffList.Count; }
            set { /* We can ignore setting the count, as it is managed by the list itself */ }
        }


        // Public property to hold a single staff object
        public clsStaff ThisStaff { get; set; }
        public clsStaffCollection()
        {
            // variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount = 0;
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank staff object
                clsStaff AStaff = new clsStaff();
                // read in the fields for the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.DateHired = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateHired"]);
                AStaff.HourlyRate = Convert.ToDecimal(DB.DataTable.Rows[Index]["HourlyRate"]);
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                // add the record to the private data member
                mStaffList.Add(AStaff);
                // point at the next record
                Index++;
            }
        }

    }
}
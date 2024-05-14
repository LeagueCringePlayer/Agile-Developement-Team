using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Private data members for the Staff properties
        private int mStaffId;
        private string mName;
        private string mRole;
        private DateTime mDateHired;
        private bool mActive;
        private decimal mHourlyRate;
        private string mEmail;

        // Public properties
        public int StaffId
        {
            get { return mStaffId; }
            set { mStaffId = value; }
        }
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public string Role
        {
            get { return mRole; }
            set { mRole = value; }
        }
        public DateTime DateHired
        {
            get { return mDateHired; }
            set { mDateHired = value; }
        }
        public bool Active
        {
            get { return mActive; }
            set { mActive = value; }
        }
        public decimal HourlyRate
        {
            get { return mHourlyRate; }
            set { mHourlyRate = value; }
        }

        public string StaffEmail {
            get { return mEmail; }
            set { mEmail = value; }
        }


        // Find method
        public bool Find(int StaffId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the search query
            DB.AddParameter("@StaffId", StaffId);

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");

            // Check if one record is found
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mDateHired = Convert.ToDateTime(DB.DataTable.Rows[0]["DateHired"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mHourlyRate = Convert.ToDecimal(DB.DataTable.Rows[0]["HourlyRate"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                // Return that everything worked OK
                return true;
            }
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }
    }
}

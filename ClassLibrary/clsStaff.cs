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
            // Hardcoding data for demonstration
            mStaffId = StaffId;
            mName = "John Doe";
            mRole = "Developer";
            mDateHired = Convert.ToDateTime("01/01/2020");
            mActive = true;
            mHourlyRate = 25.50M;
            mEmail = "johndoe@example.com";
            // Assuming the ID is always found
            return true;
        }
    }
}

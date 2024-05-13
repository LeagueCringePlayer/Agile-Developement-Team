using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public string StaffName { get; set; }
        public string StaffEmail { get; set; }
        public string StaffRole { get; set; }
        public DateTime DateHired { get; set; }
        public bool IsActive { get; set; }
        public decimal HourlyRate { get; set; }
        public int StaffID { get; set; }
    }
}
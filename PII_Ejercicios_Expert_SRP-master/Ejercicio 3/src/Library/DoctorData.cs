using System;
using System.Text;

namespace Library
{
    public class DoctorData
    {
        public string doctorName{get; set;}
        public DoctorData(String doctorName)
        {
            this.doctorName = doctorName;
        }
        public static bool DoctorValidation (string doctorName)
        {   
            StringBuilder stringBuilder = new StringBuilder("");
            Boolean isValid = true;

             if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }
            return isValid;
            
        }
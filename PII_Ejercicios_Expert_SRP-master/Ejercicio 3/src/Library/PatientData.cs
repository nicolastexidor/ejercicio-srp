using System;
using System.Text;

namespace Library
{
    public class PatientData
    {
        public string name {get; set;}
        public string id {get; set;}
        public string phoneNumber {get; set;}
        public PatientData (String name, String id, String phoneNumber)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
        }
        public static bool PatientValidation(string name, string id, string phoneNumber)
        {
            StringBuilder stringBuilder = new StringBuilder("");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }
            return isValid;
        }
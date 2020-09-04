using System;
using System.Text;

namespace Library
{
    public class DateAndPlace
    {
        public string date {get; set;}
        public string appointmentPlace {get; set;}
        public DateAndPlace (DateTime date, String appointmentPlace)
        {
            this.appointmentPlace = appointmentPlace;
        }
        public static bool DateAndPlaceValidation (string date, string appointmentPlace)
        {   
            StringBuilder stringBuilder = new StringBuilder("");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }
            return isValid;
        }
    }
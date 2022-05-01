using System;

namespace DataProvider
{
    public class DataProvider
    {
        public static string FirstName = "Soren";
        public static string LastName = "Wilson";
        public static DateTime BirthDate = new DateTime(2017, 1, 7);
        public static bool Hit_Left = true;
        public static bool Hit_Right = !Hit_Left;
        public static bool Throw_Right = true;
        public static bool Throw_Left = !Throw_Right;
    }
}

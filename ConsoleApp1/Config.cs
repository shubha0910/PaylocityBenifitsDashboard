﻿

namespace PaylocityBenifitsDashboard
{
    public static class Config
    {
        public static string BaseURL = "https://wmxrwq14uc.execute-api.us-east-1.amazonaws.com/Prod/Account/Login";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "TestUser40";
                public static string Password = "##ls^?/F#iX7";

            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string BlankUserName = "";
                    public static string SpecialCharUserName = "TestUser41";
                }

                public static class Password
                {
                    public static string BlankPassword = "";
                    public static string NumericPassword = "1234567";
                }
            }
        }
    }
}

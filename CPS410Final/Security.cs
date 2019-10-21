﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace CPS410Final
{
    public class Security
    {
        private static string connectionString = WebConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString;

        //https://stackoverflow.com/questions/50399685/c-sharp-login-system-need-help-hashing-password-before-inserting-them-to-the-da
        public static string Sha256(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                /*
                 * Generate, configure/add the salt HERE
                 */




                // Making the SHA-256 Version
                using (var sha = SHA256.Create())
                {
                    var bytes = Encoding.UTF8.GetBytes(value);
                    var hash = sha.ComputeHash(bytes);

                    return Convert.ToBase64String(hash);
                }
            }
            else
            {
                return string.Empty;
            }
        }


        /**
         * Gets the connection string for the database
         */
        public static string getConnection()
        {
            return connectionString;
        }
    }
}
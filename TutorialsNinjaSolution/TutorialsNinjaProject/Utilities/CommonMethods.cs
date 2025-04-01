using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsNinjaProject.Utilities
{
    internal class CommonMethods
    {

        public string GenerateEmail()
        {
            string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"); // Generate a timestamp-based unique identifier
            string domain = "example.com"; // Change this to your desired domain
            return $"user{timestamp}@{domain}";
        }



    }
}

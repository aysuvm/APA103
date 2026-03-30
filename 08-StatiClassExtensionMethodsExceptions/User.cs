using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; }
        public int FailedAttempts { get; set; }

        public User (string userName, string password, bool isLocked, int failedAttempts)
        {
            UserName = userName;
            Password = password;
            IsLocked = isLocked;
            FailedAttempts = 0;
        }
    }
}

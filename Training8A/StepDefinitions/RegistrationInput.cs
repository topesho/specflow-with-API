using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSkill.StepDefinitions
{
    public class RegistrationInput
    {
      

        public string Firstname { get; set; }

        public string Lastname { get; set; }
        //public Int64 Mobileno { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
}
}

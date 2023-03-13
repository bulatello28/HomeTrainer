using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTrainer.Entities
{
    public class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string fName, string lName, int height, int weight, int age, string login, string password)
        {
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
            Age = age;
            Login = login;
            Password = password;
        }
    }
}

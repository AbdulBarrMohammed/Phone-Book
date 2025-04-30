using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneBook.Model;
using Spectre.Console;

namespace PhoneBook.Controller
{
    static class UserController
    {
        public static void AddPhone()
        {
            var name = AnsiConsole.Ask<string>("User name: ");
            var email = AnsiConsole.Ask<string>("User email: ");
            var phoneNumber = AnsiConsole.Ask<string>("User phone number: ");

            // Get database
            using var db = new PhoneDBContext();
            db.Add(new User { Name = name, Email = email, PhoneNumber = phoneNumber});
            db.SaveChanges();

        }


        public static void DeletePhone() {}

        public static void UpdatePhone() {}

        public static void ViewPhone() {}


        public static List<User> ViewAllPhones()
        {
            var db = new PhoneDBContext();
            var users = db.Users.ToList<User>();
            return users;
        }
    }
}

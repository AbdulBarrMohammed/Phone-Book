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
        public static void AddPhone(string name, string email, string phoneNumber)
        {


            // Get database
            using var db = new PhoneDBContext();
            db.Add(new User { Name = name, Email = email, PhoneNumber = phoneNumber});
            db.SaveChanges();

        }


        public static void DeletePhone(User user)
        {
            using var db = new PhoneDBContext();
            db.Remove(user);
            db.SaveChanges();
        }

        public static void UpdatePhone(User user)
        {
            using var db = new PhoneDBContext();
            db.Update(user);
            db.SaveChanges();

        }

        public static User GetPhoneById(int id)
        {
            var db = new PhoneDBContext();
            var user = db.Users.SingleOrDefault(x => x.Id == id);
            return user;
        }


        public static List<User> ViewAllPhones()
        {
            var db = new PhoneDBContext();
            var users = db.Users.ToList<User>();
            return users;
        }
    }
}

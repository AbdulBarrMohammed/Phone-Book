using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Model;

namespace PhoneBook
{
    // This class serves as a link between the application and database
    public class PhoneDBContext : DbContext
    {
        // This represents database table
        public DbSet<User> Users { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite("Data Source=phonebook.db");





    }
}

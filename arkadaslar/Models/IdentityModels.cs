using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace arkadaslar.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
       

        public string LastName { get; set; }

        public DateTime DateTime { get; set; }

        public string EMail { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }



    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Post> post { get; set; }
        public DbSet<Pictures> picture { get; set; }
        public DbSet<PicturePaths> picturePath { set; get; }
       

     
    }
}
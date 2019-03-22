using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using EshopSpareParts.Models.Db;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace EshopSpareParts.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Town { get; set; }
        public string TownNumber { get; set; }
        public string TownStreet { get; set; }

        public bool IsAnonymous { get; set; }
        public bool AgreeTransaction { get; set; }
        public bool AgreeRegistration { get; set; }

        public DateTime DateIn { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<ItemAvailability> ItemAvailabilities { get; set; }
        public DbSet<TransportCompany> TransportCompanies{ get; set; }
        public DbSet<PersonalData> PersonalDatas{ get; set; }
        public DbSet<BillingAddress> BillingAddresses { get; set; }
        public DbSet<OrderDifferentDataAndAddress> OrderDifferentDataAndAddresses { get; set; }
        public DbSet<OrderTransport> OrderTransports { get; set; }
        public DbSet<CompleteOrderSummary> CompleteOrderSummaries { get; set; }
        public DbSet<ItemState> ItemStates { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("MyUsers");

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}
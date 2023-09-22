
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Data
{
    public class EventStoreContext: IdentityDbContext<ApplicationUser>
    {
        public EventStoreContext(DbContextOptions<EventStoreContext> options)
            : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
       /* public DbSet<User> Users { get; set; }*/
        public DbSet<Invitation> Invitations { get; set; }
      /*  public DbSet<Role> Roles { get; set; }*/
        public DbSet<Comment> Comments { get; set; }



        /*  public override int SaveChanges()
          {
              string errorMessage = string.Empty;
              var entities = (from entry in ChangeTracker.Entries()
                              where entry.State == EntityState.Modified || entry.State == EntityState.Added
                              select entry.Entity);

              var validationResults = new List<ValidationResult>();
              List<ValidationException> validationExceptionList = new List<ValidationException>();
              foreach (var entity in entities)
              {
                  if (!Validator.TryValidateObject(entity, new ValidationContext(entity), validationResults, true))
                  {
                      foreach (var result in validationResults)
                      {
                          if (result != ValidationResult.Success)
                          {
                              validationExceptionList.Add(new ValidationException(result.ErrorMessage));
                          }
                      }

                      throw new ValidationExceptions(validationExceptionList);
                  }
              }

              return base.SaveChanges();
          }*/
    }
}

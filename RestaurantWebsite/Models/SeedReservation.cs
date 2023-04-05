using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Reflection.Emit;

namespace RestaurantWebsite.Models
{

    internal class SeedReservation : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> entity)
        {

            entity.HasData(

                new Reservation 
                { 
                    Id = 1, 
                    Fname = "Ithan", 
                    Lname = "Sandoval", 
                    Email = "ithan@gmail.com", 
                    PhoneNumber = "215-123-4567",
                    ReserveDate = DateTime.Parse("2023 04, 22"), 
                    ReserveTime = "6:30 PM", 
                    People = 5, 
                    Note = "n/a" },

                 new Reservation
                 {
                     Id = 2,
                     Fname = "Peter",
                     Lname = "Hoang",
                     Email = "Peter@gmail.com",
                     PhoneNumber = "267-999-999",
                     ReserveDate = DateTime.Parse("2023 04, 22"),
                     ReserveTime = "7:30 PM",
                     People = 4,
                     Note = "n/a"
                 },

                  new Reservation
                  {
                      Id = 3,
                      Fname = "Kevin",
                      Lname = "Nguyen",
                      Email = "Kevin@gmail.com",
                      PhoneNumber = "610-123-4567",
                      ReserveDate = DateTime.Parse("2023 01, 01"),
                      ReserveTime = "5:30 PM",
                      People = 4,
                      Note = "n/a"
                  }


    );


        }

    }
}

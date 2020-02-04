using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task.Core.Domain;

namespace Task.Data.Configurations
{
    public class GuestConfiguration : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ZIP).IsRequired(false);
            builder.Property(x => x.DateOfBirth).IsRequired(false);
            builder.Property(x => x.Phone).IsRequired(false);
            builder.Property(x => x.City).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);

            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();


            //SeedData

            builder.HasData(
                new Guest(1,"Jan", "Nowak", "jan@wp.pl", null, "12-123", null, null, null),
                new Guest(2,"Janusz", "Nowakowski", "janusz@wp.pl", null, "42-123", null, null, null),
                new Guest(3,"Kamila", "Seweryn", "kamila@wp.pl", null, "33-133", null, null, null),
                new Guest(4,"Ola", "Nacht", "ola@wp.pl", null, null, null, null, null)

                );
        }
    }
}

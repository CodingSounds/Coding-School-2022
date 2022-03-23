using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopLibrary;
using PetShopLibrary.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {



        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(User => User.ID);
            


            builder.Property(User => User.Username).HasMaxLength(25);

            builder.Property(Customer => Customer.Password).HasMaxLength(10);

            //builder.HasOne(User => User.PetShopClass).WithMany(PetShopClass => PetShopClass.Users).HasForeignKey(User => User.ID);

        }


    }
}

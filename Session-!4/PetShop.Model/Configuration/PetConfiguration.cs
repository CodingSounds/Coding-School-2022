using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {



        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");

            builder.HasKey(pet => pet.ID);
          

            builder.Property(pet => pet.Breed).HasMaxLength(30);

            builder.Property(pet => pet.ObjectStatus).HasMaxLength(10);
            builder.Property(pet => pet.HealthStatus).HasMaxLength(10);
            builder.Property(pet => pet.AnimalType).HasMaxLength(10);

            //builder.HasOne(Pet => Pet.PetShopClass).WithMany(PetShopClass => PetShopClass.Pets).HasForeignKey(Pet => Pet.ID);

        }


    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Configuration
{
    public class PetFooDConfiguration : IEntityTypeConfiguration<PetFood>
    {



        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("PetFood");

            builder.HasKey(PetFood => PetFood.ID);
           

            

            
            builder.Property(PetFood => PetFood.Brand).HasMaxLength(10);
            //builder.Property(PetFood => PetFood.Type).HasMaxLength(10); giati leitourgei

            //builder.HasMany(PetFood => PetFood.PetShopClass).WithOne(PetShopClass => PetShopClass.PetFoods).HasForeignKey(PetFood => PetFood.ID);
            //builder.HasOne(petFood => petFood.PetShopClass).WithMany(petShopClass => petShopClass.PetFoods).HasForeignKey(PetFood => PetFood.ID);
           
        }
    }
}

/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLibrary;

namespace PetShop.EF.Configuration
{
    public class PetShopConfiguration: IEntityTypeConfiguration<PetShopClass>
    {




        public void Configure(EntityTypeBuilder<PetShopClass> builder)
        {
            
            builder.ToTable("PetShop");

            builder.HasKey(PetShopClass => PetShopClass.Id);

            //builder.HasOne(petShopClass=> petShopClass.PetFoods).WithOne(petFood=> petFood.)

*//*
            builder.Property(PetShopClass => PetShopClass.).HasMaxLength(100);

            builder.Property(PetShopClass => PetShopClass.Name).HasMaxLength(100);


            builder.Property(PetShopClass => PetShopClass.Tin).HasMaxLength(10);*//*

        }
    }
}
*/
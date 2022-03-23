using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLibrary;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PetShop.EF.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {


        
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(Customer => Customer.ID);
   

            builder.Property(Customer => Customer.Surname).HasMaxLength(100);

            builder.Property(Customer => Customer.Name).HasMaxLength(100);


            builder.Property(Customer => Customer.Tin).HasMaxLength(10);
            
        }

       
    }
}

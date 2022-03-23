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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {



        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(Customer => Customer.ID);
          

            builder.Property(Customer => Customer.Name).HasMaxLength(50);
            builder.Property(Customer => Customer.Surname).HasMaxLength(50);
            builder.Property(Customer => Customer.ObjectStatus).HasMaxLength(10);

            //builder.HasOne(Employee => Employee.PetShopClass).WithMany(PetShopClass => PetShopClass.Employees).HasForeignKey(Employee => Employee.ID);



        }


    }
}

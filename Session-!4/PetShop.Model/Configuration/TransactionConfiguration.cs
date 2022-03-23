using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {



        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(Transaction => Transaction.ID);

            //builder.HasOne(Transaction => Transaction.PetShopClass).WithMany(PetShopClass => PetShopClass.Transactions).HasForeignKey(Transaction => Transaction.ID);





            //builder.Property(PetFood => PetFood.Type).HasMaxLength(10); giati leitourgei

        }
    }
}

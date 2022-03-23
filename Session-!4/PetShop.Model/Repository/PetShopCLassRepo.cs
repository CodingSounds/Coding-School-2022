using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository
{
    public class PetShopClassRepo : IEntityRepo<PetShopClass>
    {
        public async Task Create(PetShopClass entity)
        {
            using var context = new PetShopAppContext();

            
            context.PetShopClasses.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new PetShopAppContext();
            var foundTodo = context.PetShopClasses.SingleOrDefault(PetShopClasss => PetShopClasss.Id == id);
            if (foundTodo is null)
                return;

            context.PetShopClasses.Remove(foundTodo);
            await context.SaveChangesAsync();
        }

        public List<PetShopClass> GetAll()
        {
            using var context = new PetShopAppContext();
            return context.PetShopClasses.ToList();
        }

        public PetShopClass? GetById(Guid id)
        {
            using var context = new PetShopAppContext();
            return context.PetShopClasses.Where(PetShopClass => PetShopClass.Id == id).SingleOrDefault();
        }

        public async Task Update(Guid id, PetShopClass entity)
        {
            using var context = new PetShopAppContext();
            var PetShop = context.PetShopClasses.Include(PetShopClass => PetShopClass.Customers).Include(PetShopClass => PetShopClass.Employees).SingleOrDefault(PetShopClass => PetShopClass.Id == id);
            if (PetShop is null)
                return;
            PetShop = entity;
            await context.SaveChangesAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShopLibrary;
using PetShopLibrary.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository
{
   
        public class PetShopManager
        {
            private PetShopAppContext _petShopContext;

            public PetShopManager()
            {
            }

            

            public async void Save()
            {
                using var context = new PetShopAppContext();
                await context.SaveChangesAsync();
            }
        public async void SaveCustomers(List<Customer> Customers)
        {
            using var context = new PetShopAppContext();
            if(Customers != null)
            {
                
                foreach (Customer customer in Customers)
                {
                    if (!context.Customers.Contains(customer))
                    {
                        context.Customers.Add(customer);
                    }
                    
                    

                }
            }
            await context.SaveChangesAsync();


        }




        public async void Delete(Customer customer)
            {
                using var context = new PetShopAppContext();
                var foundCustomer = context.Customers.SingleOrDefault(cust => cust.ID == customer.ID);
                if (foundCustomer is null)
                    return;
                foundCustomer.ObjectStatus = Status.Inactive;
                await context.SaveChangesAsync();
            }

            public async void Delete(Employee employee)
            {
                using var context = new PetShopAppContext();
                var foundEmployee = context.Employees.SingleOrDefault(emp => emp.ID == employee.ID);
                if (foundEmployee is null)
                    return;
                foundEmployee.ObjectStatus = Status.Inactive;
                await context.SaveChangesAsync();
            }

            public async void Delete(Pet pet)
            {
                using var context = new PetShopAppContext();
                var foundPet = context.Pets.SingleOrDefault(p => p.ID == pet.ID);
                if (foundPet is null)
                    return;
                foundPet.ObjectStatus = Status.Inactive;
                await context.SaveChangesAsync();
            }


            public async void Delete(PetFood petFood)
            {
                using var context = new PetShopAppContext();
                var foundFood = context.Customers.SingleOrDefault(food => food.ID == petFood.ID);
                if (foundFood is null)
                    return;
                foundFood.ObjectStatus = Status.Inactive;
                await context.SaveChangesAsync();
            }

            public void DeletePetFoodRange(string brand, int qty)
            {
                if (qty == 0) return;

                List<PetFood> petFoods = GetPetFoods().FindAll(x => x.Brand.Equals(brand) && x.ObjectStatus.Equals(Status.Active)).Take(qty).ToList();
                foreach (PetFood food in petFoods)
                {
                    Delete(food);
                }
            }


            public List<Customer> GetCustomers()
            {
                using var context = new PetShopAppContext();
                return context.Customers.ToList();
            }

            public List<Transaction> GetTransactions()
            {
                using var context = new PetShopAppContext();
                return context.Transactions.ToList();

            }

            public List<Pet> GetPets()
            {
                using var context = new PetShopAppContext();
                return context.Pets.ToList();
            }

            public List<PetFood> GetPetFoods()
            {
                using var context = new PetShopAppContext();

                return context.PetFoods.ToList();
            }

            public List<Employee> GetEmployees()
            {
                using var context = new PetShopAppContext();
                return context.Employees.ToList();

            }

            public async void Add(Customer customer)
            {
                using var context = new PetShopAppContext();
                context.Customers.Add(customer);
                await context.SaveChangesAsync();

            }

            public async void Add(Employee employee)
            {
                using var context = new PetShopAppContext();
                context.Employees.Add(employee);
                //await context.SaveChangesAsync();
                await context.SaveChangesAsync();



        }

            public async void Add(Pet pet)
            {
                using var context = new PetShopAppContext();
                context.Pets.Add(pet);
                await context.SaveChangesAsync();
             }

            public async void Add(Transaction transaction)
            {
                using var context = new PetShopAppContext();
                context.Transactions.Add(transaction);
                await context.SaveChangesAsync();


            }

            public async void Add(PetFood petFood)
            {
                using var context = new PetShopAppContext();
                context.PetFoods.Add(petFood);
                await context.SaveChangesAsync();

             }

            public PetFood? GetFood(AnimalType type, string brand)
            {
                PetFood? food = GetPetFoods().Find(x => x.Brand == brand && GetFoodType(type) == x.Type && x.ObjectStatus == Status.Active);
                return food;
            }

            public List<string> GetAvailableFoodBrands(AnimalType type)
            {
                var brands = GetFoodBrand(type);
                var available = brands.FindAll(x => GetFood(type, x) != null);
                return available;
            }


            public List<string> GetFoodBrand(AnimalType type)
            {
                FoodBrands brand = new FoodBrands();
                if (type == AnimalType.Dog)
                {
                    return brand.DogFoodBrands;
                }
                else if (type == AnimalType.Bird)
                {
                    return brand.BirdFoodBrands;
                }
                else if (type == AnimalType.Rat)
                {
                    return brand.RatFoodBrands;
                }
                else if (type == AnimalType.Fish)
                {
                    return brand.FishFoodBrands;
                }
                else if (type == AnimalType.Turtle)
                {
                    return brand.TurtleFoodBrands;
                }
                else if (type == AnimalType.Snake)
                {
                    return brand.SnakeFoodBrands;
                }
                else if (type == AnimalType.Cat)
                {
                    return brand.CatFoodBrands;
                }
                else return null;
            }

            public FoodType GetFoodType(AnimalType type)
            {
                if (type == AnimalType.Dog)
                {
                    return FoodType.DogFood;
                }
                else if (type == AnimalType.Bird)
                {
                    return FoodType.BirdFood;
                }
                else if (type == AnimalType.Rat)
                {
                    return FoodType.RatFood;
                }
                else if (type == AnimalType.Fish)
                {
                    return FoodType.FishFood;
                }
                else if (type == AnimalType.Turtle)
                {
                    return FoodType.TurtleFood;
                }
                else if (type == AnimalType.Snake)
                {
                    return FoodType.SnakeFood;
                }
                else
                {
                    return FoodType.CatFood;
                }

            }

            public int GetAvailableFoodQty(string brand)
            {
                return GetPetFoods().FindAll(x => x.Brand == brand).Count();
            }

            public decimal GetTotalPrice(Pet pet, int qty)
            {
                return GetFoodPrice(pet) * (qty - 1 >= 0 ? qty - 1 : 0) + pet.Price;
            }
            public decimal GetFoodPrice(Pet pet)
            {
                PetFood? petFood = GetPetFoods().Find(x => x.Brand == pet.FoodType.Brand);
                if (petFood == null) return 0;

                return petFood.Price;
            }

        }
    }


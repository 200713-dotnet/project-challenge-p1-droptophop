using PizzaStore.Domain.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PizzaStore.Storing.Factories
{
    public class UserFactory : Factory<UserModel>, IUserFactory
    {
        public UserFactory(PizzaStoreDbContext context) : base(context)
        {

        }



        public PizzaStoreDbContext PizzaStoreDbContext
        {
            get { return Context as PizzaStoreDbContext; }
        }
    }
}
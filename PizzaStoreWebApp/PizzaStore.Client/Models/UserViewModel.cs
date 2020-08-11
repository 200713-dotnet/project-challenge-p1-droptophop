using System.Collections.Generic;
using PizzaStore.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Client.Models
{
    public class UserViewModel
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public UserModel User { get; set; }
        public string Location { get; set; }
        public StoreModel Store { get; set; }
    }
}
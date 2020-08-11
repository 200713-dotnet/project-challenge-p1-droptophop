using System.Collections.Generic;
using PizzaStore.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Client.Models
{
    public class StoreViewModel
    {
        public int StoreId { get; set; }
        public string Location { get; set; }
        public StoreModel Store { get; set; }
        public List<StoreModel> Stores { get; set; }
        public bool isAdmin { get; set; }
    }
}
using System.Drawing;

namespace AMS24.Store.Shoes.Models.Entities
{
    public class Product
    {
        public Guid Id {get; set;}
        public string Brand {get; set;}
        public int MyProperty{get; set;}
        public Guid Color {get; set;}
        public Guid SizeId{get; set;}
        public double Price{get; set;}
        public bool IsActive{get; set;}
        public double Stock{get; set;}
        public string Description{get; set;}
    }
}
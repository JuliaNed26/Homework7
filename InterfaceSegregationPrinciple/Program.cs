using System;

namespace Interface_Segregation_Principle
{
    interface IItem
    {
        void SetPrice(double price);
    }

    interface IColorfulItem
    {
        void SetColor(byte color);
    }

    interface IItemWithDiscount
    {
        void ApplyDiscount(String discount);
    }
    interface IItemWithPromocode
    {
        void ApplyPromocode(String promocode);
    }
    interface ISizedItem
    {
        void SetSize(byte size);
    }

    class BookItem : IItem, IItemWithDiscount
    {
        public string Discount { get; private set; }
        public double Price { get; private set; }
        public void ApplyDiscount(string discount)
        {
            Discount = discount;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }
    }

    class ClothesItem : IItem, IColorfulItem, IItemWithDiscount, ISizedItem
    {
        public string Discount { get; private set; }
        public double Price { get; private set; }
        public byte Color { get; private set; }
        public byte Size { get; private set; }


        public void ApplyDiscount(string discount)
        {
            Discount = discount;
        }

        public void SetColor(byte color)
        {
            Color = color;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public void SetSize(byte size)
        {
            Size = size;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

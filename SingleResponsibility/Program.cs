using System;
using System.Collections.Generic;

namespace Single_responsibility
{
    //Single Responsibility principle
    class Item
    {

    }

    class OrderItems
    {
        private List<Item> itemList;
        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }
            set
            {
                itemList = value;
            }
        }
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }
    class OrderHandler
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    class OrderWriter
    {
        public void PrintOrder() {/*...*/}
    }
    class Order
    {
        OrderItems items;
        public void CalculateTotalSum() {/*...*/}
        public void ShowOrder() {/*...*/}
        
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

﻿namespace ConsoleApptest
{
    public abstract class Product
    {
        private int id;
        private string name;
        private int price;

        public Product()
        {
        }

        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public abstract double computeTax();
    }
}
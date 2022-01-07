﻿namespace Ternak_Admin.Model
{
    public class DataProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }
        
        public DataProduct(int id_produk, string name, double value, string image)
        {
            Id = id_produk;
            Name = name;
            Value = value;
            Image = image;
        }
    }
}
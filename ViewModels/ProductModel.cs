﻿using examenSeptembre2022.Models;

namespace examenSeptembre2022.ViewModels
{
    public class ProductModel
    {
        private readonly Product _myProduct;

        public ProductModel(Product product)
        {
            _myProduct = product;
        }

        public Product MonProduit
        {
            get { return _myProduct; }
        }

        public int ProductId
        {
            get { return _myProduct.ProductId; }
        }

        public string ProductName
        {
            get { return _myProduct.ProductName; }
        }

        public string ContactName
        {
            get { return _myProduct.Supplier.ContactName; }
        }

        public string QuantityPerUnit
        {
            get { return _myProduct.QuantityPerUnit; }
        }
    }
}
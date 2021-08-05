﻿using khadimSarrBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace khadimSarrBlazorApp.RechercherProduit
{
    public class ViewProduct :IViewProduct
    {

        private readonly IProductRepository productRepository;



        public ViewProduct(IProductRepository productRepository)

        {

            this.productRepository = productRepository;

        }



        public Product Execute(int id)

        {

            return productRepository.GetProduct(id);

        }
    }
}

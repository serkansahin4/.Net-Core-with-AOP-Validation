using Business.Abstract;
using Business.Data;
using Business.Entities;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        [ValidationAspect(typeof(ProductValidator),Priority =1)]
        public void Add(Product product)
        {
            
            
        }
    }
}

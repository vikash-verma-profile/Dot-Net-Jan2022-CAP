using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Models;
using EcommerceApi.ViewModel;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceDbContext _ecommerceDbContext;
        public ProductController(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            //var productData = _ecommerceDbContext.TblProducts.ToList();
            var productData = from P in _ecommerceDbContext.TblProducts
                              join PSC in _ecommerceDbContext.TblProductSizeColors
                              on P.Id equals PSC.ProductId
                              join S in _ecommerceDbContext.TblSizes
                              on PSC.SizeId equals S.Id
                              join C in _ecommerceDbContext.TblColors
                              on PSC.ColorId equals C.Id
                              join Cat in _ecommerceDbContext.TblCategories
                              on PSC.CatId equals Cat.Id
                              select new
                              {
                                  P.Id,
                                  P.ProductName,
                                  P.VendorName,
                                  P.Mrp,
                                  P.Discount,
                                  P.FinalPrice,
                                  P.Description,
                                  S.SizeName,
                                  C.ColorName,
                                  Cat.CategoryName
                              };

           var productList = new List<Product>();
            foreach(var item in productData)
            {
                var product = new Product();
                product.ProductId = item.Id;
                product.ProductName = item.ProductName;
                product.Vendor = item.VendorName;
                product.ProductSize = item.SizeName;
                product.ProductColor = item.ColorName;
                product.ProductDescription = item.Description;
                product.Category = item.CategoryName;
                product.Mrp = item.Mrp;
                product.Discount = item.Discount;
                product.FinalPrice = item.FinalPrice;
                productList.Add(product);
            }
            return productList;
        }
    }
}

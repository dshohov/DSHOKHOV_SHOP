﻿using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using shokhov_shop.Data;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;
using shokhov_shop.ViewModels;
using System.Linq;

namespace shokhov_shop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IPhotoService _photoService;
        public ProductRepository(ApplicationDbContext context, IPhotoService photoService)
        {
            _context = context;
            _photoService = photoService;
        }
        public bool Add(Product product)
        {
            _context.Add(product);
            return Save();
        }

        public bool Delete(Product product)
        {
            _context.Remove(product);
            return Save();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductInCategory(int id)
        {
            return await _context.Products.Where(x => x.Category_id == id).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Product> GetByIdAsyncNoTracking(int id)
        {
            return await _context.Products.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
        }

        public string GetNameCategory(int id)
        {
            var a = _context.Categories.FirstOrDefault(c => c.Id == id);
            return a.Name_For_User;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
        public bool Update(Product product)
        {
            _context.Update(product);
            return Save();
        }

        public async Task<IEnumerable<Product>> UseFilters(string sub_category, int categoryId)
        {
            return await _context.Products.Where(i => i.Category_id == categoryId).Where(i => i.Sub_category == sub_category).ToListAsync();
        }
        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products.Where(i => i.Id == id).FirstAsync();
        }

        public async void Delete_All_Photo_Async(Product edit_Product)
        {
            await _photoService.DeletePhotoAsync(edit_Product.Image);
            await _photoService.DeletePhotoAsync(edit_Product.Image2);
            await _photoService.DeletePhotoAsync(edit_Product.Image3);
            await _photoService.DeletePhotoAsync(edit_Product.Image4);
            await _photoService.DeletePhotoAsync(edit_Product.Image5);
        }

        public async Task<Product> Update_All_Photo_Async(int id,CreateOrEditProductViewModel productVM)
        {
            string[] sizes_Array = productVM.Sizes_Array ?? new string[0];

            var photoResult = await _photoService.AddPhotoAsync(productVM.Image);
            var photoResult2 = await _photoService.AddPhotoAsync(productVM.Image2);
            var photoResult3 = await _photoService.AddPhotoAsync(productVM.Image3);
            var photoResult4 = await _photoService.AddPhotoAsync(productVM.Image4);
            var photoResult5 = await _photoService.AddPhotoAsync(productVM.Image5);
            var product = new Product
            {
                Id = id,
                Name_For_User = productVM.Name_For_User,
                Description = productVM.Description,
                People = productVM.People,
                Image = photoResult.Url.ToString(),
                Image2 = photoResult2.Url.ToString(),
                Image3 = photoResult3.Url.ToString(),
                Image4 = photoResult4.Url.ToString(),
                Image5 = photoResult5.Url.ToString(),
                Category_id = productVM.Category_id,
                Price = productVM.Price,
                Sub_category = productVM.Sub_category,
                Sizes = string.Join(",", sizes_Array)
            };
            return product;
        }
        public Product NoUpdate_Photo(int id, CreateOrEditProductViewModel productVM, Product editProduct)
        {
            string[] sizes_Array = productVM.Sizes_Array ?? new string[0];
            var product = new Product
            {
                Id = id,
                Name_For_User = productVM.Name_For_User,
                Description = productVM.Description,
                People = productVM.People,
                Category_id = productVM.Category_id,
                Price = productVM.Price,
                Sub_category = productVM.Sub_category,
                Image = editProduct.Image,
                Image2 = editProduct.Image2,
                Image3 = editProduct.Image3,
                Image4 = editProduct.Image4,
                Image5 = editProduct.Image5,
                Sizes = string.Join(",", sizes_Array)
            };
            return product;
        }


        public async Task<Product> Create_ProductAsync(CreateOrEditProductViewModel productVM)
        {
            string[] sizes_Array = productVM.Sizes_Array ?? new string[0];

                var result = await _photoService.AddPhotoAsync(productVM.Image);
                var result2 = await _photoService.AddPhotoAsync(productVM.Image2);
                var result3 = await _photoService.AddPhotoAsync(productVM.Image3);
                var result4 = await _photoService.AddPhotoAsync(productVM.Image4);
                var result5 = await _photoService.AddPhotoAsync(productVM.Image5);
                var product = new Product
                {

                    Name_For_User = productVM.Name_For_User,
                    Description = productVM.Description,
                    People = productVM.People,
                    Image = result.Url.ToString(),
                    Image2 = result2.Url.ToString(),
                    Image3 = result3.Url.ToString(),
                    Image4 = result4.Url.ToString(),
                    Image5 = result5.Url.ToString(),
                    Sub_category = productVM.Sub_category,
                    Category_id = productVM.Category_id,
                    Price = productVM.Price,
                    Sizes = string.Join(",", sizes_Array)

                };
            
            return product;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Communication;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Repositories;
using SupermarketAPI.Domain.Services.Services;

namespace SupermarketAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await categoryRepository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await categoryRepository.AddAsync(category);
                await unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(category);
            }
            catch (Exception ex)
            {
                return new SaveCategoryResponse($"An error occurred when saving the category: {ex.Message}");

            }
        }

        public async Task<SaveCategoryResponse> UpdateAsync(int id, Category category)
        {
            var existingCategory = await categoryRepository.FindByIdAsync(id);

            if (existingCategory == null)
            {
                return new SaveCategoryResponse("Category not found!");
            }

            existingCategory.Name = category.Name;

            try
            {
                categoryRepository.Update(existingCategory);
                await unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                return new SaveCategoryResponse($"An error occurred when updating the category: {ex.Message}");

            }
        }

        public async Task<SaveCategoryResponse> DeleteAsync(int id)
        {
            var existingCategory = await categoryRepository.FindByIdAsync(id);

            if (existingCategory == null)
            {
                return new SaveCategoryResponse("Category not found!");
            }

            try
            {
                categoryRepository.Remove(existingCategory);
                await unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                return new SaveCategoryResponse($"An error occurred when deleting the category: {ex.Message}");
            }
        }
    }
}

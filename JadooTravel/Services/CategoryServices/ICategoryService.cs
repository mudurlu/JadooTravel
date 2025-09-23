﻿using JadooTravel.Dtos.CategoryDtos;

namespace JadooTravel.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetCategoryDto> GetCategoryByIdAsync(string id);
    }
}

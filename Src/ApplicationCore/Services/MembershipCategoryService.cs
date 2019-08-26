using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class MembershipCategoryService : IMembershipCategory
    {
        private readonly IAsyncRepository<Category> _categoryRepository;

        public MembershipCategoryService(IAsyncRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task CreateAsync(MembershipCategoryDto categoryDto)
        {
            var category = new Category();
            category.Id = 10;
            category.Name = categoryDto.Name;
            category.RoleId = 1;
            category.BranchId = 0;
            category.CreatedDate = DateTime.Now;
            category.UpdatedDate = DateTime.Now;
            category.Active = true;
            await _categoryRepository.AddAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Category>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}

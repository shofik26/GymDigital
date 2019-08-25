using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IMembershipCategory
    {
        Task<IReadOnlyList<Category>> GetAllCategoryAsync();
        Task  GetByIdAsync(int id);
        Task CreateAsync(MembershipCategoryDto categoryDto);
        Task UpdateAsync(Category categoryDto);
        Task DeleteAsync(int id);
    }
}

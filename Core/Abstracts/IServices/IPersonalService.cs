using Core.Concretes.DTOs;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface IPersonalService
    {
        Task<IDataResult<IEnumerable<PersonalDTO>>> GetAllAsync();
        Task<IDataResult<PersonalDTO>> GetByIdAsync(int id);
        Task<IResult> AddAsync(PersonalDTO personalDto);
        Task<IResult> UpdateAsync(PersonalDTO personalDto);
        Task<IResult> DeleteAsync(int id);
        //Task<IDataResult<IEnumerable<PersonalDTO>>> SearchCustomers(string searchTerm);

    }
}

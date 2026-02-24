using Core.Concretes.DTOs;
using Core.Concretes.Enums;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface IPersonalService
    {
        //CRUD Operations
        Task<IDataResult<IEnumerable<PersonalListDTO>>> GetAllAsync();
        Task<IDataResult<PersonalListDTO>> GetByIdAsync(int id);
        Task<IResult> AddAsync(AddPersonalDTO dto);
        Task<IResult> UpdateAsync(UpdatePersonalDTO dto);
        Task<IResult> DeleteAsync(int id);

        //Filtering and Searching Examples
        //Task<IDataResult<IEnumerable<ProjectListDTO>>> GetByWorkStatusAsync(WorkStatus status);
        //Task<IDataResult<IEnumerable<PersonalListDTO>>> GetActiveCustomerAsync();
        //Task<IDataResult<IEnumerable<PersonalListDTO>>> GetByCompanyNameAsync(string companyName);
        //Task<IDataResult<IEnumerable<PersonalListDTO>>> GetByCityAsync(string city);
        //Task<IDataResult<IEnumerable<PersonalListDTO>>> SearchCustomerAsync(string searchTerm);
        //Create More Pagination and Statistics
    }
}

using Core.Concretes.DTOs;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface IContactService
    {
        //CRUD Operations
        Task<IDataResult<IEnumerable<ContactListDTO>>> GetAllAsync();
        Task<IDataResult<ContactListDTO>> GetByIdAsync(int id);
        Task<IResult> AddAsync(AddContactDTO dto);
        Task<IResult> UpdateAsync(UpdateContactDTO dto);
        Task<IResult> DeleteAsync(int id);
    }
}

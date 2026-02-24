using Core.Concretes.DTOs;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface IEducationService
    {
        //CRUD Operations
        Task<IDataResult<IEnumerable<EducationListDTO>>> GetAllAsync();
        Task<IDataResult<EducationListDTO>> GetByIdAsync(int id);
        Task<IResult> AddAsync(AddEducationDTO dto);
        Task<IResult> UpdateAsync(UpdateEducationDTO dto);
        Task<IResult> DeleteAsync(int id);
    }
}

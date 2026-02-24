using Core.Concretes.DTOs;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface IExperienceService
    {
        //CRUD Operations
        Task<IDataResult<IEnumerable<ExperienceListDTO>>> GetAllAsync();
        Task<IDataResult<ExperienceListDTO>> GetByIdAsync(int id);
        Task<IResult> AddAsync(AddExperienceDTO dto);
        Task<IResult> UpdateAsync(UpdateExperienceDTO dto);
        Task<IResult> DeleteAsync(int id);
    }
}

using Core.Concretes.DTOs;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface ISkillService
    {
        //CRUD Operations
        Task<IDataResult<IEnumerable<SkillListDTO>>> GetAllAsync();
        Task<IDataResult<SkillListDTO>> GetByIdAsync(int id);
        Task<IResult> AddAsync(AddSkillDTO dto);
        Task<IResult> UpdateAsync(UpdateSkillDTO dto);
        Task<IResult> DeleteAsync(int id);
    }
}

using Core.Concretes.DTOs;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface IProjectService
    {
        //CRUD Operations
        Task<IDataResult<IEnumerable<ProjectListDTO>>> GetAllAsync();
        Task<IDataResult<ProjectListDTO>> GetByIdAsync(int id);
        Task<IResult> AddAsync(AddProjectDTO dto);
        Task<IResult> UpdateAsync(UpdateProjectDTO dto);
        Task<IResult> DeleteAsync(int id);
    }
}

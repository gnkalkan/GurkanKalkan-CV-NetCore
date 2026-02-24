using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Utilities.Results;

namespace Business.Services
{
    public class ProjectService(IUnitOfWork unitOfWork, IMapper mapper) : IProjectService
    {
        public Task<IResult> AddAsync(AddProjectDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<ProjectListDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ProjectListDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdateProjectDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
 
using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Utilities.Results;

namespace Business.Services
{
    public class ExperienceService(IUnitOfWork unitOfWork, IMapper mapper) : IExperienceService
    {
        public Task<IResult> AddAsync(AddExperienceDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<ExperienceListDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ExperienceListDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdateExperienceDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
 
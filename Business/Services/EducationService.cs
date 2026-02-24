using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Utilities.Results;

namespace Business.Services
{
    public class EducationService(IUnitOfWork unitOfWork, IMapper mapper) : IEducationService
    {
        public Task<IResult> AddAsync(AddEducationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<EducationListDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<EducationListDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdateEducationDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
 
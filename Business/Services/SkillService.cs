using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Utilities.Results;

namespace Business.Services
{
    public class SkillService(IUnitOfWork unitOfWork, IMapper mapper) : ISkillService
    {
        public Task<IResult> AddAsync(AddSkillDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<SkillListDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SkillListDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdateSkillDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
 
using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Utilities.Constants;
using Utilities.Results;

namespace Business.Services
{
    public class PersonalService(IUnitOfWork unitOfWork, IMapper mapper) : IPersonalService
    {
        public async Task<IResult> AddAsync(AddPersonalDTO dto)
        {
            try
            {
                var personal = mapper.Map<Personal>(dto);

                await unitOfWork.PersonalRepository.CreateAsync(personal);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Personal" + Messages.AddedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }

        public Task<IResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<PersonalListDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PersonalListDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdatePersonalDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}

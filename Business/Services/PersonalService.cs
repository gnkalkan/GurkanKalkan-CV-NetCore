using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Utilities.Constants;
using Utilities.Results;

namespace Business.Services
{
    public class PersonalService(IUnitOfWork unitOfWork, IMapper mapper) : IPersonalService
    {
        public Task<IResult> AddAsync(PersonalDTO personalDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<PersonalDTO>>> GetAllAsync()
        {
            try
            {
                var personals = await unitOfWork.PersonalRepository.FindManyAsync();
                var personalDtos = mapper.Map<IEnumerable<PersonalDTO>>(personals);
                return new SuccessDataResult<IEnumerable<PersonalDTO>>(personalDtos, $"Personals {Messages.RetrievedSuffix}");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<PersonalDTO>>($"{Messages.ErrorOccured}: {ex.Message}");
            }
        }

        public async Task<IDataResult<PersonalDTO>> GetByIdAsync(int id)
        {
            try
            {
                var personal = await unitOfWork.PersonalRepository.FindByIdAsync(id);
                if (personal == null)
                {
                    return new ErrorDataResult<PersonalDTO>($"Personal {Messages.NotFoundSuffix}");
                }
                var personalDto = mapper.Map<PersonalDTO>(personal);
                return new SuccessDataResult<PersonalDTO>(personalDto, $"Personal {Messages.RetrievedSuffix}");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<PersonalDTO>($"{Messages.ErrorOccured}: {ex.Message}");
            }
        }

        public Task<IResult> UpdateAsync(PersonalDTO personalDto)
        {
            throw new NotImplementedException();
        }
    }
}

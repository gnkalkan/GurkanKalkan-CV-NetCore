using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Utilities.Constants;
using Utilities.Results;

namespace Business.Services
{
    public class ExperienceService(IUnitOfWork unitOfWork, IMapper mapper) : IExperienceService
    {
        public async Task<IResult> AddAsync(AddExperienceDTO dto)
        {
            try
            {
                var experience = mapper.Map<Experience>(dto);

                await unitOfWork.ExperienceRepository.CreateAsync(experience);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Experience" + Messages.AddedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            try
            {
                var experience = await unitOfWork.ExperienceRepository.FindByIdAsync(id);
                if (experience == null)
                    return new ErrorResult("Experience" + Messages.NotFoundSuffix);
                await unitOfWork.ExperienceRepository.DeleteAsync(experience);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Experience" + Messages.DeletedSuffix);
            }
            catch (Exception ex)
            {

                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<ExperienceListDTO>>> GetAllAsync()
        {
            try
            {
                var experiences = await unitOfWork.ExperienceRepository.FindManyAsync();
                var experienceDTOs = mapper.Map<IEnumerable<ExperienceListDTO>>(experiences.ToList());
                return new SuccessDataResult<IEnumerable<ExperienceListDTO>>(experienceDTOs, "Experience" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<ExperienceListDTO>>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IDataResult<ExperienceListDTO>> GetByIdAsync(int id)
        {
            try
            {
                var experience = await unitOfWork.ExperienceRepository.FindByIdAsync(id);
                if (experience == null)
                    return new ErrorDataResult<ExperienceListDTO>("Experience" + Messages.NotFoundSuffix);
                var experienceDTO = mapper.Map<ExperienceListDTO>(experience);
                return new SuccessDataResult<ExperienceListDTO>(experienceDTO, "Experience" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ExperienceListDTO>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IResult> UpdateAsync(UpdateExperienceDTO dto)
        {
            try
            {
                var existingExperience = await unitOfWork.ExperienceRepository.FindByIdAsync(dto.Id);
                if (existingExperience == null)
                    return new ErrorResult("Experience" + Messages.NotFoundSuffix);

                mapper.Map(dto, existingExperience);
                await unitOfWork.ExperienceRepository.UpdateAsync(existingExperience);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Experience" + Messages.UpdatedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }
    }
}
 
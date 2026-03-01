using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Utilities.Constants;
using Utilities.Results;

namespace Business.Services
{
    public class EducationService(IUnitOfWork unitOfWork, IMapper mapper) : IEducationService
    {
        public async Task<IResult> AddAsync(AddEducationDTO dto)
        {
            try
            {
                var education = mapper.Map<Education>(dto);

                await unitOfWork.EducationRepository.CreateAsync(education);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Education" + Messages.AddedSuffix);
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
                var education = await unitOfWork.EducationRepository.FindByIdAsync(id);
                if (education == null)
                    return new ErrorResult("Education" + Messages.NotFoundSuffix);
                await unitOfWork.EducationRepository.DeleteAsync(education);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Education" + Messages.DeletedSuffix);
            }
            catch (Exception ex)
            {

                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<EducationListDTO>>> GetAllAsync()
        {
            try
            {
                var educations = await unitOfWork.EducationRepository.FindManyAsync();
                var educationDTOs = mapper.Map<IEnumerable<EducationListDTO>>(educations.ToList());
                return new SuccessDataResult<IEnumerable<EducationListDTO>>(educationDTOs, "Educations" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<EducationListDTO>>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IDataResult<EducationListDTO>> GetByIdAsync(int id)
        {
            try
            {
                var education = await unitOfWork.EducationRepository.FindByIdAsync(id);
                if (education == null)
                    return new ErrorDataResult<EducationListDTO>("Education" + Messages.NotFoundSuffix);
                var educationDTO = mapper.Map<EducationListDTO>(education);
                return new SuccessDataResult<EducationListDTO>(educationDTO, "Education" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<EducationListDTO>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IResult> UpdateAsync(UpdateEducationDTO dto)
        {
            try
            {
                var existingEducation = await unitOfWork.EducationRepository.FindByIdAsync(dto.Id);
                if (existingEducation == null)
                    return new ErrorResult("Education" + Messages.NotFoundSuffix);

                mapper.Map(dto, existingEducation);
                await unitOfWork.EducationRepository.UpdateAsync(existingEducation);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Education" + Messages.UpdatedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }
    }
}
 
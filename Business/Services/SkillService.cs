using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Utilities.Constants;
using Utilities.Results;

namespace Business.Services
{
    public class SkillService(IUnitOfWork unitOfWork, IMapper mapper) : ISkillService
    {
        public async Task<IResult> AddAsync(AddSkillDTO dto)
        {
            try
            {
                var skill = mapper.Map<Skill>(dto);

                await unitOfWork.SkillRepository.CreateAsync(skill);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Skill" + Messages.AddedSuffix);
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
                var skill = await unitOfWork.SkillRepository.FindByIdAsync(id);
                if (skill == null)
                    return new ErrorResult("Skill" + Messages.NotFoundSuffix);
                await unitOfWork.SkillRepository.DeleteAsync(skill);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Skill" + Messages.DeletedSuffix);
            }
            catch (Exception ex)
            {

                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<SkillListDTO>>> GetAllAsync()
        {
            try
            {
                var skills = await unitOfWork.SkillRepository.FindManyAsync();
                var skillDTOs = mapper.Map<IEnumerable<SkillListDTO>>(skills.ToList());
                return new SuccessDataResult<IEnumerable<SkillListDTO>>(skillDTOs, "Skill" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<SkillListDTO>>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IDataResult<SkillListDTO>> GetByIdAsync(int id)
        {
            try
            {
                var skill = await unitOfWork.SkillRepository.FindByIdAsync(id);
                if (skill == null)
                    return new ErrorDataResult<SkillListDTO>("Skill" + Messages.NotFoundSuffix);
                var skillDTO = mapper.Map<SkillListDTO>(skill);
                return new SuccessDataResult<SkillListDTO>(skillDTO, "Skill" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<SkillListDTO>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IResult> UpdateAsync(UpdateSkillDTO dto)
        {
            try
            {
                var existingSkill = await unitOfWork.SkillRepository.FindByIdAsync(dto.Id);
                if (existingSkill == null)
                    return new ErrorResult("Skill" + Messages.NotFoundSuffix);

                mapper.Map(dto, existingSkill);
                await unitOfWork.SkillRepository.UpdateAsync(existingSkill);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Skill" + Messages.UpdatedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }
    }
}
 
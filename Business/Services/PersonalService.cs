using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IResult> DeleteAsync(int id)
        {
            try
            {
                var personal = await unitOfWork.PersonalRepository.FindByIdAsync(id);
                if (personal == null)
                    return new ErrorResult("Personal" + Messages.NotFoundSuffix);
                await unitOfWork.PersonalRepository.DeleteAsync(personal);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Personal" + Messages.DeletedSuffix);
            }
            catch (Exception ex)
            {

                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<PersonalListDTO>>> GetAllAsync()
        {
            try
            {
                var personals = await unitOfWork.PersonalRepository.FindManyAsync();
                var personalDTOs = mapper.Map<IEnumerable<PersonalListDTO>>(personals.ToList());
                return new SuccessDataResult<IEnumerable<PersonalListDTO>>(personalDTOs, "Personals" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<PersonalListDTO>>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IDataResult<PersonalListDTO>> GetByIdAsync(int id)
        {
            try
            {
                var personal = await unitOfWork.PersonalRepository.FindByIdAsync(id);
                if (personal == null)
                    return new ErrorDataResult<PersonalListDTO>("Personal" + Messages.NotFoundSuffix);
                var personalDTO = mapper.Map<PersonalListDTO>(personal);
                return new SuccessDataResult<PersonalListDTO>(personalDTO, "Personal" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<PersonalListDTO>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IResult> UpdateAsync(UpdatePersonalDTO dto)
        {
            try
            {
                var existingPersonal = await unitOfWork.PersonalRepository.FindByIdAsync(dto.Id);
                if (existingPersonal == null)
                    return new ErrorResult("Personal" + Messages.NotFoundSuffix);

                mapper.Map(dto, existingPersonal);
                await unitOfWork.PersonalRepository.UpdateAsync(existingPersonal);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Personal" + Messages.UpdatedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }
    }
}

//Searching Example
//public async Task<IDataResult<IEnumerable<CustomerListDTO>>> SearchCustomersAsync(string searchTerm)
//{

//    try

//if (string.IsNullOrEmpty(searchTerm))
//        return new ErrorDataResult<IEnumerable<CustomerListDTO>>("Search term cannot be empty.");

//    var customers = await unitOfWork.CustomerRepository.FindManyAsync(c =>
//    c.CompanyName.Contains(searchTerm) | |
//    c.Email.Contains(searchTerm) | |
//    (c.City != null && c.City.Contains(searchTerm)) | |
//    (c.Country != null && c.Country.Contains(searchTerm))
    

//    var customerDTOs = mapper.Map<IEnumerable<CustomerListDTO>>(customers);
//    return new SuccessDataResult<IEnumerable<CustomerListDTO>>(customerDTOs, $"Customers matching '{searchTerm}' " + Messages.RetrievedSuffix);

//catch (Exception ex)

//return new ErrorDataResult<IEnumerable<CustomerListDTO>>(Messages.ErrorOccurred + ": " + ex.Message);

//)
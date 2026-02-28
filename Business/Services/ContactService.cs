using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Utilities.Constants;
using Utilities.Results;

namespace Business.Services
{
    public class ContactService(IUnitOfWork unitOfWork, IMapper mapper) : IContactService
    {
        public async Task<IResult> AddAsync(AddContactDTO dto)
        {
            try
            {
                var contact = mapper.Map<Contact>(dto);

                await unitOfWork.ContactRepository.CreateAsync(contact);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Contact" + Messages.AddedSuffix);
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
                var contact = await unitOfWork.ContactRepository.FindByIdAsync(id);
                if (contact == null)
                    return new ErrorResult("Contact" + Messages.NotFoundSuffix);
                await unitOfWork.ContactRepository.DeleteAsync(contact);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Contact" + Messages.DeletedSuffix);
            }
            catch (Exception ex)
            {

                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<ContactListDTO>>> GetAllAsync()
        {
            try
            {
                var contacts = await unitOfWork.ContactRepository.FindManyAsync();
                var contactDTOs = mapper.Map<IEnumerable<ContactListDTO>>(contacts.ToList());
                return new SuccessDataResult<IEnumerable<ContactListDTO>>(contactDTOs, "Contacts" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<ContactListDTO>>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IDataResult<ContactListDTO>> GetByIdAsync(int id)
        {
            try
            {
                var contact = await unitOfWork.ContactRepository.FindByIdAsync(id);
                if (contact == null)
                    return new ErrorDataResult<ContactListDTO>("Contact" + Messages.NotFoundSuffix);
                var contactDTO = mapper.Map<ContactListDTO>(contact);
                return new SuccessDataResult<ContactListDTO>(contactDTO, "Contact" + Messages.RetrievedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ContactListDTO>(Messages.ErrorOccured + ": " + ex.Message);
            }
        }

        public async Task<IResult> UpdateAsync(UpdateContactDTO dto)
        {
            try
            {
                var existingContact = await unitOfWork.ContactRepository.FindByIdAsync(dto.Id);
                if (existingContact == null)
                    return new ErrorResult("Contact" + Messages.NotFoundSuffix);

                mapper.Map(dto, existingContact);
                await unitOfWork.ContactRepository.UpdateAsync(existingContact);
                await unitOfWork.CommitAsync();
                return new SuccessResult("Contact" + Messages.UpdatedSuffix);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ErrorOccured + " : " + ex.Message);
            }
        }
    }
}
 
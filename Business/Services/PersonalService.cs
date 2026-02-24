using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class PersonalService(IUnitOfWork uniOfWork, IMapper mapper) : IPersonalService
    {
    }
}

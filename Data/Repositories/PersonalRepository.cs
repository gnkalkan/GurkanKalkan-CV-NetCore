using Core.Abstracts.IRepositories;
using Core.Concretes.Entities;
using Data.Contexts;
using Utilities.Generics;

namespace Data.Repositories
{
    public class PersonalRepository(CvDbContext context) : Repository<Personal>(context), IPersonalRepository
    {
    }
}

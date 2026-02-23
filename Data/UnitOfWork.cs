using Core.Abstracts;
using Core.Abstracts.IRepositories;
using Data.Contexts;
using Data.Repositories;

namespace Data
{
    public class UnitOfWork(CvDbContext context) : IUnitOfWork
    {
        private IPersonalRepository? personalRepository;
        public IPersonalRepository PersonalRepository => personalRepository ??= new PersonalRepository(context);

        public IContactRepository ContactRepository => throw new NotImplementedException();

        public IEducationRepository EducationRepository => throw new NotImplementedException();

        public IExperienceRepository ExperienceRepository => throw new NotImplementedException();

        public IProjectRepository ProjectRepository => throw new NotImplementedException();

        public IProjectSkillRepository ProjectSkillRepository => throw new NotImplementedException();

        public ISkillRepository SkillRepository => throw new NotImplementedException();

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}

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

        private IContactRepository? contactRepository;
        public IContactRepository ContactRepository => contactRepository ??= new ContactRepository(context);

        private IEducationRepository? educationRepository;
        public IEducationRepository EducationRepository => educationRepository ??= new EducationRepository(context);

        private IExperienceRepository? experienceRepository;
        public IExperienceRepository ExperienceRepository => experienceRepository ??= new ExperienceRepository(context);

        private ISkillRepository? skillRepository;
        public ISkillRepository SkillRepository => skillRepository ??= new SkillRepository(context);

        public async Task CommitAsync()
        {
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //await DisposeAsync();
                throw new Exception("An error occurred while saving changes to the database.", ex);
            }
        }

        public async ValueTask DisposeAsync()
        {
            await context.DisposeAsync();
            GC.SuppressFinalize(this);
        }
    }
}

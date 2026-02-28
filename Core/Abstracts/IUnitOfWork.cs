using Core.Abstracts.IRepositories;

namespace Core.Abstracts
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IPersonalRepository PersonalRepository { get; }
        IContactRepository ContactRepository { get; }
        IEducationRepository EducationRepository { get; }
        IExperienceRepository ExperienceRepository { get; }
        ISkillRepository SkillRepository { get; }
        Task CommitAsync();
    }
}

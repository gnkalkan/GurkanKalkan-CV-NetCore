using Core.Abstracts.Bases;
using Core.Concretes.Enums;

namespace Core.Concretes.Entities
{
    public class Experience : BaseEntity
    {
        public required string CompanyName { get; set; }
        public required string Title { get; set; }
        public required string StartEndYear { get; set; } = null!;
        public required string Description { get; set; }


        public WorkStatus WorkType { get; set; }
    }
}

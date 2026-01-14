namespace Embaixadinha.Models.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset Created_At { get; set; }
        public DateTimeOffset Updated_At { get; set; }
    }
}

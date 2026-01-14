namespace Embaixadinha.Models.Entities
{
    public class Score : BaseEntity
    {
        public Score(int value, int playerId)
        {
            Value = value;
            PlayerId = playerId;

            Created_At = DateTimeOffset.UtcNow;
            Updated_At = DateTimeOffset.UtcNow;
        }

        public int Value { get; set; }
        public int PlayerId { get; set; }
        
        public virtual Player Player { get; set; }
    }
}

namespace EventPoster.DataAccess.Entities
{
    public class EventGenreEntity: BaseEntity
    {
        public int EventId { get; set; }
        public EventEntity Event { get; set; }
        
        public int GenreId { get; set; }
        public GenreEntity Genre { get; set; }
    }
}
namespace EventPoster.DataAccess.Entities
{
    public class EventEntity: BaseEntity
    {
        public DateTime Date { get; set; }
        public string EventName { get; set; }
        public int Price { get; set; }
        public string Place  { get; set; }
        public int AgeLimit { get; set; }
        public string EventStatus { get; set; }
        public string Description { get; set; }
        
        public List<TicketEntity> Tickets { get; set; }
        public List<EventGenreEntity> EventGenres { get; set; }
    }
}
namespace EventPoster.DataAccess.Entities
{
    public class TicketEntity: BaseEntity
    {
        public int UserID { get; set; }
        public UserEntity User { get; set; }
        
        public int EventId { get; set; }
        public EventEntity Event { get; set; }
    }
}
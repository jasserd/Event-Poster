using System.ComponentModel.DataAnnotations.Schema;

namespace EventPoster.DataAccess.Entities
{
	[Table("users")]
    public class UserEntity: BaseEntity
    {
        public string Username { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int PasswordHash { get; set; }
        
        public List<TicketEntity> Tickets { get; set; }
    }

    public class AdministratorEntity : UserEntity
    {
        public DateTime DateOfBirth {get; set;}
     
        public int OfficeId { get; set; }
        public OfficeEntity Office { get; set; }
    }
}
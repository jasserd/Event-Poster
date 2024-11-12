namespace EventPoster.DataAccess.Entities
{
    public class OfficeEntity: BaseEntity
    {
        public string Adress { get; set; }
        
        public List<AdministratorEntity> Administrators { get; set; }
    }
}
namespace EventPoster.DataAccess.Entities
{
    public class GenreEntity: BaseEntity
    {
        public string GenreName { get; set; }
        
        public List<EventGenreEntity> EventGenres { get; set; }
    }
}
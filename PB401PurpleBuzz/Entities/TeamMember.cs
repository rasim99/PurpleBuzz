namespace PB401PurpleBuzz.Entities
{
    public class TeamMember : BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string Position { get; set; }
    }
}

namespace AutoMapperPractice.DTOs
{
    // DTO or Data Transfer Object returns specific data from Model. Can pick and choose what to return to client
    // or what information client can see.
    public class SuperHeroDto
    {
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}

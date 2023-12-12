namespace BlazorApp.Dtos
{
    public class PersonDto
    {
        public bool Selected { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = "n/a";
        public string Country { get; set; } = "n/a";
        public int Age { get; set; }
    }
}

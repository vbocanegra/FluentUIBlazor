using BlazorApp.Dtos;

namespace BlazorApp.Services
{
    public class CustomerServices
    {

        public static List<PersonDto> GetCustomers() => new()
        {
            new() { Selected=false, Id = 1, Name = "Alice", Country = "USA", Age = 25 },
            new() {Selected=false, Id = 2, Name = "Bob", Country = "Canada", Age = 32 },
            new() {Selected=false, Id = 3, Name = "Charlie", Country = "Mexico", Age = 45 },
            new() {Selected=false, Id = 4, Name = "David", Country = "Germany", Age = 22 },
            new() {Selected=false, Id = 5, Name = "Emma", Country = "France", Age = 39 },
            new() {Selected=false, Id = 6, Name = "Frank", Country = "UK", Age = 28 },
            new() {Selected=false, Id = 7, Name = "Grace", Country = "Australia", Age = 41 },
            new() {Selected=false, Id = 8, Name = "Henry", Country = "Russia", Age = 50 },
            new() {Selected=false, Id = 9, Name = "Isabella", Country = "Brazil", Age = 29 },
            new() {Selected=false, Id = 10, Name = "Jack", Country = "China", Age = 19 },
            new() {Selected=false, Id = 11, Name = "Katherine", Country = "India", Age = 36 },
            new() {Selected=false, Id = 12, Name = "Lucas", Country = "Spain", Age = 27 },
            new() {Selected=false, Id = 13, Name = "Mia", Country = "Argentina", Age = 31 },
            new() {Selected=false, Id = 14, Name = "Noah", Country = "Japan", Age = 24 },
            new() {Selected=false, Id = 15, Name = "Olivia", Country = "Italy", Age = 42 },
            new() {Selected=false, Id = 16, Name = "Patrick", Country = "South Korea", Age = 38 },
            new() {Selected=false, Id = 17, Name = "Quinn", Country = "South Africa", Age = 47 },
            new() {Selected=false, Id = 18, Name = "Ryan", Country = "Nigeria", Age = 26 },
            new() {Selected=false, Id = 19, Name = "Sophia", Country = "Egypt", Age = 33 },
            new() {Selected=false, Id = 20, Name = "Thomas", Country = "Kenya", Age = 30 }
        };
    }
}

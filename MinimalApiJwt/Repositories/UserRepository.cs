using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "mandar", EmailAddress = "mandar@gnau.com", Password = "root", GivenName = "Mandar", Surname = "Sanghavi", Role = "Administrator" },
            new() { Username = "Sunny", EmailAddress = "sunny@infopercept.com", Password = "root1", GivenName = "Sunny", Surname = "Modi", Role = "DBA" },
        };
    }
}

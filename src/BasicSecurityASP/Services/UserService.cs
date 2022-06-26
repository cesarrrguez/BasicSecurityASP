using BasicSecurityASP.Models;

namespace BasicSecurityASP.Services;

public class UserService : IUserService
{
    private readonly List<User> _users = new()
    {
        new User() { Email = "james@bond.com", Password = "123456" },
        new User() { Email = "julia@roberts.com", Password = "654321" }
    };

    public bool IsUser(string email, string pass) =>
        _users.Any(u => u.Email == email && u.Password == pass);
}

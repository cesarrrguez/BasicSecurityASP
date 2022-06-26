namespace BasicSecurityASP.Services;

public interface IUserService
{
    bool IsUser(string email, string password);
}

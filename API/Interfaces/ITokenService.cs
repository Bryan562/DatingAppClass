using API.Entities;

namespace API.Interfaces
{

    // An interface does not contain any implementation logic, only signatures 
    // of functionality the interface provides.
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
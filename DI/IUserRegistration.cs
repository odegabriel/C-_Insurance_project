using DTO;
using Models;
using Models.Confirmation;

namespace Methods;


public interface IUserRegistration
{
    
    RegistrationDtO RegisterUser(Registration registration);
    // string checkUser(Registration registration);
}

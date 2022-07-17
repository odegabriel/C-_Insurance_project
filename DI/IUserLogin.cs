using DTO;
using Models;
using Models.Confirmation;

namespace Methods;

public interface IUserLogin
{
    LoginDtoResult GetUser(Login login);
}
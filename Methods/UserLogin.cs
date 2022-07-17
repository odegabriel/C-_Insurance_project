//user login algorithem

using Models.Confirmation;
using Models;
using DTO;


namespace Methods;



public class UserLogin : IUserLogin
{
    public DataContext Context;

    public UserLogin(DataContext context)
    {
        Context = context;
    }

    //login
    public LoginDtoResult GetUser(Login login)
    {
        LoginDtoResult log = new();
        IEnumerable<User> user = Context.Users.ToList<User>();
        foreach (var item in user)
        {
            if ((login.EmailAddress.Equals(item.EmailAddress)) && (login.Password.Equals(item.Password)))
            {
                log = new()
                {
                    id = item.id,
                    FirstName = item.FirstName,
                    LastNAme = item.LastNAme,
                    DateOfBirth = item.DateOfBirth,
                    EmailAddress = item.EmailAddress,
                    HomeAddress = item.HomeAddress,
                    NextofKin = item.NextofKin,
                    // AutoInsurances = item.AutoInsurances,
                    // BusinessInsurances = item.BusinessInsurances,
                    // LifeInsurances = item.LifeInsurances,
                    // MedicalInsurances = item.MedicalInsurances,
                };
            }
            else
            {
                log = new();
            }
        }
        return log;

    }
}

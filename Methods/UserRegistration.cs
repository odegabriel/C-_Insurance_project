
//==========USER REGISTRATION======================
using DTO;
using Methods;
using Models;
using Models.Confirmation;


namespace Methods;


public class UserRegistration : IUserRegistration
{
    public DataContext Context;

    public UserRegistration(DataContext context)
    {
        Context = context;
    }

    public RegistrationDtO? RegisterUser(Registration registration)
    {
        RegistrationDtO? result = new();
       
        try{
       
            User user = new()
            {
            id = Guid.NewGuid(),
            FirstName = registration.FirstName,
            LastNAme = registration.LastNAme,
            DateOfBirth = registration.DateOfBirth,
            PhoneNo = registration.PhoneNo,
            EmailAddress = registration.EmailAddress,
            HomeAddress = registration.HomeAddress,
            NextofKin = registration.NextofKin,
            Password = registration.Password
            };
             Context.Users.Add(user);
              Context.SaveChanges();
             
             
                  result = new()
            {
                id = user.id,
                FirstName = registration.FirstName,
                LastNAme = registration.LastNAme,
                DateOfBirth = registration.DateOfBirth,
                PhoneNo = registration.PhoneNo,
                EmailAddress = registration.EmailAddress,
                HomeAddress = registration.HomeAddress,
                NextofKin = registration.NextofKin,
            };
            }

            catch(Exception)
            {
               result = null;
                
            }
              return result;

          
       
    }
 
}
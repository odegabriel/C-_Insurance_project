using System.ComponentModel.DataAnnotations;

namespace Models.Confirmation;


public class Login
{
    [Required]
    public string EmailAddress {get; set;}

    [Required] 
    public string Password {get; set;} 

    public Login (string emailAddress, string password)
    {
        EmailAddress = emailAddress;
        Password = password;
    }
}
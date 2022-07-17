using System.ComponentModel.DataAnnotations;

namespace Models.Confirmation;

public class Registration
{
    [Required]
    public string FirstName {get; set;}

    [Required]
    public string LastNAme {get; set;} 
    
    [Required]
    public string DateOfBirth {get; set;}
    
    [Required]
    public string PhoneNo {get; set;}
    
    [Required]
    [EmailAddress]
    public string EmailAddress {get; set;} 
    
    [Required]
    public string HomeAddress {get; set;} 
    
    [Required]
    public string NextofKin {get; set;} 
    
    [Required]
    public string Password {get; set;} 
 
}
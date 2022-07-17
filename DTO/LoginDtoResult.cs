using  ObjectModel;

namespace DTO;

public class LoginDtoResult
{
    public Guid id {get; set;} 
    public string FirstName {get; set;}
    public string LastNAme {get; set;} 
    public string DateOfBirth {get; set;}
    public string PhoneNo {get; set;}
    public string EmailAddress {get; set;} 
    public string HomeAddress {get; set;} 
    public string NextofKin {get; set;} 
    public string PolicyNumber {get; set;} 
    public string CardPin {get; set;} 
    public ICollection<AutoInsurance>? AutoInsurances {get; set;} 
    public ICollection<MedicalInsurance>? MedicalInsurances {get; set;} 
    public ICollection<LifeInsurance>? LifeInsurances {get; set;} 
    public ICollection<BusinessInsurance>? BusinessInsurances  {get; set;} 
    
}
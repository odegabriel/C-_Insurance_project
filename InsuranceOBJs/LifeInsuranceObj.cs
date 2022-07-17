using System.ComponentModel.DataAnnotations;

namespace obj;

public class LifeInsurancesObj
{
    public Guid id {get; set;}

    [Required]
    public string NextOfKin {get; set;} 
    
    [Required]
    public string BankName {get; set;} 
    
    [Required]
    public string AccountName {get; set;} 
    
    [Required]
    public string AccountNumber {get; set;}
    
    [Required]
    public string AssetWorth {get; set;} 

}
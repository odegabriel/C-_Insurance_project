using System.ComponentModel.DataAnnotations;

namespace obj;

public class BusinessInsuranceObj
{
    public Guid id {get; set;}

    [Required] 
    public string BusinessName {get; set;} 
    
    [Required] 
    public string city {get; set;} 
    
    [Required] 
    public string BusinessVerified {get; set;} 
    
    [Required] 
    public string Address {get; set;} 
    
    [Required] 
    public string ZipCode {get; set;} 
}
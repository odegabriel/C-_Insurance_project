using System.ComponentModel.DataAnnotations;

namespace obj;

public class AutoInsuranceObj
{

    [Required]
    public string LicenceNumber {get; set;} 
    
    [Required]
    public string LicenceHeld {get; set;} 
    
    [Required]
    public string CarType {get; set;} 
}

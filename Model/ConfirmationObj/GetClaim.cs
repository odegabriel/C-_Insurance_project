

using System.ComponentModel.DataAnnotations;

namespace Models.Confirmation;

public class GetClaimObj
{
    [Required]
    public string PolicyNumber {get; set;}

    [Required]
    public string PolicyType {get; set;} 
    
    [Required]
    public string CardPin {get; set;} 
    public GetClaimObj (string policyNumber, string policyType, string cardPin)
    {
        PolicyNumber = policyNumber;
        PolicyType = policyType;
        CardPin = cardPin; 
    }
}
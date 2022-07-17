using System.ComponentModel.DataAnnotations;

namespace obj;

public class MedicalInsuranceObj
{
    public Guid id {get; set;}

    [Required]
    public string NameOfDoctor {get; set;} = "";
    
    [Required]
    public string NameOfPatient {get; set;} = "";
    
    [Required]
    public string NameOfHospital {get; set;} = "";
    
    [Required]
    public string SicknessDiagnosed {get; set;} = "";
    
    [Required]
    public string DrugsAdministered {get; set;} 
}

// public class Drugs

// {
//     public string? Drug1 {get; set;}
//     public string? Drug2 {get; set;}
//     public string? Drug3 {get; set;}

//     public Drugs(string drug1, string drug2, string drug3)
//     {
//         Drug1 = drug1;
//         Drug2 = drug2;
//         Drug3 = drug3;
//     }
// }
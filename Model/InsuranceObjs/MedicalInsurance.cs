namespace ObjectModel;

public class MedicalInsurance
{
    public Guid id {get; set;}
    public string NameOfDoctor {get; set;} = "";
    public string NameOfPatient {get; set;} = "";
    public string NameOfHospital {get; set;} = "";
    public string SicknessDiagnosed {get; set;} = "";
    public string DrugsAdministered {get; set;} = "";

}
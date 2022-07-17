//the front end will be taking in the user id as part of the props
//completed
using obj;
using Models;
using ObjectModel;


namespace Methods.Insurance;


public class MedicalInsurances : IMedicalInsurance
{
    public DataContext Context;

    public MedicalInsurances(DataContext context)
    {
        Context = context;
    }

    public string MedicalInsurance(Guid id, MedicalInsuranceObj med)
    {
        Context.MedicalInsurances.Add(new()
        {
            id = Guid.NewGuid(),
            NameOfDoctor = med.NameOfDoctor,
            NameOfPatient = med.NameOfPatient,
            NameOfHospital = med.NameOfHospital,
            SicknessDiagnosed = med.SicknessDiagnosed,
            DrugsAdministered = med.DrugsAdministered,
            UserId = id
        });

        Context.SaveChanges();
        return "registered";
    }

    public string RemoveMedicakInsurance(Guid id)
    {
        string result = "";
        var med = Context.MedicalInsurances.Find(id);
        if (med == null)
        {
            result = "no result found";
        }
        else
        {
            Context.MedicalInsurances.Remove(med);
            Context.SaveChanges();
            result = "added sucessfully";
        }
        return result;
    }
}
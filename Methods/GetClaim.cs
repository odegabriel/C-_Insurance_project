using Models.Confirmation;
using Models;
using obj;

namespace Methods.Insurance;



public class GetClaim : IGetClaim
{
    public DataContext Context;

    public GetClaim(DataContext context)
    {
        Context = context;
    }

    //get autoinsurance claim
    public AutoInsuranceObj? GetAutoInsuranceClaim(Guid id)
    {
        AutoInsuranceObj result = new();
        var insurance = Context.AutoInsurances.ToList();
        foreach (var item in insurance)
        {
            if (item.UserId == id)
            {
                result = new()
                {
                    LicenceNumber = item.LicenceNumber,
                    LicenceHeld = item.LicenceHeld,
                    CarType = item.CarType
                };
            }
            else
            {
                result = null;
            }
        }
        return result;
    }


    //get lifeinsurance claim 
    public LifeInsurancesObj? GetLifeInsurancesClaim(Guid id)
    {
        LifeInsurancesObj result = new();
        var insurance = Context.LifeInsurances.ToList();
        foreach (var item in insurance)
        {
            if (item.UserId.Equals(id))
            {
                result = new()
                {
                    AccountName = item.AccountName,
                    AccountNumber = item.AccountNumber,
                    AssetWorth = item.AssetWorth,
                    BankName = item.BankName,
                    NextOfKin = item.NextOfKin
                };
            }
            else
            {
                result = null;
            }
        }
        return result;
    }


    //get Businessinsurance claim 
    public BusinessInsuranceObj? GetBusinessInsurancesClaim(Guid id)
    {
        BusinessInsuranceObj result = new();
        var insurance = Context.BusinessInsurances.ToList();
        foreach (var item in insurance)
        {
            if (item.UserId.Equals(id))
            {
                result = new()
                {
                    Address = item.Address,
                    BusinessName = item.BusinessName,
                    BusinessVerified = item.BusinessVerified,
                    city = item.city,
                    ZipCode = item.ZipCode
                };
            }
            else
            {
                result = null;
            }
        }
        return result;
    }


    //get Businessinsurance claim 
    public MedicalInsuranceObj? GetMedicalInsurancesClaim(Guid id)
    {
        MedicalInsuranceObj result = new();
        var insurance = Context.MedicalInsurances.ToList();
        foreach (var item in insurance)
        {
            if (item.UserId.Equals(id))
            {
                result = new()
                {
                    NameOfDoctor = item.NameOfDoctor,
                    NameOfHospital = item.NameOfHospital,
                    NameOfPatient = item.NameOfPatient,
                    DrugsAdministered = item.DrugsAdministered,
                    SicknessDiagnosed = item.SicknessDiagnosed
                };
            }
            else
            {
                result = null;
            }
        }
        return result;
    }





}
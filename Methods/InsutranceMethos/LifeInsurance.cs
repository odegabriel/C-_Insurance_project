//the front end will be taking in the user id as part of the props

using obj;
using Models;
using ObjectModel;


namespace Methods.Insurance;


public class LifeInsurances : ILifeInsurances
{
    public DataContext Context;

    public LifeInsurances(DataContext context)
    {
        Context = context;
    }
    //adding business insurance
    public string AddLifeInsurance(Guid id, LifeInsurancesObj life)
    {

        var insurance = Context.LifeInsurances.Add(new()
        {
            id = Guid.NewGuid(),
            NextOfKin = life.NextOfKin,
            BankName = life.BankName,
            AccountName = life.AccountName,
            AccountNumber = life.AccountNumber,
            AssetWorth = life.AssetWorth,
            UserId = life.id

        });
        Context.SaveChanges();
        return "sucessfull";

    }

    //remove a life insurance subcribtion
    public string RemoveLifeInsurance(Guid id)
    {
        string result = "";
        var life = Context.LifeInsurances.Find(id);
        if (life == null)
        {
            result = "no result found";
        }
        else
        {
            Context.LifeInsurances.Remove(life);
            Context.SaveChanges();
            result = "added sucessfully";
        }
        return result;

    }

}
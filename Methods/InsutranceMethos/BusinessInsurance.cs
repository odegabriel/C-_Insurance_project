//the front end will be taking in the user id as part of the props

using obj;
using Models;
using ObjectModel;


namespace Methods.Insurance;



public class BusinessInsurances : IBusinessInsurance
{
    public DataContext Context;

    public BusinessInsurances(DataContext context)
    {
        Context = context;
    }

    //adding business insurance
    public string AddBusinessInsurance(Guid id, BusinessInsuranceObj business)
    {

        var car = Context.BusinessInsurances.Add(new()
        {
            id = Guid.NewGuid(),
            BusinessName = business.BusinessName,
            Address = business.Address,
            BusinessVerified = business.BusinessVerified,
            city = business.city,
            ZipCode = business.ZipCode,
            UserId = id
        });
        Context.SaveChanges();
        return "sucessfull";

    }

    //remove a business insurance subcribtion
    public string RemoveBusinessInsurance(Guid id)
    {
        string result = "";
        var business = Context.BusinessInsurances.Find(id);
        if (business == null)
        {
            result = "no result found";
        }
        else
        {
            Context.BusinessInsurances.Remove(business);
            Context.SaveChanges();
            result = "added sucessfully";
        }
        return result;

    }
}
//the front end will be taking in the user id as part of the props

using obj;
using Models;
using ObjectModel;


namespace Methods.Insurance;


public class AutoInsurances : IAutoInsurance
{
    public DataContext Context;

    public AutoInsurances(DataContext context)
    {
        Context = context;
    }

    public void AddAutoInsurance(Guid id,AutoInsuranceObj auto)
    {
        
        
       var car = Context.AutoInsurances.Add(new()
        {
                id = Guid.NewGuid(),
                LicenceNumber = auto.LicenceNumber,
                LicenceHeld = auto.LicenceHeld,
                CarType = auto.CarType,
                UserId = id
        });
        Context.SaveChanges();
        

    }

    public AutoInsuranceObj GetAllAutoInsurance (Guid id)
    {
        AutoInsuranceObj result = new();
        var cars = Context.AutoInsurances.ToList();
        foreach (var item in cars)
        {
            if (item.UserId.Equals(id))
            {
                result = new()
                {
                    LicenceHeld = item.LicenceHeld,
                    LicenceNumber = item.LicenceNumber,
                    CarType = item.CarType
                };
            }else{
                result = null;
            }
            
        }
        return result;
    }
}
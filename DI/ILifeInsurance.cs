using obj;

namespace Methods;

public interface ILifeInsurances
{
    string AddLifeInsurance(Guid id, LifeInsurancesObj life);
    string RemoveLifeInsurance(Guid id);
}
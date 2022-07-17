using obj;

namespace Methods;

public interface IBusinessInsurance
{
    string AddBusinessInsurance(Guid id, BusinessInsuranceObj business);
    string RemoveBusinessInsurance(Guid id);
}
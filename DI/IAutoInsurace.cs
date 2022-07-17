using DTO;
using obj;

namespace Methods.Insurance;

public interface IAutoInsurance
{
    void AddAutoInsurance(Guid id,AutoInsuranceObj auto);
    AutoInsuranceObj GetAllAutoInsurance (Guid id);
}

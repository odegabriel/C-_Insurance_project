using obj;

namespace Methods.Insurance;


public interface IGetClaim
{
    AutoInsuranceObj? GetAutoInsuranceClaim(Guid id);
    BusinessInsuranceObj? GetBusinessInsurancesClaim(Guid id);
    LifeInsurancesObj? GetLifeInsurancesClaim(Guid id);
    MedicalInsuranceObj? GetMedicalInsurancesClaim(Guid id);
}
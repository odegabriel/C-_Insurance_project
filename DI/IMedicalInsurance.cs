using obj;

namespace Methods;

public interface IMedicalInsurance
{
    string MedicalInsurance(Guid id, MedicalInsuranceObj med);
    string RemoveMedicakInsurance(Guid id);
}

namespace ObjectModel;

public class LifeInsurance
{
    public Guid id {get; set;}
    public string NextOfKin {get; set;} = "";
    public string BankName {get; set;} = "";
    public string AccountName {get; set;} = "";
    public string AccountNumber {get; set;} = "";
    public string AssetWorth {get; set;} = "";

}
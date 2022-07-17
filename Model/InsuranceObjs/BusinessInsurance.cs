namespace ObjectModel;

public class BusinessInsurance
{
    public Guid id {get; set;} 
    public string BusinessName {get; set;} = "";
    public string city {get; set;} = "";
    public string BusinessVerified {get; set;} = "";
    public string Address {get; set;} = "";
    public string ZipCode {get; set;} = "";
}
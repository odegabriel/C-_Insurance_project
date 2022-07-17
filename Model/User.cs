using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models;

public record User
{
    public Guid id {get; init;} 
    public string? FirstName {get; set;}
    public string? LastNAme {get; set;} 
    public string? DateOfBirth {get; set;}
    public string? PhoneNo {get; set;}
    public string? EmailAddress {get; set;} 
    public string? HomeAddress {get; set;} 
    public string? NextofKin {get; set;} 
    public string? Password {get; set;} 
    public string? PolicyNumber {get; set;} 
    public string? CardPin {get; set;} 
    
}

public class AutoInsurance
{
    public Guid id {get; init;} 
    public string LicenceNumber {get; set;} 
    public string LicenceHeld {get; set;}
    public string CarType {get; set;}
    public Guid UserId {get; init;}
}

public class BusinessInsurance
{
    public Guid id {get; init;} 
    public string BusinessName {get; set;} 
    public string city {get; set;} 
    public string BusinessVerified {get; set;} 
    public string Address {get; set;} 
    public string ZipCode {get; set;}
    public Guid UserId {get; init;} 
}

public class LifeInsurance
{
    public Guid id {get; init;}
    public string NextOfKin {get; set;}
    public string BankName {get; set;} 
    public string AccountName {get; set;} 
    public string AccountNumber {get; set;}
    public string AssetWorth {get; set;}
    public Guid UserId {get; init;} 

}


public class MedicalInsurance
{
    public Guid id {get; init;}
    public string NameOfDoctor {get; set;} 
    public string NameOfPatient {get; set;}
    public string NameOfHospital {get; set;}
    public string SicknessDiagnosed {get; set;} 
    public string DrugsAdministered {get; set;} 
    public Guid UserId {get; init;}
}
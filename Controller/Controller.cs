using Microsoft.AspNetCore.Mvc;
using System;
using Models.Confirmation;
using Models;
using Methods;
using DTO;
using obj;
using Methods.Insurance;

namespace Controllers;
[ApiController]
[Route("insurance")]
public class Controller : ControllerBase
{
    public DataContext Context;
    public IUserLogin Login;
    public  IUserRegistration Registration;
    public IAutoInsurance AutoInsurances;
    public IMedicalInsurance MedicalInsurances;
    public ILifeInsurances LifeInsurances;
    public IBusinessInsurance BusinessInsurances;
    public IGetClaim Getcliam;
  public Controller(DataContext context ,IUserLogin login, IBusinessInsurance businessInsurance,
                     IMedicalInsurance medicalInsurance, ILifeInsurances lifeInsurances, IGetClaim getClaim,
                     IAutoInsurance autoInsurance, IUserRegistration registration)
  {
    Context = context;
    Login = login;
    Registration = registration;
    AutoInsurances = autoInsurance;
    MedicalInsurances = medicalInsurance;
    BusinessInsurances = businessInsurance;
    LifeInsurances = lifeInsurances;
    Getcliam = getClaim;
  }

//====================================REGISTER USER===========================
  [HttpPost]
  public async Task<IActionResult> AddUser ([FromBody]Registration user)
  {
    var result = await Task.Run(()=>Registration.RegisterUser(user));
    if(result==null)
    {
      return (BadRequest("user already exist"));
    }else
    {
      return Ok(result);
    }
  }
//----------------------------------------------------------------------------------

//=============================GET ALL USERS==============================
//get all users
  [HttpGet]
  public IEnumerable<User> GetUsers ()
  {
    return Context.Users.ToList<User>();
  }
  //----------------------------------------------------------------------------------

//=======================================USER LOGIN=============================
  //user login
  [HttpPost("/user/login")]
  public async Task<IActionResult> GetAUser([FromBody]Login login)
  {
    return await Task.Run(()=> Ok(Login.GetUser(login)));
  }

//---------------------------------------------------------------------

//======================================================ADDING INSURANCE=======================
//adding autoInsurance to user
[HttpPost("{id}/autoinsurance")]
public void AddAutoInsurance([FromRoute]Guid id,[FromBody]AutoInsuranceObj auto)
{
    AutoInsurances.AddAutoInsurance(id,auto);
}

//adding businessInsurance
[HttpPost("{id}/businessinsurance")]
public IActionResult AddBusinessInsurance([FromRoute]Guid id, [FromBody]BusinessInsuranceObj business)
{
    return Ok( BusinessInsurances.AddBusinessInsurance(id, business));
}

//adding lifeInsurance
[HttpPost("{id}/lifeinsurance")]
public IActionResult AddLifeInsurance([FromRoute]Guid id, [FromBody] LifeInsurancesObj life)
{
    return Ok(LifeInsurances.AddLifeInsurance(id, life));
}

//adding medicalInsurance
[HttpPost("{id}/medicalInsurance")]
public IActionResult AddMedicalInsurance([FromRoute]Guid id, [FromBody] MedicalInsuranceObj med)
{
    return Ok(MedicalInsurances.MedicalInsurance(id,med));
}

//---------------------------------------------------------------------------------

//=======================================GETTING CLAIMS================================
//gettin an autoinsurance
[HttpPost("user/{id}/autoinsurance")]
public IActionResult GetAutoInsurances([FromRoute] Guid id)
{
    return Ok(Getcliam.GetAutoInsuranceClaim(id));
}

//gettin an lifeinsurance
[HttpPost("user/{id}lifeinsurance")]
public IActionResult GetLifeInsurances([FromRoute] Guid id)
{
    return Ok(Getcliam.GetLifeInsurancesClaim(id));
}

//gettin an businessinsurance
[HttpPost("user/{id}/businessinsurance")]
public IActionResult GetBusinessInsurances([FromRoute] Guid id)
{
    return Ok(Getcliam.GetBusinessInsurancesClaim(id));
}

//gettin an medicalinsurance
[HttpPost("user/{id}/medicalinsurance")]
public IActionResult GetMedicalInsurances([FromRoute] Guid id)
{
    return Ok(Getcliam.GetMedicalInsurancesClaim(id));
}


//--------------------------------------------------------------------------

//get a single insurance
[HttpGet("{id}")]
public IActionResult AllAutoInsurance([FromRoute] Guid id )
{
    return Ok(AutoInsurances.GetAllAutoInsurance(id));
}


}
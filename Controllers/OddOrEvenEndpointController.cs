//Kenneth Fujimura
//Last Revised: 10/26/2022
//Odd Or Even - Endpoint
//This is an API program coded in C# that emulates a mini challenge we did during the coding combine of the same name that takes in a user input, evalutes whether or not it's a valid number, and tells the user whether the input is odd, even, or invalid.
//Peer Reviewed By: Reed Goodwin -- Codes works well and and fucntions properly, I like the way the UI works and he did a good job with the validation. I like how compact and neat the code is!

using Microsoft.AspNetCore.Mvc;

namespace FujimuraKOddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenEndpointController : ControllerBase
{
    [HttpGet]
    [Route("OddOrEven/{num}")]

    public string OddOrEven(string num){
        int validNum = 0;
        bool isNumber = Int32.TryParse(num, out validNum);
        if (isNumber == false){
            return $"Error: Please input a valid integer. \"{num}\" is not valid.";
        } else {
            string oddOrEvenEval = "";
            if (validNum % 2 == 0) {
                oddOrEvenEval = "even";
            } else {
                oddOrEvenEval = "odd";
            }
            return $"\"{num}\" is an \"{oddOrEvenEval}\" number.";
        }
    }
}
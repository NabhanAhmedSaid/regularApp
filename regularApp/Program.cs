// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Please insert your test!");
var input = Console.ReadLine();

string expressionPhone = @"\b[0-9]{8}\b";

if(input != "")
{
    var phone = Regex.Match(input, expressionPhone);

    var phoneValue = "";

    if (phone.Success)
    {

        phoneValue = phone.Value;
    }
    else
    {
        phoneValue = "it can not found Phone Number";
    }


    Console.WriteLine(" Phone : " + phoneValue);

}
else
{
    Console.WriteLine("You should write something");
}

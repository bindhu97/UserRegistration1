// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using UserRegistration1;

List<ValidationResult> validEnteries = new List<ValidationResult>();

RegistrationOfUser user = new RegistrationOfUser();
user.UserRegistration();
foreach (ValidationResult entry in validEnteries.FindAll(e => e.Result == false))
{
    Console.WriteLine("Invalid Entry : " + entry.UserEntry);
}

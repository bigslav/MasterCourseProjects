var person = new PersonModel("Bill", "Chill");
person.SetMiscValues(24, true);
Console.WriteLine($"{person.FirstName}, {person.LastName}, {person.Age}, {person.HasInsurance}");

var personWithAge = new PersonModel("Bill", "Chill", 24);
personWithAge.SetMiscValues(true);
Console.WriteLine($"{personWithAge.FirstName}, {personWithAge.LastName}, {personWithAge.Age}, {personWithAge.HasInsurance}");

var personWithAgeAndInsuranse = new PersonModel("Bill", "Chill", 24, true);
Console.WriteLine($"{personWithAgeAndInsuranse.FirstName}, {personWithAgeAndInsuranse.LastName}, {personWithAgeAndInsuranse.Age}, {personWithAgeAndInsuranse.HasInsurance}");

Console.ReadLine();
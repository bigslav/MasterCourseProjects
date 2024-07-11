var person = new Person("Bill", "Shimmy", 28);
var gamer = new Gamer("Ken", "Greba", 15, "Age of Empires 2");

Console.WriteLine(person.ToString());
Console.WriteLine(person.GetPersonInfo());
Console.WriteLine(gamer.ToString());
Console.WriteLine(gamer.GetPersonInfo());

Console.ReadLine();
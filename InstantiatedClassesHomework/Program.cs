using InstantiatedClassesHomework;

Address kevinAddress = new Address("Brown", 60);
Person kevinPerson = new Person ("Kevin", 25, Gender.Male, kevinAddress);

kevinPerson.MakeASpeech();

kevinPerson.Password = "1233213";
Console.WriteLine(kevinPerson.Password);
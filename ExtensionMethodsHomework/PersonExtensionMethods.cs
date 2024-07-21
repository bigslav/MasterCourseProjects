public static class PersonExtensionMethods
{
    public static PersonModel SetDefaultName(this PersonModel personModel)
    {
        personModel.FirstName = "John";
        personModel.LastName = "Malkovich";
        return personModel;
    }

    public static PersonModel SetDefaultAge(this PersonModel personModel)
    {
        personModel.Age = 25;
        return personModel;
    }

    public static PersonModel PrintInfo(this PersonModel personModel)
    {
        Console.WriteLine($"{personModel.FirstName}, {personModel.LastName}, {personModel.Age}");
        return personModel;
    }
}

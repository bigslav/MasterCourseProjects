public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool HasInsurance { get; set; }

    public PersonModel(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public PersonModel(string firstName, string lastName, int age) : this(firstName, lastName)
    {
        Age = age;
    }

    public PersonModel(string firstName, string lastName, int age, bool hasInsurance) : this(firstName, lastName, age)
    {
        HasInsurance = hasInsurance;
    }

    public void SetMiscValues(int age, bool hasInsurance)
    {
        Age = age;
        HasInsurance = hasInsurance;
    }

    public void SetMiscValues(bool hasInsurance)
    {
        SetMiscValues(Age, hasInsurance);
    }
}
public class Person
{
public string _givenName = "";
public string _familyName = "";

//A special method, called a constructor that is invoked using the new keyword followed by the
//class name and parentheses.
public Person()
{
}

public void ShowEasternName()
{
    Console.WriteLine($"{_familyName}, {_givenName}");
}

public void ShowWesternName()
{
    Console.WriteLine($"{_givenName}, {_familyName}");
}
}
public class Person
{
    //start member variable with an underscore
public string _givenName = "";
public string _familyName = "";

//A special method, called a constructor that is invoked using the new keyword followed by the
//class name and parentheses.
public Person()
{
}
// a method that displays the persons's full name as used in eastern countries
public void ShowEasternName()
{
    Console.WriteLine($"{_familyName}, {_givenName}");
}
// a method that displays the persons's full name as used in western countries
public void ShowWesternName()
{
    Console.WriteLine($"{_givenName}, {_familyName}");
}
}
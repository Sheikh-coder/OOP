using ClassAndObject;

/// Property Example
try
{
    Property p = new Property();
    p.Age = -10;
    Console.WriteLine(p.Age);
}
catch(ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}


/// Method Example 
Person person = new Person();
person.GetFirstName = 
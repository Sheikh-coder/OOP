using Interface;

IEmployee emp1 = new PermanentEmployee();
emp1.Name = "Papon";
emp1.PrintName();
Console.WriteLine($"Employee Salary : {emp1.CalculateSalary()}");


IEmployee emp2 = new ContractEmployee();
emp2.Name = "Sultan";
emp2.PrintName();
Console.WriteLine($"Employee Salary : {emp2.CalculateSalary()}");
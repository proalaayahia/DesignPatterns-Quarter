using ProtoTypeDesignPattern.Core;

shallow();
deep();
void shallow()
{
    Console.WriteLine("*****************Shallow Clone******************");
    EmployeePrototype tempEmp1 = new TempEmployee();
    tempEmp1.Id = 1;
    tempEmp1.Name = "Adel Matter";
    tempEmp1.Address = new Address { Building = "B3", City = "Cairo", StreetName = "AlWafaa" };

    EmployeePrototype tempEmp2 = tempEmp1.ShallowClone();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("=================Temp Emplyee 1 Original Values===================");
    Console.WriteLine(tempEmp1.ToString());
    Console.WriteLine("=================Temp Emplyee 2 Copy===================");
    Console.WriteLine(tempEmp2.ToString());
    tempEmp2.Name = "Mahmoud Aref";
    tempEmp2.Address.StreetName = "Esmailia";
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("=================Temp Emplyee 1 After Change===================");
    Console.WriteLine(tempEmp1.ToString());
    Console.WriteLine("=================Temp Emplyee 2 After Change===================");
    Console.WriteLine(tempEmp2.ToString());
    Console.ForegroundColor = ConsoleColor.White;
}

void deep()
{
    Console.WriteLine("*****************Deep Clone******************");
    EmployeePrototype tempEmp1 = new TempEmployee();
    tempEmp1.Id = 1;
    tempEmp1.Name = "Adel Matter";
    tempEmp1.Address = new Address { Building = "B3", City = "Cairo", StreetName = "AlWafaa" };

    EmployeePrototype tempEmp2 = tempEmp1.DeepClone();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=================Temp Emplyee 1 Original Values===================");
    Console.WriteLine(tempEmp1.ToString());
    Console.WriteLine("=================Temp Emplyee 2 Copy===================");
    Console.WriteLine(tempEmp2.ToString());
    tempEmp2.Name = "Mahmoud Aref";
    tempEmp2.Address.StreetName = "Esmailia";
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("=================Temp Emplyee 1 After Change===================");
    Console.WriteLine(tempEmp1.ToString());
    Console.WriteLine("=================Temp Emplyee 2 After Change===================");
    Console.WriteLine(tempEmp2.ToString());
    Console.ForegroundColor = ConsoleColor.White;
}
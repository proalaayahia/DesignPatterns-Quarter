namespace AdapterPattern.Core;
public class EmployeesDataReader
{
    public IEnumerable<Employee> GetEmployees()
    {
        return
                [
                new Employee("Mohamed","El Ghazaly",[
                    new PayItem("Basic Salary",1000),
                    new PayItem("Transportations",250),
                    new PayItem("Medical Insurance",150,true),
                    ]),
                new Employee("Mousa","Sadik",[
                    new PayItem("Basic Salary",1000),
                    new PayItem("Transportations",250),
                    new PayItem("Medical Insurance",-150),
                    ]),
                new Employee("Ahmed","Thabet",[
                    new PayItem("Basic Salary",1000),
                    new PayItem("Transportations",250),
                    new PayItem("Medical Insurance",-150),
                    ]),
                ];
    }
}
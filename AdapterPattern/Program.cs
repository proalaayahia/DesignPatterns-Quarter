using AdapterPattern.Core;
using System.Text;
using System.Text.Json;

var payrollCalculatorUrl = "https://localhost:7092/api/PayrollCalculator";
var reader = new EmployeesDataReader();
var employees = reader.GetEmployees();
using var client = new HttpClient();
foreach (var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculatorUrl);
    var employeeAdapter = new PayrolllSystemEmployeeAdapter(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json");
    var response = await client.SendAsync(request);
    var responseJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responseJson);
    Console.WriteLine($"salary of employee `{employee.FullName}` as of today = {salary}");
}
Console.ReadKey();
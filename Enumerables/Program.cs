using Enumerables;

namespace CSharpAdvanced;

public class Program

{
    static void Main(string[] args)
    {
        var employee = new Employee();
        employee.AddPay1item("BaisSalary", 1000);
        employee.AddPay1item("Bouns", 500);
        employee.AddPay1item("Transportation", 200);
        employee.AddPay1item("Insurance", -300);


        var payitem = employee.GetEnumerator();

        var payitem1 = employee.GetPayItems();
        foreach (var PayItems in employee)
        {
            Console.WriteLine($"{PayItems.name} = {PayItems.value}");
        }
    }
    

}

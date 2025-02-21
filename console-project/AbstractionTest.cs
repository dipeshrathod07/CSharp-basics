namespace Csharp
{
    class Employee1
    {
        public int empId;
        public string empName;
        public int GrossPay;

        double TaxDeduction = 0.1;
        double netSalary ;

        public Employee1(int id , string name , int grossPay )
        {
            this.empId = id ;
            empName = name;
            GrossPay = grossPay;
        }

       void CalculateSalary()
       {
        if(GrossPay >= 30000)
        {
            netSalary = GrossPay - (TaxDeduction * GrossPay);
            Console.WriteLine("your salary is:{0}",netSalary);
        }
        else
        {
            Console.WriteLine("Your salary is{0}",GrossPay);
        }
       }
       public void Display()
       {
        Console.WriteLine("Employee Id is{0}",empId);  
        Console.WriteLine("Employee Name is{0}",empName);  
         CalculateSalary();
       }

    }
}
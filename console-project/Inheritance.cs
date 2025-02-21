using System;

namespace Csharp;


class Employees
{
  public int EmpId;
  public string EmpName;
  public int EmpAge;
  public long EmpContactNo;

  public Employees(int empId, string empName, int empAge,long empContactNo)
  {
    EmpId = empId;
    EmpName = empName;
    EmpAge = empAge;
   EmpContactNo = empContactNo;
  }
  public virtual void Display()
  {
    Console.WriteLine("This the method use in parent Class:-Empolyees");
  }
}

class PermanentEmployee : Employees
{
    public int permanentSalary;
    public int permanentHours;
    
public PermanentEmployee(int empId, string empNamme,int empAge, long empContactNo,int visitingSalary,int visitingHours):base( empId,  empNamme, empAge, empContactNo)
    {
        this.permanentSalary = visitingSalary;
        this.permanentHours = visitingHours;
    }
    public override void Display()
    {
        //base.Display();
        Console.WriteLine($" EmpID:-{EmpId} \n EmpName:-{EmpName} \n EmpAge:-{EmpAge} \n EmpContact:-{EmpContactNo} \n EmpPermannetSalary:-{permanentSalary} \n EmpPermanentHours:-{permanentHours}");
    }
}
class VisitingEmployee : Employees
{
    public int visitingSalary;
    public int VisitingHours;

    public VisitingEmployee(int empId, string empNamme,int empAge, long empContactNo,int visitingSalary,int visitingHours):base( empId,  empNamme, empAge,  empContactNo)
    {
        this.visitingSalary = visitingSalary;
        this.VisitingHours = visitingHours;

    }
        public new void Display()
    {
        base.Display();
        Console.WriteLine($" EmpID:-{EmpId} \n EmpName:-{EmpName} \n EmpAge:-{EmpAge} \n EmpContact:-{EmpContactNo} \n EmpPermannetSalary:-{visitingSalary} \n EmpPermanentHours:-{VisitingHours}");
    }
}


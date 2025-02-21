using static Csharp.DelegatesTest;

namespace Csharp
{
  class Hello
  {
    public static void Main(string[] args)
    {


      #region Basics
      //    CsharpBasic.Basics();
      #endregion

      #region DateTimeBasics
      // CsharpBasic.DateTimeBasic();
      #endregion

      #region CallbyValueAndRefandOutKeyword
      // CsharpBasic.CallbyValue();   

      //CsharpBasic.CallByRef();
      // DateTime dt;
      //CsharpBasic.UseOutKeyWord(out dt);
      //Console.WriteLine(dt);
      #endregion

      #region VarAndDynamic
      // CsharpBasic.VarAndDynamic();
      #endregion

      #region TypeCastingAndBoxingUnboxing 
      // CsharpBasic.TypeCastingAndBoxingUnboxing();
      #endregion

      #region MenuDriven 
      //CsharpBasic.MenuDriven();
      #endregion

      #region FileInfo
      // FileInformation.FileInfo();
      #endregion

      #region CreateDirectory
      // FolderOps.CreateDir();
      #endregion

      #region RemoveDir
      // FolderOps.RemoveDir();
      #endregion

      #region FileRemove
      //FolderOps.FileRemove();
      #endregion

      #region FileOperations
      //FileOps.AllOperations();
      #endregion

      #region ConcurrentBagOps
      // ConcurrentBag.ConOps();
      //  ConcurrentBag.RemoveAll();
      // ConcurrentBag.PeekEle();
      #endregion

      #region ConcurrentDictonary
      // ConcurrentDictonary.DictOps();
      //ConcurrentDictonary.UpdateDict();
      // ConcurrentDictonary.RemoveDict();
      #endregion

      #region static class
      //StaticTest.StaticMain();
      #endregion

      #region  Datablepractise
      //   Database.Database1();
      #endregion

      #region OwnStringMethod
      // ExtMethodExample.ExtMethodExampleMain();
      #endregion

      #region Linq Practise

      //  LinqTest.Exam();

      //LinqObj.LinqObjMain();

      // LinqJoins.LinqJoinsMain();
      #endregion

      #region StringBuilder
      //StringBuilderTest.StringBuilderMain();
      #endregion

      #region Non-Genrics Collections
      // NonGenricTest.ArrayListDisplay();
      //  NonGenricTest.HashTableDisplay();
      // NonGenricTest.SortedListDisplay();
      // NonGenricTest.StackDisplay();
      //NonGenricTest.QueueDisplay();
      #endregion

      #region ConstructorPractise
      // Car Audi = new Car("Audi1","Dark-Blue",2018);
      //Console.WriteLine($"Model :-{Audi.Model} Color:-{Audi.Colour} Year:-{Audi.Year}");
      #endregion

      #region ConstructorInheritance
      //DerivedClass derived = new DerivedClass();
      #endregion

      #region Inheritance


      // PermanentEmployee Dipesh = new PermanentEmployee();
      // Dipesh.EmpId = 1;
      // Dipesh.EmpName = "Dipesh";
      // Dipesh.EmpContactNo= 9657904587;
      // Dipesh.permanentSalary = 30000;
      // Console.WriteLine($"{Dipesh.EmpName} \n {Dipesh.EmpContactNo} \n {Dipesh.permanentSalary}");

      // PermanentEmployee Dipesh = new PermanentEmployee(1,"Dipesh",20,934234,20000,8);
      //Console.WriteLine($" EmpID:-{Dipesh.EmpId} \n EmpName:-{Dipesh.EmpName} \n EmpAge:-{Dipesh.EmpAge} \n EmpContact:-{Dipesh.EmpContactNo} \n EmpPermannetSalary:-{Dipesh.permanentSalary} \n EmpPermanentHours:-{Dipesh.permanentHours}");
      // Dipesh.Display();

      //  Employees obj1 = new VisitingEmployee(2,"Vidyut",21,23234232,25000,23);
      // Vidyuth.Display();

      //Emp.Display();
      #endregion

      #region MethodHiding
      //Method Hiding can be done by base key word || creating the reference of Parent and object of Child|| and aslo achive by typecasting;
      // Child cs = new Child();
      // cs.Show();
      // Base bs = new Child();
      // bs.Show();
      // new Child().Show();
      // ((Base)cs).Show();//TypeCasting 
      #endregion
      #region ConstructorTypes

      //Console.WriteLine(PrivateCons.Age(10));
      // Console.ReadLine();
      //  PrivateCons pv = new PrivateCons();

      

      //  Addition add = new Addition(10,20);
      // Addition add2 = new Addition(add,200);

      // Console.WriteLine(add2.Display());

      //Person dipesh = new Person();
      //dipesh.GetDetails();
      // Person gama = new Person();
      // gama.GetDetails();

      #endregion

      #region Static Class Person
      //   Products.GetProductDetails();
      //  Products.Discount();
      #endregion

      #region Value and Reference data type

      // ValueType e  = new ValueType();
      // e.personName="Dipeshh";
      // e.age =21;
      // ValueType e1 = e;
      // ValueType e2 = e1;
      // e.age = 22;
      // Console.WriteLine("This is value type there all value of object not be changed");//because it makes different object blocks when the object is created;
      // Console.WriteLine(e.age);
      // Console.WriteLine(e1.age);
      // Console.WriteLine(e2.age);

      // ReferType r = new ReferType();
      // r.personName = "Dipesh";
      // r.age = 21;
      // ReferType r1 = r;
      // ReferType r2 = r;

      // r.age = 22;
      // Console.WriteLine("This is reference type there change is occour on all the declared variable");//because it contains only one object blocks;
      // Console.WriteLine(r.age);
      // Console.WriteLine(r1.age);
      // Console.WriteLine(r2.age);

      #endregion
      #region Abstraction Example

      // Employee1 e1 = new Employee1(333,"Dipesh",40000);
      // e1.Display();
      #endregion

      #region Abstract Class
      // Student1 aman = new Student1("Aman","Mistry",20,34567890,1,240000);
      //aman.GetDetails();
      //Console.WriteLine("--------------------------------------------");
      //Teacher Ramesh = new Teacher("Ramesh","Chavhan",49,9657904589,"M.A",57000);
      //Ramesh.GetDetails();
      #endregion
      #region  Interface implicit and Explicit
      // Myclass mc  = new Myclass();
      // I3 myInterface = new Myclass();
      // myInterface.Display2();
      // mc.Display();
      // mc.Display1(); 
      //((i1)mc).show();//type casting to access the method
      // ((i2)mc).show();//type casting to access the method

      // i1 obj= new Myclass();
      // obj.show();

      #endregion

      #region Delegates
      DelegatesTest dt = new DelegatesTest();
         Calculation obj = new Calculation(dt.Addition);
          obj.Invoke(10,20);
      //     //obj = Substraction;
      //    // obj(10,20);
      //   Calculation obj2 = new Calculation(DelegatesTest.Substraction);
      //   obj2(10,20);

      //   Calculation obj3 = new Calculation(DelegatesTest.Multiplication);
      //   obj3(10,20);

      //   Calculation obj4 = new Calculation(DelegatesTest.Division);
      //   obj4(10,20);
      #endregion
    }
  }
}

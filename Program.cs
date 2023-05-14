using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using FreeProject2023;
using Hashtables_;

public class Program
{
    public static void Main(string[] args)
    {

        Employee test = new Employee(1001, "Jack", "Silverstone");
        Employee test2 = new Employee(1002, "Jack2", "Silverstone");
        Employee test3 = new Employee(1003, "Jack3", "Silverstone");
        Employee test4 = new Employee(1004, "Jack4", "Silverstone");
        Employee test5 = new Employee(1005, "Jack5", "Silverstone");

        test.PrintInfo();

        Employee richard = new Employee(1005, "Richard", "Bradford");


        //create a hashtable 
        Hashtable empTable = new Hashtable();
        empTable.Add(test.EmployeeID, test);
        empTable.Add(test2.EmployeeID, test2);
        empTable.Add(test3.EmployeeID, test3);
        empTable.Add(test4.EmployeeID, test4);
        empTable.Add(richard.EmployeeID, richard);

        Employee empTest = (Employee)empTable[test.EmployeeID]; //cast it

        empTest.PrintInfo();

        foreach (Employee e in empTable.Values)
        {
            e.PrintInfo();
        }

        //foreach (DictionaryEntry e in empTable)
        //{

        //    Employee tempEmp = (Employee)e.Value;
        //    tempEmp.PrintInfo();
        //}

        foreach (var e in empTable.Keys) //print only the primary keys 
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(e);
            Console.ResetColor();
        }

        //here we guys are going to talk a bit about validation check 
        Console.WriteLine("Please input an employee ID:");
        string inputEmpID = Console.ReadLine();

        int.TryParse(inputEmpID, out int validEmpId);

        while ((validEmpId == 0) || (!empTable.ContainsKey(validEmpId)))
        {
            Console.WriteLine("Please enter a vaild ID!");
            inputEmpID = Console.ReadLine();
            int.TryParse(inputEmpID, out validEmpId);

        }

        Employee storedEmp = (Employee)empTable[validEmpId];
        storedEmp.PrintInfo(); //we are getting this exception because right now
        //we've got a string and we need an integer 



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpFeatureapp;
using HR;
using Penaltys;

namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation
            Account acct = new Account(15000);
            //event registration
            acct.underBalance += PenaltyHandler.ServiceDisconnectionPenaltyCharges;
            acct.underBalance += PenaltyHandler.NotificationPenaltyCharges;
            //object invocation

            acct.Withdraw(8000);

            acct.overBalance += TaxHandler.PayIncomeTax;
            acct.overBalance += TaxHandler.PayProfessionalTax;
            acct.overBalance += TaxHandler.PayGST;

            acct.Deposit(300000);







          /*  Handler.PayIncomeTax(10);
            Handler.PayProfessionalTax(20);
            Handler.PayGST(30);

            Operation opn1=new Operation(TaxHandler.PayIncomeTax);
            Operation opn2 = new Operation(TaxHandler.PayProfessionalTax);
            Operation opn3 = new Operation(TaxHandler.PayGST);

            Operation masterOperation = null;
            masterOperation += opn1;
            masterOperation += opn2;
            masterOperation += opn3;

            masterOperation.Invoke(5);
            Console.WriteLine("After Dettach");
            masterOperation -= opn1;

            masterOperation.Invoke(6);

           /* opn1.Invoke(10);
            opn2.Invoke(10);
            opn3.Invoke(10);*/

           /* MathEngine engine = new MathEngine();
            engine.Add(76, 89);
            engine.Add(76, 89, 87);

            MathEngine.ViewNames("Sarika", "Manoj", "Charan", "Chetan");
            MathEngine.ViewNames("Raj", "Amita", "Shishir");
            MathEngine.ViewNames("Sameer", "Sagar");


            //  MathEngine.ShowDetails(56);
            // MathEngine.ShowDetails("Ravi Tambade");
            //  MathEngine.ShowDetails(76.8);
            Person person = new Person();
            MathEngine.ShowDetails(person);
            Complex complex = new Complex();//early binding
            Complex c1 = new Complex(22, 33); // early binding
            Complex c2 = new Complex(11, 11);

            Complex c3 = c1 + c2;  //
            Console.WriteLine(c3);  //ToString () method 
                                    //C3 type is complex
                                    //Complex class inherited
                                    // Parent of Complext is Object
                                    //Complex has implementation ToString
                                    //Object also has implementation of ToString

            Employee emp = new Employee { Id = 12, Name = "Raj", BasicSalary = 5000, DA = 500, HRA = 20000 };
            double packageEmp = emp.ComputePay();
            Console.WriteLine(packageEmp);

            emp = new Manager { Id = 13, Name = "Manish", BasicSalary = 5000, DA = 500, HRA = 20000, Incentive = 45000 };
            double packageMgr = emp.ComputePay();
            Console.WriteLine(packageMgr);
           */
            Console.ReadLine();
        }
    }
}
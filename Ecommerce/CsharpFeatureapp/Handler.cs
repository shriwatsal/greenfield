using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatureapp
{
    public delegate void Operation(float factor);  //Object oriented function pointer
    public static class TaxHandler
    {
        
        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income Tax"+factor+" Deducted");
        }
        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service Tax"+factor+" Deducted");
        }
        public static void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Professional Tax"+factor+" Deducted");
        }
        public static void PayGST(float factor)
        {
            Console.WriteLine("GST "+factor+" Deducted");
        }




    }

    
}

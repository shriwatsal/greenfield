using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penaltys
{
    public static class PenaltyHandler
    {
        public static void ServiceDisconnectionPenaltyCharges(float amount)
        {
            Console.WriteLine("Service Disconnection charges applied =" + amount);

        }
        public static void NotificationPenaltyCharges(float amount)
        {

            Console.WriteLine("Notification charges applied =" + amount);

        }

    }
}

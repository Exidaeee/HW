using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._2
{
    internal class User
    {
        public User (Post postOffice)
        {
            postOffice.NewLetterArrived += OnNewLetterArrived;
        }

        private void OnNewLetterArrived(object sender, Letter message)
        {
            Console.WriteLine("Отримано новий лист: " + message.Message);
        }
    }
}

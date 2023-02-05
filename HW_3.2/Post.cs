using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._2
{
    class Post
    {
        public event EventHandler<Letter> NewLetterArrived;

        public void ReceiveLetter(string message)
        {
            OnNewLetterArrived(new Letter(message));
        }

        protected virtual void OnNewLetterArrived(Letter message)
        {
            NewLetterArrived?.Invoke(this, message);
        }
    }
}

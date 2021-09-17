using System;
using System.Collections.Generic;
using System.Text;

namespace advancedCsharp
{
    class PublishEvent
    {
        private int value;
        public delegate void NumManipulationHandler();

        public event NumManipulationHandler ChangeNum;

        public PublishEvent()
        {
            int n = 5;
            SetValue(n);
        }

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("event not fire");
                Console.ReadKey();
            }
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }

    public class SubscribEvent
    {
        public void printf()
        {
            Console.WriteLine("event fire");
            Console.ReadKey();
        }
    }

    class Event
    {
/*        static void Main(string[] args)
        {
            PublishEvent publishEvent = new PublishEvent();
            SubscribEvent subscribEvent = new SubscribEvent();
            publishEvent.ChangeNum += new PublishEvent.NumManipulationHandler(subscribEvent.printf);
            publishEvent.SetValue(7);
            publishEvent.SetValue(11);
        }*/
    }
}

using System;
namespace EventExample
{
    class Subscriber
    {
        private string uid;
        public Subscriber(Guid guid, Publisher pub)
        {
            uid = guid.ToString();
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CounterEvent e)
        {
            Console.WriteLine(uid + " received message: {0}", e.Message);
        }
    }
}

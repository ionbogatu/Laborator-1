using System;

namespace EventExample
{
    class CounterEvent : EventArgs
    {
        public CounterEvent(string s)
        {
            Message = s;
        }
        public string Message { set; get; }
    }
}

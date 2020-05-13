using System;namespace EventExample
{
    class Publisher
    {
        public event EventHandler<CounterEvent> RaiseCustomEvent;

        public void Update()
        {
            OnRaiseCustomEvent(new CounterEvent("1"));
        }

        protected virtual void OnRaiseCustomEvent(CounterEvent e)
        {
            RaiseCustomEvent?.Invoke(this, e);
        }
    }
}

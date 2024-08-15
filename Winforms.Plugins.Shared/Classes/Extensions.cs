using System;

namespace System
{
    public class EventArgs<T> : EventArgs
    {
        public EventArgs(T value)
        {
            _value = value;
        }

        private T _value;

        public T Value
        {
            get { return _value; }
        }
    }

    public static class Extensions
    {
        public static void SafeInvoke<T>(this EventHandler<T> eventToRaise, object sender, T e) where T : EventArgs
        {
            EventHandler<T> handler = eventToRaise;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
    }
}

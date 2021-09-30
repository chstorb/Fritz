using System;

namespace Fritz.Common
{
    internal static class ThrowIf
    {
        public static T Null<T>(T value, string name) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
            return value;
        }

        public static void NullOrEmpty(string value, string name)
        {
            ThrowIf.Null(value, name);
            if (value.Length == 0)
            {
                throw new ArgumentException("The value cannot be empty.", name);
            }
        }
    }
}

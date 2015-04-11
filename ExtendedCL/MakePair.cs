using System.Collections.Generic;

namespace ExtendedCL
{
    public static class MakePair
    {
        public static KeyValuePair<TKey, TValue> Make<TKey, TValue>(TKey k, TValue v)
        {
            return new KeyValuePair<TKey, TValue>(k, v);
        }
    }
}

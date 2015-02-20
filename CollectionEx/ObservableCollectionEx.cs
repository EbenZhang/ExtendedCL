using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CollectionEx
{
    public static class ObservableCollectionEx
    {
        public static void Assign<T>(this ObservableCollection<T> to,  IEnumerable<T> from)
        {
            to.Clear();
            foreach (var item in from)
            {
                to.Add(item);
            }
        }
    }
}

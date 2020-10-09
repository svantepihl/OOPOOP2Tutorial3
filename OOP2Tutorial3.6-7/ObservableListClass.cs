using System.Collections.Generic;

namespace OOP2Tutorial3._5_7
{
    public class ObservableList<T>
    {
        List<T> internalList = new List<T>();

        public void Add(T item)
        {
            internalList.Add(item);
            if (OnItemAdd != null)
            {
                OnItemAdd(internalList.Count - 1, item);
            }
        }
        
        public delegate void ListAddHandler(int itemIndex, T item);

        public event ListAddHandler OnItemAdd;

        public void RemoveAt(int index)
        {
            internalList.RemoveAt(index);
            if (OnRemoveAt != null)
            {
                OnRemoveAt(index);
            }
        }

        public delegate void ListRemoveAtHandler(int itemIndex);

        public event ListRemoveAtHandler OnRemoveAt;
    }
}
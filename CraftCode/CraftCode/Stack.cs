using System;
using System.Collections.Generic;
using System.Linq;

namespace CraftCode
{
    public class Stack
    {
        private List<object> storage = new List<object>();

        public Stack()
        {
        }
        
        public void Push(object item)
        {
            storage.Add(item);
        }

        public object Pop()
        {
            if (storage.Count == 0)
            {
                throw new InvalidOperationException("Empty stack");
            }

            var objectToReturn = storage.Last();
            storage.RemoveAt(storage.Count-1);

            return objectToReturn;
        }
    }
}

using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class BinarySearchTreeKeyValueMap<TKey, TValue>: IKeyValueMap<TKey, TValue>
    {
        private BinarySearchTreeMap<TKey, TValue> binarySearchTreeMap = new BinarySearchTreeMap<TKey, TValue>();

        public int Height => throw new System.NotImplementedException();

        public int Count => throw new System.NotImplementedException();

        public void Add(TKey key, TValue value)
        {
            throw new System.NotImplementedException();
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new System.NotImplementedException();
        }
    }
}
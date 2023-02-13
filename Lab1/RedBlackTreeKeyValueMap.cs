using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    //TODO
    public class RedBlackTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        public RedBlackTreeKeyValueMap()
        {
        }

        private RedBlackTreeMap<TKey, TValue> RedBlackTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public int Height => RedBlackTreeMap.Height;

        public int Count => RedBlackTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            RedBlackTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value;
            RedBlackTreeMap.TryGetValue(key, out value);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            return RedBlackTreeMap.Remove(key);
        }
    }
}
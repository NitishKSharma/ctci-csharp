using System;
using System.Collections.Generic;


namespace ctci_csharp
{
    public class NHashTable<K, V>
    {
        private readonly int _size;
        private readonly LinkedList<KeyValue<K, V>>[] items;


        public NHashTable(int size)
        {
            this._size = size;
            items = new LinkedList<KeyValue<K, V>>[size];
        }


        public V Find(K key)
        {
            int position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }

            return default(V);
        }

        public void Add(K key, V value)
        {
            var position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            var item = new KeyValue<K, V>()
            {
                Key = key,
                Value = value
            };
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            var position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            bool itemFound = false;
            var foundItem = default(KeyValue<K, V>);
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }

            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % this._size;
            return Math.Abs(position);
        }


        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            var linkedList = this.items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
    }


    public class KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}

// This is another change
// one more change
// change after pass

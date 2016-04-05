using System;
using System.Collections.Generic;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Code
{
    public class RequeueCache<TKey, TValue>
    {
        private object SyncRoot = new Object();
        private LinkedList<Tuple<TKey, TValue>> cache = new LinkedList<Tuple<TKey, TValue>>();
        private int capacity;

        public RequeueCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                lock (this.SyncRoot)
                {
                    while (this.cache.Count > value)
                    {
                        this.cache.RemoveLast();
                    }

                    this.capacity = value;
                }
            }
        }

        public bool TryGet(TKey key, out TValue value)
        {
            lock (this.SyncRoot)
            {
                var found = false;
                var foundItem = new Tuple<TKey,TValue>(default(TKey), default(TValue));
                foreach (var item in cache)
                {
                    if (item.Item1.Equals(key))
                    {
                        foundItem = item;
                        found = true;
                    }
                }

                if (found)
                {
                    cache.Remove(foundItem);
                    cache.AddFirst(foundItem);
                    value = foundItem.Item2;
                    return true;
                }
                else
                {
                    value = default(TValue);
                    return false;
                }
            }
        }

        public void Set(TKey key, TValue value)
        {
            lock (this.SyncRoot)
            {
                while (cache.Count >= capacity) cache.RemoveLast();
                cache.AddFirst(new Tuple<TKey, TValue>(key, value));
            }
        }
    }
}
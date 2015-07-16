using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace RpsTest
{
    /// <summary>
    /// Queue with limit (last items are removed when limit is reached)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AvgQueue : ConcurrentQueue<long>
    {

        private object _syncRoot = new object();
        private int? _maxCapacity;

        public AvgQueue() { _maxCapacity = null; }
        public AvgQueue(int capacity) { _maxCapacity = capacity; }

        public ICollection<long> All
        {
            get
            {
                lock (_syncRoot)
                {
                    return this.ToList();
                    
                }
            }
        }

        public double Avg()
        {
            return this.Sum(c => c)/(double)this.Count;
        }

        public void Add(long newElement)
        {
            if (Count >= _maxCapacity)
            {
                long o;
                TryDequeue(out o);
            }
            Enqueue(newElement);
        }
    }
}
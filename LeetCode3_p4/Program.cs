//Kadin Meyer
//4/16/2025

namespace LeetCode3_p4
{
    public class RecentCounter
    {
        private Queue<int> _queue = new Queue<int>();
        public Queue<int> _Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        public RecentCounter()
        {
            _Queue = new Queue<int>();

        }


        public int Ping(int t)
        {
            _Queue.Enqueue(t);
            while (_Queue.Peek() < t - 3000)
            {
                _Queue.Dequeue();
            }
            return _Queue.Count;
        }
    }

}

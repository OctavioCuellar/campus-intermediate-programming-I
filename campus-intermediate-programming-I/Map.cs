using System;

namespace campus_intermediate_programming_I
{
    public class Map <T>
        where T : Pair
    {
        private T[] _pairs = new T[100];

        public void Put(int i, T obj)
        {
            _pairs[i] = obj;
        }

        public T GetAt(int received)
        {
            var found = _pairs[received];
            return found;
        }

        public T Get(string key)
        {
            foreach (T pair in _pairs)
            {
                if (pair != null && pair.Key == key)
                    return pair;
            }
            throw new Exception("Key not found!");
        }

    }
}

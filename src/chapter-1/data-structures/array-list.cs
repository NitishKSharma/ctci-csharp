/*
ArrayList is a data structure that resizes on demand. It doesn't need specific size on declaration.
This implementation is general and is based on array underneath. 
There is an actual ArrayList in C# which is based on IList.
 */


using System;


namespace ctci_csharp
{
    public class AList<T> : IAList<T>
    {
        private T[] _collection;

        private int _size;
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private int _lastValueAt = 0;


        public AList()
        {
            this._size = 1;
            this._collection = new T[this._size];
        }

        public void Add(T item)
        {
            if (this.IsArrayFull())
                this.DoubleArraySize();

            this._collection[this._lastValueAt] = item;
            this._lastValueAt += 1;
        }

        public void RemoveAt(int index)
        {
            if (index > this._size - 1)
                throw new IndexOutOfRangeException();

            var i = 0;
            while (i < this._size - 1)
            {
                if (i < index)
                {
                    i += 1;
                    continue;
                }

                this._collection[i] = this._collection[i + 1];
                this._collection[i + 1] = default(T);
                i += 1;
            }
        }

        public T Get(int index)
        {
            if (index > this._size)
                throw new IndexOutOfRangeException();

            return this._collection[index];
        }


        private bool IsArrayFull()
        {
            if (default(T).Equals(this._collection[this._size - 1]))
                // if (T.Equals(this._collection[this._size - 1], defaultValue)
                return false;

            return true;
        }

        private void DoubleArraySize()
        {
            this._size = this._size * 2;
            var newArray = new T[this._size];
            for (int i = 0; i < this._collection.Length; i++)
            {
                newArray[i] = this._collection[i];
            }
            this._collection = newArray;
        }
    }
}


public interface IAList<T>
{
    int Size { get; set; }
    void Add(T item);
    void RemoveAt(int index);
    T Get(int index);
}
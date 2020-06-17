/*
Custom stringbuilder implementation.
Stringbuilder 
Implementing as a modified version of array-list where array is of string type and supports append and toString()
*/
using System;


namespace ctci_csharp
{
    public class NStringBuilder : INStringBuilder
    {
        private string[] _array;
        private int _nextIndex;
        private int _size;


        public NStringBuilder()
        {
            this._size = 1;
            this._nextIndex = 0;
            this._array = new string[this._size];
        }


        public void Append(string value)
        {
            if(this.IsArrayFull())
                this.DoubleArraySize();

            this._array[this._nextIndex] = value;
            this._nextIndex += 1;
        }

        public void Append(string[] value)
        {
            for(int i = 0; i < value.Length; i++)
            {
                this.Append(value[i]);
            }
        }

        public void Remove(int startIndex, int length)
        {
            if(startIndex > this._nextIndex || startIndex + length - 1 > this._nextIndex)
                throw new IndexOutOfRangeException();

            // TODO: check for complexity here
            for(int i = startIndex; i < startIndex + length; i++)
            {
                if(this._array[i] != null)
                    this._array[i] = null;
            }

            for(int i = 0; i < this._nextIndex; i++)
            {
                if(this._array[i] != null)   
                    continue;

                this._array[i] = this._array[i + 1];
                this._array[i + 1] = null;
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this._array);
        }


        private bool IsArrayFull()
        {
            if (this._array[this._size - 1] == null)
                return false;
            return true;
        }

        private void DoubleArraySize()
        {
            this._size = this._size * 2;
            var newArray = new string[this._size];
            for(int i = 0; i < this._array.Length; i++)
            {
                newArray[i] = this._array[i];
            }
            this._array = newArray;
        }
    }
}


public interface INStringBuilder
{
    void Append(string value);
    void Append(string[] value);
    void Remove(int startIndex, int length);
    string ToString();
}

// This is a change
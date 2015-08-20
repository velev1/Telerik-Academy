namespace GenericList
{
    using System;
    using System.Linq;
    using System.Text;
    
    public class GenericList<T> where T : IComparable
    {
        // fields
        private int currIndex;
        private T[] genList;
        private int listCapacity;

        // constructors
        public GenericList(int initiaLcapacity)
        {
            this.listCapacity = initiaLcapacity;
            this.genList = new T[this.listCapacity];
            this.currIndex = 0;
        }

        // properties
        public int Capacity
        {
            get
            {
                return this.listCapacity;
            }
        }

        public int Count
        {
            get
            {
                return this.currIndex;
            }
        }

        // indexers
        public T this[int index]
        {
            get
            {
                if ((index < 0 || index > this.currIndex) || this.currIndex == 0)
                {
                    throw new IndexOutOfRangeException("index is outside the GenericList");
                }

                return this.genList[index];
            }
        }

        // public methods
        public void Add(T element)
        {
            this.genList[this.currIndex] = element;
            ++this.currIndex;

            if (this.currIndex == this.listCapacity)
            {
                this.DoubleCapacity();
            }
        }

        public void Clear()
        {
            this.currIndex = 0;
        }

        public int IndexOf(T element, int startIndex = 0)
        {
            int index = Array.IndexOf(this.genList, element, startIndex);

            return index;
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index > this.currIndex)
            {
                throw new IndexOutOfRangeException("index is outside the GenericList");
            }

            ++this.currIndex;

            if (this.currIndex == this.listCapacity)
            {
                this.DoubleCapacity();
            }

            for (int i = this.currIndex; i > index; i--)
            {
                this.genList[i] = this.genList[i - 1];
            }

            this.genList[index] = element;
        }

        public T Max()
        {
            T max = this.genList.Max();
            return max;
        }

        public T Min()
        {
            T min = this.genList.Min();
            return min; 
        }

        public void Remove()
        {
            --this.currIndex;
        }

        public void RemoveByIndex(int index)
        {
            if (index < 0 || index > this.currIndex)
            {
                throw new IndexOutOfRangeException("index is outside the GenericList");
            }

            for (int i = index; i <= this.currIndex; i++)
            {
                if (i == this.genList.Length - 1)
                {
                    this.genList[i] = default(T);
                }
                else
                {
                    this.genList[i] = this.genList[i + 1];
                }
            }

            --this.currIndex;
        }

        // override ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.currIndex; i++)
            {
                if (i == this.currIndex - 1)
                {
                    sb.Append(this.genList[i]);
                }
                else
                {
                    sb.Append(this.genList[i] + ", ");
                }
            }

            return sb.ToString();
        }

        // private methods
        private void DoubleCapacity()
        {
            this.listCapacity *= 2;
            
            T[] doubledList = new T[this.listCapacity];

            for (int i = 0; i < this.genList.Length; i++)
            {
                doubledList[i] = this.genList[i];
            }

            this.genList = doubledList; 
        }      
    }
}

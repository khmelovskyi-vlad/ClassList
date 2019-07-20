using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassList
{
    class VladList<TElement>
    {
        public VladList()
        {
            List = new TElement[101];
        }
        private TElement[] List;
        private int index;
        public void Add(TElement num)
        {
            if (List.Length <= index)
            {
                Array.Copy(List, 0, List = new TElement[List.Length * 2], 0, List.Length / 2);
            }
            List[index] = num;
            index++;
        }
        public TElement this[int index]
        {
            get
            {
                if (index > this.index)
                {
                    throw new IndexOutOfRangeException();
                }
                return List[index];
            }
            set
            {
                if (index > this.index)
                {
                    throw new IndexOutOfRangeException();
                }
                List[index] = value;
            }
        }
    }
}

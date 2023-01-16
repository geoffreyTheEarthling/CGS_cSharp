using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS_Part1
{
    class Curators : CollectionBase // this class is used for data structure, it handles data
    {
        public void add(Curator cur)
        {
            List.Add(cur);
        }

        public Curator this[int index] // indexer
        {
            get { return (Curator) List[index]; } // type-casting
            set { List[index] = value; }
        }
    }
}

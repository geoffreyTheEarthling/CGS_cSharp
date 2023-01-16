using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS_Part1
{
    class Artists : CollectionBase // this class is used for data structure, it handles data
    {
        public void add(Artist art)
        {
            List.Add(art);
        }

        public Artist this[int index] // indexer
        {
            get { return (Artist)List[index]; }
            set { List[index] = value; }
        }
    }
}

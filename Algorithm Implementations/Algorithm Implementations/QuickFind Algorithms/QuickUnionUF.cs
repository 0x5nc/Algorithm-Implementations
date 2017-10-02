namespace Algorithm_Implementations.QuickFind_Algorithms
{
    /*this algorithm is also not a very good implementation on a big scale
     * it requires N accesses to find the root 
     * the tree of roots in the table can get really big to the point that finding a root
     * requires going through the entire variables at worst case */
    class QuickUnionUF
    {
        private int[] id;

        //n array accesses
        public QuickUnionUF(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        private int root(int i)
        {
            while (i != id[i])
            {
                i = id[i];
            }
            return i;
        }

        public bool Connected(int p, int q)
        {
            return root(p) == root(q);
        }

        public void Union(int p, int q)
        {
            int i = root(p);
            int j = root(q);

            id[i] = j;
        }
    }
}

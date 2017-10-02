namespace Algorithm_Implementations.QuickFind_Algorithms
{
    //Eager Algorithm 
    //This is a slow algorithm, plain and simple
    class QuickFindUF
    {
        private int[] id;

        //Set an array with values equal to their respective indexes 
        //This means all our points are not connected 
        //N array accesses
        public QuickFindUF(int n)
        {
            id = new int[n];
            for (var i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        //Checks whether point p is connected to point q
        //2 array accesses
        public bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }

        //This links all node with value p ( linked nodes ) to a node q
        //2N + 2 accesses
        //This is why QF algorithm is bad, it takes quadratic ( N² ) time to process N unions on N objects
        public void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == pid)
                    id[i] = qid;
            }
        }

    }
}

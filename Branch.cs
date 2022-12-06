public class Branch
{
    public List<Branch> branches = new List<Branch>();

    private int height;
    private int currentHeight;

    //constructor for leaf
    public Branch(int treeEnd)
    {
        this.branches = null;
    }

    // recursive constructor for branch
    public Branch()
    {
        this.branches = new List<Branch>();
    }

    //method to count height of a tree
    public int maxDepth(List<Branch> branches)
    {

        //check if branch is not a leaf
        if (branches != null)
        {
            //cycle goes through branches of a tree
            foreach (Branch branch in branches)
            {
                //check if branch is not a leaf
                if (branch.branches != null)
                {
                    //currentHeight counts height of a current fork
                    currentHeight++;
                    //recursion going deeper if branch is not a leaf
                    maxDepth(branch.branches);
                }

                //if current fork is higher than the highest branch so far, make current branch the highest
                if (currentHeight > height)
                {
                    height = currentHeight;
                }
            }
        }

        //returns height of a tree
        return height - 1;
    }

}
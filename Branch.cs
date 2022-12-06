public class Branch
{
    public List<Branch> branches = new List<Branch>();

    private int height;
    private int currentHeight;

    //recursive constructor for branch
    public Branch(int treeEnd)
    {
        this.branches = null;
    }

    // //constructor for leaf
    public Branch()
    {
        this.branches = new List<Branch>();
    }

    //method to count height of a tree
    public int maxDepth(List<Branch> sakos)
    {

        //check if branch is not a leaf
        if (sakos != null)
        {
            //cycle goes through branches of a tree
            foreach (Branch branch in branches)
            {
                //check if branch is not a leaf
                if (branch.branches[0] != null)
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
                    //diminishes current height when descending from a leaf to a fork
                    currentHeight--;
                }
                else
                {
                    currentHeight--;
                }
            }
        }
        //Test print to show current highest branch
        //System.out.println(height);

        //returns height of a tree
        return height;
    }

}
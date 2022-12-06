public class Tree
{
    public static void countTreeDepth()
    {
        List<Branch> tree = new Branch().branches;
        // level 1
        tree.Add(new Branch());
        // level 2
        tree[0].branches.Add(new Branch());
        tree[0].branches.Add(new Branch());
        // // level 3
        tree[0].branches[0].branches.Add(new Branch(1));
        tree[0].branches[1].branches.Add(new Branch());
        tree[0].branches[1].branches.Add(new Branch());
        tree[0].branches[1].branches.Add(new Branch(1));
        // // level 4
        tree[0].branches[1].branches[0].branches.Add(new Branch(1));
        tree[0].branches[1].branches[1].branches.Add(new Branch());
        tree[0].branches[1].branches[1].branches.Add(new Branch(1));
        // // level 5
        tree[0].branches[1].branches[1].branches[0].branches.Add(new Branch(1));

        Console.WriteLine(tree[0].maxDepth(tree));
    }
}
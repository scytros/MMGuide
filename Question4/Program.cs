using Question4.Models;

var unbalancedTree = new UnbalancedBinaryTree();

var root = unbalancedTree.root = new BinaryTreeNode(50);
root.Left = new BinaryTreeNode(17);
root.Left.Left = new BinaryTreeNode(9);
root.Left.Left.Right = new BinaryTreeNode(14);
root.Left.Left.Right.Left = new BinaryTreeNode(12);
root.Left.Right = new BinaryTreeNode(23);
root.Left.Right.Left = new BinaryTreeNode(19);
root.Right = new BinaryTreeNode(76);
root.Right.Left = new BinaryTreeNode(54);
root.Right.Left.Right = new BinaryTreeNode(72);
root.Right.Left.Right.Left = new BinaryTreeNode(67);

var results = CheckChildren(root);
results.ForEach(node => Console.WriteLine(node.Value));

List<BinaryTreeNode> CheckChildren(BinaryTreeNode node)
{
    var results = new List<BinaryTreeNode>();

    if (node == null || (node.Left == null && node.Right == null)) return results;

    if (node.Left == null || node.Right == null)
    {
        var childNode = node.Left ?? node.Right;

        if (childNode.Left == null && childNode.Right == null)
        {
            results.Add(node);
        }
    }
    
    results.AddRange(CheckChildren(node.Left));
    results.AddRange(CheckChildren(node.Right));

    return results;
}

namespace Question4.Models;

public class BinaryTreeNode
{
    public int Value { get; private set; }
    public BinaryTreeNode Left { get; set; }
    public BinaryTreeNode Right { get; set; }

    public BinaryTreeNode(int value)
    {
        Value = value;
    }
}

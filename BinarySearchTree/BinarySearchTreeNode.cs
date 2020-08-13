
using System.Security.Cryptography.X509Certificates;

namespace BinarySearchTree
{
    public class BSTNode
    {
        public BSTNode(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public BSTNode Left { get; set; }

        public BSTNode Right { get; set; }

        public int Min()
        {
            if (Left != null)
            {
                return Left.Min();
            }

            return Value;
        }

        public int Max()
        {
            if (Right != null)
            {
                return Right.Max();
            }

            return Value;
        }

        public bool AddItem(int value)
        {
            if (value > Value)
            {
                if (Right == null)
                {
                    Right = new BSTNode(value);

                    return true;
                }

                Right.AddItem(value);

            }
            else if (value < Value)
            {
                if (Left == null)
                {
                    Left = new BSTNode(value);

                    return true;
                }

                Left.AddItem(value);
            }

            return false;
        }

        public bool Contains(int value)
        {
            return FindItem(value) != null;
        }

        public BSTNode FindItem(int value)
        {
            if (value > Value)
            {
                if (Right != null)
                {
                    return Right.FindItem(value);
                }

                return null;
            }
            else if (value < Value)
            {
                if (Left != null)
                {
                    return Left.FindItem(value);
                }

                return null;
            }

            return this;
        }
        public BSTNode FindParentItem(int value)
        {
            if (value > Value)
            {
                if (Right != null)
                {
                    if (Right.Value == Value)
                    {
                        return this;
                    }

                    return Right.FindParentItem(value);
                }

                return null;
            }
            else if (value < Value)
            {
                if (Left != null)
                {
                    if (Left.Value == Value)
                    {
                        return this;
                    }

                    return Left.FindParentItem(value);
                }

                return null;
            }

            return null;
        }

        public bool DeleteItem(int value, BSTNode parent)
        {
            BSTNode item = FindItem(value);

            if (item != null)
            {
                parent.Right = item.Right;
                parent.Left = item.Left;

                return true;
            }

            return false;
        }
    }
}

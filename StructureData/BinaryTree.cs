namespace StructureData;

public class BinaryTree
{
        private BinaryTree? _parent;
        private BinaryTree? _left;
        private BinaryTree? _right;
        private int _value;

        public BinaryTree(int value, BinaryTree? parent)
        {
            _value = value;
            _parent = parent;
        }

        public void Add(int value)
        {
            if (value < _value)
            {
                if (_left == null)
                {
                    _left = new BinaryTree(value, this);
                }
                else if (_left != null)
                {
                    _left.Add(value);
                }
            }
            else
            {
                if (_right == null)
                {
                    _right = new BinaryTree(value, this);
                }
                else if (_right != null)
                {
                    _right.Add(value);
                }
            }
        }

        private BinaryTree? Search(BinaryTree? tree, int value)
        {
            if (tree == null)
            {
                return null;
            }
            
            return value == tree._value ? tree : Search(value > tree._value ? tree._right : tree._left, value);
        }

        private BinaryTree? Search(int value)
        {
            return Search(this, value);
        }

        public bool Remove(int value)
        {
            //Check if this node exists
            BinaryTree? tree = Search(value);
            if (tree == null)
            {
                //If the node does not exist, return false
                return false;
            }

            BinaryTree? curTree;
            //If we remove the root
            if (tree == this)
            {
                curTree = tree._right ?? tree._left;

                while (curTree?._left != null)
                {
                    curTree = curTree._left;
                }

                if (curTree == null) return true;
                var temp = curTree._value;
                Remove(temp);
                tree._value = temp;

                return true;
            }

            //Leaf removal
            if (tree._left == null && tree._right == null && tree._parent != null)
            {
                if (tree == tree._parent._left)
                {
                    tree._parent._left = null;
                }
                else
                {
                    tree._parent._right = null;
                }

                return true;
            }

            //Removing a node that has a left subtree but no right subtree
            if (tree is { _left: { }, _right: null })
            {
                //Change parent
                tree._left._parent = tree._parent;
                if (tree._parent != null && tree == tree._parent._left)
                {
                    tree._parent._left = tree._left;
                }
                else if (tree._parent != null && tree == tree._parent._right)
                {
                    tree._parent._right = tree._left;
                }

                return true;
            }

            //Removing a node that has a right subtree but no left subtree
            if (tree._left == null && tree._right != null)
            {
                //Change parent
                tree._right._parent = tree._parent;
                
                if (tree._parent != null && tree == tree._parent._left)
                {
                    tree._parent._left = tree._right;
                }
                else if (tree._parent != null && tree == tree._parent._right)
                {
                    tree._parent._right = tree._right;
                }

                return true;
            }

            //Remove the node that has subtrees on both sides
            if (tree is { _right: { }, _left: { } })
            {
                curTree = tree._right;

                while (curTree._left != null)
                {
                    curTree = curTree._left;
                }

                //If the leftmost element is the first descendant of
                if (curTree._parent == tree)
                {
                    curTree._left = tree._left;
                    tree._left._parent = curTree;
                    curTree._parent = tree._parent;
                    
                    if (tree._parent != null && tree == tree._parent._left)
                    {
                        tree._parent._left = curTree;
                    }
                    else if (tree._parent != null && tree == tree._parent._right)
                    {
                        tree._parent._right = curTree;
                    }

                    return true;
                }
                //If the leftmost element is NOT the first descendant

                if (curTree._right != null)
                {
                    curTree._right._parent = curTree._parent;
                }

                if (curTree._parent != null)
                {
                    curTree._parent._left = curTree._right;
                    curTree._right = tree._right;
                    curTree._left = tree._left;
                }

                tree._left._parent = curTree;
                tree._right._parent = curTree;
                curTree._parent = tree._parent;
                    
                if (tree._parent != null && tree == tree._parent._left)
                {
                    tree._parent._left = curTree;
                }
                else if (tree._parent != null && tree == tree._parent._right)
                {
                    tree._parent._right = curTree;
                }

                return true;
            }

            return false;
        }

        private void Print(BinaryTree? node)
        {
            if (node == null) return;
            
            Print(node._left);
            
            Console.Write(node + " ");
            
            if (node._right != null)
            {
                Print(node._right);
            }
        }

        public void Print()
        {
            Print(this);
            
            Console.WriteLine();
        }

        public override string ToString()
        {
            return _value.ToString();
        }
}
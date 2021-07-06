using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) { }

        /* ====================================================================== */

        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        };

        public class BinaryTree
        {
            public Node Root { get; set; }

            /* ------------------------ Search Function ------------------------- */
            public Node Search(int value)
            {
                Node root = this.Root;
                while (root != null)
                {
                    if (root.Data > value) root = root.Left;
                    else if (root.Data < value) root = root.Right;
                    else break;
                }
                return root;
            }

            /* ------------------------ Insert Function ------------------------- */
            public bool Insert(int value)
            {
                Node newNode = new Node { Data = value };
                if (this.Root == null) this.Root = newNode;
                else
                {
                    Node root = null, node = this.Root;
                    while (node != null)
                    {
                        root = node;
                        if (value < node.Data) node = node.Left;
                        else if (value > node.Data) node = node.Right;
                        else return false;
                    }
                    if (value < root.Data) root.Left = newNode;
                    else root.Right = newNode;
                }
                return true;
            }

            /* ------------------------ Delete Function ------------------------- */
            public Node Delete(int value)
            {
                return Delete(this.Root, value);
            }

            public Node Delete(Node root, int value)
            {
                if (root == null) return root;
                if (value < root.Data)
                    root.Left = Delete(root.Left, value);
                else if (value > root.Data)
                    root.Right = Delete(root.Right, value);
                else
                {
                    if (root.Left == null) return root.Right;
                    else if (root.Right == null) return root.Left;
                    root.Data = findMin(root.Right);
                    root.Right = Delete(root.Right, root.Data);
                }
                return root;
            }

            public int findMin(Node root)
            {
                int minv = root.Data;
                while (root.Left != null)
                {
                    minv = root.Left.Data;
                    root = root.Left;
                }
                return minv;
            }

            /* ------------------ Preorder Traversal Function ------------------- */
            public List<int> PreOrder()
            {
                var list = new List<int>();
                if (this.Root == null) return list;
                var stack = new Stack<Node>();
                stack.Push(this.Root);
                while (stack.Count != 0)
                {
                    Node node = stack.Pop();
                    list.Add(node.Data);
                    if (node.Right != null) stack.Push(node.Right);
                    if (node.Left != null) stack.Push(node.Left);
                }
                return list;
            }

            /* ------------------- Inorder Traversal Function ------------------- */
            public List<int> InOrder()
            {
                var list = new List<int>();
                var stack = new Stack<Node>();
                Node node = this.Root;
                while (node != null || stack.Count != 0)
                {
                    if (node != null)
                    {
                        stack.Push(node);
                        node = node.Left;
                    }
                    else if (stack.Count != 0)
                    {
                        node = stack.Pop();
                        list.Add(node.Data);
                        node = node.Right;
                    }
                }
                return list;
            }

            /* ------------------ Postorder Traversal Function ------------------ */
            public List<int> PostOrder()
            {
                var list = new List<int>();
                if (this.Root == null) return list;
                var stack1 = new Stack<Node>();
                var stack2 = new Stack<Node>();
                stack1.Push(this.Root);
                while (stack1.Count != 0)
                {
                    Node node = stack1.Pop();
                    stack2.Push(node);
                    if (node.Left != null) stack1.Push(node.Left);
                    if (node.Right != null) stack1.Push(node.Right);
                }
                while (stack2.Count != 0) list.Add(stack2.Pop().Data);
                return list;
            }

            /* ----------------- Levelorder Traversal Function ------------------ */
            public List<int> levelOrder()
            {
                var list = new List<int>();
                if (this.Root == null) return list;
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(this.Root);
                while (queue.Count != 0)
                {
                    Node node = queue.Dequeue();
                    list.Add(node.Data);
                    if (node.Left != null) queue.Enqueue(node.Left);
                    if (node.Right != null) queue.Enqueue(node.Right);
                }
                return list;
            }
        }

        /* ====================================================================== */

        private void InTraversal_btn_Click(object sender, EventArgs e)
        {
            print("[Inorder Tree] =" + (Tree.Root == null ? " NULL" : ""));
            foreach (int i in Tree.InOrder()) print(" " + i.ToString());
            print("\r\n\r\n");
        }

        private void PreTraversal_btn_Click(object sender, EventArgs e)
        {
            print("[Preorder Tree] =" + (Tree.Root == null ? " NULL" : ""));
            foreach (int i in Tree.PreOrder()) print(" " + i.ToString());
            print("\r\n\r\n");
        }

        private void PostTraversal_btn_Click(object sender, EventArgs e)
        {
            print("[Postorder Tree] =" + (Tree.Root == null ? " NULL" : ""));
            foreach (int i in Tree.PostOrder()) print(" " + i.ToString());
            print("\r\n\r\n");
        }

        private void LevelTraversal_btn_Click(object sender, EventArgs e)
        {
            print("[Level-order Tree] =" + (Tree.Root == null ? " NULL" : ""));
            foreach (int i in Tree.levelOrder()) print(" " + i.ToString());
            print("\r\n\r\n");
        }

        /* ====================================================================== */

        public BinaryTree Tree = new BinaryTree();

        public void print(String msg)
        {
            Board.AppendText(msg);
        }

        public int Text2Int(TextBox T)
        {
            return Int32.Parse(T.Text);
        }

        public int[] randomNum(TextBox Quantity, TextBox Range)
        {
            int quantity = Text2Int(Quantity);
            int range = Text2Int(Range);
            int[] list = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                list[i] = new Random().Next(0, range);
                for (int j = 0; j < i; j++)
                {
                    while (list[i] == list[j])
                    {
                        list[i] = new Random().Next(0, range);
                        j = 0;
                    }
                }
            }
            return list;
        }

        /* ====================================================================== */
        /* ----------------------- Generte random number ------------------------ */
        private void Generate_btn_Click(object sender, EventArgs e)
        {
            if (Text2Int(Quantity) <= Text2Int(Range))
            {
                int[] list = randomNum(Quantity, Range);
                print("Generate and insert number:");
                foreach (int num in list)
                {
                    print(" " + num.ToString());
                    Tree.Insert(num);
                }
                print("\r\n");
                InTraversal_btn_Click(sender, e);
            }
            else print("Error: Quantity out of range.\r\n\r\n");
        }

        /* ------------------------- Insert the number -------------------------- */
        private void Insert_btn_Click(object sender, EventArgs e)
        {
            print("Insert number: " + Number.Text);
            if (!Tree.Insert(Text2Int(Number)))
            {
                print(", but " + Number.Text + " is exist.");
            }
            print("\r\n");
            InTraversal_btn_Click(sender, e);
        }

        /* ------------------------- Search the number -------------------------- */
        private void Search_btn_Click(object sender, EventArgs e)
        {
            Node node = Tree.Search(Text2Int(Number));
            if (node != null) print(Number.Text + " is exist.\r\n\r\n");
            else
            {
                print(Number.Text + " is not exist, insert " + Number.Text + " into Tree.\r\n");
                Tree.Insert(Text2Int(Number));
                InTraversal_btn_Click(sender, e);
            }
        }

        /* ------------------------- Delete the number -------------------------- */
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            print("Delete number: " + Number.Text);
            if (Tree.Delete(Text2Int(Number)) == null)
            {
                print(", but " + Number.Text + " is not exist.");
            }
            print("\r\n");
            InTraversal_btn_Click(sender, e);
        }

        /* --------------------------- Clear the tree --------------------------- */
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            print("Clear tree.\r\n[Inorder Tree] = NULL\r\n\r\n");
            Tree = new BinaryTree();
        }

        /* ====================================================================== */

        public class cBinaryTree
        {
            public cNode Root { get; set; }
            public Image Draw()
            {
                GC.Collect();
                int temp;
                return Root == null ? null : Root.Draw(out temp);
            }
        };

        /* ---------------------------- BuildPreTree ---------------------------- */

        private cNode BuildPreTree(String prefix, String infix)
        {
            if (infix.Length == 0) return null;
            if (prefix.Length == 0) return null;
            var node = new cNode(prefix[0]);
            var idx = infix.IndexOf(node.Data);
            if (idx == -1) return null;

            node.Left = BuildPreTree(prefix[1..(idx+1)], infix[..idx]);
            node.Right = BuildPreTree(prefix[(idx + 1)..], infix[(idx + 1)..]);
            
            return node;
        }

        private void FindByPre_Click(object sender, EventArgs e)
        {
            var _tree = new cBinaryTree() { Root = BuildPreTree(Prefix.Text, Infix.Text) };
            if (_tree.Root == null) return;
            pictureBox1.Image = _tree.Draw();
        }

        /* --------------------------- BuildPostTree ---------------------------- */

        private cNode BuildPostTree(String postfix, String infix)
        {
            if (infix.Length == 0) return null;
            if (postfix.Length == 0) return null;
            var node = new cNode(postfix.Last());
            var idx = infix.IndexOf(node.Data);
            if (idx == -1) return null;

            node.Left = BuildPostTree(postfix[..idx], infix[..idx]);
            node.Right = BuildPostTree(postfix[idx..(postfix.Length-1)], infix[(idx + 1)..]);

            return node;
        }

        private void FindByPost_Click(object sender, EventArgs e)
        {
            var _tree = new cBinaryTree() { Root = BuildPostTree(Postfix.Text, Infix.Text) };
            if (_tree.Root == null) return;
            pictureBox1.Image = _tree.Draw();
        }

        private void FindByLevel_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
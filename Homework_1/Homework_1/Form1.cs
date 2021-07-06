using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1 {
    public partial class mainForm : Form {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
        public class BinaryTree
        {
            public Node Root { get; set; }
            

            /* ---------- Insert Function ---------- */
            public bool Insert(int value)
            {
                Node before = null, after = this.Root;
                while (after != null)
                {
                    before = after;
                    if (value < after.Data)
                        after = after.Left;
                    else if (value > after.Data)
                        after = after.Right;
                    else return false;
                }
                Node newNode = new Node { Data = value };
                if (this.Root == null)
                {
                    this.Root = newNode;
                }
                else
                {
                    if (value < before.Data)
                        before.Left = newNode;
                    else
                        before.Right = newNode;
                }
                return true;
            }

            /* ---------- Find Function ---------- */
            public bool Find(int value)
            {
                return this.Find(value, this.Root) != null;
            }
            private Node Find(int value, Node parent)
            {
                if (parent != null)
                {
                    if (value == parent.Data) return parent;
                    if (value < parent.Data)
                        return Find(value, parent.Left);
                    else
                        return Find(value, parent.Right);
                }
                return null;
            }

            /* ---------- Traversal Function ---------- */
            public List<int> PreOrder(Node parent)
            {
                if (parent != null)
                {
                    var list = new List<int> { parent.Data };
                    var tmp1 = PreOrder(parent.Left);
                    var tmp2 = PreOrder(parent.Right);
                    return list.Concat(tmp1).Concat(tmp2).ToList();
                }
                else return new List<int>();
            }

            public List<int> InOrder(Node parent)
            {
                if (parent != null)
                {
                    var list = new List<int> { parent.Data };
                    var tmp1 = InOrder(parent.Left);
                    var tmp2 = InOrder(parent.Right);
                    return tmp1.Concat(list).Concat(tmp2).ToList();
                }
                else return new List<int>();
            }

            public List<int> PostOrder(Node parent)
            {
                if (parent != null)
                {
                    var list = new List<int> { parent.Data };
                    var tmp1 = PostOrder(parent.Left);
                    var tmp2 = PostOrder(parent.Right);
                    return tmp1.Concat(tmp2).Concat(list).ToList();
                }
                else return new List<int>();
            }
        }
        public mainForm() {InitializeComponent();}
        public BinaryTree binaryTree = new BinaryTree();
        public void print(String msg) {
            board.Text = board.Text + msg;
        }
        private void insertBtn_Click(object sender, EventArgs e) {
            binaryTree.Insert(Int32.Parse(modifyBox.Text));
            print("Insert number: " + modifyBox.Text + "\r\n[Tree] =");
            foreach (int i in binaryTree.InOrder(binaryTree.Root))
            {
                print(" " + i.ToString());
            }
            print("\r\n\r\n");
        }
        private void generateBtn_Click(object sender, EventArgs e) {
            int quantity = Int32.Parse(QuantityBox.Text);
            int range = Int32.Parse(RangeBox.Text);
            int[] list = new int[quantity];
            for (int i = 0; i < quantity; i++) {
                list[i] = new Random().Next(0, range);
                for (int j = 0; j < i; j++) {
                    while (list[i] == list[j]) {
                        list[i] = new Random().Next(0, range);
                        j = 0;
                    }
                }
            }
            print("Generate and insert number:");
            for (int i = 0; i < quantity; i++) { 
                print(" " + list[i].ToString());
                binaryTree.Insert(list[i]);
            }
            print("\r\n[Tree] =");
            foreach (int i in binaryTree.InOrder(binaryTree.Root))
            {
                print(" " + i.ToString());
            }
            print("\r\n\r\n");
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            print("Clear tree.\r\n[Tree] = NULL\r\n\r\n");
            binaryTree = new BinaryTree();
        }
        private void inorderBtn_Click(object sender, EventArgs e)
        {
            print("Display inorder tree.\r\n[Tree] =");
            foreach (int i in binaryTree.InOrder(binaryTree.Root))
            {
                print(" " + i.ToString());
            }
            print("\r\n\r\n");
        }
        private void preorderBtn_Click(object sender, EventArgs e)
        {
            print("Display preorder tree.\r\n[Tree] =");
            foreach (int i in binaryTree.PreOrder(binaryTree.Root))
            {
                print(" " + i.ToString());
            }
            print("\r\n\r\n");
        }
        private void postorderBtn_Click(object sender, EventArgs e)
        {
            print("Display postorder tree.\r\n[Tree] =");
            foreach (int i in binaryTree.PostOrder(binaryTree.Root))
            {
                print(" " + i.ToString());
            }
            print("\r\n\r\n");
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            print("Searching " + modifyBox.Text + ", " + modifyBox.Text);
            if (binaryTree.Find(Int32.Parse(modifyBox.Text))) {
                print(" is exist.\r\n\r\n");
            } else {
                print(" is not exist.\r\n\r\n");
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

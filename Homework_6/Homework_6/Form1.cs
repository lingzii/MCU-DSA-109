using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_btn_Click(sender, e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            density.Text = ((Double)trackBar.Value / 100).ToString();
        }

        
        List<List<bool>> matrix = new List<List<bool>>();
        List<LinkedList<int>> graph = new List<LinkedList<int>>();
        List<int> indegree = new List<int>();
        List<List<int>> ans = new List<List<int>>();

        private void generate_btn_Click(object sender, EventArgs e)
        {
            matrix = makeMatrix(Convert.ToInt32(number.Text));
            graph = new List<LinkedList<int>>();
            indegree.Clear();
            for (int i = 0; i < matrix.Count; i++) indegree.Add(0);
            board.AppendText("Generate adjacency matrix:\r\n");
            for (int i = 0; i < matrix.Count; i++)
            {
                LinkedList<int> ll = new LinkedList<int>();
                for (int j = 0; j < matrix.Count; j++)
                {
                    if (matrix[i][j])
                    {
                        ll.AddLast(j);
                        indegree[j]++;
                    }
                    board.AppendText(matrix[i][j]?"1 ":"0 ");
                }
                graph.Add(ll);
                board.AppendText("\r\n");
            }
            board.AppendText("\r\nConvert matrix to adjacency list:\r\n");
            for (int i = 0; i < matrix.Count; i++)
            {
                board.AppendText(String.Format("vertex({0}) ", i));
                foreach (var elm in graph[i])
                    board.AppendText(String.Format("->({0}) ", elm));
                board.AppendText("\r\n");
            }
            board.AppendText("\r\n");
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            board.AppendText("---- Print Topology sort ----\r\n\r\n");
            var que = new Queue<int>();
            for (int i = 0; i < indegree.Count; i++)
            {
                if (indegree[i] == 0) que.Enqueue(i);
            }

            var newDegree = new List<int>(indegree);
            var ansList = new List<int>();
            while (que.Count != 0)
            {
                int n = que.Dequeue();
                ansList.Add(n);
                if (detail_ckb.Checked) {
                    board.AppendText("Output: [");
                    foreach (var i in ansList)
                        board.AppendText(i.ToString() + ", ");
                    board.AppendText("], Queue: [");
                    foreach (var i in que)
                        board.AppendText(i.ToString() + ", ");
                    board.AppendText("]\r\n");
                }

                foreach (var i in graph[n])
                {
                    if (--newDegree[i] == 0) que.Enqueue(i);
                    if (detail_ckb.Checked)
                    {
                        var str = String.Format("vertex({0})|{1}| ", i, newDegree[i]);
                        board.AppendText(str);
                        foreach (var j in graph[i])
                            board.AppendText(String.Format("->({0}) ", j));
                        board.AppendText("<\r\n");
                    }
                }
                if (detail_ckb.Checked)
                    board.AppendText("\r\n");
            }
            if (ansList.Count == indegree.Count)
            {
                board.AppendText("Result: [");
                foreach (var i in ansList)
                    board.AppendText(i.ToString() + ", ");
                board.AppendText("]\r\n");
            }
            else 
                board.AppendText("This is a cyclic graph, no solution!\r\n");
            board.AppendText("\r\n");
        }

        private void all_sort_btn_Click(object sender, EventArgs e)
        {
            board.AppendText("---- Print all sequence of Topology sort ----\r\n\r\n");
            ans.Clear();
            toposort(new List<int>(indegree), new List<int>());
            int kase = 1;
            foreach (var ls in ans)
            {
                board.AppendText(String.Format("Result[{0}]: [", kase++));
                foreach (var i in ls)
                    board.AppendText(i.ToString() + ", ");
                board.AppendText("]\r\n");
            }
            if (ans.Count == 0)
                board.AppendText("This is a cyclic graph, no solution!\r\n");
            board.AppendText("\r\n");
        }

        private void toposort(List<int> degree, List<int> tmp)
        {
            if (tmp.Count == degree.Count)
            {
                ans.Add(tmp);
                return;
            }
            for (int i = 0; i < degree.Count; i++)
            {
                if (degree[i] == 0)
                {
                    var newDegree = new List<int>(degree);
                    var newTmp = new List<int>(tmp);
                    foreach (var j in graph[i]) newDegree[j]--;
                    newDegree[i] = -1;
                    newTmp.Add(i);
                    toposort(newDegree, newTmp);
                }
            }
        }


        private List<List<bool>> makeMatrix(int num)
        {
            List<List<bool>> m = new List<List<bool>>();
            Random rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                Double d = Convert.ToDouble(density.Text);
                List<Double> ls = new List<double>();
                for (int j = 0; j < num; j++)
                {
                    ls.Add(rnd.NextDouble());
                }
                List<bool> row = new List<bool>();
                for (int j = 0; j < num; j++)
                {
                    row.Add(ls[j] <= d);
                }
                m.Add(row);
            }
            for (int i = 0; i < num; i++)
            {
                m[i][i] = false;
                for (int j = 0; j < num; j++)
                {
                    if (m[i][j] && m[j][i]) m[j][i] = false;
                }
            }
            return m;
        }

        
    }
}

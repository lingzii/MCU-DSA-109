using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Homework_5
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { generate_btn_Click(sender, e); firstLoad = true; }

        /*-------------------------------- Global variable ---------------------------------*/

        private List<List<int>> data;
        private const int INF = 9999;
        private bool firstLoad = false;

        /*----------------------------------- Grid View ------------------------------------*/

        private DataTable CreateTable(int col, int row)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < col; i++) table.Columns.Add();
            for (int i = 0; i < row; i++) table.Rows.Add();
            return table;
        }

        private void UpdateGridView(ref DataGridView grid, List<List<int>> dists)
        {
            grid.DataSource = CreateTable(dists.Count + 1, dists.Count + 1);
            grid.RowTemplate.Height = 45;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.Width = 60;
            }
            for (int i = 1; i <= dists.Count; i++)
            {
                grid.Rows[0].Cells[i].Value = String.Format("[{0}]", i - 1);
                grid.Rows[i].Cells[0].Value = String.Format("[{0}]", i - 1);
                for (int j = 1; j <= dists.Count; j++)
                {
                    if (dists[i - 1][j - 1] == INF)
                        grid.Rows[i].Cells[j].Value = "∞";
                    else
                        grid.Rows[i].Cells[j].Value = dists[i - 1][j - 1];
                }
            }
        }

        private void UpdateMSTGridView(ref DataGridView grid, ref List<Edge> MST)
        {
            grid.DataSource = CreateTable(3, MST.Count + 1);
            foreach (DataGridViewColumn col in grid.Columns) col.Width = 80;
            grid.Rows[0].Cells[0].Value = "vertex";
            grid.Rows[0].Cells[1].Value = "vertex";
            grid.Rows[0].Cells[2].Value = "weight";
            for (int i = 1; i <= MST.Count; i++)
            {
                grid.Rows[i].Cells[0].Value = MST[i - 1].i;
                grid.Rows[i].Cells[1].Value = MST[i - 1].j;
                grid.Rows[i].Cells[2].Value = MST[i - 1].weight;
            }
        }

        /*-------------------------------- Default function --------------------------------*/

        private List<int> randomArray(int num, int range, int max)
        {
            int[] array = new int[num];
            Random rd = new Random();
            for (int i = 0; i < num; i++)
            {
                array[i] = rd.Next(1, range + 1);
                for (int j = 0; j < i; j++)
                {
                    while (array[i] == array[j])
                    {
                        j = 0;
                        array[i] = rd.Next(1, range + 1);
                    }
                }
            }
            for (int i = 0; i < num; i++)
            {
                if (array[i] > max) array[i] = INF;
            }
            return new List<int>(array);
        }

        private void standardData(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    if (i == j) data[i][j] = 0;
                    else if (data[i][j] != INF)
                    {
                        data[j][i] = data[i][j];
                    }
                    else if (data[j][i] != INF)
                    {
                        data[i][j] = data[j][i];
                    }
                }
            }
        }

        private void print(string str, int end = 2)
        {
            broad.AppendText(str);
            while (end-- != 0) broad.AppendText("\r\n");
        }

        private void printEdge(ref List<Edge> edges)
        {
            foreach (Edge i in edges)
            {
                print(String.Format("({0}, {1}) = {2}", i.i, i.j, i.weight), 1);
            }
            UpdateMSTGridView(ref MSTGridView, ref edges);
        }

        /*------------------------------------- Button -------------------------------------*/

        private void generate_btn_Click(object sender, EventArgs e)
        {
            data = new List<List<int>>();
            int num = Convert.ToInt32(vertexNumber.Text);
            int range = Convert.ToInt32(weightRange.Text);
            int max = Convert.ToInt32(maxWeight.Text);
            if (firstLoad) print("--------------------------------------------------", 1);
            print(String.Format("Generate {0} vertex from random range [{1}-{2}]", num, max, range));
            for (int i = 0; i < num; i++)
            {
                data.Add(randomArray(num, range, max));
            }
            standardData(num);
            if (checkBox1.Checked)
            {
                UpdateGridView(ref sourceGridView, data);
                tabControl.SelectedTab = tabPage2;
            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            int num, range, max, defINF;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ".";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string[] array = reader.ReadLine().Split(' ');
                        data = new List<List<int>>();
                        num = int.Parse(array[0]);
                        range = int.Parse(array[1]);
                        max = int.Parse(array[2]);
                        defINF = int.Parse(array[3]);
                        for (int i = 0; i < num; i++)
                        {
                            array = reader.ReadLine().Split(' ');
                            int[] nums = new int[num];
                            for (int j = 0; j < num; j++)
                            {
                                nums[j] = int.Parse(array[j]);
                                if (nums[j] == defINF) nums[j] = INF;
                            }
                            data.Add(new List<int>(nums));
                        }
                        vertexNumber.Text = num.ToString();
                        weightRange.Text = range.ToString();
                        maxWeight.Text = max.ToString();
                        standardData(num);
                        UpdateGridView(ref sourceGridView, data);
                    }
                    print(String.Format("Import graph file from \"{0}\"", filePath));
                }
                else return;
            }
            tabControl.SelectedTab = tabPage2;
        }

        private void kruskal_btn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage1;
            if (checkBox1.Checked)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Reset();
                stopwatch.Start();
                List<Edge> edges = Kruskal();
                stopwatch.Stop();

                printEdge(ref edges);

                print(String.Format("[Kruskal] Spend Ticks: {0} ({1} ms)",
                     stopwatch.ElapsedTicks, stopwatch.ElapsedMilliseconds));
            }
            visualization();
        }

        private void prim_btn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage1;
            if (checkBox1.Checked)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Reset();
                stopwatch.Start();
                List<Edge> edges = prim();
                stopwatch.Stop();

                increaseBySort(ref edges);
                printEdge(ref edges);

                print(String.Format("[Prim] Spend Ticks: {0} ({1} ms)",
                     stopwatch.ElapsedTicks, stopwatch.ElapsedMilliseconds));
            }
            visualization();
        }

        /*------------------------------- kruskal algorithm --------------------------------*/

        private class Edge
        {
            public int i, j, weight;
            public Edge(int _i, int _j, int _w)
            {
                i = _i; j = _j; weight = _w;
            }
            public bool less(Edge e)
            {
                return this.weight < e.weight;
            }
        };

        private List<Edge> Kruskal()
        {
            List<Edge> increaseWeight = new List<Edge>();

            for (int i = 0; i < data.Count; i++)
                for (int j = i; j < data.Count; j++)
                    if (data[i][j] != 0 && data[i][j] != INF)
                        increaseWeight.Add(new Edge(i, j, data[i][j]));

            if (sort_ckb.Checked)
            {
                increaseBySort(ref increaseWeight);
            }
            else
            {
                increaseByHeap(ref increaseWeight);
            }

            List<Edge> edgeSetMST = new List<Edge>();

            if (detect_loop_ckb.Checked)
            {
                edgeSetMST = kruskal_loop(increaseWeight);
            }
            else
            {
                edgeSetMST = kruskal_subset(increaseWeight);
            }

            return edgeSetMST;
        }

        private void increaseBySort(ref List<Edge> increaseWeight)
        {
            increaseWeight.Sort(delegate (Edge x, Edge y)
            {
                return x.weight.CompareTo(y.weight);
            });
        }

        private void increaseByHeap(ref List<Edge> increaseWeight)
        {
            int len = increaseWeight.Count;
            for (int i = len / 2 - 1; i >= 0; i--)
                maxHeapify(ref increaseWeight, i, len - 1);
            for (int i = len - 1; i > 0; i--)
            {
                Swap(ref increaseWeight, 0, i);
                maxHeapify(ref increaseWeight, 0, i - 1);
            }
        }

        private List<int> parent;

        private List<Edge> kruskal_loop(List<Edge> increaseWeight)
        {
            parent = new List<int>(new int[data.Count]);
            for (int i = 0; i < data.Count; i++) parent[i] = i;
            List<Edge> edgeSetMST = new List<Edge>();
            foreach (Edge edge in increaseWeight)
            {
                if (parent[edge.i] != parent[edge.j])
                {
                    int small = parent[edge.i] < parent[edge.j] ? parent[edge.i] : parent[edge.j];
                    int large = parent[edge.i] < parent[edge.j] ? parent[edge.j] : parent[edge.i];
                    for (int i = 0; i < parent.Count; i++)
                    {
                        if (parent[i] == large) parent[i] = small;
                    }
                    edgeSetMST.Add(edge);
                }
            }
            return edgeSetMST;
        }

        private List<Edge> kruskal_subset(List<Edge> increaseWeight)
        {
            parent = new List<int>(new int[data.Count]);
            for (int i = 0; i < data.Count; i++) parent[i] = i;
            List<Edge> edgeSetMST = new List<Edge>();
            foreach (Edge edge in increaseWeight)
            {
                if (findGroup(edge.i) != findGroup(edge.j))
                {
                    unionGroup(edge.i, edge.j);
                    edgeSetMST.Add(edge);
                }
            }
            return edgeSetMST;
        }

        private List<List<int>> connected;
        private int otherVertex;

        private List<Edge> kruskal_dfs(List<Edge> increaseWeight)
        {
            connected = new List<List<int>>();
            for (int i = 0; i < data.Count; i++)
            {
                List<int> newRow = new List<int>(new int[data.Count]);
                for (int j = 0; j < data.Count; j++) newRow[j] = 0;
                connected.Add(newRow);
            }

            List<Edge> edgeSetMST = new List<Edge>();
            foreach (Edge edge in increaseWeight)
            {
                connected[edge.i][edge.j] = connected[edge.j][edge.i] = 1;
                if (cycleDectection(edge.i, edge.j) || cycleDectection(edge.j, edge.i))
                {
                    connected[edge.i][edge.j] = connected[edge.j][edge.i] = 0;
                }
                else
                {
                    edgeSetMST.Add(edge);
                }
            }
            return edgeSetMST;
        }

        /*------------------------------ kruskal subfunction -------------------------------*/

        private void Swap(ref List<Edge> ls, int x, int y)
        {
            Edge tmp = ls[x];
            ls[x] = ls[y];
            ls[y] = tmp;
        }

        private void maxHeapify(ref List<Edge> increaseWeight, int pos, int len)
        {
            int son = pos * 2 + 1;
            while (son <= len)
            {
                if (son + 1 <= len && increaseWeight[son].less(increaseWeight[son + 1]))
                    son++;
                if (increaseWeight[son].less(increaseWeight[pos]))
                    return;
                else
                {
                    Swap(ref increaseWeight, pos, son);
                    pos = son;
                    son = pos * 2 + 1;
                }
            }
        }

        private int findGroup(int idx)
        {
            return parent[idx] == idx ? idx : findGroup(parent[idx]);
        }

        private void unionGroup(int a, int b)
        {
            int a_group = findGroup(a), b_group = findGroup(b);
            if (a_group == b_group) return;
            parent[b_group] = a_group;
        }

        private bool cycleDectection(int vertex1, int vertex2)
        {
            otherVertex = vertex1;
            return checkCycle(vertex2, new List<int>());
        }

        private bool checkCycle(int vertex, List<int> visited)
        {
            if (vertex == otherVertex && visited.Count >= 2)
            {
                return true;
            }
            visited.Add(vertex);
            bool result = false;
            for (int i = 0; i < data.Count; i++)
            {
                if (visited.Exists(x => x.Equals(i)) && connected[i][vertex] != 0)
                {
                    if (checkCycle(i, visited))
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        /*-------------------------------- prim algorithm ----------------------------------*/

        private List<Edge> prim()
        {
            List<Edge> edges = new List<Edge>();
            List<int> parent = Enumerable.Repeat(-1, data.Count).ToList();
            List<int> weight = Enumerable.Repeat(INF, data.Count).ToList();
            List<bool> visited = Enumerable.Repeat(false, data.Count).ToList();

            int curr = 0;
            weight[curr] = 0;
            for (int t = 0; t < data.Count; t++)
            {
                int min = INF, minpos = 0;
                for (int i = 0; i < data.Count; i++)
                {
                    if (!visited[i] && weight[i] < min)
                    {
                        minpos = i; min = weight[i];
                    }
                }
                int u = minpos;
                visited[u] = true;
                for (int i = 0; i < data.Count; i++)
                {
                    if (visited[i] == false && data[u][i] != 0 && data[u][i] < weight[i])
                    {
                        parent[i] = u;
                        weight[i] = data[u][i];
                    }
                }
            }
            for (int i = 1; i < data.Count; i++)
            {
                edges.Add(new Edge(i, parent[i], weight[i]));
            }
            return edges;
        }

        /*------------------------------- MST visualization --------------------------------*/

        private void visualization()
        {
            List<Edge> increaseWeight = new List<Edge>(), edges = prim();
            for (int i = 0; i < data.Count; i++)
                for (int j = i; j < data.Count; j++)
                    if (data[i][j] != 0 && data[i][j] != INF)
                        increaseWeight.Add(new Edge(i, j, data[i][j]));

            using (StreamWriter sw = new StreamWriter(@".\visualization\graph.txt"))
            {
                sw.WriteLine(data.Count);
                sw.WriteLine(increaseWeight.Count);
                foreach (Edge edge in increaseWeight)
                {
                    sw.WriteLine(String.Format("{0} {1} {2}", edge.i, edge.j, edge.weight));
                }
                sw.WriteLine(edges.Count);
                foreach (Edge edge in edges)
                {
                    sw.WriteLine(String.Format("{0} {1} {2}", edge.i, edge.j, edge.weight));
                }
            }
            using (var process = new Process())
            {
                var path = @".\visualization\visualization.exe";
                process.StartInfo.FileName = path;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
            }
            using (var fs = File.OpenRead(@".\visualization\Digraph.gv.png"))
            {
                pictureBox.Image = Image.FromStream(fs);
            }
        }
    }
}

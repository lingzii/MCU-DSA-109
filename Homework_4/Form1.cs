using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Homework_4 
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_btn_Click(sender, e);
            firstLoad = true;
        }


        /*-------------------------------- Global variable ---------------------------------*/
        
        private bool directed = true;
        private const int INF = 9999;
        private List<List<int>> data;
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


        private void UpdateSsadView(ref DataGridView grid, List<List<int>> dists)
        {
            grid.DataSource = CreateTable(dists.Count + 2, dist.Count + 1);
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.Width = 60;
            }
            grid.Rows[0].Cells[0].Value = "times:";
            grid.Rows[0].Cells[grid.Columns.Count - 1].Value = "from";
            for (int i = 1; i <= dist.Count; i++)
            {
                grid.Rows[i].Cells[0].Value = String.Format("[{0}]", i - 1);
                var str = from[i - 1] == INF ? "void" : String.Format("[{0}]", from[i - 1]);
                grid.Rows[i].Cells[dists.Count + 1].Value = str;
            }
            for (int i = 1; i <= dists.Count; i++)
            {
                for (int j = 0; j <= dist.Count; j++)
                {
                    if (j == 0) grid.Rows[j].Cells[i].Value = i;
                    else
                    {
                        var num = dists[i - 1][j - 1];
                        if (num == INF)
                            grid.Rows[j].Cells[i].Value = "∞";
                        else
                            grid.Rows[j].Cells[i].Value = num;
                    }
                }

            }
            tabControl.SelectedTab = tabPage3;
        }


        /*------------------------------------ dijkstra ------------------------------------*/

        private List<int> dist;
        private List<int> from;

        private List<List<int>> dijkstra(int src)
        {
            var visited = Enumerable.Repeat(false, data.Count).ToList();
            var dists = new List<List<int>>();
            dist = Enumerable.Repeat(INF, data.Count).ToList();
            from = Enumerable.Repeat(INF, data.Count).ToList();
            dist[src] = 0; from[src] = src;
            for (int T = 0; T < data.Count; T++)
            {
                int v = -1, min = INF;
                for (int i = 0; i < data.Count; i++)
                {
                    if (!visited[i] && dist[i] < min)
                    {
                        v = i; min = dist[i];
                    }
                }
                if (v == -1) break;
                visited[v] = true;
                for (int i = 0; i < data.Count; i++)
                {
                    var newDist = dist[v] + data[v][i];
                    if (!visited[i] && newDist < dist[i])
                    {
                        dist[i] = newDist; from[i] = v;
                    }
                }
                dists.Add(new List<int>(dist));
            }
            return dists;
        }


        /*------------------------------- Transitive Closure --------------------------------*/

        private List<List<int>> transitiveClosure()
        {
            var reach = new List<List<bool>>();
            for (int i = 0; i < data.Count; i++) 
                reach.Add(Enumerable.Repeat(true, data.Count).ToList());

            for (int i = 0; i < data.Count; i++)
                for (int j = 0; j < data.Count; j++)
                    if (data[i][j] == INF)
                        reach[i][j] = false;

            for (int k = 0; k < data.Count; k++)
                for (int i = 0; i < data.Count; i++)
                    for (int j = 0; j < data.Count; j++)
                        reach[i][j] = reach[i][j] || (reach[i][k] && reach[k][j]);

            var result = new List<List<int>>();
            for (int i = 0; i < data.Count; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < data.Count; j++)
                    row.Add(reach[i][j] ? 1 : 0);
                result.Add(row);
            }

            return result;
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


        private void staandardData(int num, bool mode)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    if (i == j) data[i][j] = 0;
                    else if (mode)
                    {
                        if (!directed) data[j][i] = data[i][j];
                        else
                        {
                            if (data[i][j] != INF && data[j][i] != INF)
                            {
                                data[j][i] = INF;
                            }
                        }
                    }
                }
            }
        }

        private void print(string str, int end = 2)
        {
            broad.AppendText(str);
            while (end--!=0) broad.AppendText("\r\n");
        }

        private string findPath(int dest)
        {
            if (from[dest] == INF) return "Disconnected";
            if (dest == Convert.ToInt32(src.Text)) return String.Format("[{0}]", dest);
            var path = String.Format("--{0}->[{1}]", data[from[dest]][dest], dest);
            return findPath(from[dest]) + path;
        }


        /*------------------------------------- Button -------------------------------------*/

        private void directed_btn_Click(object sender, EventArgs e)
        {
            directed = directed ? false : true;
            directed_btn.Text = directed ? "True" : "False";
        }


        private void generate_btn_Click(object sender, EventArgs e)
        {
            data = new List<List<int>>();
            int num = Convert.ToInt32(vertexNumber.Text);
            int range = Convert.ToInt32(weightRange.Text);
            int max = Convert.ToInt32(maxWeight.Text);
            if (firstLoad) print("--------------------------------------------------", 1);
            print(String.Format("Generate {0} vertex from random range [{1}-{2}]", num, max, range), 1);
            for (int i = 0; i < num; i++)
            {
                data.Add(randomArray(num, range, max));
            }
            staandardData(num, true);
            UpdateGridView(ref sourceGridView, data);
            tabControl.SelectedTab = tabPage2;
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
                        staandardData(num, false);
                        UpdateGridView(ref sourceGridView, data);
                    }
                    print(String.Format("Import graph file from \"{0}\"", filePath));
                }
                else return;
            }
            tabControl.SelectedTab = tabPage2;
        }


        private void SSAD_btn_Click(object sender, EventArgs e)
        {
            print("Find single source all destinations from src [" + src.Text + "]");
            var dists = dijkstra(Convert.ToInt32(src.Text));
            UpdateSsadView(ref ssadGridView, dists);
            for (int i = 0; i < from.Count; i++)
            {
                if (i == Convert.ToInt32(src.Text)) continue;
                print(String.Format("The shortest distance from [{0}] to [{1}]: {2}", src.Text, i, dist[i]), 1);
                if (!path_ck.Checked) continue;
                print("with path: ", 0);
                print(findPath(i));
            }
        }


        private void APSP_btn_Click(object sender, EventArgs e)
        {
            var dists = new List<List<int>>();
            for (int i = 0; i < data.Count; i++)
            {
                dijkstra(i); dists.Add(new List<int>(dist));
            }
            UpdateGridView(ref apspGridView, dists);
            tabControl.SelectedTab = tabPage4;
        }

        private void TC_btn_Click(object sender, EventArgs e)
        {
            var adjacency = transitiveClosure();
            UpdateGridView(ref TCGridView, adjacency);
            tabControl.SelectedTab = tabPage5;
        }

        private void MV_btn_Click(object sender, EventArgs e)
        {
            visualization();
            tabControl.SelectedTab = tabPage6;
        }

        /*--------------------------------- visualization ----------------------------------*/

        private void visualization()
        {
            using (StreamWriter sw = new StreamWriter(@".\visualization\graph.txt"))
            {
                sw.WriteLine(String.Format("{0} {1}", data.Count, INF));
                foreach (var row in data)
                {
                    sw.WriteLine(String.Join(" ", row));
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
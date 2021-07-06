using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Homework_7
{
    using Pair = KeyValuePair<Action<List<int>>, List<string>>;

    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private List<int> makeRandomSeq(int n, int range)
        {
            List<int> seq = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                seq.Add((int)(rand.NextDouble() * range));
            return seq;
        }

        private Pair mkPair(Action<List<int>> method, string name)
        {
            var data = new List<string>();
            data.Add(name);
            return new Pair(method, data);
        }

        private void DrawDiagram_Click(object sender, EventArgs e)
        {
            var funcList = new List<Pair>();
            if (selectionSort_ckb.Checked) funcList.Add(mkPair(selectionSort, "Selection sort"));
            if (insertionSort_ckb.Checked) funcList.Add(mkPair(insertionSort, "Insertion sort"));
            if (reQuickSort_ckb.Checked) funcList.Add(mkPair(reQuickSort, "Quick sort (recursive)"));
            if (reMergeSort_ckb.Checked) funcList.Add(mkPair(reMergeSort, "Merge sort (recursive)"));
            if (wlQuickSort_ckb.Checked) funcList.Add(mkPair(wlQuickSort, "Quick sort (non-recursive)"));
            if (wlMergeSort_ckb.Checked) funcList.Add(mkPair(wlMergeSort, "Merge sort (non-recursive)"));
            if (bubbleSort_ckb.Checked) funcList.Add(mkPair(bubbleSort, "Bubble sort"));
            if (radixSort_ckb.Checked) funcList.Add(mkPair(radixSort, "Radix sort"));
            if (heapSort_ckb.Checked) funcList.Add(mkPair(heapSort, "Heap sort"));

            var time = Convert.ToInt32(Time.Text);
            var num = Convert.ToInt32(Num.Text);
            var range = Convert.ToInt32(Range.Text);

            for (int n = num, t = time; (t--) != 0; n += num)
            {
                var rndseq = makeRandomSeq(n, range);
                foreach (var function in funcList)
                {
                    var seq = new List<int>(rndseq);
                    var stopWatch = Stopwatch.StartNew();
                    function.Key(seq);
                    stopWatch.Stop();
                    function.Value.Add(stopWatch.ElapsedMilliseconds.ToString());
                    logBoard.AppendText(
                        String.Format("[{0}] {1}: {2} ms\r\n",
                                      time - t, 
                                      function.Value[0], 
                                      function.Value[function.Value.Count - 1])
                    );
                }
            }
            logBoard.AppendText("Drawing diagram...\r\n");

            using (var file = new StreamWriter("input.txt"))
            {
                file.WriteLine(String.Format("{0} {1}", funcList.Count, time));
                foreach (var function in funcList)
                {
                    file.WriteLine(function.Value[0]);
                    for (int i = 1; i <= time; i++)
                    {
                        file.Write(function.Value[i]);
                        if (i != time) file.Write(" ");
                    }
                    file.Write("\r\n");
                }
            }

            using (var process = new Process())
            {
                process.StartInfo.FileName = "mkChart.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
            }

            using var fs = File.OpenRead("chart.png");
            pictureBox.Image = Image.FromStream(fs);

            logBoard.AppendText("Finish.\r\n");
        }

        /* ---------------------------------------------------------------------------------------------------------- */

        private void selectionSort(List<int> seq)
        {
            int n = seq.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (seq[j] < seq[min_idx])
                        min_idx = j;
                int temp = seq[min_idx];
                seq[min_idx] = seq[i];
                seq[i] = temp;
            }
        }

        private void insertionSort(List<int> seq)
        {
            int n = seq.Count;
            for (int i = 1; i < n; ++i)
            {
                int key = seq[i], j = i - 1;
                while (j >= 0 && seq[j] > key)
                {
                    seq[j + 1] = seq[j];
                    j = j - 1;
                }
                seq[j + 1] = key;
            }
        }

        private void bubbleSort(List<int> seq)
        {
            int n = seq.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (seq[j] > seq[j + 1])
                    {
                        int temp = seq[j];
                        seq[j] = seq[j + 1];
                        seq[j + 1] = temp;
                    }
        }

        private void reQuickSort(List<int> seq)
        {
            requicksort(seq, 0, seq.Count - 1);
        }

        private void wlQuickSort(List<int> seq)
        {
            qSort(seq, 0, seq.Count - 1);
        }

        private void reMergeSort(List<int> seq)
        {
            remergesort(seq, 0, seq.Count - 1);
        }

        private void wlMergeSort(List<int> seq)
        {
            wlmergesort(seq, 0, seq.Count - 1);
        }

        private void radixSort(List<int> seq)
        {
            int n = seq.Count;
            int m = getMax(seq, n);
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(seq, n, exp);
        }

        private void heapSort(List<int> seq)
        {
            int n = seq.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(seq, n, i);
            for (int i = n - 1; i > 0; i--)
            {
                int temp = seq[0];
                seq[0] = seq[i];
                seq[i] = temp;
                heapify(seq, i, 0);
            }
        }

        /* ---------------------------------------------------------------------------------------------------------- */

        private static int partition(List<int> seq, int low, int high)
        {
            int pivot = seq[high], temp, i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (seq[j] <= pivot)
                {
                    i++;
                    temp = seq[i];
                    seq[i] = seq[j];
                    seq[j] = temp;
                }
            }
            temp = seq[i + 1];
            seq[i + 1] = seq[high];
            seq[high] = temp;

            return i + 1;
        }

        private static void qSort(List<int> seq, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(seq, low, high);
                qSort(seq, low, pi - 1);
                qSort(seq, pi + 1, high);
            }
        }

        private static void wlmerge(List<int> seq, int l, int m, int r)
        {
            int i, j, k, n1 = m - l + 1, n2 = r - m;
            int[] L = new int[n1], R = new int[n2];

            for (i = 0; i < n1; i++) L[i] = seq[l + i];
            for (j = 0; j < n2; j++) R[j] = seq[m + 1 + j];

            for (i = j = 0, k = l; i < n1 && j < n2; k++)
            {
                if (L[i] <= R[j]) seq[k] = L[i++];
                else seq[k] = R[j++];
            }

            while (i < n1) seq[k++] = L[i++];
            while (j < n2) seq[k++] = R[j++];
        }

        private void wlmergesort(List<int> seq, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                wlmergesort(seq, l, m);
                wlmergesort(seq, m + 1, r);
                wlmerge(seq, l, m, r);
            }
        }

        private static int Partition(List<int> seq, int left, int right)
        {
            int pivot = seq[right], i = (left - 1), tmp;
            for (int j = left; j < right; j++)
            {
                if (seq[j] < pivot)
                {
                    i++;
                    tmp = seq[i];
                    seq[i] = seq[j];
                    seq[j] = tmp;
                }
            }
            tmp = seq[i + 1];
            seq[i + 1] = seq[right];
            seq[right] = tmp;
            return (i + 1);
        }

        private static void requicksort(List<int> seq, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(seq, left, right);
                requicksort(seq, left, pivot - 1);
                requicksort(seq, pivot + 1, right);
            }
        }

        public void remerge(List<int> seq, int l, int m, int r)
        {
            int i, j, k, n1 = m - l + 1, n2 = r - m;
            int[] L = new int[n1], R = new int[n2];

            for (i = 0; i < n1; ++i) L[i] = seq[l + i];
            for (j = 0; j < n2; ++j) R[j] = seq[m + 1 + j];

            for (i = j = 0, k = l; i < n1 && j < n2; k++)
            {
                if (L[i] <= R[j]) seq[k] = L[i++];
                else seq[k] = R[j++];
            }

            while (i < n1) seq[k++] = L[i++];
            while (j < n2) seq[k++] = R[j++];
        }

        public void remergesort(List<int> seq, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                remergesort(seq, l, m);
                remergesort(seq, m + 1, r);
                remerge(seq, l, m, r);
            }
        }

        public static int getMax(List<int> seq, int n)
        {
            int mx = seq[0];
            for (int i = 1; i < n; i++)
                if (seq[i] > mx) mx = seq[i];
            return mx;
        }

        public static void countSort(List<int> seq, int n, int exp)
        {
            int[] output = new int[n], count = new int[10];

            for (int i = 0; i < 10; i++) count[i] = 0;
            for (int i = 0; i < n; i++) count[(seq[i] / exp) % 10]++;
            for (int i = 1; i < 10; i++) count[i] += count[i - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(seq[i] / exp) % 10] - 1] = seq[i];
                count[(seq[i] / exp) % 10]--;
            }
            for (int i  = 0; i < n; i++) seq[i] = output[i];
        }

        private void heapify(List<int> seq, int n, int i)
        {
            int largest = i, l = 2 * i + 1, r = 2 * i + 2;
            if (l < n && seq[l] > seq[largest]) largest = l;
            if (r < n && seq[r] > seq[largest]) largest = r;
            if (largest != i)
            {
                int swap = seq[i];
                seq[i] = seq[largest];
                seq[largest] = swap;
                heapify(seq, n, largest);
            }
        }
    }
}

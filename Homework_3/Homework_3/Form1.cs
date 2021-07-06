using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3
{
	public partial class Form1 : Form
	{
		public Form1() { InitializeComponent(); }
		public List<int> arr = new List<int> ();

		private void Swap (int x, int y)
		{
			int tmp = arr[x];
			arr[x]= arr[y];
			arr[y] = tmp;
		}

		private void Sift_Down(int pos, int size)
		{
			int maxpos = pos;
			int left = 2 * pos + 1;
			int right = 2 * pos + 2;
			if (left < size && arr[left] > arr[maxpos])
			{
				maxpos = left;
			} 
			if (right < size && arr[right] > arr[maxpos])
			{
				maxpos = right;
			}
			if (maxpos != pos)
			{
				Swap(maxpos, pos);
				Sift_Down(maxpos, size);
			}
		}

		private void Build_Heap()
		{
			int last = arr.Count / 2 - 1;
			for (int i = last; i >= 0; i--)
			{
				Sift_Down(i, arr.Count);
			}
			
		}

		private void Print()
		{
			broad.AppendText("[Heap] =");
			foreach (int i in arr)
			{
				broad.AppendText(" " + i.ToString());
			}
			broad.AppendText("\r\n");
		}

		private void generate_Click(object sender, EventArgs e)
		{
            List<int> ls = new List<int> { };
            Random rnd = new Random();
            for (int i = 0; i < Int32.Parse(range.Text); i++)
            {
                ls.Add(rnd.Next(0, Int32.Parse(size.Text)));
                for (int j = 0; j < i; j++)
                {
                    while (ls[j] == ls[i])
                    {
                        j = 0;
                        ls[i] = rnd.Next(0, Int32.Parse(size.Text));
                    }
                }
            }
			arr.AddRange(ls);
			Build_Heap();
			Print();
		}

        private void Insert_btn_Click(object sender, EventArgs e)
        {
			broad.AppendText("Insert the element " + number.Text + "\r\n");
			arr.Add(Int32.Parse(number.Text));
			Build_Heap();
			Print();
		}

        private void delete_btn_Click(object sender, EventArgs e)
        {
			broad.AppendText("Delete the element " + arr[0].ToString() + "\r\n");
			arr[0] = arr.Last();
			arr.RemoveAt(arr.Count - 1);
			Build_Heap();
			Print();
		}

        private void sort_btn_Click(object sender, EventArgs e)
        {
			List<int> tmp = new List<int> (arr);
			for (int end = arr.Count - 1; end > 0; end--)
			{
				Swap(0, end);
				Sift_Down(0, end);
			}
			broad.AppendText("[Sort] =");
			foreach (int i in arr)
			{
				broad.AppendText(" " + i.ToString());
			}
			broad.AppendText("\r\n");
			arr.Clear();
			arr.AddRange(tmp);
		}

        private void clear_btn_Click(object sender, EventArgs e)
        {
			broad.AppendText("Clear heap!\r\n");
			arr.Clear();
		}
    }
}

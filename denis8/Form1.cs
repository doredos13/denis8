using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denis8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 9; 
            dataGridView1.ColumnCount = 9; 
            int[,] a = new int[9, 9]; 
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 9; i++)
                for (j = 0; j < 9; j++)
                    a[i, j] = rand.Next(0, 10);
            // Выводим матрицу в dataGridView1 
            for (i = 0; i < 9; i++)
                for (j = 0; j < 9; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            for (i = 0; i < 9; i++)
            {
                int minInStr = a[i, 0];
                for (j = 0; j < 9; j++)
                {
                    if (a[i, j] <= minInStr)
                    {
                        minInStr = a[i, j];
                    }
                    if (j == 8)
                        a[i, 0] = minInStr;
                }
            }
            dataGridView2.RowCount = 9;
            dataGridView2.ColumnCount = 9;
            for (i = 0; i < 9; i++)
                for (j = 0; j < 9; j++)
                    dataGridView2.Rows[i].Cells[j].Value = a[i, j].ToString();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clcbtn_Click(object sender, EventArgs e)
        {
            outputlb.Items.Clear();
            try
            {
                Int32.TryParse(tb.Text, out int n);

                n += 1;

                int[] ret = fibo(n);

                for (int i = 0; i < ret.Length; i++)
                {
                    outputlb.Items.Add(ret[i].ToString());
                }
            }
            catch (Exception ex)
            {
                outputlb.Items.Add(ex.Message);
            }
        }
        private int[] fibo(int n)
        {
            int[] result = new int[n];
            int a, b, c;
            a = 0;
            b = 1;
            c = 0;
            result[0] = 0;
            for (int i = 1; i < n; i++)
            {
                result[i] = b;
                c = a + b;
                a = b;
                b = c;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            N.Maximum = int.MaxValue;
            M.Maximum = int.MaxValue;
            Min.Minimum = int.MinValue;
            Min.Maximum = int.MaxValue;
        }
        private void InMas_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Isn.Clear();
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            if (M.Value != (int)M.Value)
                M.Value = (int)M.Value;
            int[,] mas = new int[(int)N.Value, (int)M.Value];
            for (int i = 0; i < (int)N.Value; i++)
                for(int j = 0; j < (int)M.Value; j++)
                {
                    mas[i,j] = random.Next(-100,100);
                }
            for (int i = 0; i < (int)N.Value; i++)
            {
                for (int j = 0; j < (int)M.Value; j++)
                {
                    Isn.Text += mas[i, j];
                    if (j + 1 < (int)M.Value)
                        Isn.Text += "\t";
                }
                if (i + 1 < (int)M.Value)
                    Isn.Text += "\n";
            }
            Ism.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Ism.Clear();
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            if (M.Value != (int)M.Value)
                M.Value = (int)M.Value;
            if (Isn.Text == "")
                return;
            int[,] mas = new int[(int)N.Value, (int)M.Value];
            string[] strbuf = Isn.Text.Split(new Char[] { '\n' });
            string[][] str = new string[strbuf.Length][];
            for (int i = 0; i < strbuf.Length; i++)
            {
                str[i] = strbuf[i].Split(new Char[] { '\t' });
            }
            bool prov;
            bool nbuf = N.Value != str.Count();
            bool mbuf = M.Value != str[0].Count();
            if (N.Value != str.Count() | M.Value != str[0].Count())
                return;
            for (int i = 0; i < (int)N.Value; i++)
                for (int j = 0; j < (int)M.Value; j++)
                {
                    prov = int.TryParse(str[i][j], out mas[i, j]);
                    if (!prov)
                        return;
                }
            if (Min.Value != (int)Min.Value)
                Min.Value = (int)Min.Value;
            for (int i = 0; i < (int)N.Value; i++)
                for (int j = 0; j < (int)M.Value; j++)
                    if (mas[i, j] < (int)Min.Value)
                        mas[i, j] = (int)Min.Value;
            for (int i = 0; i < (int)N.Value; i++, Ism.Text += "\n")
                for (int j = 0; j < (int)M.Value; j++)
                    Ism.Text += mas[i, j] + "\t";
        }
    }
}

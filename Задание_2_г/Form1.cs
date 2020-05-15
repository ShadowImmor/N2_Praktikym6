using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            N.Maximum = decimal.MaxValue;
        }

        private void Mas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            TextBox tb = sender as TextBox;
            int position = tb.SelectionStart;
            if (char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            string str = Mas.Text;
            if (e.KeyChar == ' ')
            {
                if (position != 0)
                {
                    string[] strbuf = str.Split(' ');
                    if ((int)N.Value > strbuf.Count() & strbuf[strbuf.Count() - 1] != "" & str[position - 1] != ' ' & str[position - 1] != '-')
                        if(str[position - 1] != ',')
                            return;
                }
            }
           if (e.KeyChar == '-')
           {
                if (position == 0 & str == "")
                    return;
                if(position == 0)
                    if(str[0] != '-')
                        return;
                if (position != 0)
                {
                    string[] strbuf = str.Split(' ');
                    if (str[position - 1] == ' ' & str.Count() == position)
                        return;
                    if (str.Count() != position & str[position - 1] == ' ')
                        if (str[position] != '-')
                            return;
                }
           }
            if(e.KeyChar == ',')
            {
                if (position != 0)
                {
                    string[] strbuf = str.Split(' ');
                    int positionword = 0;
                    bool bufpw = false;
                    for(int i =0 , n = 0; i < strbuf.Count(); i++,n++)
                    {
                        for (int j = 0; j < strbuf[i].Count(); j++, n++)
                            if (n == position - 1)
                            {
                                bufpw = true;
                                break;
                            }
                        if (bufpw)
                            break;
                        if (n == position - 1)
                        {
                            e.Handled = true;
                            return;
                        }
                        positionword++;
                    }
                    if (str[position - 1] != ' ' & str[position - 1] != '-' & !strbuf[positionword].Contains(","))
                    {
                        return;
                    }
                }
            }
            e.Handled = true;
        }

        static Random random = new Random();

        private decimal RandDecimal(decimal minimum, decimal maximum)
        {
            return (decimal)random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void InMasbutton_Click(object sender, EventArgs e)
        {
            if (N.Value != (decimal)((int)N.Value))
                N.Value = (int)N.Value;
            decimal[] mas = new decimal[(int)N.Value];
            for (int i = 0; i < (int)N.Value; i++)
            {
                mas[i] = Math.Round(RandDecimal(-10, 10), 2);
            }
            Mas.Text = String.Join(" ", mas);
            IndexMin.Clear();
        }

        private void IndexMinbutton_Click(object sender, EventArgs e)
        {
            IndexMin.Clear();
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            if (Mas.Text == "")
                return;
            bool prov;
            decimal[] mas = new decimal[(int)N.Value];
            string[] str = Mas.Text.Split(' ');
            if (str.Count() != N.Value)
                return;
            for (int i = 0, j = 0; i < str.Count() & i < mas.Count(); i++)
            {
                prov = decimal.TryParse(str[i], out mas[i]);
                if (prov)
                    j++;
                else return;
            }
            decimal min = mas.Min();
            int[] index = mas.Select((n, i) => n == min ? i : -1).Where(n => n != -1).ToArray();
            IndexMin.Text = String.Join(" ", index);
        }
    }
}

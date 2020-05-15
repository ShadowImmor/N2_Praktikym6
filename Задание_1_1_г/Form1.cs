using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            N.Maximum = int.MaxValue;
            Min.Minimum = int.MinValue;
            Min.Maximum = int.MaxValue;
        }
        private void InMasbutton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            int[] mas = new int[(int)N.Value];
            for(int i = 0 ; i < (int)N.Value; i++)
            {
                mas[i] = random.Next(-100,100);
            }
            Isn.Text = String.Join(" ", mas);
            Ism.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Ism.Clear();
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            if (Isn.Text == "")
                return;
            bool prov;
            int[] mas = new int[(int)N.Value];
            string[] str = Isn.Text.Split(' ');
            if (str.Count() != (int)N.Value)
                return;
            for (int i = 0, j = 0; i < str.Count() & i < mas.Count(); i++)
            {
                prov = int.TryParse(str[i], out mas[i]);
                if (prov)
                    j++;
            }
            if (Min.Value != (int)Min.Value)
                Min.Value = (int)Min.Value;
            for (int i = 0; i < (int)N.Value; i++)
            {
                if (mas[i] < (int)Min.Value)
                    mas[i] = (int)Min.Value;
            }
            Ism.Text = String.Join(" ", mas);
        }
    }
}

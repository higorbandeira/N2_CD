using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1_CD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Calcula(double ang, int qtd, double temp)
        {
            double funcao = 0;
            double somaSen = 0;
            double sen = 0;

            int[] num = new int[qtd];

            int n = 1;

            for(int i = 0; i > qtd; i++)
            {
                num[i] = n;
                n = n + 2;
            }

            for(int i = 0; i < qtd; i++)
            {
                sen = Math.Sin(num[i] * ang * Math.PI * temp);
                sen = sen * 1 / num[i];
                somaSen = somaSen + sen;
            }

            funcao = 1 / 2 + ((2 / Math.PI) * somaSen);

            return funcao;
        }

        private void btnGeraGrafico_Click(object sender, EventArgs e)
        {
            double count = 0.00001;
            double valor = 0;
            double w = 0;
            int qtd = 0;

            if (txtRA.Text == "" || txtQTD.Text == "")
            {
                
            }
            else
            {
                try
                {
                    w = Convert.ToDouble(txtRA.Text);
                    qtd = Convert.ToInt32(txtQTD.Text);

                    do
                    {
                        valor = Calcula(w, qtd, count);

                        chart.Series["f0"].Points.AddXY(count, valor);

                        count = count + 0.00002;
                    }
                    while (count <= 0.01);

                    lblF0.Text = (w / 2).ToString();
                }
                catch (Exception ex) { };
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double hora_trab, salario_hora, hora_mes = 160, salario_total;

            hora_trab = double.Parse(txt_horatrab.Text);
            salario_hora = double.Parse(txt_salariohora.Text);

            if (hora_trab < hora_mes) {
                salario_total = salario_hora * hora_trab;
                lbl_valortotal.Text = "R$ " + salario_total.ToString("F2");
            } else {
                salario_total = salario_hora * hora_mes + ((hora_trab - hora_mes) * (salario_hora * 1.50));
                lbl_valortotal.Text = "R$ " + salario_total.ToString("F2"); 
            }
        }
    }
}

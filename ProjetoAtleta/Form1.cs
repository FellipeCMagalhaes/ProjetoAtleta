using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Usuario obj = new Usuario();

        private void btn_set_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_name.Text;
                obj.DataNascimento = DateTime.Parse(dtp_birth.Text);
                obj.Altura = double.Parse(txt_height.Text);
                obj.Peso = double.Parse(txt_weight.Text);
                MessageBox.Show("Dados armazenados");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimeDados() +
                            "\n\nIdade: " + obj.CalcularIdade().ToString("00") +
                            "\n\nIMC: " + obj.CalcularIMC().ToString("00.00"));
            txt_age.Text = obj.CalcularIdade().ToString();
            txt_IMC.Text = obj.CalcularIMC().ToString();
        }
    }
}

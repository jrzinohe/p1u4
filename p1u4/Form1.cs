using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1u4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double monto;

        private void activar_controles()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;

            button2.Enabled = true;
            button2.Enabled = true;
        }
        private void desactivar_controles()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;

            button2.Enabled = false;
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cliente;
            cliente = textBox1.Text;
            monto = Convert.ToDouble(textBox2.Text);
            if (monto > 0)
            {
                activar_controles();
            }
            else MessageBox.Show("el monto debe ser mayor o igual que 0", "gestion de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       private double leer (string mensaje)
        {
            double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("ingrese monto a " + mensaje, "gestion de ahorro","0",100,0));
            return cantidad;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            double deposito;
            deposito = leer("depositar");
            monto = monto + deposito;
            listBox1.Items.Add(deposito);
            mostrar();
        }
        private void mostrar()
        {
            textBox3.Text= Convert.ToString(monto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double retiro;
            retiro = leer(" retirar ");

                
                if (retiro <= monto)
            {
                monto = monto - retiro;
                listBox2.Items.Add(retiro);
                mostrar();
            }
            else
            {
                MessageBox.Show(" la cantidad de retiro es mayor al monto disponible","gestion de ahorros",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            desactivar_controles();
        }
    }
}

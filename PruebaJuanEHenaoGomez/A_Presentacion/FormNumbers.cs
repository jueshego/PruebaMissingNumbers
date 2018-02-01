using B_Fachada;
using D_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposVacios())
                return;

            Buscar();
        }

        private bool ValidarCamposVacios()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox || item is RichTextBox) && String.IsNullOrEmpty(item.Text) && item.Name != "rtxtListResult")
                {
                    MessageBox.Show("Faltan datos por ingresar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void Buscar()
        {
            ListaNumeros listaNumeros = new ListaNumeros
            {
                cantListA = txtCanA.Text,
                ListA = rtxtListA.Text,
                cantListB = txtCanB.Text,
                ListB = rtxtListB.Text
            };

            FacadeMissingNum facadeMissingNumbers = new FacadeMissingNum();

            try
            {
                string result = facadeMissingNumbers.RetornarNrosPerdidos(listaNumeros);
                rtxtListResult.Text = result;

                if (String.IsNullOrEmpty(result))
                    MessageBox.Show("No hay Números Perdidos de la lista A en la lista B", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

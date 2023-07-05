using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRaoEjxResolv
{
    public partial class frmMain : Form
    {
        List<ClaseEspecialidad> listEspecialidad = new List<ClaseEspecialidad>();
        List<ClaseMedico> listMedico = new List<ClaseMedico>();

        void LimpiarDatos()
        {
            txtAgregarEspecialidad.Text = "";
            txtMatricula.Text = "";
            txtNombre.Text = "";
            cmbEspecialiadMedico.SelectedIndex = -1;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        int Codigo = 1;

        private void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {
          
            ClaseEspecialidad ObjEspecialidad = new ClaseEspecialidad();

            ObjEspecialidad.Especialidad = txtAgregarEspecialidad.Text;
            ObjEspecialidad.CodigoEsp = Codigo++;
            listEspecialidad.Add(ObjEspecialidad);

            cmbEspecialiadMedico.Items.Add(ObjEspecialidad);
            cmbConsultaEspecialidad.Items.Add(ObjEspecialidad);

            MessageBox.Show(ObjEspecialidad.DevolverDatosEsp());

            LimpiarDatos();
        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {

            ClaseMedico objMedico =new ClaseMedico();

            objMedico.Nombre = txtNombre.Text;
            objMedico.Matricula = int.Parse(txtMatricula.Text);
            objMedico.Especialidad = cmbEspecialiadMedico.Text;

            listMedico.Add(objMedico);

            MessageBox.Show(objMedico.DevolverDatosMedico());

            LimpiarDatos();
        }

        private void btnConsultarEspecialidad_Click(object sender, EventArgs e)
        {
            foreach (ClaseEspecialidad campo in listEspecialidad)
            {
                if (cmbConsultaEspecialidad.SelectedIndex == int.Parse(campo.Especialidad))
                {
                    foreach (ClaseMedico campo2 in listMedico)
                    {
                        lstConsulta.Items.Add(campo2);
                    }
                }
            }
        }
    }
}

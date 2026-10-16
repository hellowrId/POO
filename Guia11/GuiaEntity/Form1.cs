using System;
using System.Linq;
using System.Windows.Forms;
using GuiaEntity.Modelo;

namespace GuiaEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Refrescar()
        {
            using (bdd_udbEntities db = new bdd_udbEntities())
            {
                //selecciona los datos disponibles en la tabla persona
                var lista = from datos in db.Persona
                            select datos;
                //se carga el datagridview con la información recopilada desde la bd
                DgvDatos.DataSource = lista.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //creamos un objeto del formulario FrmTabla
            FrmTabla frmtabla = new FrmTabla();
            //abrimos con ShowDialog
            frmtabla.ShowDialog();
            //refrescamos los datos
            Refrescar();
        }

        //permite retornar entero o nulo
        private int? ObtenerId()
        {
            try
            {
                // devolver el valor del índice de la fila seleccionada
                return int.Parse(DgvDatos.Rows[DgvDatos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerId();
            if (id != null)
            {
                FrmTabla frmtabla = new FrmTabla(id);
                frmtabla.ShowDialog();
            }
            Refrescar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerId();
            if (id != null)
            {
                using (bdd_udbEntities db = new bdd_udbEntities())
                {
                    Persona personas = db.Persona.Find(id);
                    db.Persona.Remove(personas);
                    db.SaveChanges();
                }
            }
            Refrescar();
        }
    }
}

using System;
using System.Windows.Forms;
using GuiaEntity.Modelo;

namespace GuiaEntity
{
    public partial class FrmTabla : Form
    {
        public int? id;
        Persona personas = null;

        // constructor sin parámetros (requerido por el diseñador de Visual Studio)
        public FrmTabla()
        {
            InitializeComponent();
        }

        public FrmTabla(int? id) : this()
        {
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (bdd_udbEntities db = new bdd_udbEntities())
            {
                personas = db.Persona.Find(id);
                TxtId.Text = personas.id.ToString();
                TxtNombre.Text = personas.nombre;
                TxtCorreo.Text = personas.correo;
                DtpFecha.Value = (DateTime)personas.fecha_nacimiento;
                // al editar, el id (llave primaria) no debe cambiarse
                TxtId.ReadOnly = true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (bdd_udbEntities db = new bdd_udbEntities())
            {
                // creamos un objeto del tipo de la tabla de la base
                if (id == null)
                {
                    personas = new Persona();
                }
                //lo llenamos con información desde el formulario
                personas.id = int.Parse(TxtId.Text);
                personas.nombre = TxtNombre.Text;
                personas.correo = TxtCorreo.Text;
                personas.fecha_nacimiento = DtpFecha.Value;

                if (id == null)
                {
                    //agregamos ese nuevo objeto a la entidad
                    db.Persona.Add(personas);
                }
                else
                {
                    db.Entry(personas).State = System.Data.Entity.EntityState.Modified;
                }
                //guardamos cambios en la base
                db.SaveChanges();
                this.Close();
            }
        }
    }
}

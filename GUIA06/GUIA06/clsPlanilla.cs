using GUIA06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA06
{
    internal class clsPlanilla
    {
        private int Estado; // 1: Sin iniciar, 2: En proceso, 3: Finalizada
        private string Empresa;
        private DateTime FechaPlanilla;
        private Dictionary<int, clsEmpleado> Listaempleados = new Dictionary<int, clsEmpleado>();
        private int TotalEmpleados;

        /// <summary>
        /// Si true, la clase mostrará mensajes vía MessageBox. Si false, solo emitirá el evento Notificar.
        /// /// Mejor práctica: suscribirse al evento Notificar en la UI y poner MostrarMensajes = false.
        /// </summary>
        public bool MostrarMensajes { get; set; } = true;

        /// <summary>
        /// Evento que notifica mensajes; la UI puede suscribirse para recibirlos.
        /// </summary>
        public event Action<string, string> Notificar;

        public clsPlanilla()
        {
            Estado = 1;
            Empresa = string.Empty;
            FechaPlanilla = DateTime.Now;
            TotalEmpleados = 0;
        }

        // Método para centralizar notificaciones
        private void EnviarMensaje(string mensaje, string titulo = "")
        {
            Notificar?.Invoke(titulo, mensaje);

            if (MostrarMensajes)
            {
                MessageBox.Show(mensaje, string.IsNullOrWhiteSpace(titulo) ? "Información" : titulo);
            }
        }

        public void AbrirPlanilla(DateTime fechaInicio, string nombreempresa = "(Sin nombre)")
        {
            nombreempresa = (nombreempresa ?? string.Empty).Trim();

            switch (Estado)
            {
                case 1:
                    FechaPlanilla = fechaInicio;

                    if (nombreempresa.Length > 0)
                        Empresa = nombreempresa;

                    Estado = 2;

                    EnviarMensaje(
                        "Planilla Abierta, inicie registro empleados",
                        $"Planilla de {Empresa}, APERTURA: {FechaPlanilla}"
                    );
                    break;

                case 2:
                    EnviarMensaje(
                        $"Planilla ya está abierta desde el: {FechaPlanilla}",
                        $"Planilla de {Empresa}"
                    );
                    break;

                case 3:
                    EnviarMensaje(
                        $"Planilla creada el {FechaPlanilla} ya se cerró",
                        $"Planilla de {Empresa}"
                    );
                    break;
            }
        }

        public void RecibirEmpleado(clsEmpleado nuevoEmpleado)
        {
            if (nuevoEmpleado == null)
            {
                EnviarMensaje("Empleado nulo. No se puede registrar.", "Error");
                return;
            }

            if (Estado != 2)
            {
                EnviarMensaje("Planilla aún no está abierta", $"Planilla de {Empresa}");
                return;
            }

            if (!nuevoEmpleado.datospersonales_aceptados)
            {
                EnviarMensaje("Error, datos personales están incompletos", "Control planilla");
                return;
            }

            if (!nuevoEmpleado.datoslaborales_aceptados)
            {
                EnviarMensaje("Error, datos laborales están incompletos", "Control planilla");
                return;
            }

            TotalEmpleados++;
            Listaempleados.Add(TotalEmpleados, nuevoEmpleado);
        }

        public void GenerarListado(ref DataGridView cuadro)
        {
            if (cuadro == null)
                throw new ArgumentNullException(nameof(cuadro));

            switch (Estado)
            {
                case 1:
                    EnviarMensaje("Planilla aún no ha sido abierta", $"Planilla {Empresa}");
                    return;

                case 2:
                    if (TotalEmpleados == 0)
                    {
                        EnviarMensaje(
                            "Planilla no tiene aún empleados registrados",
                            $"Planilla de {Empresa}"
                        );
                        return;
                    }

                    Estado = 3;

                    EnviarMensaje(
                        $"Planilla cerrada con {TotalEmpleados} empleados",
                        $"Planilla de {Empresa}"
                    );

                    EnviarMensaje(
                        $"Planilla abierta el {FechaPlanilla} se muestra ahora!!",
                        $"Planilla de {Empresa}"
                    );
                    break;
            }

            // Preparar DataGridView
            cuadro.SuspendLayout();
            cuadro.Rows.Clear();
            cuadro.Columns.Clear();

            // Columnas
            cuadro.Columns.Add("id", "ID");
            cuadro.Columns.Add("nom", "Nombre completo");
            cuadro.Columns.Add("sb", "Sueldo base");
            cuadro.Columns.Add("sf", "Sueldo neto final");

            // Formatos y comportamiento
            cuadro.ReadOnly = true;
            cuadro.AllowUserToAddRows = false;
            cuadro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilos
            cuadro.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque;
            cuadro.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige;

            // Llenar filas
            int i = 0;

            foreach (var kvp in Listaempleados.OrderBy(k => k.Key))
            {
                var empleado = kvp.Value;
                string sb = "0";
                string sf = "0";

                empleado.VerSueldos(ref sb, ref sf);

                cuadro.Rows.Add();

                cuadro.Rows[i].Cells[0].Value = kvp.Key;
                cuadro.Rows[i].Cells[1].Value = empleado.nombrecompleto;
                cuadro.Rows[i].Cells[2].Value = sb;
                cuadro.Rows[i].Cells[3].Value = sf;

                i++;
            }

            cuadro.ResumeLayout();

            EnviarMensaje("Planilla de pago final completa generada en pantalla!!");
        }

        /// <summary>Propiedad para obtener total de empleados como cadena (compatibilidad)</summary>
        public string TotaldeEmpleado => TotalEmpleados.ToString();

        /// <summary>Acceso de solo lectura a los empleados (si necesario para otras operaciones)</summary>
        public IReadOnlyDictionary<int, clsEmpleado> Empleados =>
            new System.Collections.ObjectModel.ReadOnlyDictionary<int, clsEmpleado>(Listaempleados);
    }
}
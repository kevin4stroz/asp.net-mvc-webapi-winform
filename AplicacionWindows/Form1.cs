using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using AplicacionWindows.Clases;

namespace AplicacionWindows
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        static List<Empleado> empleados;
        static List<Vehiculo> vehiculos;
        static List<Viaje> viajes;

        public Form1()
        {
            InitializeComponent();

            cbxCodEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCodigoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;

            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55438/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        static async Task<List<Empleado>> GetEmpleadosAsync(string path)
        {
            List<Empleado> empleado = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                empleado = await response.Content.ReadAsAsync<List<Empleado>>();
            }

            return empleado;
        }

        static async Task<List<Vehiculo>> GetVehiculosAsync(string path)
        {
            List<Vehiculo> vehiculo = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                vehiculo = await response.Content.ReadAsAsync<List<Vehiculo>>();
            }
            return vehiculo;
        }

        static async Task<List<Viaje>> GetViajesAsync(string path)
        {
            List<Viaje> viaje = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                viaje = await response.Content.ReadAsAsync<List<Viaje>>();
            }
            return viaje;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // obtener listado de empleados
            try
            {
                empleados = await GetEmpleadosAsync("api/EMPLEADOS/");
            }
            catch
            {
                MessageBox.Show("ERROR ENVIANDO PETICION AL WEB SERVICE api/EMPLEADOS/");
                System.Windows.Forms.Application.Exit();
            }
            

            // alimentar cbxCodEmpleado
            foreach(Empleado emp in empleados)
            {
                cbxCodEmpleado.Items.Add(emp.CEDULA);
            }

            // obtener listado de vehiculos            
            try
            {
                vehiculos = await GetVehiculosAsync("api/VEHICULOS/");
            }
            catch
            {
                MessageBox.Show("ERROR ENVIANDO PETICION AL WEB SERVICE api/VEHICULOS/");
                System.Windows.Forms.Application.Exit();
            }

            // alimentar cbxCodigoVehiculo
            foreach (Vehiculo veh in vehiculos)
            {
                cbxCodigoVehiculo.Items.Add(veh.PLACA);
            }

        }

        private Empleado getEmpCbx()
        {
            return empleados.Find(emp => emp.CEDULA == long.Parse(cbxCodEmpleado.Text));
        }

        private Vehiculo getVehCbx()
        {
            return vehiculos.Find(veh => veh.PLACA == cbxCodigoVehiculo.Text);
        }

        private void cbxCodEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBoxEmpleado.Text = "";

            Empleado select_emp = getEmpCbx();

            txtBoxEmpleado.Text = String.Format("NOMBRE : {0}\r\n", select_emp.NOMBRE);
            txtBoxEmpleado.Text += String.Format("APELLIDOS : {0}\r\n", select_emp.APELLIDO);
            txtBoxEmpleado.Text += String.Format("CEDULA : {0}\r\n", select_emp.CEDULA);
            txtBoxEmpleado.Text += String.Format("SEXO : {0}\r\n", select_emp.SEXO);
            txtBoxEmpleado.Text += String.Format("REGISTRO : {0}\r\n", select_emp.F_REGISTRO);

        }

        private void cbxCodigoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBoxVehiculo.Text = "";

            Vehiculo select_veh = getVehCbx();

            txtBoxVehiculo.Text = String.Format("PLACA : {0}\r\n", select_veh.PLACA);
            txtBoxVehiculo.Text += String.Format("MODELO : {0}\r\n", select_veh.MODELO);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            bool status = true;
            string cod_emp = cbxCodEmpleado.Text;
            string cod_veh = cbxCodigoVehiculo.Text;
            DateTime fecha = dtimePkFecha.Value;
            string fecha_s = fecha.ToString("yyyy-MM-dd");

            // VALIDAR QUE CODIGO EMPLEADO NO VENGA VACIO
            if (cod_emp.Equals(String.Empty))
            {
                status = false;
                MessageBox.Show("Codigo del empleado no puede estar vacio");
            }

            // VALIDAR QUE CODIGO VEHICULO NO VENGA VACIO
            if (cod_veh.Equals(String.Empty))
            {
                status = false;
                MessageBox.Show("Codigo del vehiculo no puede estar vacio");
            }

            // VALIDAR QUE FECHA SELECCIONADA SEA MENOR O IGUAL AL DIA ACTUAL
            if (fecha > DateTime.Now)
            {
                status = false;
                MessageBox.Show("Fecha seleccionada debe ser menor o igual al dia actual");
            }

            if (status)
            {
                // VALORES
                Empleado temp_emp = getEmpCbx();
                Vehiculo temp_veh = getVehCbx();

                // TRAER TODOS LOS VIAJES REALIZADOS POR LOS PARAMETROS DADOS
                try
                {
                    string url_path = String.Format("api/VIAJES/{0}/{1}/{2}/", temp_emp.ID_EMP, temp_veh.ID_VEHICULO, fecha_s);
                    viajes = await GetViajesAsync(url_path);
                }
                catch
                {
                    MessageBox.Show("ERROR ENVIANDO PETICION AL WEB SERVICE api/VIAJES/");
                    System.Windows.Forms.Application.Exit();
                }

                // ALIMENTAR DATAGRID
                dtGridViajes.DataSource = viajes;
            }


        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace reportsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CargarComboBox()
        {
            cmbReportes.Items.Clear();
            cmbReportes.Items.Add("Producto mas vendido");
            cmbReportes.Items.Add("Total de ingresos");
            cmbReportes.Items.Add("Ventas por dia");
            cmbReportes.SelectedIndex = 0;
        }

        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbReportes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de reporte.",
                                "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccion = cmbReportes.SelectedItem.ToString();
            string query = ObtenerQuery(seleccion);
            CargarReporte(query);
        }

        private string ObtenerQuery(string tipo)
        {
            switch (tipo)
            {
                case "Producto mas vendido":
                    return @"SELECT p.nombre AS Producto, 
                                    SUM(v.cantidad) AS Total_Vendido
                             FROM ventas v
                             JOIN productos p ON v.id_producto = p.id
                             GROUP BY p.nombre
                             ORDER BY Total_Vendido DESC";

                case "Total de ingresos":
                    return @"SELECT p.nombre AS Producto,
                                    SUM(v.cantidad * p.precio) AS Ingresos
                             FROM ventas v
                             JOIN productos p ON v.id_producto = p.id
                             GROUP BY p.nombre
                             ORDER BY Ingresos DESC";

                case "Ventas por dia":
                    return @"SELECT fecha AS Fecha,
                                    SUM(cantidad) AS Total_Ventas
                             FROM ventas
                             GROUP BY fecha
                             ORDER BY fecha";

                default:
                    return null;
            }
        }

        private void CargarReporte(string query)
        {
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);

                        dgvReportes.DataSource = tabla;
                        dgvReportes.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL: " + ex.Message);
                MessageBox.Show("Error al consultar la base de datos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Ocurrio un error inesperado.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}

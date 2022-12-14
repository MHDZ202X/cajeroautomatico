using System.IO;
using System.Text;

namespace cajero1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            cuenta c = new cuenta();// crea un objeto de la clase cuenta //
            //c.numcuenta = txtcuenta.Text; // dentro del objeto clase cuenta la variable publica numcuenta almacena el texto del la caja de texto txtnumcuenta "
            string uc = txtcuenta.Text; // variable usuario cuenta (uc) //
            string unip = txtnip.Text; // variable de usuario nip (unip) //
            if (uc == c.numcuenta && unip == c.numnip)
            {
                MessageBox.Show("los datos introducidos son correctos");
                MessageBox.Show("Bienvenido " + c.Nombre + " adelante");
                //tabmenu.Hide();


                GeneralConsulta.SelectedTab = tabinicio;
                tabmenu.Hide();
                btnacceder.Hide();
            }
            else
            {
                MessageBox.Show("introduce los datos correctos ");
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("2");
        }

        private void button11_Click(object sender, EventArgs e)
        {

            txtnip.AppendText("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("5");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("6");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("7");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("8");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("9");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtnip.AppendText("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralConsulta.SelectedTab = AltasC;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Formularios_Click(object sender, EventArgs e)
        {

        }

        private void btnAguardar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("..Banco.txt", true, Encoding.ASCII);
            sw.WriteLine(txtAcuenta.Text);
            sw.WriteLine(txtAcliente.Text);
            sw.WriteLine(txtAsaldo.Text);
            MessageBox.Show("Datos Guardados", "Altas Clientes", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            sw.Close();
            txtAcuenta.Clear();
            txtAcliente.Clear();
            txtAsaldo.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCbuscar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("..Banco.txt");
            bool band = true;
            string cuenta = sr.ReadLine();
            string cliente = sr.ReadLine();
            string saldo = sr.ReadLine();
            while (cuenta != null)
            {
                if (cuenta == txtCcuenta.Text)
                {
                    band = false;
                    txtCcliente.Text = cliente;
                    txtCsaldo.Text = saldo;
                }
                cuenta = sr.ReadLine();
                cliente = sr.ReadLine();
                saldo = sr.ReadLine();

            }
            sr.Close();
            if (band == true)
            {
                MessageBox.Show("No Existe la Cuenta", "Consulta Cuenta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCcuenta.Clear();
                txtCcliente.Clear();
                txtCsaldo.Clear();

            }
        }

        private void txtEcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                StreamReader sr = new StreamReader("..Banco.txt");
                bool band = true;
                string cuenta = sr.ReadLine();
                string cliente = sr.ReadLine();
                string saldo = sr.ReadLine();
                while (cuenta != null)
                {
                    if (cuenta == txtEcuenta.Text)
                    {
                        band = false;
                        txtEcliente.Text = cliente;
                        txtEsaldo.Text = saldo;
                    }
                    cuenta = sr.ReadLine();
                    cliente = sr.ReadLine();
                    saldo = sr.ReadLine();

                }
                sr.Close();
                if (band == true)
                {
                    MessageBox.Show("No Existe la Cuenta", "Consulta Cuenta", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtEcuenta.Clear();
                    txtEcliente.Clear();
                    txtEsaldo.Clear();

                }
            }
        }

        private void btnEeliminar_Click(object sender, EventArgs e)
        {
            bool band = true;
            StreamReader sr = new StreamReader("..Banco.txt");
            StreamWriter sW = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
            string cuenta = sr.ReadLine();
            string cliente = sr.ReadLine();
            string saldo = sr.ReadLine();
            while (cuenta != null)
            {
                if (cuenta == txtEcuenta.Text)
                {
                    band = false;
                }
                if (cuenta != txtEcuenta.Text)
                {
                    sW.WriteLine(cuenta);
                    sW.WriteLine(cliente);
                    sW.WriteLine(saldo);
                }
                cuenta = sr.ReadLine();
                cliente = sr.ReadLine();
                saldo = sr.ReadLine();
            }
            sr.Close();
            sW.Close();
            StreamReader sr1 = new StreamReader("..Auxiliar.txt");
            StreamWriter sw1 = new StreamWriter("..Banco.txt", false, Encoding.ASCII);
            cuenta = sr1.ReadLine();
            cliente = sr1.ReadLine();
            saldo = sr1.ReadLine();
            while (cuenta != null)
            {
                sw1.WriteLine(cuenta);
                sw1.WriteLine(cliente);
                sw1.WriteLine(saldo);
                cuenta = sr1.ReadLine();
                cliente = sr1.ReadLine();
                saldo = sr1.ReadLine();
            }
            sw1.Close();
            sw1.Close();
            if (band == false)
            {
                MessageBox.Show("La cuenta fue eliminada", "Eliminar cuenta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEcuenta.Clear();
                txtEcliente.Clear();
                txtEsaldo.Clear();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("..Banco.txt");
            bool band = true;
            string cuenta = sr.ReadLine();
            string cliente = sr.ReadLine();
            string saldo = sr.ReadLine();
            while (cuenta != null)
            {
                ListViewItem datos = new ListViewItem(cuenta);
                datos.SubItems.Add(cliente);
                datos.SubItems.Add(saldo);
                listView1.Items.Add(datos);
                cuenta = sr.ReadLine();
                cliente = sr.ReadLine();
                saldo = sr.ReadLine();

            }
            sr.Close();
        }

        private void btnAcancelar_Click(object sender, EventArgs e)
        {
            txtAcuenta.Clear();
            txtAcliente.Clear();
            txtAsaldo.Clear();
        }

        private void btnCcancelar_Click(object sender, EventArgs e)
        {
            txtCcuenta.Clear();
            txtCcliente.Clear();
            txtCsaldo.Clear();
        }

        private void btnEcancelar_Click(object sender, EventArgs e)
        {
            txtEcuenta.Clear();
            txtEcliente.Clear();
            txtEsaldo.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("..Banco.txt");
            bool band = true;
            string cuenta = sr.ReadLine();
            string cliente = sr.ReadLine();
            string saldo = sr.ReadLine();
            while (cuenta != null)
            {
                ListViewItem datos = new ListViewItem(cuenta);
                //datos.SubItems.Add(cliente);
                //datos.SubItems.Add(saldo);
                listView1.Items.Add(datos);
                cuenta = sr.ReadLine();
                //cliente = sr.ReadLine();
                //saldo = sr.ReadLine();

            }
            sr.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {


            bool band = true;
            StreamReader sr = new StreamReader("..Banco.txt");
            StreamWriter sW = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
            string cuenta = sr.ReadLine();
            string cliente = sr.ReadLine();
            string saldo = sr.ReadLine();
            while (cuenta != null)
            {
                if (cuenta == txtMcuenta.Text)
                {
                    band = false;
                }
                if (cuenta != txtMcuenta.Text)
                {
                    sW.WriteLine(cuenta);
                    sW.WriteLine(cliente);
                    sW.WriteLine(saldo);
                }
                cuenta = sr.ReadLine();
                cliente = sr.ReadLine();
                saldo = sr.ReadLine();
            }
            sr.Close();
            sW.Close();
            StreamReader sr1 = new StreamReader("..Auxiliar.txt");
            StreamWriter sw1 = new StreamWriter("..Banco.txt", false, Encoding.ASCII);
            cuenta = sr1.ReadLine();
            cliente = sr1.ReadLine();
            saldo = sr1.ReadLine();
            while (cuenta != null)
            {
                sw1.WriteLine(cuenta);
                sw1.WriteLine(cliente);
                sw1.WriteLine(saldo);
                cuenta = sr1.ReadLine();
                cliente = sr1.ReadLine();
                saldo = sr1.ReadLine();
            }
            sw1.Close();
            sw1.Close();

            StreamWriter sw = new StreamWriter("..Banco.txt", true, Encoding.ASCII);
            sw.WriteLine(txtMcuenta.Text);
            sw.WriteLine(txtMcliente.Text);
            sw.WriteLine(txtMsaldo.Text);
            MessageBox.Show("Se a modificado la cuenta", "Datos Actualizados", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            sw.Close();
            txtMcuenta.Clear();
            txtMcliente.Clear();
            txtMsaldo.Clear();
            sr1.Close();
            sr.Close();


        }

        private void btnMguardar_Click(object sender, EventArgs e)
        {
            bool band = true;
            StreamReader sr = new StreamReader("..Banco.txt");
            StreamWriter sW = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
            string cuenta = sr.ReadLine();
            string cliente = sr.ReadLine();
            string saldo = sr.ReadLine();
            while (cuenta != null)
            {
                if (cuenta == txtMcuenta.Text)
                {
                    band = false;
                }
                if (cuenta != txtMcuenta.Text)
                {
                    sW.WriteLine(cuenta);
                    sW.WriteLine(cliente);
                    sW.WriteLine(saldo);
                }
                cuenta = sr.ReadLine();
                cliente = sr.ReadLine();
                saldo = sr.ReadLine();
            }
            sr.Close();
            sW.Close();
            StreamReader sr1 = new StreamReader("..Auxiliar.txt");
            StreamWriter sw1 = new StreamWriter("..Banco.txt", false, Encoding.ASCII);
            cuenta = sr1.ReadLine();
            cliente = sr1.ReadLine();
            saldo = sr1.ReadLine();
            while (cuenta != null)
            {
                sw1.WriteLine(cuenta);
                sw1.WriteLine(cliente);
                sw1.WriteLine(saldo);
                cuenta = sr1.ReadLine();
                cliente = sr1.ReadLine();
                saldo = sr1.ReadLine();
            }

            sw1.Close();
            sw1.Close();

           
                StreamWriter sw = new StreamWriter("..Banco.txt", true, Encoding.ASCII);
                sw.WriteLine(txtMcuenta.Text);
                sw.WriteLine(txtMcliente.Text);
                sw.WriteLine(txtMsaldo.Text);
                MessageBox.Show("Se a modificado la cuenta", "Datos Actualizados", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                sw.Close();
                txtMcuenta.Clear();
                txtMcliente.Clear();
                txtMsaldo.Clear();
                sr1.Close();
                sr.Close();
            
            sr1.Close();
            sr.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneralConsulta.SelectedTab = Formularios;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneralConsulta.SelectedTab = Eliminar;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GeneralConsulta.SelectedTab = tabinicio;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GeneralConsulta.SelectedTab = tabCG;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GeneralConsulta.SelectedTab = tabmenu;
        }

        private void txtcuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMcancelar_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
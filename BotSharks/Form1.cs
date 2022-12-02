using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
//ES NECESARIO CARGAR LAS LIBRERIAS
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Keys = OpenQA.Selenium.Keys;

namespace BotSharks
{
    public partial class Form1 : Form
    {
        //INICIALIZAMOS Y DEFINIMOS EL WEB-BROWSER
        public IWebDriver driver = Form1.sinpromt();
        public int pause = 1250;
        public int time_ini = 5000;       
        public int valorprogress = 0;
        //private IContainer components = (IContainer)null;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new System.Drawing.Size(600, 300);
            Name = "Form1";
            Load += new System.EventHandler(Form1_Load);
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("http://web.whatsapp.com"); // URL DE NAVEGACION
            Mdl_JAAS.bw_jaas = new BackgroundWorker();
            Mdl_JAAS.bw_jaas.DoWork += new DoWorkEventHandler(procesoEnvio);
            Mdl_JAAS.bw_jaas.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            Mdl_JAAS.bw_jaas.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            Mdl_JAAS.bw_jaas.WorkerReportsProgress = true;
            Mdl_JAAS.bw_jaas.WorkerSupportsCancellation = true;
        }

        public static IWebDriver sinpromt()
        {
            /* Con esta funcion mandamos a abrir el navegador justo al ejecutar el programa */
            ChromeDriverService defaultService = ChromeDriverService.CreateDefaultService();
            defaultService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--safebrowsing-disable-download-protection");
            options.AddUserProfilePreference("safebrowsing.enabled", (object)"false");
            return (IWebDriver)new ChromeDriver(defaultService, options);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            driver.Close(); //finalizamos el evento selenium
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "Excel | *.xls;  *.xlsx;",
                    Title = "Seleccionar Archivo",
                    InitialDirectory = "Desktop"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(openFileDialog.FileName);
                    dataGridView.DataSource = importarDatos(openFileDialog.FileName);
                    //txtTelefono.Text = openFileDialog.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = dataGridView.RowCount;
            valorprogress = 0;
            progressBar.Value = valorprogress;
            if (txtMensaje.Text.Trim().Length == 0)
                return;
            if (BtnEnviar.Text.Equals("Cancelar"))
            {
                Mdl_JAAS.bw_jaas.CancelAsync();
                valorprogress = 0;
                progressBar.Value = valorprogress;
            }
            else
            {
                cambiaNombreBtn(BtnEnviar, 1);
                Mdl_JAAS.bw_jaas.RunWorkerAsync();
            }

        }



        DataView importarDatos(string nombreArchivo)
        {
            string conexion = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {0}; Extended Properties=Excel 8.0;", nombreArchivo);
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();
            OleDbCommand consulta = new OleDbCommand("select * from [Hoja1$]", conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta)
            {
                SelectCommand = consulta
            };
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;
        }


        private void procesoEnvio(object sender, DoWorkEventArgs e)
        {
            if (txtMensaje.Text.Length <= 0)
                return;
            for (int percentProgress = 0; percentProgress <= dataGridView.RowCount; ++percentProgress)
            {
                if (Mdl_JAAS.bw_jaas.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                string messagetoSend = txtMensaje.Text.Trim().Replace(" ", "%20");

                //txtTelefono.Text = dataGridView.CurrentRow.Cells["Contacto"].Value.ToString();

                urlContacto(dataGridView.Rows[percentProgress].Cells["Contacto"].Value.ToString(), messagetoSend);
                Thread.Sleep(time_ini);
                if (Verificar_Existebtn())
                    envioMessage();
                try
                {
                    ++valorprogress;
                    System.Windows.Forms.Application.DoEvents();
                    Mdl_JAAS.bw_jaas.ReportProgress(percentProgress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void urlContacto(string telefono, string mensaje)
        {
            driver.Navigate().GoToUrl("https://web.whatsapp.com/send?phone=" + telefono + "&text=" + mensaje);
        }

        private bool Verificar_Existebtn()
        {
            bool flag = false;
            try
            {
                flag = driver.PageSource.ToString().Contains("<span data-icon=\"send\" class=\"\">");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return flag;
        }

        public void envioMessage()
        {
            try
            {
                Thread.Sleep(pause);
                driver.FindElement(By.XPath("//div[@class='_3u328 copyable-text selectable-text']")).SendKeys(Keys.Enter);
                //driver.FindElement(By.XPath("//div[@title='Escribe un mensaje aquí']")).Click();
                //driver.FindElement(By.XPath("//div[@title='Escribe un mensaje aquí']")).SendKeys(Keys.Enter);
                //driver.FindElement(By.XPath("div[@class='_2S1VP copyable - text selectable - text']")).SendKeys(Keys.Enter);
                //driver.FindElement(By.XPath("label[@class=”_2MSJr”]div[@class=”_2S1VP copyable-text selectable-text”]"));
                //driver.FindElement(By.XPath("div[@class=”_6h3Ps”]div[@class=”_2S1VP copyable-text selectable-text”]"));
                //driver.FindElement(By.XPath("div[@class='_35EW6 selectable - text copyable - text']")).SendKeys(Keys.Enter);
                //driver.FindElement(By.ClassName("_35EW6")).Click();
                //driver.FindElement(By.XPath("label[@class=”_4sWnG”]div[@class=”_13NKt copyable-text selectable-text”]"));
                //driver.FindElement(By.XPath("//div[@title='Nova conversa']")).Click();
                //driver.FindElement(By.XPath("div[@class='_6h3Ps copyable-text selectable-text']")).SendKeys(Keys.Enter);
                Thread.Sleep(pause);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar.Value = valorprogress;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cambiaNombreBtn(BtnEnviar, 2);
            int num = (int)MessageBox.Show("Proceso Finalizado ...!", "Dexter!");
        }

        public void cambiaNombreBtn(Button btnX, int op)
        {
            if (op == 1)
            {
                btnX.Text = "Cancelar";
                btnX.Enabled = true;
            }
            if (op == 2)
                btnX.Text = "Enviar";
            System.Windows.Forms.Application.DoEvents();
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblCount.Text = string.Concat(txtMensaje.Text.Trim().Length);
        }

    }
}

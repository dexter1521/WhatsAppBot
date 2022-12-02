namespace BotSharks
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.process = new System.Diagnostics.Process();
            this.lblCount = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Envío Automático de WhatsApp";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(391, 85);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(201, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto a enviar";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(535, 248);
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(56, 26);
            this.BtnEnviar.TabIndex = 4;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número a contactar";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 85);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(374, 139);
            this.dataGridView.TabIndex = 6;
            // 
            // BtnImportar
            // 
            this.BtnImportar.Location = new System.Drawing.Point(326, 248);
            this.BtnImportar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(56, 26);
            this.BtnImportar.TabIndex = 7;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 248);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(237, 26);
            this.progressBar.TabIndex = 8;
            // 
            // process
            // 
            this.process.StartInfo.Domain = "";
            this.process.StartInfo.LoadUserProfile = false;
            this.process.StartInfo.Password = null;
            this.process.StartInfo.StandardErrorEncoding = null;
            this.process.StartInfo.StandardOutputEncoding = null;
            this.process.StartInfo.UserName = "";
            this.process.SynchronizingObject = this;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(390, 231);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "0";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(393, 141);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(195, 83);
            this.txtMensaje.TabIndex = 10;
            this.txtMensaje.TextChanged += new System.EventHandler(this.txtMensaje_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 295);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Diagnostics.Process process;
        private System.Windows.Forms.Label lblCount;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}


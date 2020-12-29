namespace Fernando
{
    partial class Fernando
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblCapitura = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNivelDor = new System.Windows.Forms.Label();
            this.radNao = new System.Windows.Forms.RadioButton();
            this.lblData = new System.Windows.Forms.Label();
            this.radSim = new System.Windows.Forms.RadioButton();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNivelDor = new System.Windows.Forms.TextBox();
            this.pnlControle = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.pnlControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(27, 20);
            this.txtId.TabIndex = 18;
            this.txtId.Visible = false;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(97, 18);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 1;
            this.dtpData.Value = new System.DateTime(2020, 12, 10, 17, 44, 41, 0);
            this.dtpData.Leave += new System.EventHandler(this.dtpData_Leave);
            // 
            // lblCapitura
            // 
            this.lblCapitura.AutoSize = true;
            this.lblCapitura.Location = new System.Drawing.Point(40, 98);
            this.lblCapitura.Name = "lblCapitura";
            this.lblCapitura.Size = new System.Drawing.Size(46, 13);
            this.lblCapitura.TabIndex = 16;
            this.lblCapitura.Text = "Capitura";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(56, 48);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(34, 13);
            this.lblCusto.TabIndex = 15;
            this.lblCusto.Text = "Custo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(40, 73);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 14;
            this.lblDistancia.Text = "Distancia";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(59, 158);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNivelDor
            // 
            this.lblNivelDor.AutoSize = true;
            this.lblNivelDor.Location = new System.Drawing.Point(20, 122);
            this.lblNivelDor.Name = "lblNivelDor";
            this.lblNivelDor.Size = new System.Drawing.Size(66, 13);
            this.lblNivelDor.TabIndex = 13;
            this.lblNivelDor.Text = "Nível de dor";
            // 
            // radNao
            // 
            this.radNao.AutoSize = true;
            this.radNao.Location = new System.Drawing.Point(97, 96);
            this.radNao.Name = "radNao";
            this.radNao.Size = new System.Drawing.Size(45, 17);
            this.radNao.TabIndex = 5;
            this.radNao.TabStop = true;
            this.radNao.Text = "Não";
            this.radNao.UseVisualStyleBackColor = true;
            this.radNao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radNao_MouseClick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(56, 21);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // radSim
            // 
            this.radSim.AutoSize = true;
            this.radSim.Location = new System.Drawing.Point(155, 96);
            this.radSim.Name = "radSim";
            this.radSim.Size = new System.Drawing.Size(42, 17);
            this.radSim.TabIndex = 4;
            this.radSim.TabStop = true;
            this.radSim.Text = "Sim";
            this.radSim.UseVisualStyleBackColor = true;
            this.radSim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radSim_MouseClick);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(97, 44);
            this.txtCusto.MaxLength = 13;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 2;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(97, 70);
            this.txtDistancia.MaxLength = 100;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 3;
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(59, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(140, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Location = new System.Drawing.Point(234, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 29);
            this.panel1.TabIndex = 20;
            // 
            // txtNivelDor
            // 
            this.txtNivelDor.Location = new System.Drawing.Point(97, 119);
            this.txtNivelDor.MaxLength = 2;
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(100, 20);
            this.txtNivelDor.TabIndex = 6;
            this.txtNivelDor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivelDor_KeyPress);
            // 
            // pnlControle
            // 
            this.pnlControle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlControle.Controls.Add(this.txtId);
            this.pnlControle.Controls.Add(this.dtpData);
            this.pnlControle.Controls.Add(this.lblCapitura);
            this.pnlControle.Controls.Add(this.lblCusto);
            this.pnlControle.Controls.Add(this.btnCancelar);
            this.pnlControle.Controls.Add(this.lblDistancia);
            this.pnlControle.Controls.Add(this.btnSalvar);
            this.pnlControle.Controls.Add(this.lblNivelDor);
            this.pnlControle.Controls.Add(this.radNao);
            this.pnlControle.Controls.Add(this.lblData);
            this.pnlControle.Controls.Add(this.radSim);
            this.pnlControle.Controls.Add(this.txtCusto);
            this.pnlControle.Controls.Add(this.txtNivelDor);
            this.pnlControle.Controls.Add(this.txtDistancia);
            this.pnlControle.Location = new System.Drawing.Point(234, 47);
            this.pnlControle.Name = "pnlControle";
            this.pnlControle.Size = new System.Drawing.Size(265, 201);
            this.pnlControle.TabIndex = 21;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 11);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(216, 237);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Captura";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nivel de dor";
            this.columnHeader4.Width = 70;
            // 
            // Fernando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Fernando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACME FLIGHT MANAGER";
            this.Load += new System.EventHandler(this.Fernando_Load);
            this.panel1.ResumeLayout(false);
            this.pnlControle.ResumeLayout(false);
            this.pnlControle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblCapitura;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNivelDor;
        private System.Windows.Forms.RadioButton radNao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.RadioButton radSim;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNivelDor;
        private System.Windows.Forms.Panel pnlControle;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}


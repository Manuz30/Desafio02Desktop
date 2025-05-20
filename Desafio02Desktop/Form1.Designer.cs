namespace Desafio02Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btnFavorito = new System.Windows.Forms.Button();
            this.btnFiltrarPreco = new System.Windows.Forms.Button();
            this.btnFiltrarCategoria = new System.Windows.Forms.Button();
            this.txtPrecoMax = new System.Windows.Forms.TextBox();
            this.txtPrecoMin = new System.Windows.Forms.TextBox();
            this.lbPrecoMax = new System.Windows.Forms.Label();
            this.lbPrecoMin = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnBuscarFavorito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(12, 318);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 31);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(192, 34);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 2;
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(15, 27);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(0, 20);
            this.lbtitulo.TabIndex = 6;
            // 
            // btnFavorito
            // 
            this.btnFavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorito.Location = new System.Drawing.Point(519, 34);
            this.btnFavorito.Name = "btnFavorito";
            this.btnFavorito.Size = new System.Drawing.Size(101, 33);
            this.btnFavorito.TabIndex = 7;
            this.btnFavorito.Text = "Favoritar";
            this.btnFavorito.UseVisualStyleBackColor = true;
            this.btnFavorito.Click += new System.EventHandler(this.btnFavorito_Click);
            // 
            // btnFiltrarPreco
            // 
            this.btnFiltrarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPreco.Location = new System.Drawing.Point(744, 200);
            this.btnFiltrarPreco.Name = "btnFiltrarPreco";
            this.btnFiltrarPreco.Size = new System.Drawing.Size(104, 29);
            this.btnFiltrarPreco.TabIndex = 8;
            this.btnFiltrarPreco.Text = "Filtrar Preço";
            this.btnFiltrarPreco.UseVisualStyleBackColor = true;
            this.btnFiltrarPreco.Click += new System.EventHandler(this.btnFiltrarPreco_Click);
            // 
            // btnFiltrarCategoria
            // 
            this.btnFiltrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCategoria.Location = new System.Drawing.Point(519, 98);
            this.btnFiltrarCategoria.Name = "btnFiltrarCategoria";
            this.btnFiltrarCategoria.Size = new System.Drawing.Size(142, 31);
            this.btnFiltrarCategoria.TabIndex = 9;
            this.btnFiltrarCategoria.Text = "Filtrar Categoria";
            this.btnFiltrarCategoria.UseVisualStyleBackColor = true;
            this.btnFiltrarCategoria.Click += new System.EventHandler(this.btnFiltrarCategoria_Click);
            // 
            // txtPrecoMax
            // 
            this.txtPrecoMax.Location = new System.Drawing.Point(628, 162);
            this.txtPrecoMax.Name = "txtPrecoMax";
            this.txtPrecoMax.Size = new System.Drawing.Size(83, 20);
            this.txtPrecoMax.TabIndex = 10;
            // 
            // txtPrecoMin
            // 
            this.txtPrecoMin.Location = new System.Drawing.Point(626, 200);
            this.txtPrecoMin.Name = "txtPrecoMin";
            this.txtPrecoMin.Size = new System.Drawing.Size(85, 20);
            this.txtPrecoMin.TabIndex = 11;
            // 
            // lbPrecoMax
            // 
            this.lbPrecoMax.AutoSize = true;
            this.lbPrecoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoMax.Location = new System.Drawing.Point(516, 162);
            this.lbPrecoMax.Name = "lbPrecoMax";
            this.lbPrecoMax.Size = new System.Drawing.Size(93, 16);
            this.lbPrecoMax.TabIndex = 12;
            this.lbPrecoMax.Text = "Preço Maximo";
            // 
            // lbPrecoMin
            // 
            this.lbPrecoMin.AutoSize = true;
            this.lbPrecoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoMin.Location = new System.Drawing.Point(517, 200);
            this.lbPrecoMin.Name = "lbPrecoMin";
            this.lbPrecoMin.Size = new System.Drawing.Size(103, 16);
            this.lbPrecoMin.TabIndex = 13;
            this.lbPrecoMin.Text = "Preço Minimimo";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(675, 109);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(162, 20);
            this.txtCategoria.TabIndex = 14;
            // 
            // btnBuscarFavorito
            // 
            this.btnBuscarFavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFavorito.Location = new System.Drawing.Point(659, 36);
            this.btnBuscarFavorito.Name = "btnBuscarFavorito";
            this.btnBuscarFavorito.Size = new System.Drawing.Size(119, 31);
            this.btnBuscarFavorito.TabIndex = 15;
            this.btnBuscarFavorito.Text = "Filtrar Favorito";
            this.btnBuscarFavorito.UseVisualStyleBackColor = true;
            this.btnBuscarFavorito.Click += new System.EventHandler(this.btnBuscarFavorito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.btnBuscarFavorito);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lbPrecoMin);
            this.Controls.Add(this.lbPrecoMax);
            this.Controls.Add(this.txtPrecoMin);
            this.Controls.Add(this.txtPrecoMax);
            this.Controls.Add(this.btnFiltrarCategoria);
            this.Controls.Add(this.btnFiltrarPreco);
            this.Controls.Add(this.btnFavorito);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btnFavorito;
        private System.Windows.Forms.Button btnFiltrarPreco;
        private System.Windows.Forms.Button btnFiltrarCategoria;
        private System.Windows.Forms.TextBox txtPrecoMax;
        private System.Windows.Forms.TextBox txtPrecoMin;
        private System.Windows.Forms.Label lbPrecoMax;
        private System.Windows.Forms.Label lbPrecoMin;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnBuscarFavorito;
    }
}


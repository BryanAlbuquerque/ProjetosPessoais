namespace StorageProject
{
    partial class TelaPrincipal
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
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnGestao = new System.Windows.Forms.Button();
            this.btnBaixa = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(301, 173);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(155, 36);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnGestao
            // 
            this.btnGestao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestao.Location = new System.Drawing.Point(301, 118);
            this.btnGestao.Name = "btnGestao";
            this.btnGestao.Size = new System.Drawing.Size(155, 36);
            this.btnGestao.TabIndex = 2;
            this.btnGestao.Text = "Gestão de Estoque";
            this.btnGestao.UseVisualStyleBackColor = true;
            this.btnGestao.Click += new System.EventHandler(this.btnGestao_Click);
            // 
            // btnBaixa
            // 
            this.btnBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixa.Location = new System.Drawing.Point(301, 228);
            this.btnBaixa.Name = "btnBaixa";
            this.btnBaixa.Size = new System.Drawing.Size(155, 36);
            this.btnBaixa.TabIndex = 3;
            this.btnBaixa.Text = "Baixa";
            this.btnBaixa.UseVisualStyleBackColor = true;
            this.btnBaixa.Click += new System.EventHandler(this.btnBaixa_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(301, 284);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(155, 36);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Movimentação (Endereçamento)";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 36);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnBaixa);
            this.Controls.Add(this.btnGestao);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnVoltar);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnGestao;
        private System.Windows.Forms.Button btnBaixa;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnVoltar;
    }
}
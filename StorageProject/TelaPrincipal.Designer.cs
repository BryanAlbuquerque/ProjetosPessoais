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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnGestao = new System.Windows.Forms.Button();
            this.btnBaixa = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBaixaPL = new System.Windows.Forms.TextBox();
            this.btnEnviarBaixa = new System.Windows.Forms.Button();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblPallet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTituloBaixa = new System.Windows.Forms.Label();
            this.btnEnviarEnd = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtEnderecoPL = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblPallet2 = new System.Windows.Forms.Label();
            this.lblTituloEnd = new System.Windows.Forms.Label();
            this.PicBoxBaixa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.Navy;
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(12, 207);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(130, 36);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnGestao
            // 
            this.btnGestao.BackColor = System.Drawing.Color.Navy;
            this.btnGestao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestao.ForeColor = System.Drawing.Color.White;
            this.btnGestao.Location = new System.Drawing.Point(12, 145);
            this.btnGestao.Name = "btnGestao";
            this.btnGestao.Size = new System.Drawing.Size(130, 46);
            this.btnGestao.TabIndex = 2;
            this.btnGestao.Text = "Gestão do Estoque";
            this.btnGestao.UseVisualStyleBackColor = false;
            this.btnGestao.Click += new System.EventHandler(this.btnGestao_Click);
            // 
            // btnBaixa
            // 
            this.btnBaixa.BackColor = System.Drawing.Color.Navy;
            this.btnBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixa.ForeColor = System.Drawing.Color.White;
            this.btnBaixa.Location = new System.Drawing.Point(12, 258);
            this.btnBaixa.Name = "btnBaixa";
            this.btnBaixa.Size = new System.Drawing.Size(130, 36);
            this.btnBaixa.TabIndex = 3;
            this.btnBaixa.Text = "Baixa";
            this.btnBaixa.UseVisualStyleBackColor = false;
            this.btnBaixa.Click += new System.EventHandler(this.btnBaixa_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Navy;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(12, 312);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(141, 36);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Movimentação (Endereçamento)";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVoltar.Location = new System.Drawing.Point(817, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 36);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Navy;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-1, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 576);
            this.listBox1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 37);
            this.label8.TabIndex = 60;
            this.label8.Text = "Storage Control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // txtBaixaPL
            // 
            this.txtBaixaPL.Location = new System.Drawing.Point(268, 229);
            this.txtBaixaPL.Name = "txtBaixaPL";
            this.txtBaixaPL.Size = new System.Drawing.Size(100, 20);
            this.txtBaixaPL.TabIndex = 65;
            this.txtBaixaPL.Visible = false;
            // 
            // btnEnviarBaixa
            // 
            this.btnEnviarBaixa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEnviarBaixa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarBaixa.Location = new System.Drawing.Point(257, 329);
            this.btnEnviarBaixa.Name = "btnEnviarBaixa";
            this.btnEnviarBaixa.Size = new System.Drawing.Size(125, 26);
            this.btnEnviarBaixa.TabIndex = 64;
            this.btnEnviarBaixa.Text = "Enviar";
            this.btnEnviarBaixa.UseVisualStyleBackColor = false;
            this.btnEnviarBaixa.Visible = false;
            this.btnEnviarBaixa.Click += new System.EventHandler(this.btnEnviarBaixa_Click);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(265, 266);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(101, 18);
            this.lblQtde.TabIndex = 63;
            this.lblQtde.Text = "Quantidade";
            this.lblQtde.Visible = false;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(268, 288);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 62;
            this.txtQtde.Visible = false;
            // 
            // lblPallet
            // 
            this.lblPallet.AutoSize = true;
            this.lblPallet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallet.Location = new System.Drawing.Point(265, 208);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(70, 18);
            this.lblPallet.TabIndex = 67;
            this.lblPallet.Text = "PalletID";
            this.lblPallet.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "_________________________________________________________________________";
            // 
            // lblTituloBaixa
            // 
            this.lblTituloBaixa.AutoSize = true;
            this.lblTituloBaixa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBaixa.Location = new System.Drawing.Point(231, 173);
            this.lblTituloBaixa.Name = "lblTituloBaixa";
            this.lblTituloBaixa.Size = new System.Drawing.Size(201, 18);
            this.lblTituloBaixa.TabIndex = 69;
            this.lblTituloBaixa.Text = "Realizar baixa Sistemica";
            this.lblTituloBaixa.Visible = false;
            // 
            // btnEnviarEnd
            // 
            this.btnEnviarEnd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEnviarEnd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEnd.Location = new System.Drawing.Point(691, 307);
            this.btnEnviarEnd.Name = "btnEnviarEnd";
            this.btnEnviarEnd.Size = new System.Drawing.Size(124, 25);
            this.btnEnviarEnd.TabIndex = 75;
            this.btnEnviarEnd.Text = "Enviar";
            this.btnEnviarEnd.UseVisualStyleBackColor = false;
            this.btnEnviarEnd.Visible = false;
            this.btnEnviarEnd.Click += new System.EventHandler(this.btnEnviarEnd_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(699, 272);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 74;
            this.txtEnd.Visible = false;
            // 
            // txtEnderecoPL
            // 
            this.txtEnderecoPL.Location = new System.Drawing.Point(699, 214);
            this.txtEnderecoPL.Name = "txtEnderecoPL";
            this.txtEnderecoPL.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoPL.TabIndex = 73;
            this.txtEnderecoPL.Visible = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(695, 249);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(86, 18);
            this.lblEnd.TabIndex = 72;
            this.lblEnd.Text = "Endereço";
            this.lblEnd.Visible = false;
            // 
            // lblPallet2
            // 
            this.lblPallet2.AutoSize = true;
            this.lblPallet2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallet2.Location = new System.Drawing.Point(697, 193);
            this.lblPallet2.Name = "lblPallet2";
            this.lblPallet2.Size = new System.Drawing.Size(70, 18);
            this.lblPallet2.TabIndex = 71;
            this.lblPallet2.Text = "PalletID";
            this.lblPallet2.Visible = false;
            // 
            // lblTituloEnd
            // 
            this.lblTituloEnd.AutoSize = true;
            this.lblTituloEnd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEnd.Location = new System.Drawing.Point(671, 158);
            this.lblTituloEnd.Name = "lblTituloEnd";
            this.lblTituloEnd.Size = new System.Drawing.Size(231, 18);
            this.lblTituloEnd.TabIndex = 70;
            this.lblTituloEnd.Text = "Endereçamento de Insumos";
            this.lblTituloEnd.Visible = false;
            // 
            // PicBoxBaixa
            // 
            this.PicBoxBaixa.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxBaixa.Image")));
            this.PicBoxBaixa.Location = new System.Drawing.Point(615, 370);
            this.PicBoxBaixa.Name = "PicBoxBaixa";
            this.PicBoxBaixa.Size = new System.Drawing.Size(316, 206);
            this.PicBoxBaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxBaixa.TabIndex = 76;
            this.PicBoxBaixa.TabStop = false;
            this.PicBoxBaixa.Visible = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 577);
            this.Controls.Add(this.PicBoxBaixa);
            this.Controls.Add(this.btnEnviarEnd);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtEnderecoPL);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblPallet2);
            this.Controls.Add(this.lblTituloEnd);
            this.Controls.Add(this.lblTituloBaixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPallet);
            this.Controls.Add(this.txtBaixaPL);
            this.Controls.Add(this.btnEnviarBaixa);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnBaixa);
            this.Controls.Add(this.btnGestao);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnGestao;
        private System.Windows.Forms.Button btnBaixa;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBaixaPL;
        private System.Windows.Forms.Button btnEnviarBaixa;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblPallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTituloBaixa;
        private System.Windows.Forms.Button btnEnviarEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtEnderecoPL;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblPallet2;
        private System.Windows.Forms.Label lblTituloEnd;
        private System.Windows.Forms.PictureBox PicBoxBaixa;
    }
}
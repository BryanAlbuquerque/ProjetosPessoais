namespace StorageProject
{
    partial class Gestao
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
            this.dataGridGestao = new System.Windows.Forms.DataGridView();
            this.clnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtdeIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtdeAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGestao
            // 
            this.dataGridGestao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGestao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnEnd,
            this.clnPL,
            this.clnData,
            this.clnNomeIn,
            this.clnForn,
            this.clnQtdeIni,
            this.clnValorUni,
            this.clnValorTotal,
            this.clnNF,
            this.clnNP,
            this.clnCon,
            this.clnQtdeAtual,
            this.clnColaborador});
            this.dataGridGestao.Location = new System.Drawing.Point(3, 57);
            this.dataGridGestao.Name = "dataGridGestao";
            this.dataGridGestao.Size = new System.Drawing.Size(1343, 118);
            this.dataGridGestao.TabIndex = 4;
            // 
            // clnEnd
            // 
            this.clnEnd.DataPropertyName = "Endereco";
            this.clnEnd.HeaderText = "ENDEREÇO";
            this.clnEnd.Name = "clnEnd";
            this.clnEnd.ReadOnly = true;
            // 
            // clnPL
            // 
            this.clnPL.DataPropertyName = "PalletID";
            this.clnPL.HeaderText = "PALLET ID";
            this.clnPL.Name = "clnPL";
            this.clnPL.ReadOnly = true;
            // 
            // clnData
            // 
            this.clnData.DataPropertyName = "DataEntrada";
            this.clnData.HeaderText = "DATA DE ENTRADA";
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            // 
            // clnNomeIn
            // 
            this.clnNomeIn.DataPropertyName = "NomeInsumo";
            this.clnNomeIn.HeaderText = "NOME DO INSUMO";
            this.clnNomeIn.Name = "clnNomeIn";
            this.clnNomeIn.ReadOnly = true;
            // 
            // clnForn
            // 
            this.clnForn.DataPropertyName = "Fornecedor";
            this.clnForn.HeaderText = "FORNECEDOR";
            this.clnForn.Name = "clnForn";
            this.clnForn.ReadOnly = true;
            // 
            // clnQtdeIni
            // 
            this.clnQtdeIni.DataPropertyName = "Quantidade";
            this.clnQtdeIni.HeaderText = "QUANTIDADE";
            this.clnQtdeIni.Name = "clnQtdeIni";
            this.clnQtdeIni.ReadOnly = true;
            // 
            // clnValorUni
            // 
            this.clnValorUni.DataPropertyName = "ValorUnitario";
            this.clnValorUni.HeaderText = "VALOR UNITÁRIO";
            this.clnValorUni.Name = "clnValorUni";
            this.clnValorUni.ReadOnly = true;
            // 
            // clnValorTotal
            // 
            this.clnValorTotal.DataPropertyName = "ValorTotal";
            this.clnValorTotal.HeaderText = "VALOR TOTAL";
            this.clnValorTotal.Name = "clnValorTotal";
            this.clnValorTotal.ReadOnly = true;
            // 
            // clnNF
            // 
            this.clnNF.DataPropertyName = "NumeroNotaFiscal";
            this.clnNF.HeaderText = "NÚMERO DA NOTA FISCAL";
            this.clnNF.Name = "clnNF";
            this.clnNF.ReadOnly = true;
            // 
            // clnNP
            // 
            this.clnNP.DataPropertyName = "NumeroPedido";
            this.clnNP.HeaderText = "NÚMERO DO PEDIDO";
            this.clnNP.Name = "clnNP";
            this.clnNP.ReadOnly = true;
            // 
            // clnCon
            // 
            this.clnCon.DataPropertyName = "Consumo";
            this.clnCon.HeaderText = "CONSUMO";
            this.clnCon.Name = "clnCon";
            this.clnCon.ReadOnly = true;
            // 
            // clnQtdeAtual
            // 
            this.clnQtdeAtual.DataPropertyName = "QuantidadeAtual";
            this.clnQtdeAtual.HeaderText = "QUANTIDADE ATUAL";
            this.clnQtdeAtual.Name = "clnQtdeAtual";
            this.clnQtdeAtual.ReadOnly = true;
            // 
            // clnColaborador
            // 
            this.clnColaborador.DataPropertyName = "RE_Colaborador";
            this.clnColaborador.HeaderText = "RE DO COLABORADOR";
            this.clnColaborador.Name = "clnColaborador";
            this.clnColaborador.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 53);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar para tela Principal";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 672);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridGestao);
            this.Name = "Gestao";
            this.Text = "GESTÃO DO ESTOQUE";
            this.Load += new System.EventHandler(this.Gestao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridGestao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtdeIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtdeAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnColaborador;
        private System.Windows.Forms.Button btnVoltar;
    }
}
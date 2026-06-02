namespace ProcessamentoDeImagens
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btCarregarImagem = new System.Windows.Forms.Button();
            this.btSalvarImagem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btCarregarImagem2 = new System.Windows.Forms.Button();
            this.btMostrarImagem = new System.Windows.Forms.Button();
            this.btSomarImagens = new System.Windows.Forms.Button();
            this.btSubtrairImagens = new System.Windows.Forms.Button();
            this.numUpDown_SomaImgs = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_SubtImgs = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_MultImgs = new System.Windows.Forms.NumericUpDown();
            this.btMultiplicarImagens = new System.Windows.Forms.Button();
            this.numUpDown_DividImgs = new System.Windows.Forms.NumericUpDown();
            this.btDividirImagens = new System.Windows.Forms.Button();
            this.btGrayScale = new System.Windows.Forms.Button();
            this.btInvertHorz = new System.Windows.Forms.Button();
            this.btInvertVert = new System.Windows.Forms.Button();
            this.btDiferencaImgs = new System.Windows.Forms.Button();
            this.btBlending = new System.Windows.Forms.Button();
            this.numUpDown_Blending = new System.Windows.Forms.NumericUpDown();
            this.btMediaImgs = new System.Windows.Forms.Button();
            this.numUpDown_Limiarizacao = new System.Windows.Forms.NumericUpDown();
            this.btLimiarizacao = new System.Windows.Forms.Button();
            this.btNegativoImgs = new System.Windows.Forms.Button();
            this.btMediana = new System.Windows.Forms.Button();
            this.btAND = new System.Windows.Forms.Button();
            this.btOR = new System.Windows.Forms.Button();
            this.btNOT = new System.Windows.Forms.Button();
            this.btXOR = new System.Windows.Forms.Button();
            this.boxOpLog = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartHistOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHistFinal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btEqualizacaoHistograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SomaImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SubtImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_MultImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DividImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Blending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Limiarizacao)).BeginInit();
            this.boxOpLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(45, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(800, 48);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(244, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Location = new System.Drawing.Point(70, 223);
            this.btCarregarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Size = new System.Drawing.Size(110, 29);
            this.btCarregarImagem.TabIndex = 3;
            this.btCarregarImagem.Text = "Carregar imagem";
            this.btCarregarImagem.UseVisualStyleBackColor = true;
            this.btCarregarImagem.Click += new System.EventHandler(this.btCarregarImagem_Click);
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.Location = new System.Drawing.Point(834, 223);
            this.btSalvarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(93, 29);
            this.btSalvarImagem.TabIndex = 4;
            this.btSalvarImagem.Text = "Salvar imagem";
            this.btSalvarImagem.UseVisualStyleBackColor = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // btCarregarImagem2
            // 
            this.btCarregarImagem2.Location = new System.Drawing.Point(269, 223);
            this.btCarregarImagem2.Margin = new System.Windows.Forms.Padding(2);
            this.btCarregarImagem2.Name = "btCarregarImagem2";
            this.btCarregarImagem2.Size = new System.Drawing.Size(110, 29);
            this.btCarregarImagem2.TabIndex = 5;
            this.btCarregarImagem2.Text = "Carregar imagem";
            this.btCarregarImagem2.UseVisualStyleBackColor = true;
            this.btCarregarImagem2.Click += new System.EventHandler(this.btCarregarImagem2_Click);
            // 
            // btMostrarImagem
            // 
            this.btMostrarImagem.Location = new System.Drawing.Point(0, 0);
            this.btMostrarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btMostrarImagem.Name = "btMostrarImagem";
            this.btMostrarImagem.Size = new System.Drawing.Size(38, 12);
            this.btMostrarImagem.TabIndex = 0;
            // 
            // btSomarImagens
            // 
            this.btSomarImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomarImagens.Location = new System.Drawing.Point(5, 16);
            this.btSomarImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btSomarImagens.Name = "btSomarImagens";
            this.btSomarImagens.Size = new System.Drawing.Size(80, 30);
            this.btSomarImagens.TabIndex = 6;
            this.btSomarImagens.Text = "Adição";
            this.btSomarImagens.UseVisualStyleBackColor = true;
            this.btSomarImagens.Click += new System.EventHandler(this.btSomarImagens_Click);
            // 
            // btSubtrairImagens
            // 
            this.btSubtrairImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtrairImagens.Location = new System.Drawing.Point(5, 50);
            this.btSubtrairImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btSubtrairImagens.Name = "btSubtrairImagens";
            this.btSubtrairImagens.Size = new System.Drawing.Size(80, 30);
            this.btSubtrairImagens.TabIndex = 7;
            this.btSubtrairImagens.Text = "Subtração";
            this.btSubtrairImagens.UseVisualStyleBackColor = true;
            this.btSubtrairImagens.Click += new System.EventHandler(this.btSubtrairImagens_Click);
            // 
            // numUpDown_SomaImgs
            // 
            this.numUpDown_SomaImgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_SomaImgs.Location = new System.Drawing.Point(89, 24);
            this.numUpDown_SomaImgs.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown_SomaImgs.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDown_SomaImgs.Name = "numUpDown_SomaImgs";
            this.numUpDown_SomaImgs.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_SomaImgs.TabIndex = 8;
            // 
            // numUpDown_SubtImgs
            // 
            this.numUpDown_SubtImgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_SubtImgs.Location = new System.Drawing.Point(89, 57);
            this.numUpDown_SubtImgs.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown_SubtImgs.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDown_SubtImgs.Name = "numUpDown_SubtImgs";
            this.numUpDown_SubtImgs.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_SubtImgs.TabIndex = 9;
            // 
            // numUpDown_MultImgs
            // 
            this.numUpDown_MultImgs.DecimalPlaces = 2;
            this.numUpDown_MultImgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_MultImgs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_MultImgs.Location = new System.Drawing.Point(89, 91);
            this.numUpDown_MultImgs.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown_MultImgs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_MultImgs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_MultImgs.Name = "numUpDown_MultImgs";
            this.numUpDown_MultImgs.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_MultImgs.TabIndex = 11;
            this.numUpDown_MultImgs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btMultiplicarImagens
            // 
            this.btMultiplicarImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicarImagens.Location = new System.Drawing.Point(5, 84);
            this.btMultiplicarImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btMultiplicarImagens.Name = "btMultiplicarImagens";
            this.btMultiplicarImagens.Size = new System.Drawing.Size(80, 30);
            this.btMultiplicarImagens.TabIndex = 10;
            this.btMultiplicarImagens.Text = "Multiplicação";
            this.btMultiplicarImagens.UseVisualStyleBackColor = true;
            this.btMultiplicarImagens.Click += new System.EventHandler(this.btMultiplicarImagens_Click);
            // 
            // numUpDown_DividImgs
            // 
            this.numUpDown_DividImgs.DecimalPlaces = 2;
            this.numUpDown_DividImgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_DividImgs.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numUpDown_DividImgs.Location = new System.Drawing.Point(89, 124);
            this.numUpDown_DividImgs.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown_DividImgs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_DividImgs.Name = "numUpDown_DividImgs";
            this.numUpDown_DividImgs.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_DividImgs.TabIndex = 13;
            this.numUpDown_DividImgs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btDividirImagens
            // 
            this.btDividirImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividirImagens.Location = new System.Drawing.Point(5, 118);
            this.btDividirImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btDividirImagens.Name = "btDividirImagens";
            this.btDividirImagens.Size = new System.Drawing.Size(80, 30);
            this.btDividirImagens.TabIndex = 12;
            this.btDividirImagens.Text = "Divisão";
            this.btDividirImagens.UseVisualStyleBackColor = true;
            // 
            // btGrayScale
            // 
            this.btGrayScale.Location = new System.Drawing.Point(256, 421);
            this.btGrayScale.Margin = new System.Windows.Forms.Padding(2);
            this.btGrayScale.Name = "btGrayScale";
            this.btGrayScale.Size = new System.Drawing.Size(110, 29);
            this.btGrayScale.TabIndex = 14;
            this.btGrayScale.Text = "Escala de cinza";
            this.btGrayScale.UseVisualStyleBackColor = true;
            this.btGrayScale.Click += new System.EventHandler(this.btGrayScale_Click);
            // 
            // btInvertHorz
            // 
            this.btInvertHorz.Location = new System.Drawing.Point(381, 421);
            this.btInvertHorz.Margin = new System.Windows.Forms.Padding(2);
            this.btInvertHorz.Name = "btInvertHorz";
            this.btInvertHorz.Size = new System.Drawing.Size(110, 29);
            this.btInvertHorz.TabIndex = 15;
            this.btInvertHorz.Text = "Inverter Horizontal";
            this.btInvertHorz.UseVisualStyleBackColor = true;
            this.btInvertHorz.Click += new System.EventHandler(this.btInvertHorz_Click);
            // 
            // btInvertVert
            // 
            this.btInvertVert.Location = new System.Drawing.Point(506, 421);
            this.btInvertVert.Margin = new System.Windows.Forms.Padding(2);
            this.btInvertVert.Name = "btInvertVert";
            this.btInvertVert.Size = new System.Drawing.Size(110, 29);
            this.btInvertVert.TabIndex = 16;
            this.btInvertVert.Text = "Inverter Vertical";
            this.btInvertVert.UseVisualStyleBackColor = true;
            this.btInvertVert.Click += new System.EventHandler(this.btInvertVert_Click);
            // 
            // btDiferencaImgs
            // 
            this.btDiferencaImgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiferencaImgs.Location = new System.Drawing.Point(631, 416);
            this.btDiferencaImgs.Margin = new System.Windows.Forms.Padding(2);
            this.btDiferencaImgs.Name = "btDiferencaImgs";
            this.btDiferencaImgs.Size = new System.Drawing.Size(110, 38);
            this.btDiferencaImgs.TabIndex = 17;
            this.btDiferencaImgs.Text = "Diferenca entre imagens";
            this.btDiferencaImgs.UseVisualStyleBackColor = true;
            this.btDiferencaImgs.Click += new System.EventHandler(this.btDiferencaImgs_Click);
            // 
            // btBlending
            // 
            this.btBlending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBlending.Location = new System.Drawing.Point(5, 186);
            this.btBlending.Margin = new System.Windows.Forms.Padding(2);
            this.btBlending.Name = "btBlending";
            this.btBlending.Size = new System.Drawing.Size(80, 30);
            this.btBlending.TabIndex = 18;
            this.btBlending.Text = "Blending";
            this.btBlending.UseVisualStyleBackColor = true;
            this.btBlending.Click += new System.EventHandler(this.btBlending_Click);
            // 
            // numUpDown_Blending
            // 
            this.numUpDown_Blending.DecimalPlaces = 2;
            this.numUpDown_Blending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_Blending.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_Blending.Location = new System.Drawing.Point(89, 193);
            this.numUpDown_Blending.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown_Blending.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_Blending.Name = "numUpDown_Blending";
            this.numUpDown_Blending.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_Blending.TabIndex = 19;
            this.numUpDown_Blending.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // btMediaImgs
            // 
            this.btMediaImgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMediaImgs.Location = new System.Drawing.Point(5, 152);
            this.btMediaImgs.Margin = new System.Windows.Forms.Padding(2);
            this.btMediaImgs.Name = "btMediaImgs";
            this.btMediaImgs.Size = new System.Drawing.Size(80, 30);
            this.btMediaImgs.TabIndex = 20;
            this.btMediaImgs.Text = "Média";
            this.btMediaImgs.UseVisualStyleBackColor = true;
            this.btMediaImgs.Click += new System.EventHandler(this.btMediaImgs_Click);
            // 
            // numUpDown_Limiarizacao
            // 
            this.numUpDown_Limiarizacao.Location = new System.Drawing.Point(542, 313);
            this.numUpDown_Limiarizacao.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown_Limiarizacao.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDown_Limiarizacao.Name = "numUpDown_Limiarizacao";
            this.numUpDown_Limiarizacao.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_Limiarizacao.TabIndex = 22;
            // 
            // btLimiarizacao
            // 
            this.btLimiarizacao.Location = new System.Drawing.Point(425, 307);
            this.btLimiarizacao.Margin = new System.Windows.Forms.Padding(2);
            this.btLimiarizacao.Name = "btLimiarizacao";
            this.btLimiarizacao.Size = new System.Drawing.Size(110, 29);
            this.btLimiarizacao.TabIndex = 21;
            this.btLimiarizacao.Text = "Limiarização";
            this.btLimiarizacao.UseVisualStyleBackColor = true;
            this.btLimiarizacao.Click += new System.EventHandler(this.btLimiarizacao_Click);
            // 
            // btNegativoImgs
            // 
            this.btNegativoImgs.Location = new System.Drawing.Point(381, 473);
            this.btNegativoImgs.Margin = new System.Windows.Forms.Padding(2);
            this.btNegativoImgs.Name = "btNegativoImgs";
            this.btNegativoImgs.Size = new System.Drawing.Size(110, 29);
            this.btNegativoImgs.TabIndex = 23;
            this.btNegativoImgs.Text = "Negativo";
            this.btNegativoImgs.UseVisualStyleBackColor = true;
            this.btNegativoImgs.Click += new System.EventHandler(this.btNegativoImgs_Click);
            // 
            // btMediana
            // 
            this.btMediana.Location = new System.Drawing.Point(506, 473);
            this.btMediana.Margin = new System.Windows.Forms.Padding(2);
            this.btMediana.Name = "btMediana";
            this.btMediana.Size = new System.Drawing.Size(110, 29);
            this.btMediana.TabIndex = 24;
            this.btMediana.Text = "Mediana";
            this.btMediana.UseVisualStyleBackColor = true;
            this.btMediana.Click += new System.EventHandler(this.btMediana_Click);
            // 
            // btAND
            // 
            this.btAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAND.Location = new System.Drawing.Point(5, 19);
            this.btAND.Margin = new System.Windows.Forms.Padding(2);
            this.btAND.Name = "btAND";
            this.btAND.Size = new System.Drawing.Size(50, 29);
            this.btAND.TabIndex = 25;
            this.btAND.Text = "AND";
            this.btAND.UseVisualStyleBackColor = true;
            this.btAND.Click += new System.EventHandler(this.btAND_Click);
            // 
            // btOR
            // 
            this.btOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOR.Location = new System.Drawing.Point(68, 19);
            this.btOR.Margin = new System.Windows.Forms.Padding(2);
            this.btOR.Name = "btOR";
            this.btOR.Size = new System.Drawing.Size(50, 29);
            this.btOR.TabIndex = 26;
            this.btOR.Text = "OR";
            this.btOR.UseVisualStyleBackColor = true;
            this.btOR.Click += new System.EventHandler(this.btOR_Click);
            // 
            // btNOT
            // 
            this.btNOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNOT.Location = new System.Drawing.Point(5, 58);
            this.btNOT.Margin = new System.Windows.Forms.Padding(2);
            this.btNOT.Name = "btNOT";
            this.btNOT.Size = new System.Drawing.Size(50, 29);
            this.btNOT.TabIndex = 27;
            this.btNOT.Text = "NOT";
            this.btNOT.UseVisualStyleBackColor = true;
            this.btNOT.Click += new System.EventHandler(this.btNOT_Click);
            // 
            // btXOR
            // 
            this.btXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXOR.Location = new System.Drawing.Point(68, 58);
            this.btXOR.Margin = new System.Windows.Forms.Padding(2);
            this.btXOR.Name = "btXOR";
            this.btXOR.Size = new System.Drawing.Size(50, 29);
            this.btXOR.TabIndex = 28;
            this.btXOR.Text = "XOR";
            this.btXOR.UseVisualStyleBackColor = true;
            this.btXOR.Click += new System.EventHandler(this.btXOR_Click);
            // 
            // boxOpLog
            // 
            this.boxOpLog.Controls.Add(this.btAND);
            this.boxOpLog.Controls.Add(this.btOR);
            this.boxOpLog.Controls.Add(this.btNOT);
            this.boxOpLog.Controls.Add(this.btXOR);
            this.boxOpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOpLog.Location = new System.Drawing.Point(607, 48);
            this.boxOpLog.Name = "boxOpLog";
            this.boxOpLog.Size = new System.Drawing.Size(125, 94);
            this.boxOpLog.TabIndex = 29;
            this.boxOpLog.TabStop = false;
            this.boxOpLog.Text = "Operações lógicas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSomarImagens);
            this.groupBox1.Controls.Add(this.numUpDown_SomaImgs);
            this.groupBox1.Controls.Add(this.btSubtrairImagens);
            this.groupBox1.Controls.Add(this.numUpDown_SubtImgs);
            this.groupBox1.Controls.Add(this.btMultiplicarImagens);
            this.groupBox1.Controls.Add(this.numUpDown_MultImgs);
            this.groupBox1.Controls.Add(this.numUpDown_Blending);
            this.groupBox1.Controls.Add(this.btMediaImgs);
            this.groupBox1.Controls.Add(this.btBlending);
            this.groupBox1.Controls.Add(this.btDividirImagens);
            this.groupBox1.Controls.Add(this.numUpDown_DividImgs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(443, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 220);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações Aritméticas";
            // 
            // chartHistOriginal
            // 
            this.chartHistOriginal.BorderlineColor = System.Drawing.Color.LightGray;
            this.chartHistOriginal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartHistOriginal.Location = new System.Drawing.Point(22, 277);
            this.chartHistOriginal.Name = "chartHistOriginal";
            this.chartHistOriginal.Size = new System.Drawing.Size(210, 130);
            this.chartHistOriginal.TabIndex = 31;
            this.chartHistOriginal.Text = "Histograma Original";
            // 
            // chartHistFinal
            // 
            this.chartHistFinal.BorderlineColor = System.Drawing.Color.LightGray;
            this.chartHistFinal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartHistFinal.Location = new System.Drawing.Point(775, 276);
            this.chartHistFinal.Name = "chartHistFinal";
            this.chartHistFinal.Size = new System.Drawing.Size(210, 130);
            this.chartHistFinal.TabIndex = 32;
            this.chartHistFinal.Text = "Histograma Equalizado";
            // 
            // btEqualizacaoHistograma
            // 
            this.btEqualizacaoHistograma.Location = new System.Drawing.Point(631, 473);
            this.btEqualizacaoHistograma.Margin = new System.Windows.Forms.Padding(2);
            this.btEqualizacaoHistograma.Name = "btEqualizacaoHistograma";
            this.btEqualizacaoHistograma.Size = new System.Drawing.Size(110, 29);
            this.btEqualizacaoHistograma.TabIndex = 35;
            this.btEqualizacaoHistograma.Text = "Equalização";
            this.btEqualizacaoHistograma.UseVisualStyleBackColor = true;
            this.btEqualizacaoHistograma.Click += new System.EventHandler(this.btEqualizacaoHistograma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 658);
            this.Controls.Add(this.btEqualizacaoHistograma);
            this.Controls.Add(this.chartHistFinal);
            this.Controls.Add(this.chartHistOriginal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxOpLog);
            this.Controls.Add(this.btMediana);
            this.Controls.Add(this.btNegativoImgs);
            this.Controls.Add(this.numUpDown_Limiarizacao);
            this.Controls.Add(this.btLimiarizacao);
            this.Controls.Add(this.btDiferencaImgs);
            this.Controls.Add(this.btInvertVert);
            this.Controls.Add(this.btInvertHorz);
            this.Controls.Add(this.btGrayScale);
            this.Controls.Add(this.btMostrarImagem);
            this.Controls.Add(this.btCarregarImagem2);
            this.Controls.Add(this.btSalvarImagem);
            this.Controls.Add(this.btCarregarImagem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SomaImgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SubtImgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_MultImgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DividImgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Blending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Limiarizacao)).EndInit();
            this.boxOpLog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btCarregarImagem;
        private System.Windows.Forms.Button btSalvarImagem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btCarregarImagem2;
        private System.Windows.Forms.Button btMostrarImagem;
        private System.Windows.Forms.Button btSomarImagens;
        private System.Windows.Forms.Button btSubtrairImagens;
        private System.Windows.Forms.NumericUpDown numUpDown_SomaImgs;
        private System.Windows.Forms.NumericUpDown numUpDown_SubtImgs;
        private System.Windows.Forms.NumericUpDown numUpDown_MultImgs;
        private System.Windows.Forms.Button btMultiplicarImagens;
        private System.Windows.Forms.NumericUpDown numUpDown_DividImgs;
        private System.Windows.Forms.Button btDividirImagens;
        private System.Windows.Forms.Button btGrayScale;
        private System.Windows.Forms.Button btInvertHorz;
        private System.Windows.Forms.Button btInvertVert;
        private System.Windows.Forms.Button btDiferencaImgs;
        private System.Windows.Forms.Button btBlending;
        private System.Windows.Forms.NumericUpDown numUpDown_Blending;
        private System.Windows.Forms.Button btMediaImgs;
        private System.Windows.Forms.NumericUpDown numUpDown_Limiarizacao;
        private System.Windows.Forms.Button btLimiarizacao;
        private System.Windows.Forms.Button btNegativoImgs;
        private System.Windows.Forms.Button btMediana;
        private System.Windows.Forms.Button btAND;
        private System.Windows.Forms.Button btOR;
        private System.Windows.Forms.Button btNOT;
        private System.Windows.Forms.Button btXOR;
        private System.Windows.Forms.GroupBox boxOpLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistOriginal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistFinal;
        private System.Windows.Forms.Button btEqualizacaoHistograma;
    }
}


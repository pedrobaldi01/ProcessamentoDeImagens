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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SomaImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SubtImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_MultImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DividImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Blending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Limiarizacao)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(50, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(610, 48);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 157);
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
            this.pictureBox2.Size = new System.Drawing.Size(151, 157);
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
            this.btSalvarImagem.Location = new System.Drawing.Point(639, 223);
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
            this.btCarregarImagem2.Location = new System.Drawing.Point(265, 223);
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
            this.btSomarImagens.Location = new System.Drawing.Point(50, 306);
            this.btSomarImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btSomarImagens.Name = "btSomarImagens";
            this.btSomarImagens.Size = new System.Drawing.Size(110, 29);
            this.btSomarImagens.TabIndex = 6;
            this.btSomarImagens.Text = "Somar imagens";
            this.btSomarImagens.UseVisualStyleBackColor = true;
            this.btSomarImagens.Click += new System.EventHandler(this.btSomarImagens_Click);
            // 
            // btSubtrairImagens
            // 
            this.btSubtrairImagens.Location = new System.Drawing.Point(50, 356);
            this.btSubtrairImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btSubtrairImagens.Name = "btSubtrairImagens";
            this.btSubtrairImagens.Size = new System.Drawing.Size(110, 29);
            this.btSubtrairImagens.TabIndex = 7;
            this.btSubtrairImagens.Text = "Subtrair imagens";
            this.btSubtrairImagens.UseVisualStyleBackColor = true;
            this.btSubtrairImagens.Click += new System.EventHandler(this.btSubtrairImagens_Click);
            // 
            // numUpDown_SomaImgs
            // 
            this.numUpDown_SomaImgs.Location = new System.Drawing.Point(167, 313);
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
            this.numUpDown_SubtImgs.Location = new System.Drawing.Point(167, 363);
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
            this.numUpDown_MultImgs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_MultImgs.Location = new System.Drawing.Point(362, 313);
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
            this.btMultiplicarImagens.Location = new System.Drawing.Point(244, 306);
            this.btMultiplicarImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btMultiplicarImagens.Name = "btMultiplicarImagens";
            this.btMultiplicarImagens.Size = new System.Drawing.Size(110, 29);
            this.btMultiplicarImagens.TabIndex = 10;
            this.btMultiplicarImagens.Text = "Multiplicar imagens";
            this.btMultiplicarImagens.UseVisualStyleBackColor = true;
            this.btMultiplicarImagens.Click += new System.EventHandler(this.btMultiplicarImagens_Click);
            // 
            // numUpDown_DividImgs
            // 
            this.numUpDown_DividImgs.DecimalPlaces = 2;
            this.numUpDown_DividImgs.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numUpDown_DividImgs.Location = new System.Drawing.Point(362, 363);
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
            this.btDividirImagens.Location = new System.Drawing.Point(244, 356);
            this.btDividirImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btDividirImagens.Name = "btDividirImagens";
            this.btDividirImagens.Size = new System.Drawing.Size(110, 29);
            this.btDividirImagens.TabIndex = 12;
            this.btDividirImagens.Text = "Dividir imagens";
            this.btDividirImagens.UseVisualStyleBackColor = true;
            // 
            // btGrayScale
            // 
            this.btGrayScale.Location = new System.Drawing.Point(50, 410);
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
            this.btInvertHorz.Location = new System.Drawing.Point(175, 410);
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
            this.btInvertVert.Location = new System.Drawing.Point(300, 410);
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
            this.btDiferencaImgs.Location = new System.Drawing.Point(425, 405);
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
            this.btBlending.Location = new System.Drawing.Point(425, 356);
            this.btBlending.Margin = new System.Windows.Forms.Padding(2);
            this.btBlending.Name = "btBlending";
            this.btBlending.Size = new System.Drawing.Size(110, 29);
            this.btBlending.TabIndex = 18;
            this.btBlending.Text = "Blending";
            this.btBlending.UseVisualStyleBackColor = true;
            this.btBlending.Click += new System.EventHandler(this.btBlending_Click);
            // 
            // numUpDown_Blending
            // 
            this.numUpDown_Blending.DecimalPlaces = 2;
            this.numUpDown_Blending.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_Blending.Location = new System.Drawing.Point(542, 362);
            this.numUpDown_Blending.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown_Blending.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_Blending.Name = "numUpDown_Blending";
            this.numUpDown_Blending.Size = new System.Drawing.Size(47, 20);
            this.numUpDown_Blending.TabIndex = 19;
            // 
            // btMediaImgs
            // 
            this.btMediaImgs.Location = new System.Drawing.Point(551, 414);
            this.btMediaImgs.Margin = new System.Windows.Forms.Padding(2);
            this.btMediaImgs.Name = "btMediaImgs";
            this.btMediaImgs.Size = new System.Drawing.Size(110, 29);
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
            this.btNegativoImgs.Location = new System.Drawing.Point(676, 414);
            this.btNegativoImgs.Margin = new System.Windows.Forms.Padding(2);
            this.btNegativoImgs.Name = "btNegativoImgs";
            this.btNegativoImgs.Size = new System.Drawing.Size(110, 29);
            this.btNegativoImgs.TabIndex = 23;
            this.btNegativoImgs.Text = "Negativo";
            this.btNegativoImgs.UseVisualStyleBackColor = true;
            this.btNegativoImgs.Click += new System.EventHandler(this.btNegativoImgs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.btNegativoImgs);
            this.Controls.Add(this.numUpDown_Limiarizacao);
            this.Controls.Add(this.btLimiarizacao);
            this.Controls.Add(this.btMediaImgs);
            this.Controls.Add(this.numUpDown_Blending);
            this.Controls.Add(this.btBlending);
            this.Controls.Add(this.btDiferencaImgs);
            this.Controls.Add(this.btInvertVert);
            this.Controls.Add(this.btInvertHorz);
            this.Controls.Add(this.btGrayScale);
            this.Controls.Add(this.numUpDown_DividImgs);
            this.Controls.Add(this.btDividirImagens);
            this.Controls.Add(this.numUpDown_MultImgs);
            this.Controls.Add(this.btMultiplicarImagens);
            this.Controls.Add(this.numUpDown_SubtImgs);
            this.Controls.Add(this.numUpDown_SomaImgs);
            this.Controls.Add(this.btSubtrairImagens);
            this.Controls.Add(this.btSomarImagens);
            this.Controls.Add(this.btMostrarImagem);
            this.Controls.Add(this.btCarregarImagem2);
            this.Controls.Add(this.btSalvarImagem);
            this.Controls.Add(this.btCarregarImagem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
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
    }
}


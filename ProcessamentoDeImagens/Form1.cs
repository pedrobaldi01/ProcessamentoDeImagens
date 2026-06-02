using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace ProcessamentoDeImagens
{
    public partial class Form1 : Form
    {

        Bitmap img1;
        Bitmap img2;
        Bitmap imgFinal;
        byte[,] vImg1Gray;
        byte[,] vImg2Gray;
        byte[,] vImgFinal;


        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;

        byte[,] vImg2R;
        byte[,] vImg2G;
        byte[,] vImg2B;
        byte[,] vImg2A;

        byte[,] vimgFinalR;
        byte[,] vimgFinalG;
        byte[,] vimgFinalB;
        byte[,] vimgFinalA;



        public Form1()
        {
            InitializeComponent();
        }

        private void ArmazenarImagem1EmMatrizes()
        {
            vImg1Gray = new byte[img1.Width, img1.Height];
            vImg1R = new byte[img1.Width, img1.Height];
            vImg1G = new byte[img1.Width, img1.Height];
            vImg1B = new byte[img1.Width, img1.Height];
            vImg1A = new byte[img1.Width, img1.Height];

            ArmazenarPixelsEmMatrizes(img1, vImg1Gray, vImg1R, vImg1G, vImg1B, vImg1A);
        }

        private void ArmazenarImagem2EmMatrizes()
        {
            vImg2Gray = new byte[img2.Width, img2.Height];
            vImg2R = new byte[img2.Width, img2.Height];
            vImg2G = new byte[img2.Width, img2.Height];
            vImg2B = new byte[img2.Width, img2.Height];
            vImg2A = new byte[img2.Width, img2.Height];

            ArmazenarPixelsEmMatrizes(img2, vImg2Gray, vImg2R, vImg2G, vImg2B, vImg2A);
        }

        private void ArmazenarPixelsEmMatrizes(Bitmap imagem, byte[,] matrizGray, byte[,] matrizR, byte[,] matrizG, byte[,] matrizB, byte[,] matrizA)
        {
            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    Color pixel = imagem.GetPixel(x, y);

                    matrizR[x, y] = pixel.R;
                    matrizG[x, y] = pixel.G;
                    matrizB[x, y] = pixel.B;
                    matrizA[x, y] = pixel.A;
                    matrizGray[x, y] = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                }
            }
        }

        private int[] CalcularHistograma(Bitmap img)
        {
            int[] histograma = new int[256];

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int intensidade = (pixel.R + pixel.G + pixel.B) / 3;

                    histograma[intensidade]++;
                }
            }

            return histograma;
        }

        private void MostrarHistograma(Chart chart, Bitmap img, string titulo)
        {
            int[] histograma = CalcularHistograma(img);

            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            ChartArea area = new ChartArea("AreaHistograma");
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = 255;
            area.AxisX.Interval = 51;
            area.AxisY.Minimum = 0;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 7F);
            area.AxisY.LabelStyle.Font = new Font("Microsoft Sans Serif", 7F);
            chart.ChartAreas.Add(area);

            Series serie = new Series("Pixels");
            serie.ChartType = SeriesChartType.Column;
            serie.Color = Color.RoyalBlue;
            serie.IsVisibleInLegend = false;

            for (int i = 0; i < histograma.Length; i++)
            {
                serie.Points.AddXY(i, histograma[i]);
            }

            chart.Series.Add(serie);
            chart.Titles.Add(titulo);
            chart.Titles[0].Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
        }

        private void LimparHistogramaFinal()
        {
            chartHistFinal.Series.Clear();
            chartHistFinal.ChartAreas.Clear();
            chartHistFinal.Titles.Clear();
        }

        private void ExibirImagemFinal(Bitmap imagem)
        {
            imgFinal = imagem;
            pictureBox3.Image = imgFinal;
            MostrarHistograma(chartHistFinal, imgFinal, "Histograma Final");
        }

        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    imgFinal = new Bitmap(img1.Width, img1.Height);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                    ArmazenarImagem1EmMatrizes();
                    MostrarHistograma(chartHistOriginal, img1, "Histograma Original");
                    LimparHistogramaFinal();
                }

            }
        }

        private void btCarregarImagem2_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img2 = new Bitmap(filePath);
                    imgFinal = new Bitmap(img2.Width, img2.Height);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox2.Image = img2;
                    ArmazenarImagem2EmMatrizes();

                }

            }
        }

        private void btSomarImagens_Click(object sender, EventArgs e)
        {
            int valor = (int)numUpDown_SomaImgs.Value;

            if (img1 == null && img2 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro para realizar a soma.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (valor > 0 && img1 != null && img2 != null)
            {
                MessageBox.Show("Não é possível realizar ao mesmo tempo a soma entre duas imagens e a soma de um valor constante nos pixels.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (valor > 0)
            {
                if (img1 == null)
                {
                    MessageBox.Show("Carregue a Imagem 1 para realizar a soma.",
                                    "Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                ExibirImagemFinal(AumentarBrilho(img1, valor));
                return;
            }

            if (valor == 0)
            {
                if (img1 == null || img2 == null)
                {
                    MessageBox.Show("Valor zerado, aumente o valor ou carregue duas imagens para realizar a soma.",
                                    "Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (img1.Width != img2.Width || img1.Height != img2.Height)
                {
                    MessageBox.Show("As imagens devem ter as mesmas dimensões.",
                                    "Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                ExibirImagemFinal(SomarDuasImagens(img1, img2));
                return;
            }

            MessageBox.Show("Operação inválida.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private Bitmap AumentarBrilho(Bitmap imagem, int valor)
        {
            Bitmap resultado = new Bitmap(imagem.Width, imagem.Height);

            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    Color pixel = imagem.GetPixel(x, y);

                    int r = pixel.R + valor;
                    int g = pixel.G + valor;
                    int b = pixel.B + valor;

                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;

                    Color novoPixel = Color.FromArgb(pixel.A, r, g, b);
                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        private Bitmap SomarDuasImagens(Bitmap img1, Bitmap img2)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel1 = img1.GetPixel(x, y);
                    Color pixel2 = img2.GetPixel(x, y);

                    int r = pixel1.R + pixel2.R;
                    int g = pixel1.G + pixel2.G;
                    int b = pixel1.B + pixel2.B;

                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;

                    Color novoPixel = Color.FromArgb(r, g, b);
                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        private void btSubtrairImagens_Click(object sender, EventArgs e)
        {
            int valor = (int)numUpDown_SubtImgs.Value;

            if (img1 == null && img2 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro para realizar a subtração.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (valor > 0 && img1 != null && img2 != null)
            {
                MessageBox.Show("Não é possível realizar ao mesmo tempo a operação entre duas imagens e a subtração de um valor constante nos pixels.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (valor <= 0)
            {
                if (img1 == null || img2 == null)
                {
                    MessageBox.Show("Valor zerado, aumente o valor ou carregue duas imagens para realizar a subtração.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    return;
                }

                if (img1.Width != img2.Width || img1.Height != img2.Height)
                {
                    MessageBox.Show("As imagens devem ter as mesmas dimensões.",
                                    "Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                ExibirImagemFinal(SubtrairDuasImagens(img1, img2));
                return;
            }

            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para realizar a subtração.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(DiminuirBrilho(img1, valor));
        }

        private Bitmap SubtrairDuasImagens(Bitmap img1, Bitmap img2)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel1 = img1.GetPixel(x, y);
                    Color pixel2 = img2.GetPixel(x, y);

                    int r = pixel1.R - pixel2.R;
                    int g = pixel1.G - pixel2.G;
                    int b = pixel1.B - pixel2.B;

                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;

                    Color novoPixel = Color.FromArgb(r, g, b);
                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        private Bitmap DiminuirBrilho(Bitmap img1, int valor)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    int r = pixel.R - valor;
                    int g = pixel.G - valor;
                    int b = pixel.B - valor;

                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;

                    Color novoPixel = Color.FromArgb(pixel.A, r, g, b);
                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }


        private void btMultiplicarImagens_Click(object sender, EventArgs e)
        {
            double fator = (double)numUpDown_MultImgs.Value;

            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para realizar a multiplicação.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (fator <= 0)
            {
                MessageBox.Show("Informe um valor maior que zero para realizar a multiplicação.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(MultiplicarImagem(img1, fator));
        }

        private Bitmap MultiplicarImagem(Bitmap img1, double fator)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    int r = (int)(pixel.R * fator);
                    int g = (int)(pixel.G * fator);
                    int b = (int)(pixel.B * fator);

                    // Tratamento de overflow e underflow
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;

                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;

                    Color novoPixel = Color.FromArgb(pixel.A, r, g, b);
                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        
        private void btGrayScale_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para realizar a alteração.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            ExibirImagemFinal(GrayScale(img1));
        }

        private Bitmap GrayScale(Bitmap img1)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    byte intensidade = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                    Color novoPixel = Color.FromArgb(
                        pixel.A,
                        intensidade,
                        intensidade,
                        intensidade
                    );

                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }


        private void btInvertHorz_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para realizar a alteração.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            ExibirImagemFinal(InverterHorizontal(img1));
        }

        private Bitmap InverterHorizontal(Bitmap img)
        {
            Bitmap resultado = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    int novoX = img.Width - 1 - x;

                    resultado.SetPixel(novoX, y, pixel);
                }
            }

            return resultado;
        }


        private void btInvertVert_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para realizar a alteração.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(InverterVertical(img1));
        }

        private Bitmap InverterVertical(Bitmap img)
        {
            Bitmap resultado = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    int novoY = img.Height - 1 - y;

                    resultado.SetPixel(x, novoY, pixel);
                }
            }

            return resultado;
        }


        private void btDiferencaImgs_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue duas imagens para realizar a subtração.",
                            "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }

            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter as mesmas dimensões.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(Diferenca(img1, img2));
        }

        private Bitmap Diferenca(Bitmap img1, Bitmap img2)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    int r = Math.Abs(p1.R - p2.R);
                    int g = Math.Abs(p1.G - p2.G);
                    int b = Math.Abs(p1.B - p2.B);

                    Color novoPixel = Color.FromArgb(r, g, b);

                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        // Blending
        private void btBlending_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue as duas imagens.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter o mesmo tamanho.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double alpha = (double)numUpDown_Blending.Value; // ex: 0.0 até 1.0

            ExibirImagemFinal(Blending(img1, img2, alpha));
        }

        private Bitmap Blending(Bitmap img1, Bitmap img2, double alpha)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    int r = (int)Math.Round(alpha * p1.R + (1 - alpha) * p2.R);
                    int g = (int)Math.Round(alpha * p1.G + (1 - alpha) * p2.G);
                    int b = (int)Math.Round(alpha * p1.B + (1 - alpha) * p2.B);

                    // garantir que não passe de 255
                    r = Math.Min(255, r);
                    g = Math.Min(255, g);
                    b = Math.Min(255, b);

                    Color novoPixel = Color.FromArgb(r, g, b);

                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        // Media de imagens
        private void btMediaImgs_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue as duas imagens.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter o mesmo tamanho.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(Media(img1, img2));
        }

        private Bitmap Media(Bitmap img1, Bitmap img2)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    int r = (p1.R + p2.R) / 2;
                    int g = (p1.G + p2.G) / 2;
                    int b = (p1.B + p2.B) / 2;

                    Color novoPixel = Color.FromArgb(r, g, b);

                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        // Operacoes logicas

        private void btAND_Click(object sender, EventArgs e)
        {
            if (!ValidarDuasImagens("AND"))
                return;

            ExibirImagemFinal(AND(img1, img2));
        }

        private Bitmap AND(Bitmap img1, Bitmap img2)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    int valor = ConverterPixelBinario(p1) & ConverterPixelBinario(p2);

                    resultado.SetPixel(x, y, Color.FromArgb(valor, valor, valor));
                }
            }

            return resultado;
        }

        private void btOR_Click(object sender, EventArgs e)
        {
            if (!ValidarDuasImagens("OR"))
                return;

            ExibirImagemFinal(OR(img1, img2));
        }

        private Bitmap OR(Bitmap img1, Bitmap img2)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    int valor = ConverterPixelBinario(p1) | ConverterPixelBinario(p2);

                    resultado.SetPixel(x, y, Color.FromArgb(valor, valor, valor));
                }
            }

            return resultado;
        }

        private void btNOT_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para realizar a operação NOT.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(NOT(img1));
        }

        private Bitmap NOT(Bitmap img)
        {
            Bitmap resultado = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    int valor = 255 - ConverterPixelBinario(pixel);

                    resultado.SetPixel(x, y, Color.FromArgb(valor, valor, valor));
                }
            }

            return resultado;
        }

        private void btXOR_Click(object sender, EventArgs e)
        {
            if (!ValidarDuasImagens("XOR"))
                return;

            ExibirImagemFinal(XOR(img1, img2));
        }

        private Bitmap XOR(Bitmap img1, Bitmap img2)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    int valor = ConverterPixelBinario(p1) ^ ConverterPixelBinario(p2);

                    resultado.SetPixel(x, y, Color.FromArgb(valor, valor, valor));
                }
            }

            return resultado;
        }

        private bool ValidarDuasImagens(string operacao)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue duas imagens para realizar a operação " + operacao + ".",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter as mesmas dimensões.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int ConverterPixelBinario(Color pixel)
        {
            int intensidade = (pixel.R + pixel.G + pixel.B) / 3;

            if (intensidade >= 128)
                return 255;

            return 0;
        }

        private void btLimiarizacao_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int limiar = (int)numUpDown_Limiarizacao.Value;

            ExibirImagemFinal(Limiarizacao(img1, limiar));
        }

        private Bitmap Limiarizacao(Bitmap img, int limiar)
        {
            Bitmap resultado = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    int intensidade = (pixel.R + pixel.G + pixel.B) / 3;

                    Color novoPixel;

                    if (intensidade >= limiar)
                        novoPixel = Color.White;
                    else
                        novoPixel = Color.Black;

                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }


        private void btNegativoImgs_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(Negativo(img1));
        }

        private Bitmap Negativo(Bitmap img)
        {
            Bitmap resultado = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;

                    Color novoPixel = Color.FromArgb(pixel.A, r, g, b);

                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }

        private void btEqualizacaoHistograma_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para aplicar a equalização de histograma.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(EqualizarHistograma(img1));
        }

        private Bitmap EqualizarHistograma(Bitmap img)
        {
            Bitmap resultado = new Bitmap(img.Width, img.Height);
            int[] histograma = CalcularHistograma(img);
            int[] acumulado = new int[256];

            acumulado[0] = histograma[0];

            for (int i = 1; i < histograma.Length; i++)
            {
                acumulado[i] = acumulado[i - 1] + histograma[i];
            }

            int totalPixels = img.Width * img.Height;
            int acumuladoMinimo = 0;

            for (int i = 0; i < acumulado.Length; i++)
            {
                if (acumulado[i] > 0)
                {
                    acumuladoMinimo = acumulado[i];
                    break;
                }
            }

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int intensidade = (pixel.R + pixel.G + pixel.B) / 3;
                    int novoValor;

                    if (totalPixels == acumuladoMinimo)
                    {
                        novoValor = intensidade;
                    }
                    else
                    {
                        novoValor = (int)Math.Round(((double)(acumulado[intensidade] - acumuladoMinimo) / (totalPixels - acumuladoMinimo)) * 255);
                    }

                    if (novoValor < 0) novoValor = 0;
                    if (novoValor > 255) novoValor = 255;

                    resultado.SetPixel(x, y, Color.FromArgb(pixel.A, novoValor, novoValor, novoValor));
                }
            }

            return resultado;
        }

        private void btMediana_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a Imagem 1 para aplicar o filtro de mediana.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ExibirImagemFinal(FiltroMediana(img1));
        }

        private Bitmap FiltroMediana(Bitmap img)
        {
            Bitmap resultado = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    resultado.SetPixel(x, y, img.GetPixel(x, y));
                }
            }

            for (int x = 1; x < img.Width - 1; x++)
            {
                for (int y = 1; y < img.Height - 1; y++)
                {
                    byte[] valoresR = new byte[9];
                    byte[] valoresG = new byte[9];
                    byte[] valoresB = new byte[9];
                    int indice = 0;

                    for (int vizinhoX = x - 1; vizinhoX <= x + 1; vizinhoX++)
                    {
                        for (int vizinhoY = y - 1; vizinhoY <= y + 1; vizinhoY++)
                        {
                            Color pixelVizinho = img.GetPixel(vizinhoX, vizinhoY);

                            valoresR[indice] = pixelVizinho.R;
                            valoresG[indice] = pixelVizinho.G;
                            valoresB[indice] = pixelVizinho.B;
                            indice++;
                        }
                    }

                    Array.Sort(valoresR);
                    Array.Sort(valoresG);
                    Array.Sort(valoresB);

                    Color pixelOriginal = img.GetPixel(x, y);
                    Color novoPixel = Color.FromArgb(
                        pixelOriginal.A,
                        valoresR[4],
                        valoresG[4],
                        valoresB[4]
                    );

                    resultado.SetPixel(x, y, novoPixel);
                }
            }

            return resultado;
        }


        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (imgFinal == null)
                return;

            // Configurações iniciais da saveFileDialog1
            var filePath = string.Empty;
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            ImageFormat format = imgFinal.RawFormat;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                //pictureBox3.Image.Save(saveFileDialog1.FileName, format);
                imgFinal.Save(saveFileDialog1.FileName, format);
            }
        }

    }

}

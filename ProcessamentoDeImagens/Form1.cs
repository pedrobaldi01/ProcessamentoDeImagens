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
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];
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
                    vImg2Gray = new byte[img2.Width, img2.Height];
                    vImg2R = new byte[img2.Width, img2.Height];
                    vImg2G = new byte[img2.Width, img2.Height];
                    vImg2B = new byte[img2.Width, img2.Height];
                    vImg2A = new byte[img2.Width, img2.Height];

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

                imgFinal = AumentarBrilho(img1, valor);
                pictureBox3.Image = imgFinal;
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

                imgFinal = SomarDuasImagens(img1, img2);
                pictureBox3.Image = imgFinal;
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

                imgFinal = SubtrairDuasImagens(img1, img2);
                pictureBox3.Image = imgFinal;
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

            imgFinal = DiminuirBrilho(img1, valor);
            pictureBox3.Image = imgFinal;
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

            imgFinal = MultiplicarImagem(img1, fator);
            pictureBox3.Image = imgFinal;
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
            imgFinal = GrayScale(img1);
            pictureBox3.Image = imgFinal;
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
            imgFinal = InverterHorizontal(img1);
            pictureBox3.Image = imgFinal;
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

            imgFinal = InverterVertical(img1);
            pictureBox3.Image = imgFinal;
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

            imgFinal = Diferenca(img1, img2);
            pictureBox3.Image = imgFinal;
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

            imgFinal = Blending(img1, img2, alpha);
            pictureBox3.Image = imgFinal;
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

                    int r = (int)(alpha * p1.R + (1 - alpha) * p2.R);
                    int g = (int)(alpha * p1.G + (1 - alpha) * p2.G);
                    int b = (int)(alpha * p1.B + (1 - alpha) * p2.B);

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

            imgFinal = Media(img1, img2);
            pictureBox3.Image = imgFinal;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using IMG_uploder;

namespace PCX_uploder
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>();
        Bitmap bmp;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.json"))
            {
                openWith = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("settings.json"));
            }
            else
            {
                MessageBox.Show("Settings.json non trovato");
                Close();
            }
        }
        public Form1()
        {
            InitializeComponent();
            format.SelectedIndex = 3;
        }

        Bitmap convertImg(string path, string Url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
            httpWebRequest.ContentType = "application/octet-stream";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("filename", Path.GetFileNameWithoutExtension(path));
            httpWebRequest.Headers.Add("extension", format.Text);

            using (var streamWriter = new BinaryWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(File.ReadAllBytes(path));
            }
            using (var streamReader = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            using (WebClient wc = new WebClient())
            {
                Uri myUri = new Uri(Url);
                string host = myUri.Scheme + "://" + myUri.Authority + "/" + JsonConvert.DeserializeObject<Img>(wc.DownloadString(Url)).convertedImg;
                using (var ms = new MemoryStream(wc.DownloadData(host)))
                {
                    return new Bitmap(ms);
                }
            }
        }

        private void Sfoglia_ClickAsync(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = openFileDialog1.FileName;
            }
        }

        private void SaveImg_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            bool state = false;
            label1.Text = "stato: caricamento...";
            FilePath.Refresh();
            label1.Refresh();

            try
            {
                bmp = convertImg(FilePath.Text, openWith[Path.GetExtension(FilePath.Text).ToLower()]);
                pictureBox1.Image = bmp;
                label1.Text = "stato: pronto";
                state = true;
            }
            catch (KeyNotFoundException)
            {
                label1.Text = "L'applicazione non sa quale server contattare per aprire questo file.";
            }
            catch (Exception err)
            {
                label1.Text = err.Message;
            }
            pictureBox1.Visible = state;
            SaveImg.Enabled = state;
        }
    }
}

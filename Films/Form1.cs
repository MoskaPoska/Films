using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;

namespace Films
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] kat = { "Movie", "Serial", "Episode" };
            comboBox1.Items.AddRange(kat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://www.omdbapi.com/?i=tt3896198&apikey=ae3fec7d&t=" + textBox1.Text + "&y=" + textBox2.Text;
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(url);
                JObject jobject = JObject.Parse(json);
                label3.Text = jobject.GetValue("Title").ToString();
                string imageUrl = jobject.GetValue("Poster").ToString();
                pictureBox1.Load(imageUrl);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(jobject.GetValue("Year").ToString());
                sb.AppendLine(jobject.GetValue("Released").ToString());
                sb.AppendLine(jobject.GetValue("Plot").ToString());
                sb.AppendLine(jobject.GetValue("Country").ToString());
                sb.AppendLine(jobject.GetValue("Genre").ToString());
                textBox3.Text = sb.ToString();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //<a class="pgenmed" href="viewtopic.php?t=1042301&amp;sid=30a2868fe4c3d4dca1cee4eb775d6260" title="Найдено вещество, использование которого позволит создать первые органические компьютеры">Найдено вещество, использование которого позволит создать первые органические компьютеры</a>
            WebClient w = new WebClient();
            String page = w.DownloadString(textBox1.Text);
            String name = "title=\"(.*?)\"";
            

           /* Encoding utf8 = Encoding.UTF8;
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            byte[] utf8Bytes = utf8.GetBytes(page);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);
            page = win1251.GetString(win1251Bytes);
           */

            foreach (Match match in Regex.Matches(page, name))
                listBox1.Items.Add(match.Groups[1].Value);
        }
     
    }
}

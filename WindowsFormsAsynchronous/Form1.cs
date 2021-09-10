using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAsynchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
        }        

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private async Task<string> ReadTextAsync()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            return "async succinctly";
        }
        private static async Task<string> ReadHelloWorldAsync(string value)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(6000)).ConfigureAwait(false);
            return $"hello {value}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string text = await ReadTextAsync();
            label1.Text = text;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var stringValue =  await ReadHelloWorldAsync("world");
            label2.Text = stringValue.ToString();
        }

  
    }
}

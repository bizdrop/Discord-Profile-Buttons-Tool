using System;
using DiscordRPC;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Discord_Buttons_On_Profile
{
    public partial class Form1 : Form
    {
        private DiscordRpcClient discordRpcClient;
        bool buttons = false;
        public Form1()
        {
            InitializeComponent();
            discordRpcClient = new DiscordRpcClient("CLIENT ID");
            discordRpcClient.Initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttons == false)
            {
                string largeImageId = comboBox1.SelectedItem?.ToString();
                string smallImageId = comboBox2.SelectedItem?.ToString();
                string stateText = textBox1.Text;
                string detailText = textBox2.Text;

                discordRpcClient.SetPresence(new RichPresence
                {
                    Assets = new Assets
                    {
                        LargeImageKey = largeImageId,
                        SmallImageKey = smallImageId
                    },
                    Details = detailText,
                    State = stateText
                });
            }

            if (buttons == true)
            {
                string largeImageId = comboBox1.SelectedItem?.ToString();
                string smallImageId = comboBox2.SelectedItem?.ToString();
                string stateText = textBox1.Text;
                string detailText = textBox2.Text;
                string button1Label = textBox3.Text;
                string button1Link = textBox4.Text;
                string button2Label = textBox5.Text;
                string button2Link = textBox6.Text;

                discordRpcClient.SetPresence(new RichPresence
                {
                    Assets = new Assets
                    {
                        LargeImageKey = largeImageId,
                        SmallImageKey = smallImageId
                    },
                    Details = detailText,
                    State = stateText,

                    Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button { Label = button1Label, Url = button1Link },
                    new DiscordRPC.Button { Label = button2Label, Url = button2Link }
                }
                });
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            discordRpcClient.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.buttons = true;
            }
            else
            {
                this.buttons = false;
            }
        }
    }
}

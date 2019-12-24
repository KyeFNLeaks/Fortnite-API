using System;
using System.Drawing;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using System.Diagnostics;
using KyeBase.API;
using KyeBase.DiscordRPC;

namespace KyeBase
{
    public partial class Application : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public Application()
        {
            InitializeComponent();
        }

        int mouseValueX;
        int mouseValueY;
        int toggleMovement;

        private void Application_Load(object sender, EventArgs e)
        {
            page1Panel.Location = new Point(158, 44);

            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing the Home Page";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "API";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void topPanel_Up(object sender, MouseEventArgs e)
        {
            toggleMovement = 0;
        }
        private void topPanel_Down(object sender, MouseEventArgs e)
        {
            toggleMovement = 1;
            mouseValueX = e.X;
            mouseValueY = e.Y;
        }

        private void topPanel_Move(object sender, MouseEventArgs e)
        {
            if (toggleMovement == 1)
            {
                SetDesktopLocation(MousePosition.X - mouseValueX, MousePosition.Y - mouseValueY);
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Page1Button_Click(object sender, EventArgs e)
        {
            if (page1Panel.Enabled == false)
            {
                if (page2Panel.Enabled == true)
                {
                    page2Panel.Location = new Point(1337, 1337);
                    page2Panel.Enabled = false;
                }

                if (page3Panel.Enabled == true)
                {
                    page3Panel.Location = new Point(1337, 1337);
                    page3Panel.Enabled = false;
                }

                if (page4Panel.Enabled == true)
                {
                    page4Panel.Location = new Point(1337, 1337);
                    page4Panel.Enabled = false;
                }

                page1Panel.Location = new Point(158, 44);
                page1Panel.Enabled = true;
            }
        }

        private void Page2Button_Click(object sender, EventArgs e)
        {
            if (page2Panel.Enabled == false)
            {
                if (page1Panel.Enabled == true)
                {
                    page1Panel.Location = new Point(1337, 1337);
                    page1Panel.Enabled = false;
                }

                if (page3Panel.Enabled == true)
                {
                    page3Panel.Location = new Point(1337, 1337);
                    page3Panel.Enabled = false;
                }

                if (page4Panel.Enabled == true)
                {
                    page4Panel.Location = new Point(1337, 1337);
                    page4Panel.Enabled = false;
                }

                page2Panel.Location = new Point(158, 44);
                page2Panel.Enabled = true;
            }
        }

        private void AESKeybutton_Click(object sender, EventArgs e)
        {
            AES main = new AES();
            main.Show();
        }

        private void Newsbrbutton_Click(object sender, EventArgs e)
        {
            brnews main = new brnews();
            main.Show();

        }

        private void EFbutton_Click(object sender, EventArgs e)
        {
            eventflags main = new eventflags();
            main.Show();
        }

        private void LTMbutton_Click(object sender, EventArgs e)
        {
            LTM main = new LTM();
            main.Show();
        }

        private void Statusbutton_Click(object sender, EventArgs e)
        {
            FNStatus main = new FNStatus();
            main.Show();
        }

        private void PVEbutton_Click(object sender, EventArgs e)
        {
            PVE main = new PVE();
            main.Show();
        }
        private void DiscordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/BaRzadu");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FNupdate main = new FNupdate();
            main.Show();
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            Store main = new Store();
            main.Show();
        }

        private void Cosmeticsbutton_Click(object sender, EventArgs e)
        {
            Cosmetics main = new Cosmetics();
            main.Show();
        }

        private void APIbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://discordapp.com/invite/aZmsM8M");
        }

        private void APIlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://fortnite-api.ga/");
        }
        private void BPbutton_Click(object sender, EventArgs e)
        {
            BP main = new BP();
            main.Show();
        }

        private void Keybutton_Click(object sender, EventArgs e)
        {
            KeyChain main = new KeyChain();
            main.Show();
        }

        private void Blogbutton_Click(object sender, EventArgs e)
        {
            Blog main = new Blog();
            main.Show();
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {
            AutoUpdater.Start("https://www.kyekillerbot.tk/Update.xml");
        }

        private void Page3Button_Click(object sender, EventArgs e)
        {
            if (page3Panel.Enabled == false)
            {
                if (page1Panel.Enabled == true)
                {
                    page1Panel.Location = new Point(1337, 1337);
                    page1Panel.Enabled = false;
                }

                if (page2Panel.Enabled == true)
                {
                    page2Panel.Location = new Point(1337, 1337);
                    page2Panel.Enabled = false;
                }

                if (page4Panel.Enabled == true)
                {
                    page4Panel.Location = new Point(1337, 1337);
                    page4Panel.Enabled = false;
                }

                page3Panel.Location = new Point(158, 44);
                page3Panel.Enabled = true;
            }
        }

        private void Kyetwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/KyeFNLeaks");
        }

        private void BRtwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/fortniteapi_ga");
        }

        private void Slushtwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://fortnite-api.ga/");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(2);
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/KyeFNLeaks/Fortnite-API/releases");
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/KyeFNLeaks/Fortnite-API/blob/master/README.md");
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void reportAProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/KyeFNLeaks/Fortnite-API/issues");
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FNAPI.ShowBalloonTip(1000, "Hidden", "I'm runnning in the background please click 'show' to reopen me.", ToolTipIcon.Info);
        }

        private void Page4Button_Click(object sender, EventArgs e)
        {
            if (page4Panel.Enabled == false)
            {
                if (page1Panel.Enabled == true)
                {
                    page1Panel.Location = new Point(1337, 1337);
                    page1Panel.Enabled = false;
                }

                if (page2Panel.Enabled == true)
                {
                    page2Panel.Location = new Point(1337, 1337);
                    page2Panel.Enabled = false;
                }

                if (page3Panel.Enabled == true)
                {
                    page3Panel.Location = new Point(1337, 1337);
                    page3Panel.Enabled = false;
                }

                page4Panel.Location = new Point(158, 44);
                page4Panel.Enabled = true;
            }
        }

        private void Redbutton_Click(object sender, EventArgs e)
        {
            topPanel.BackColor = Color.Red;
            bottomPanel.BackColor = Color.Red;
        }

        private void Yellowbutton_Click(object sender, EventArgs e)
        {
            topPanel.BackColor = Color.Yellow;
            bottomPanel.BackColor = Color.Yellow;
        }

        private void Purplebutton_Click(object sender, EventArgs e)
        {
            topPanel.BackColor = Color.Purple;
            bottomPanel.BackColor = Color.Purple;
        }

        private void Greenbutton_Click(object sender, EventArgs e)
        {
            topPanel.BackColor = Color.Green;
            bottomPanel.BackColor = Color.Green;
        }

        private void Bluebutton_Click(object sender, EventArgs e)
        {
            topPanel.BackColor = Color.Blue;
            bottomPanel.BackColor = Color.Blue;
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using KyeBase.DiscordRPC;

namespace KyeBase
{
    public partial class brnews : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public brnews()
        {
            InitializeComponent();
        }



        private void brnewsbutton_Click(object sender, EventArgs e)
        {
            BRrichTextBox.Text = "";
            this.BRrichTextBox.Text = JObject.Parse(new WebClient().DownloadString("https://fortnitecontent-website-prod07.ol.epicgames.com/content/api/pages/fortnite-game"))["battleroyalenews"][(object)"news"].ToString(Formatting.Indented);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BRrichTextBox.Text = "";
            this.BRrichTextBox.Text = JObject.Parse(new WebClient().DownloadString("https://fortnitecontent-website-prod07.ol.epicgames.com/content/api/pages/fortnite-game"))["savetheworldnews"][(object)"news"].ToString(Formatting.Indented);
        }

        private void brnews_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing the News";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "API";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}

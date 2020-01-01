using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using KyeBase.DiscordRPC;

namespace KyeBase.API
{
    public partial class KeyChain : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public KeyChain()
        {
            InitializeComponent();
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
            string downloadString = client.DownloadString("https://fortnite-api.de/api/keychain");
            JArray json = JArray.Parse(downloadString);
            KeyrichTextBox.Text = json.ToString(Formatting.Indented);

        }

        private void KeyChain_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing KeyChains";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "API";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}

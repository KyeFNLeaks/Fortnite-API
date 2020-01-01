using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using KyeBase.DiscordRPC;

namespace KyeBase.API
{
    public partial class Main : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Main()
        {
            InitializeComponent();
        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("https://fortnite-api.de/api/aeskeys/main");
            JObject json = JObject.Parse(downloadString);
            MainrichTextBox.Text = json.ToString(Formatting.Indented);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing Main AES Key";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "API";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}

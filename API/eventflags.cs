using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using KyeBase.DiscordRPC;

namespace KyeBase
{
    public partial class eventflags : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public eventflags()
        {
            InitializeComponent();
        }

        private void EFbutton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://fortnite-api.de/api/eventflags");
            JObject json = JObject.Parse(downloadString);
            EFrichTextBox.Text = json.ToString(Formatting.Indented);
        }

        private void eventflags_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing EventFlags";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "API";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}

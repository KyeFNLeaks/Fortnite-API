using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using KyeBase.DiscordRPC;

namespace KyeBase
{
    public partial class AES : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public AES()
        {
            InitializeComponent();
        }

        private void AESbutton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("https://fortnite-api.de/api/aeskeys");
            JArray json = JArray.Parse(downloadString);
            AESrichTextBox.Text = json.ToString(Formatting.Indented);
        }

        private void AES_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing AES Keys";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "API";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}

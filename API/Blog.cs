using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyeBase.DiscordRPC;


namespace KyeBase.API
{
    public partial class Blog : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Blog()
        {
            InitializeComponent();
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
            string downloadString = client.DownloadString("https://fortnite-api.ga/api/blogposts");
            JObject json = JObject.Parse(downloadString);
            BlogrichTextBox.Text = json.ToString(Formatting.Indented);

        }

        private void Blog_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing Blog";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "Version 1.4";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}

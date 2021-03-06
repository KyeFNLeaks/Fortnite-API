﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using KyeBase.DiscordRPC;

namespace KyeBase
{
    public partial class FNupdate : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public FNupdate()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("https://fortnite-public-service-stage.ol.epicgames.com/fortnite/api/version");
            JObject json = JObject.Parse(downloadString);
            updaterichTextBox.Text = json.ToString(Formatting.Indented);
        }

        private void FNupdate_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("656175405706772493", ref this.handlers, true, null);
            this.presence.details = "Viewing Test Servers";
            this.presence.state = "Created by KyeFNLeaks";
            this.presence.largeImageKey = "rpc_logo";
            this.presence.largeImageText = "API";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}

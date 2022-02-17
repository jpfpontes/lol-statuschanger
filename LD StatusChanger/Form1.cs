using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LCUSharp.Http;
using LCUSharp.Http.Endpoints;
using LCUSharp.Utility;
using LCUSharp.Websocket;
using System.Net.Http;
using LCUSharp;

namespace LD_StatusChanger
{
    public partial class Form1 : Form
    {
        public bool isLolRunning = false;
        List<Panel> panelStack = new List<Panel>();
        int iconID = 0;

        public Form1()
        {
            InitializeComponent();
            ConnectLoL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelStack.Add(statusPanel);
            panelStack.Add(iconPanel);
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            if (isLolRunning)
            {
                panelStack[1].Visible = false;
                panelStack[0].Visible = true;
                panelStack[0].BringToFront();
            }
        }

        private void IconBtn_Click(object sender, EventArgs e)
        {
            if (isLolRunning)
            {
                panelStack[0].Visible = false;
                panelStack[1].Visible = true;
                panelStack[1].BringToFront();
            }
        }

        private async void ApplyMissionBtn_Click(object sender, EventArgs e)
        {
            string mission = MissionTextBox.Text;
            ChangeMission(mission);
            statusAtual.Visible = true;
            await Task.Delay(1000);
            statusAtual.Visible = false;
        }

        private async void ApplyIconButton_Click(object sender, EventArgs e)
        {

            int[] iconSelected = new int[] {66, 29, 50, 51, 52, 53, 54, 55, 56, 59, 60, 61, 62, 63, 64, 65, 69,
                                            70, 71, 72, 73, 74, 76, 57, 58, 67, 68, 78, 77};

            foreach (RadioButton rb in iconPanel.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    iconID = iconSelected[rb.TabIndex];
                    ChangeIcon(iconID);
                    statusAtual2.Visible = true;
                    await Task.Delay(1000);
                    statusAtual2.Visible = false;
                }
            }
        }

        public async void ConnectLoL()
        {
            api = await LeagueClientApi.ConnectAsync();
        }

        public LeagueClientApi api;

        private async void ChangeMission(string missionNew)
        {
            var body = new { statusMessage = missionNew };
            var queryParameters = Enumerable.Empty<string>();
            var json = await api.RequestHandler.GetJsonResponseAsync(HttpMethod.Put, "lol-chat/v1/me",
                                                                        queryParameters, body);
        }

        private async void ChangeIcon(int iconId)
        {
            var body = new { profileIconId = iconId };
            var queryParameters = Enumerable.Empty<string>();
            var json = await api.RequestHandler.GetJsonResponseAsync(HttpMethod.Put, "lol-summoner/v1/current-summoner/icon",
                                                                        queryParameters, body);
        }

        bool tryConnect = true;
        private void RefreshUpdate_Tick(object sender, EventArgs e)
        {

            bool isLoLRunning = Process.GetProcessesByName("LeagueClientUx").Any();
            if (isLoLRunning)
            {
                if (tryConnect)
                {
                    ConnectLoL();
                    tryConnect = false;
                }
                avisoLol.Visible = false;
                isLolRunning = true;
                iconBtn.Visible = true;
                statusBtn.Visible = true;
            }
            else
            {
                tryConnect = true;
                isLolRunning = false;
                foreach (var panel in panelStack)
                {
                    panel.Visible = false;
                }
                iconBtn.Visible = false;
                statusBtn.Visible = false;
                avisoLol.Visible = true;
            }
        }
    }
}

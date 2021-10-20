using MQTTnet;
using MQTTnet.Client;
using Rido.IoTHubClient;
using System.Text;

namespace MyBrokerClient
{
    public partial class Form1 : Form
    {
        IMqttClient client;
        public Form1()
        {
            InitializeComponent();
            client = new MqttFactory().CreateMqttClient();
            client.UseApplicationMessageReceivedHandler(e => 
            {
                textBoxMessages.Invoke(() => {
                    textBoxMessages.Text += $"{e.ApplicationMessage.Topic} {Environment.NewLine}";
                    textBoxMessages.Text += $"{System.Text.Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}";
                    textBoxMessages.Text += $"{ Environment.NewLine} ---- {Environment.NewLine}";
                });
            });
        }

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            var connack = await client.ConnectWithSasAsync(
                textBoxHostName.Text, 
                textBoxDeviceId.Text, 
                textBoxSasKey.Text);
            labelConnectStatus.Text = connack.ResultCode.ToString();
        }

        private async void buttonSub_Click(object sender, EventArgs e)
        {
            var suback = await client.SubscribeAsync(textBoxTopicSub.Text);
            StringBuilder sb = new StringBuilder();
            suback.Items.ToList().ForEach(c => sb.AppendLine(c.ResultCode.ToString()));
            labelSubStatus.Text = sb.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var puback = await client.PublishAsync(textBoxPubTopic.Text, textBoxPayload.Text);
            labelPubStatus.Text = puback.ReasonCode.ToString();
        }
    }
}
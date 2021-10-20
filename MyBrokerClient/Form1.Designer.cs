namespace MyBrokerClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.textBoxDeviceId = new System.Windows.Forms.TextBox();
            this.textBoxSasKey = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxTopicSub = new System.Windows.Forms.TextBox();
            this.buttonSub = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.textBoxPubTopic = new System.Windows.Forms.TextBox();
            this.textBoxPayload = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelConnectStatus = new System.Windows.Forms.Label();
            this.labelSubStatus = new System.Windows.Forms.Label();
            this.labelPubStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.Location = new System.Drawing.Point(60, 20);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(411, 23);
            this.textBoxHostName.TabIndex = 0;
            this.textBoxHostName.Text = "broker.azure-devices.net";
            // 
            // textBoxDeviceId
            // 
            this.textBoxDeviceId.Location = new System.Drawing.Point(60, 49);
            this.textBoxDeviceId.Name = "textBoxDeviceId";
            this.textBoxDeviceId.Size = new System.Drawing.Size(411, 23);
            this.textBoxDeviceId.TabIndex = 1;
            this.textBoxDeviceId.Text = "myDevice";
            // 
            // textBoxSasKey
            // 
            this.textBoxSasKey.Location = new System.Drawing.Point(60, 78);
            this.textBoxSasKey.Name = "textBoxSasKey";
            this.textBoxSasKey.Size = new System.Drawing.Size(411, 23);
            this.textBoxSasKey.TabIndex = 2;
            this.textBoxSasKey.Text = "MDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDA=";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(482, 68);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(128, 32);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxTopicSub
            // 
            this.textBoxTopicSub.Location = new System.Drawing.Point(58, 127);
            this.textBoxTopicSub.Name = "textBoxTopicSub";
            this.textBoxTopicSub.Size = new System.Drawing.Size(200, 23);
            this.textBoxTopicSub.TabIndex = 4;
            this.textBoxTopicSub.Text = "vehicles/#";
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(270, 127);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(76, 24);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "subscribe";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(53, 162);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(295, 255);
            this.textBoxMessages.TabIndex = 6;
            // 
            // textBoxPubTopic
            // 
            this.textBoxPubTopic.Location = new System.Drawing.Point(395, 162);
            this.textBoxPubTopic.Name = "textBoxPubTopic";
            this.textBoxPubTopic.Size = new System.Drawing.Size(200, 23);
            this.textBoxPubTopic.TabIndex = 7;
            this.textBoxPubTopic.Text = "vehicles/myDevice/telemetry";
            // 
            // textBoxPayload
            // 
            this.textBoxPayload.Location = new System.Drawing.Point(394, 194);
            this.textBoxPayload.Multiline = true;
            this.textBoxPayload.Name = "textBoxPayload";
            this.textBoxPayload.Size = new System.Drawing.Size(201, 85);
            this.textBoxPayload.TabIndex = 8;
            this.textBoxPayload.Text = "{ \"temperature\" : 23 }";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Publish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelConnectStatus
            // 
            this.labelConnectStatus.AutoSize = true;
            this.labelConnectStatus.Location = new System.Drawing.Point(482, 103);
            this.labelConnectStatus.Name = "labelConnectStatus";
            this.labelConnectStatus.Size = new System.Drawing.Size(38, 15);
            this.labelConnectStatus.TabIndex = 10;
            this.labelConnectStatus.Text = "label1";
            // 
            // labelSubStatus
            // 
            this.labelSubStatus.AutoSize = true;
            this.labelSubStatus.Location = new System.Drawing.Point(54, 427);
            this.labelSubStatus.Name = "labelSubStatus";
            this.labelSubStatus.Size = new System.Drawing.Size(38, 15);
            this.labelSubStatus.TabIndex = 11;
            this.labelSubStatus.Text = "label1";
            // 
            // labelPubStatus
            // 
            this.labelPubStatus.AutoSize = true;
            this.labelPubStatus.Location = new System.Drawing.Point(391, 310);
            this.labelPubStatus.Name = "labelPubStatus";
            this.labelPubStatus.Size = new System.Drawing.Size(38, 15);
            this.labelPubStatus.TabIndex = 12;
            this.labelPubStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPubStatus);
            this.Controls.Add(this.labelSubStatus);
            this.Controls.Add(this.labelConnectStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPayload);
            this.Controls.Add(this.textBoxPubTopic);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.textBoxTopicSub);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxSasKey);
            this.Controls.Add(this.textBoxDeviceId);
            this.Controls.Add(this.textBoxHostName);
            this.Name = "Form1";
            this.Text = "MQTT Broker Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxHostName;
        private TextBox textBoxDeviceId;
        private TextBox textBoxSasKey;
        private Button buttonConnect;
        private TextBox textBoxTopicSub;
        private Button buttonSub;
        private TextBox textBoxMessages;
        private TextBox textBoxPubTopic;
        private TextBox textBoxPayload;
        private Button button1;
        private Label labelConnectStatus;
        private Label labelSubStatus;
        private Label labelPubStatus;
    }
}
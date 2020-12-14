using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolSms;

namespace SMS_TEST
{
    public partial class Form1 : Form
    {
        string message = "";
        public Form1()
        {
            InitializeComponent();
        }

        SmsApi api = new SmsApi(new SmsApiOptions
        {
            //ApiKey = "발급 받은 ApiKey",
            //ApiSecret = "발급 받은 Secret Key",
            ApiKey = "NCSWCLGOTXULQQDM",
            ApiSecret = "16RIKZFEFYQFDG0BUOHAHDIPSMQJHW2V",
            DefaultSenderId = "01025230070" // 문자 보내는 사람 번호, coolsms 홈페이지에서 발신자 등록한 번호 필수
        });

        private async Task SendSMS()
        {
            //var result = api.SendMessageAsync("01063057225", message);

            var request = new SendMessageRequest("01025230070", "Warning 발생\r\n" + DateTime.Now.ToString());

            var result = await api.SendMessageAsync(request);

            listBox1.Items.Add(result.GroupId);
            listBox1.Items.Add(result.IsSuccess);
            listBox1.Items.Add(result.ResultCode);
            listBox1.Items.Add(result.ResultMessage);
            listBox1.Items.Add(result.SuccessCount);

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message = textBox1.Text;

            SendSMS();
        }

        private async Task Get_GroupidAsync()
        {
            var request = new GetMessagesRequest
            {
                GroupId = "R1G3drgnu5aHboWc"
            };
            var result = await api.GetMessagesAsync(request);
            
            List<GetMessagesResponse.MessageResponse> abc = result.Messages.ToList();

            listBox1.Items.Add(abc[0].AcceptedTime.Value.ToString());
            listBox1.Items.Add(abc[0].Carrier);
            listBox1.Items.Add(abc[0].GroupId);
            listBox1.Items.Add(abc[0].MessageId);
            listBox1.Items.Add(abc[0].Recipient);
            listBox1.Items.Add(abc[0].ResultCode);
            listBox1.Items.Add(abc[0].ResultMessage);
            listBox1.Items.Add(abc[0].ScheduledTime.ToString());
            listBox1.Items.Add(abc[0].SentTime.ToString());
            listBox1.Items.Add(abc[0].Status.ToString());
            listBox1.Items.Add(abc[0].Text);
            listBox1.Items.Add(abc[0].Type.ToString());
        }

        private async Task test()
        {
            var request = SendMessageRequest.CraeteTest("테스트메시지");
            var result = await api.SendMessageAsync(request);

            string aa = result.ResultMessage;

            label1.Text = aa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Get_GroupidAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test();
        }
    }

    
}


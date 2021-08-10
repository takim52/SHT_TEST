using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.InSight;
using Cognex.InSight.Net;

namespace INSIGHT_SDK_TEST
{
    public partial class frmMain : Form
    {
        // 인사이트 모니터 입니다. 얼마나 연결 되어 있는지 알 수 있습니다.
        // 현재는 사용하지 않았지만 사용할 길이 있는것으로 생각하여 만들어 두었습니다.
        private CvsNetworkMonitor mMonitor;
        // 카메라 정보를 가져와야 하기 때문에 변수 선언을 하였습니다.
        private Camconfigform _frmCamConfig;
        // 다수의 카메라를 연결 하기 위해 선언 하였습니다.
        private frmCamView[] chform;

        // 카메라 정보를 저장하기 위해 사용합니다.
        DataGridView St1Cam;

        // 카메라 갯수를 표기 하기 위해 사용합니다.
        int cCamCount = 0;
        // 카메라 이름을 알고 컨트롤 하기 위해 선언합니다.
        string[] cCamName;

        public frmMain()
        {
            // frmMain 의 디자인 생성
            InitializeComponent();

            // 카메라 Config를 생성
            _frmCamConfig = new Camconfigform();

            // 카메라의 아이피, 이름을 가져와서 사용 하기 위해 사용합니다.
            // 그리고 카메라 갯수가 얼마나 되는지 알기 위해 사용합니다.
            _frmCamConfig.DataSendEvent += new DataGetEventHandler(this.GetData);

            // frmMain 보다 먼저 나와 설정 되어야 하기 때문에 사용합니다.
            _frmCamConfig.ShowDialog();

            // 인사이트 View를 하기 위한 개발자 키트를 생성합니다.
            CvsInSightSoftwareDevelopmentKit.Initialize();

            // 카메라 갯수에 맞게 카메라를 생성 해줍니다.
            chform = new frmCamView[cCamCount];
        }

        private void GetData(DataGridView St1, CvsNetworkMonitor nMonitor)
        {
            // 모니터 정보를 넣어 줍니다.
            mMonitor = nMonitor;
            // 카메라 정보를 넣어 줍니다.
            St1Cam = St1;

            // 카메라 갯수를 넣어 줍니다.
            cCamCount = St1.Rows.Count - 1;
            // 카메라 이름의 갯수를 만들어 줍니다.
            cCamName = new string[cCamCount];

            for (int i = 0; i < St1.Rows.Count - 1; i++)
            {
                // 카메라 이름을 각각에 맞게 넣어 줍니다.
                cCamName[i] = St1.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cCamCount; i++)
            {
                //path = GlobalStatic.PATHVPPFILE + "Cam" + i.ToString() + "\\";      // 자식폼 생성
                try
                {
                    chform[i] = new frmCamView();
                    chform[i].TopLevel = false;
                    // 카메라를 frmMain MID 부모 폼에 들어가게 해줍니다.
                    chform[i].MdiParent = this;

                    chform[i].Text = St1Cam.Rows[i].Cells[0].Value.ToString().Trim();
                    chform[i].Tag = i;
                    chform[i].Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            // Mdi 폼의 정렬을 해줍니다.
            btnAutoLayout_Click(null, null);
        }

        private void btnAutoLayout_Click(object sender, EventArgs e)
        {
            // Mdi 폼의 정렬을 해줍니다.
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 이미지를 가져옵니다.
            chform[0].IMG_SAVE();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 셀의 값을 가져옵니다.
            label1.Text = chform[0].GET_STRING();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // 셀의 값을 지정합니다. 이 경우 EditString에만 할 수 있습니다.
            chform[0].SET_STRING(textBox1.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // 수동 트리거를 사용합니다.
            chform[0].TRIGGER();
        }
    }
}

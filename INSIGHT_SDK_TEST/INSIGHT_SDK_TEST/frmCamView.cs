using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.InSight.Net;
using Cognex.InSight;
using Cognex.InSight.Controls.Display;
using System.IO;
using System.Configuration;
using Cognex.InSight.Cell;

namespace INSIGHT_SDK_TEST
{
    public partial class frmCamView : Form
    {
        private CvsNetworkMonitor mMonitor;
        private CvsInSight mInSight;
        private Camconfigform _frmCamConfig;

        static string GET_TEXT = ConfigurationManager.AppSettings["GET_TEXT"];

        static Cognex.InSight.CvsCellLocation cl_GET_TEXT = new Cognex.InSight.CvsCellLocation(GET_TEXT);

        static string SET_TEXT = ConfigurationManager.AppSettings["SET_TEXT"];

        static Cognex.InSight.CvsCellLocation cl_SET_TEXT = new Cognex.InSight.CvsCellLocation(SET_TEXT);



        public frmCamView()
        {
            InitializeComponent();

            Init();

            _frmCamConfig = new Camconfigform();

            _frmCamConfig.DataSendEvent += new DataGetEventHandler(this.ConnectedCam);
        }

        private void Init()
        {
            // Create a network monitor and connect to events of the display's InSight
            mMonitor = new CvsNetworkMonitor();
            mMonitor.PingInterval = 0;


            // Setup InSightDisplay and InSight object.
            // 인사이트 디스플레이를 mInsight에 넣어줍니다.
            mInSight = cvsInSightDisplay2.InSight;
            cvsInSightDisplay2.ShowGrid = true;
            cvsInSightDisplay2.ShowGraphics = true;
            cvsInSightDisplay2.ShowImage = true;
            cvsInSightDisplay2.ShowScrollBars = true;
            cvsInSightDisplay2.GridOpacity = 0.7;
            cvsInSightDisplay2.ImageScale = 1.0;
            cvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;

            mMonitor.HostsChanged += new EventHandler(mMonitor_HostsChanged);
            mMonitor.Enabled = true;

            cvsInSightDisplay2.InSightChanged += new System.EventHandler(this.cvsInSightDisplay1_InSightChanged);

        }
        private CvsInSight InSight
        {
            get { return mInSight; }
            set
            {
                mInSight = value;
            }
        }

        void mMonitor_HostsChanged(object sender, EventArgs e)
        {

            string status = string.Empty;
            if (mMonitor.Hosts.Count > 0)
            {

                for (int i = 0; i < mMonitor.Hosts.Count; i++)
                {
                    if (mMonitor.Hosts[i].Name == this.Text)
                    {
                        cvsInSightDisplay2.Connect(mMonitor.Hosts[i].IPAddress.ToString(), "admin", "", false);

                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("센서가 없습니다.");
            }
        }

        private void cvsInSightDisplay1_InSightChanged(object sender, EventArgs e)
        {
            // 인사이트 커넥트를 하게 해줍니다.
            InSight = cvsInSightDisplay2.InSight;
        }

        private void ConnectedCam(DataGridView St1, CvsNetworkMonitor nMonitor)
        {

            string[] cCamName = new string[St1.Rows.Count];

            for (int i = 0; i < St1.Rows.Count - 1; i++)
            {
                cCamName[i] = St1.Rows[i].Cells[0].Value.ToString();
            }
        }

        
        public void IMG_SAVE()
        {
            DateTime today = DateTime.Now;

            try
            {
                mInSight.Results.Image.Save(Application.StartupPath + "\\IMG\\"
                               + today.Year + ".bmp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public string GET_STRING()
        {
            CvsCell cell1 = mInSight.Results.Cells[GET_TEXT];

            return cell1.Text;
        }

        public void SET_STRING(string value)
        {
            mInSight.SetString(cl_SET_TEXT, value);
        }

        public void TRIGGER()
        {
            mInSight.ManualAcquire(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blade_Monitoring
{
    class Serialization
    {
        [Serializable]
        public class Setting_Data
        {
            public Dictionary<string, string> strData = new Dictionary<string, string>();
        }
        
        public void Setting_Data_Serialize(Dictionary<string, string> data)
        {
            Setting_Data setting_data = new Setting_Data();
            Stream stream = null;

            setting_data.strData = data;

            try
            {
                string dir_y = Directory.GetCurrentDirectory() + @"\BIN\";
                DirectoryInfo di_y = new DirectoryInfo(dir_y);
                if (di_y.Exists != true) Directory.CreateDirectory(dir_y);

                IFormatter formatter = new BinaryFormatter();

                
                stream = new FileStream(Application.StartupPath + "\\BIN\\Monitor_setting_data.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, setting_data);
            }
            catch
            { }

            finally
            {
                if (stream != null)
                    stream.Close();
            }

        }
        public Dictionary<string, string> Setting_Data_Deserialize()
        {
            Stream stream = null;
            Dictionary<string, string> data = new Dictionary<string, string>();

            try
            {
                

                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(Application.StartupPath + "\\BIN\\Monitor_setting_data.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                Setting_Data setting_data = (Setting_Data)formatter.Deserialize(stream);

                data = setting_data.strData;
            }
            catch
            { }

            finally
            {
                if (stream != null)
                    stream.Close();
            }

            return data;
        }



    }
}

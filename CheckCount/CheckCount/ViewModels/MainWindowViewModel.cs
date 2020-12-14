using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Linq;

namespace CheckCount.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand DelegateCommandFindFilePath { get; private set; }
        public DelegateCommand DelegateCommandSelectFolderPath { get; private set; }
        public DelegateCommand DelegateCommandFileSetting { get; private set; }
        public DelegateCommand DelegateCommandCheckSerial { get; private set; }

        private List<string> _getSerial = new List<string>();

        private string _title = "File Check Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set 
            { SetProperty(ref _filePath, value); }
        }

        private string _folderPath;

        public string FolderPath
        {
            get { return _folderPath; }
            set
            { SetProperty(ref _folderPath, value); }
        }

        private int _serialCount;

        public int SerialCount
        {
            get { return _serialCount; }
            set { SetProperty(ref _serialCount, value); }
        }

        private int _compareCount;

        public int CompareCount
        {
            get { return _compareCount; }
            set { SetProperty(ref _compareCount, value); }
        }

        private string _fileStatus;

        public string FileStatus
        {
            get { return _fileStatus; }
            set { SetProperty(ref _fileStatus, value); }
        }

        private string _folderStatus;

        public string FolderStatus
        {
            get { return _folderStatus; }
            set { SetProperty(ref _folderStatus, value); }
        }


        public MainWindowViewModel()
        {
            DelegateCommandFindFilePath = new DelegateCommand(FindFilePath);
            DelegateCommandSelectFolderPath = new DelegateCommand(selectFolderPath);
            DelegateCommandFileSetting = new DelegateCommand(fileSetting);
            DelegateCommandCheckSerial = new DelegateCommand(checkSerial);
        }

        private void FindFilePath()
        {
            var dialog = new System.Windows.Forms.OpenFileDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                FilePath = dialog.FileName;
            }

            FileStatus = "파일 셋팅 대기";
        }
        private void selectFolderPath()
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();

            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                FolderPath = dialog.SelectedPath;
            }
            FolderStatus = "폴더 비교 대기";
        }
        private void fileSetting()
        {
            FileStatus = "파일 셋팅 중";
            Thread.Sleep(100);

            if (_getSerial.Count > 0)
            {
                _getSerial.Clear();
            }

            var path = FilePath;

            var enumLines = File.ReadLines(path, Encoding.UTF8);
            foreach (var line in enumLines)
            {
                if (!_getSerial.Contains(line))
                {
                    _getSerial.Add(line);
                }
            }

            SerialCount = _getSerial.Count;

            FileStatus = "파일 셋팅 완료";
        }
        
        private async void checkSerial()
        {
            FolderStatus = "폴더 비교 중";
            if (CompareCount > 0)
            {
                CompareCount = 0;
            }

            var progress = new Progress<int>(value =>
            {
                FolderStatus = $"{value}%";
            });

            await Task.Run(() => LoopCheckSerial(progress));
            //await Task.Run(() => LoopTest(1000,progress));
            FolderStatus = "폴더 비교 완료";
        }

        private void LoopTest(int count, IProgress<int> progress)
        {
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(100);
                var percentComplete = (i * 100) / count;
                progress.Report(percentComplete);
            }
        }

        private void LoopCheckSerial(IProgress<int> progress)
        {
            List<string> fileNames = Directory.GetFiles(FolderPath).ToList();

            int dbCount = _getSerial.Count;
            for (int i = 0; i < dbCount; i++)
            {
                Thread.Sleep(1);
                for (int j = 0; j < fileNames.Count; j++)
                {
                    if (fileNames[j].Contains(_getSerial[i]))
                    {
                        CompareCount++;
                        fileNames.RemoveAt(j);
                        break;
                    }
                }
                var percentComplete = (i*100) / dbCount;
                progress.Report(percentComplete);
            }
        }
    }
}

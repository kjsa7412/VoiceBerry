using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace voice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RecodePage_Sub2 : Page
    {
        RecodePage_Sub1_List _pageParameters;
        private string test;
        private int a;
        private Frame ff;


        private MediaCapture _mediaCaptureManager;
        private StorageFile _recordStorageFile;
        private bool _recording;
        private bool _userRequestedRaw;
        private bool _rawAudioSupported;

        int playFlag = 0;//첨부터 시작인지 일시정지 후 시작인지
        int nameCnt = 0; //저장 파일 이름 확인




        public RecodePage_Sub2()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            ff = MainPage2.MainPage2Frame;
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _pageParameters = e.Parameter as RecodePage_Sub1_List;
            if (_pageParameters != null)
            {
                test = _pageParameters.Message;
            }
            Initilize_RecodePage_Sub2();
        }

        private void Initilize_RecodePage_Sub2()
        {
            for (int i = 0; i < LocalDatabase.Imsi_Title.Count; i++)
            {
                if (LocalDatabase.Imsi_Title[i].ToString() == test)
                {
                    TBox_Title.Text = LocalDatabase.Imsi_Title[i].ToString();
                    TBox_Content.Text = LocalDatabase.Imsi_Content[i].ToString();
                    TBox_Time.Text = "00 : 00";
                }
            }
        }

        private async void InitializeAudioRecording()
        {

            _mediaCaptureManager = new MediaCapture();
            var settings = new MediaCaptureInitializationSettings();
            settings.StreamingCaptureMode = StreamingCaptureMode.Audio;
            settings.MediaCategory = MediaCategory.Other;
            settings.AudioProcessing = (_rawAudioSupported && _userRequestedRaw) ? AudioProcessing.Raw : AudioProcessing.Default;

            await _mediaCaptureManager.InitializeAsync(settings);

            Debug.WriteLine("Device initialised successfully");

            _mediaCaptureManager.RecordLimitationExceeded += new RecordLimitationExceededEventHandler(RecordLimitationExceeded);
            _mediaCaptureManager.Failed += new MediaCaptureFailedEventHandler(Failed);
        }

        private void Failed(MediaCapture sender, MediaCaptureFailedEventArgs errorEventArgs)
        {
            throw new NotImplementedException();
        }

        private void RecordLimitationExceeded(MediaCapture sender)
        {
            throw new NotImplementedException();
        }

        //녹음 버튼 클릭
        private async void CaptureAudio()
        {
            try
            {
                Debug.WriteLine("Starting record");
                String fileName = "record.m4a";

                _recordStorageFile = await KnownFolders.VideosLibrary.CreateFileAsync(fileName, CreationCollisionOption.GenerateUniqueName);

                Debug.WriteLine("Create record file successfully");

                MediaEncodingProfile recordProfile = MediaEncodingProfile.CreateM4a(AudioEncodingQuality.Auto);
                await _mediaCaptureManager.StartRecordToStorageFileAsync(recordProfile, this._recordStorageFile);

                Debug.WriteLine("Start Record successful");

                _recording = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to capture audio");
            }
        }


        //정지 버튼 클릭(녹음 완료)
        private async void StopCapture()
        {

            if (_recording)
            {
                Debug.WriteLine("Stopping recording");
                await _mediaCaptureManager.StopRecordAsync();
                Debug.WriteLine("Stop recording successful");
                _recording = false;
            }

        }
        //재생 버튼 클릭
        private async void PlayRecordedCapture()
        {
            if (!_recording)
            {
                var stream = await _recordStorageFile.OpenAsync(FileAccessMode.Read);
                Debug.WriteLine("Recording file opened");


                //처음 시작 Play
                if (playFlag == 0)
                {
                    playbackElement1.AutoPlay = true;
                    playbackElement1.SetSource(stream, _recordStorageFile.FileType);
                    playbackElement1.Play();

                }
                //일시 정지 한 다음 Play
                else
                {
                    playbackElement1.Play();
                }
            }
        }
        //일시정지 클릭
        private void PausePlay()
        {
            playbackElement1.Pause();
            playFlag = 1;

        }


        private void RecordBtn(object sender, RoutedEventArgs e)
        {
            if ((string)recordBtn.Tag == "Record")
            {
                recordBtn.Icon = new SymbolIcon(Symbol.Stop);
                recordBtn.Label = "Stop";
                recordBtn.Tag = "Stop";
                // timer.Tick += OnTimerTick;

                ///  timer.Start();
                // flag = 1;
                CaptureAudio();
            }


            else
            {
                recordBtn.Icon = new SymbolIcon(Symbol.Target);
                recordBtn.Label = "Record";
                recordBtn.Tag = "Record";
                //  cnt = 0;
                //   timer.Stop();
                //   VolumeImage.SetBinding(Image.SourceProperty, SetProperty(""));
                //flag = 0;
                StopCapture();
            }
        }
        //재생이 끝났을 경우
        private void endAudio(object sender, RoutedEventArgs e)
        {
            playBtn.Icon = new SymbolIcon(Symbol.Play);
            playBtn.Label = "Play";
            playBtn.Tag = "Play";
            playFlag = 0;
        }
        //플레이 버튼 클릭
        private void playBtn_clicked(object sender, RoutedEventArgs e)
        {

            if ((string)playBtn.Tag == "Play")//Play 버튼 클릭
            {
                playBtn.Icon = new SymbolIcon(Symbol.Pause);
                playBtn.Label = "Pause";
                playBtn.Tag = "Pause";

                PlayRecordedCapture();
            }


            else //일시정지 버튼 클릭
            {
                playBtn.Icon = new SymbolIcon(Symbol.Play);
                playBtn.Label = "Play";
                playBtn.Tag = "Play";
                PausePlay();

            }

        }


        private void CompleteBtn_Click_1(object sender, RoutedEventArgs e)
        {
      
        }

        private void CompleteBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ff.Navigate(typeof(MyPage));
        }

    }
}

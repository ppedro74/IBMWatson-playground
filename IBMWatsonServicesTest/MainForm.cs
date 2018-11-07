using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DigitalMediaManagement.TestApp;
using IBM.WatsonDeveloperCloud.TextToSpeech.v1;
using IBM.WatsonDeveloperCloud.TextToSpeech.v1.Model;
using IBM.WatsonDeveloperCloud.Util;
using IniParser;

namespace IBMWatsonServicesTest
{
    public partial class MainForm : Form
    {
        private static readonly string[] Pangrams =
        {
            "The five boxing wizards jump quickly. ",
            "Crazy Fredrick bought many very exquisite opal jewels.",
            "Two driven jocks help fax my big quiz.",
            "Jinxed wizards pluck ivy from the big quilt. (",
            "Quick zephyrs blow, vexing daft Jim.",
            "The quick brown fox jumps over the lazy dog.",
            "A mad boxer shot a quick, gloved jab to the jaw of his dizzy opponent.",
            "The job requires extra pluck and zeal from every young wage earner.",
            "Jaded zombies acted quaintly but kept driving their oxen forward.",
            "Waltz, bad nymph, for quick jigs vex. ",
            "Pack my box with five dozen liquor jugs.",
            "Five quacking zephyrs jolt my wax bed.",
            "We promptly judged antique ivory buckles for the next prize.",
            "Sphinx of black quartz, judge my vow.",
        };

        private readonly string iniFile;
        private readonly Random random = new Random();

        public MainForm()
        {
            this.iniFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "watson.ini");
            this.InitializeComponent();

            this.TextToSynthesizeTextBox.Text = this.GetNewPangram();
            this.TextToSynthesizeTextBox.Tag = false;

            this.OutputFileTextBox.Tag = false;
            this.OutputFileTextBox.Text = this.GetNewOutputFile();
        }

        private string GetNewOutputFile()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string.Format("{0:yyyyxMMxddxHHxmmxss}", DateTime.Now) + ".wav");
        }

        private string GetNewPangram()
        {
            return Pangrams[this.random.Next(Pangrams.Length - 1)];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(this.iniFile))
            {
                this.Log(LogLevel.Warning, "Create an empty watson ini file " + this.iniFile);

                File.WriteAllText(
                    this.iniFile,
                    @"; Watson Services
[TextToSpeechService]
ApiKey=put_here_the_api_key

;ServiceUrl=https://gateway-wdc.watsonplatform.net/text-to-speech/api
ServiceUrl=put_here_the_service_url
");
            }
            else
            {
                var fileIniDataParser = new FileIniDataParser();
                var iniData = fileIniDataParser.ReadFile(this.iniFile);
                if (string.IsNullOrWhiteSpace(iniData["TextToSpeechService"]["ApiKey"]) || string.IsNullOrWhiteSpace(iniData["TextToSpeechService"]["ServiceUrl"]))
                {
                    this.Log(LogLevel.Warning, this.iniFile + ": Please set ApiKey and/or ServiceKey");
                }
            }

            //Debug: verify System.Net.Http.HttpClient version
            var httpClientType = typeof(System.Net.Http.HttpClient);
            this.Log(LogLevel.Warning, "Loaded: " + httpClientType.Assembly.FullName);
            var version = httpClientType.Assembly.GetName().Version.ToString();
            const string expectedVersion = "4.0.0.0";
            if (version != expectedVersion)
            {
                this.Log(LogLevel.Warning, "...Expected " + expectedVersion);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void SynthesizeButton_Click(object sender, EventArgs e)
        {
            var fileIniDataParser = new FileIniDataParser();
            var iniData = fileIniDataParser.ReadFile(this.iniFile);
            var tokenOptions = new TokenOptions
            {
                IamApiKey = iniData["TextToSpeechService"]["ApiKey"],
                ServiceUrl = iniData["TextToSpeechService"]["ServiceUrl"]
            };

            try
            {
                if (this.OutputFileTextBox.Tag is bool && false == (bool)this.OutputFileTextBox.Tag)
                {
                    //update the output file
                    this.OutputFileTextBox.Text = this.GetNewOutputFile();
                }

                var service = new TextToSpeechService(tokenOptions);
                var text = new Text { _Text = this.TextToSynthesizeTextBox.Text };

                using (var fileStream = File.Create(this.OutputFileTextBox.Text))
                {
                    using (var memoryStream = service.Synthesize(text, "audio/wav"))
                    {
                        memoryStream.CopyTo(fileStream);
                    }
                }

                if (this.TextToSynthesizeTextBox.Tag is bool && false == (bool)this.TextToSynthesizeTextBox.Tag)
                {
                    //randomize a new phrase
                    this.TextToSynthesizeTextBox.Text = this.GetNewPangram();
                }
            }
            catch (Exception ex)
            {
                this.Log(LogLevel.Error, ex);
            }
        }

        private void Log(LogLevel logLevel, object obj, bool clear = false)
        {
            if (!this.IsHandleCreated)
            {
                //no handle yet
                return;
            }

            var text = obj is Exception ? " Exception=[\r\n" + obj + "]" : obj.ToString();

            this.LogTextBox.SynchronizedInvoke(
                () =>
                {
                    if (clear)
                    {
                        this.LogTextBox.Text = string.Empty;
                    }

                    this.LogTextBox.Text = this.LogTextBox.Text + DateTime.Now.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture) + ">" + logLevel + ">>" + text + "\r\n";

                    if (this.AutoScrollCB.Checked)
                    {
                        this.LogTextBox.SelectionLength = 0;
                        this.LogTextBox.SelectionStart = this.LogTextBox.Text.Length;
                        this.LogTextBox.ScrollToCaret();
                    }
                });
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Tag = true;
            }
        }
    }
}
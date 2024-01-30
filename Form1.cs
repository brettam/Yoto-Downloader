using System;
using System.Diagnostics;
using Yoto_Downloader.Properties;

namespace Yoto_Downloader;

public partial class yotoDLForm : Form
{

    private string ytdlpScriptMain = $"-x --audio-format mp3 -o \"%(title)s.%(ext)s\"";
    private string ytdlpStart = $" --postprocessor-args \"-ss";

    private string _dirLocation = "c:\\";
    public string DirLocation
    {
        get => _dirLocation;
        set
        {
            _dirLocation = value;
            tbxFolder.Text = _dirLocation;
        }
    }

    public bool FullLength { get; set; } = true;

    public string URL { get; set; } = "";
    private ProcessTypes ProcType { get; set; }
    public string YtDlpOutput { get; set; } = "";

    public string startDir { get; set; }

    private string TrackTitle { get; set; }
    private string EndHr { get; set; }
    private string EndMin { get; set; }
    private string EndSec { get; set; }
    private string SetFullStringStart { get; set; }
    private string SetFullStringEnd { get; set; }

    private bool _showLoadingGif;

    private bool ShowLoadingGif
    {
        set
        {
            _showLoadingGif = value;
            if (_showLoadingGif)
            {
                pbx_loadingGif.Visible = true;
            }
            else
            {
                pbx_loadingGif.Visible = false;
            }
        }
    }

    private AcceptButtonTypes ProcButton;


    public yotoDLForm()
    {
        InitializeComponent();
    }
    private void yotoDLForm_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Settings.Default.DefaultFolder))
        {
            startDir = Settings.Default.DefaultFolder;
        }
        else
        {
            startDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToLower();
        }

        btnOpenFolderDia.Image = new Bitmap(SystemIcons.GetStockIcon(StockIconId.FolderOpen).ToBitmap());

        tbxFolder.Text = startDir;
        ProcButton = AcceptButtonTypes.Process;
        MessageBox.Show("I love you, Nat'e! You are the love of my life!", "Message to Nat'e Simone Morrell", buttons: MessageBoxButtons.OK);
    }

    private void startEndTbxs_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void btnOpenFolderDia_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog FBD = new FolderBrowserDialog();
        FBD.InitialDirectory = startDir;
        if (FBD.ShowDialog() == DialogResult.OK)
        {
            if (!Directory.Exists(FBD.SelectedPath))
            {
                Directory.CreateDirectory(FBD.SelectedPath);
            }
            DirLocation = FBD.SelectedPath;
        }

    }


    private async void tbxUrl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
        if ((e.Modifiers & Keys.Control) == Keys.Control && e.KeyCode == Keys.V)
        {
            if (Clipboard.ContainsText())
            {
                ResetVariablesToDefault();

                string clipText = Clipboard.GetText();

                if (clipText.StartsWith("https://"))
                {
                    URL = clipText;
                    ProcType = ProcessTypes.fetch;
                    await RunProcess();
                }
            }
        }
    }

    private async Task RunProcess()
    {
        ShowLoadingGif = true;

        using (Process process = new Process())
        {
            process.StartInfo.FileName = "yt-dlp.exe";

            switch (ProcType)
            {
                case ProcessTypes.fetch:
                    process.StartInfo.Arguments = $"c/ --get-duration --get-title {URL}";
                    break;

                case ProcessTypes.downloadAll:
                    process.StartInfo.Arguments = $"c/ {ytdlpScriptMain} {URL}";
                    break;

                case ProcessTypes.downloadSpec:

                    process.StartInfo.Arguments = $"c/ {ytdlpScriptMain} {URL} {ytdlpStart} {SetFullStringStart} \"-to\" {SetFullStringEnd}\"";
                    break;

                default:
                    break;
            }

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WorkingDirectory = DirLocation;

            process.Start();

            YtDlpOutput = await process.StandardOutput.ReadToEndAsync();
            await process.WaitForExitAsync();


            ProcessOutputVariables();
            
        }
        ShowLoadingGif = false;
    }

    private void ProcessOutputVariables()
    {
        if (string.IsNullOrWhiteSpace(YtDlpOutput))
        {
            return;
        }

        switch (ProcType)
        {
            case ProcessTypes.fetch:
                string[] tempData = YtDlpOutput.Split('\n');
                foreach (var data in tempData)
                {
                    var tempTime = data.Split(':');

                    if (tempTime.All(t => t.All(char.IsDigit)))
                    {
                        if (tempTime.Length > 2)
                        {
                            EndHr = tempTime[0];
                            EndMin = tempTime[1];
                            EndSec = tempTime[2];
                        }
                        else
                        {
                            EndHr = "00";
                            EndMin = tempTime[0];
                            EndSec = tempTime[1];
                        }
                        break;
                    }
                }
                TrackTitle = tempData[0];
                ModifyFormValues();
                lbl_Title.Visible = true;
                break;
            default:
                lbl_Title.Text = "Download Complete!";
                break;
        }
    }

    private void ModifyFormValues()
    {
        tbxEndHr.Text = EndHr;
        tbxEndMin.Text = EndMin;
        tbxEndSec.Text = EndSec;
        lbl_Title.Text = $"\"{TrackTitle}\'";
    }

    private void CenterLabel(Label lbl)
    {
        this.BeginInvoke((Action)(() =>
        {
            lbl.Left = (this.ClientSize.Width - lbl.Width) / 2;
            // lbl.Top = (this.ClientSize.Height - lbl.Height) / 2; // Uncomment to center vertically as well
        }));
    }

    private void lbl_Title_TextChanged(object sender, EventArgs e)
    {
        CenterLabel(lbl_Title);
    }

    private void ResetVariablesToDefault()
    {
        lbl_Title.Text = "";
        lbl_Title.Visible = false;
        tbxEndHr.Text = "00";
        tbxEndMin.Text = "00";
        tbxEndSec.Text = "00";
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void btnProcess_Click(object sender, EventArgs e)
    {
        if (ProcButton == AcceptButtonTypes.Process)
        {
            if (cbx_Full.Checked)
            {
                ProcType = ProcessTypes.downloadAll;
            }
            else
            {
                ProcType = ProcessTypes.downloadSpec;
                await SetStartAndEndStrings();
            }

            await RunProcess();
            btnProcess.Text = "Add New";
            ProcButton = AcceptButtonTypes.AddNew;
        }
        else
        {
            lbl_Title.Text = "Paste Another Url into Textbox!";
            btnProcess.Text = "Process";
            ProcButton = AcceptButtonTypes.Process;
        }

    }

    private Task SetStartAndEndStrings()
    {
        string stHr = string.IsNullOrEmpty(tbxStartHr.Text) ? "00" : tbxStartHr.Text;
        string stMin = string.IsNullOrEmpty(tbxStartMin.Text) ? "00" : tbxStartMin.Text;
        string stSec = string.IsNullOrEmpty(tbxStartSec.Text) ? "00" : tbxStartSec.Text;
        string endHr = string.IsNullOrEmpty(tbxEndHr.Text) ? "00" : tbxEndHr.Text;
        string endMin = string.IsNullOrEmpty(tbxEndMin.Text) ? "00" : tbxEndMin.Text;
        string endSec = string.IsNullOrEmpty(tbxEndSec.Text) ? "00" : tbxEndSec.Text;

        if (stHr.Length < 2)
        {
            stHr = "0" + stHr;
        }
        if (stMin.Length < 2)
        {
            stMin = "0" + stMin;
        }
        if (stSec.Length < 2)
        {
            stSec = "0" + stSec;
        }
        if (endHr.Length < 2)
        {
            endHr = "0" + endHr;
        }
        if (endMin.Length < 2)
        {
            endMin = "0" + endMin;
        }
        if (endSec.Length < 2)
        {
            endSec = "0" + endSec;
        }

        SetFullStringStart = $"{stHr}:{stMin}:{stSec}";
        SetFullStringEnd = $"{endHr}:{endMin}:{endSec}";

        return Task.CompletedTask;
    }

    private void cbx_Full_CheckedChanged(object sender, EventArgs e)
    {
        if (cbx_Full.Checked == true)
        {
            tbxEndHr.Enabled = false;
            tbxEndMin.Enabled = false;
            tbxEndSec.Enabled = false; 
            tbxStartHr.Enabled = false;
            tbxStartMin.Enabled = false;
            tbxStartSec.Enabled = false;
        }
        else
        {
            tbxEndHr.Enabled = true;
            tbxEndMin.Enabled = true;
            tbxEndSec.Enabled = true;
            tbxStartHr.Enabled = true;
            tbxStartMin.Enabled = true;
            tbxStartSec.Enabled = true;
        }
    }

    private enum ProcessTypes
    {
        fetch,
        downloadAll,
        downloadSpec
    }

    private enum AcceptButtonTypes
    {
        Process,
        AddNew
    }
}

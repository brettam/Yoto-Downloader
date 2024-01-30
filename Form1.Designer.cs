namespace Yoto_Downloader;

partial class yotoDLForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yotoDLForm));
        tbxUrl = new TextBox();
        label1 = new Label();
        tbxStartHr = new TextBox();
        tbxStartMin = new TextBox();
        label2 = new Label();
        label3 = new Label();
        tbxStartSec = new TextBox();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        tbxEndSec = new TextBox();
        label7 = new Label();
        tbxEndMin = new TextBox();
        tbxEndHr = new TextBox();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        groupBox1 = new GroupBox();
        cbx_Full = new CheckBox();
        label15 = new Label();
        tbxFolder = new TextBox();
        btnProcess = new Button();
        btnOpenFolderDia = new Button();
        btnCancel = new Button();
        label16 = new Label();
        lbl_Title = new Label();
        pbx_loadingGif = new PictureBox();
        btnOpenFolder = new Button();
        cbxSaveDefaultFolder = new CheckBox();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbx_loadingGif).BeginInit();
        SuspendLayout();
        // 
        // tbxUrl
        // 
        tbxUrl.Font = new Font("Arial", 12F);
        tbxUrl.ForeColor = Color.DimGray;
        tbxUrl.Location = new Point(89, 31);
        tbxUrl.Name = "tbxUrl";
        tbxUrl.Size = new Size(622, 26);
        tbxUrl.TabIndex = 1;
        tbxUrl.PreviewKeyDown += tbxUrl_PreviewKeyDown;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(45, 34);
        label1.Name = "label1";
        label1.Size = new Size(38, 22);
        label1.TabIndex = 1;
        label1.Text = "Url:";
        // 
        // tbxStartHr
        // 
        tbxStartHr.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbxStartHr.Enabled = false;
        tbxStartHr.Location = new Point(81, 56);
        tbxStartHr.MaxLength = 2;
        tbxStartHr.Name = "tbxStartHr";
        tbxStartHr.PlaceholderText = "00";
        tbxStartHr.Size = new Size(28, 29);
        tbxStartHr.TabIndex = 2;
        tbxStartHr.KeyPress += startEndTbxs_KeyPress;
        // 
        // tbxStartMin
        // 
        tbxStartMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbxStartMin.Enabled = false;
        tbxStartMin.Location = new Point(136, 56);
        tbxStartMin.MaxLength = 2;
        tbxStartMin.Name = "tbxStartMin";
        tbxStartMin.PlaceholderText = "00";
        tbxStartMin.Size = new Size(28, 29);
        tbxStartMin.TabIndex = 3;
        tbxStartMin.KeyPress += startEndTbxs_KeyPress;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.BackColor = Color.FromArgb(170, 154, 154);
        label2.FlatStyle = FlatStyle.System;
        label2.Location = new Point(115, 59);
        label2.Name = "label2";
        label2.Size = new Size(15, 22);
        label2.TabIndex = 0;
        label2.Text = ":";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.BackColor = Color.FromArgb(170, 154, 154);
        label3.FlatStyle = FlatStyle.System;
        label3.Location = new Point(170, 59);
        label3.Name = "label3";
        label3.Size = new Size(15, 22);
        label3.TabIndex = 4;
        label3.Text = ":";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbxStartSec
        // 
        tbxStartSec.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbxStartSec.Enabled = false;
        tbxStartSec.Location = new Point(191, 56);
        tbxStartSec.MaxLength = 2;
        tbxStartSec.Name = "tbxStartSec";
        tbxStartSec.PlaceholderText = "00";
        tbxStartSec.Size = new Size(28, 29);
        tbxStartSec.TabIndex = 5;
        tbxStartSec.KeyPress += startEndTbxs_KeyPress;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(21, 59);
        label4.Name = "label4";
        label4.Size = new Size(54, 22);
        label4.TabIndex = 6;
        label4.Text = "Start:";
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(271, 59);
        label5.Name = "label5";
        label5.Size = new Size(49, 22);
        label5.TabIndex = 12;
        label5.Text = "End:";
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label6.AutoSize = true;
        label6.BackColor = Color.FromArgb(170, 154, 154);
        label6.FlatStyle = FlatStyle.System;
        label6.Location = new Point(415, 59);
        label6.Name = "label6";
        label6.Size = new Size(15, 22);
        label6.TabIndex = 10;
        label6.Text = ":";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbxEndSec
        // 
        tbxEndSec.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbxEndSec.Enabled = false;
        tbxEndSec.Location = new Point(436, 56);
        tbxEndSec.MaxLength = 2;
        tbxEndSec.Name = "tbxEndSec";
        tbxEndSec.PlaceholderText = "00";
        tbxEndSec.Size = new Size(28, 29);
        tbxEndSec.TabIndex = 11;
        tbxEndSec.KeyPress += startEndTbxs_KeyPress;
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label7.AutoSize = true;
        label7.BackColor = Color.FromArgb(170, 154, 154);
        label7.FlatStyle = FlatStyle.System;
        label7.Location = new Point(360, 59);
        label7.Name = "label7";
        label7.Size = new Size(15, 22);
        label7.TabIndex = 7;
        label7.Text = ":";
        label7.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbxEndMin
        // 
        tbxEndMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbxEndMin.Enabled = false;
        tbxEndMin.Location = new Point(381, 56);
        tbxEndMin.MaxLength = 2;
        tbxEndMin.Name = "tbxEndMin";
        tbxEndMin.PlaceholderText = "00";
        tbxEndMin.Size = new Size(28, 29);
        tbxEndMin.TabIndex = 9;
        tbxEndMin.KeyPress += startEndTbxs_KeyPress;
        // 
        // tbxEndHr
        // 
        tbxEndHr.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbxEndHr.Enabled = false;
        tbxEndHr.Location = new Point(326, 56);
        tbxEndHr.MaxLength = 2;
        tbxEndHr.Name = "tbxEndHr";
        tbxEndHr.PlaceholderText = "00";
        tbxEndHr.Size = new Size(28, 29);
        tbxEndHr.TabIndex = 8;
        tbxEndHr.KeyPress += startEndTbxs_KeyPress;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label8.AutoSize = true;
        label8.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label8.Location = new Point(82, 31);
        label8.Name = "label8";
        label8.Size = new Size(27, 18);
        label8.TabIndex = 13;
        label8.Text = "Hr";
        // 
        // label9
        // 
        label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label9.AutoSize = true;
        label9.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label9.Location = new Point(133, 31);
        label9.Name = "label9";
        label9.Size = new Size(35, 18);
        label9.TabIndex = 14;
        label9.Text = "Min";
        // 
        // label10
        // 
        label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label10.AutoSize = true;
        label10.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label10.Location = new Point(191, 31);
        label10.Name = "label10";
        label10.Size = new Size(30, 18);
        label10.TabIndex = 15;
        label10.Text = "Sec";
        // 
        // label11
        // 
        label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label11.AutoSize = true;
        label11.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label11.Location = new Point(436, 31);
        label11.Name = "label11";
        label11.Size = new Size(30, 18);
        label11.TabIndex = 18;
        label11.Text = "Sec";
        // 
        // label12
        // 
        label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label12.AutoSize = true;
        label12.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label12.Location = new Point(378, 31);
        label12.Name = "label12";
        label12.Size = new Size(35, 18);
        label12.TabIndex = 17;
        label12.Text = "Min";
        // 
        // label13
        // 
        label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label13.AutoSize = true;
        label13.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label13.Location = new Point(327, 31);
        label13.Name = "label13";
        label13.Size = new Size(27, 18);
        label13.TabIndex = 16;
        label13.Text = "Hr";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cbx_Full);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label11);
        groupBox1.Controls.Add(tbxStartHr);
        groupBox1.Controls.Add(label12);
        groupBox1.Controls.Add(tbxStartMin);
        groupBox1.Controls.Add(label13);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(tbxStartSec);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(tbxEndHr);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(tbxEndMin);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(tbxEndSec);
        groupBox1.FlatStyle = FlatStyle.System;
        groupBox1.ForeColor = SystemColors.ControlText;
        groupBox1.Location = new Point(153, 132);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(482, 136);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "Settings";
        // 
        // cbx_Full
        // 
        cbx_Full.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cbx_Full.AutoSize = true;
        cbx_Full.Checked = true;
        cbx_Full.CheckState = CheckState.Checked;
        cbx_Full.Font = new Font("Arial", 12F);
        cbx_Full.Location = new Point(170, 108);
        cbx_Full.Name = "cbx_Full";
        cbx_Full.Size = new Size(166, 22);
        cbx_Full.TabIndex = 0;
        cbx_Full.Text = "Download Full Song";
        cbx_Full.UseVisualStyleBackColor = true;
        cbx_Full.CheckedChanged += cbx_Full_CheckedChanged;
        // 
        // label15
        // 
        label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label15.AutoSize = true;
        label15.Location = new Point(12, 300);
        label15.Name = "label15";
        label15.Size = new Size(135, 22);
        label15.TabIndex = 22;
        label15.Text = "Save Location:";
        // 
        // tbxFolder
        // 
        tbxFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        tbxFolder.Location = new Point(153, 297);
        tbxFolder.Name = "tbxFolder";
        tbxFolder.PlaceholderText = "c:\\";
        tbxFolder.Size = new Size(482, 29);
        tbxFolder.TabIndex = 23;
        // 
        // btnProcess
        // 
        btnProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnProcess.Font = new Font("Arial", 12F);
        btnProcess.Location = new Point(693, 360);
        btnProcess.Name = "btnProcess";
        btnProcess.Size = new Size(79, 31);
        btnProcess.TabIndex = 4;
        btnProcess.Text = "Process";
        btnProcess.UseVisualStyleBackColor = true;
        btnProcess.Click += btnProcess_Click;
        // 
        // btnOpenFolderDia
        // 
        btnOpenFolderDia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnOpenFolderDia.Font = new Font("Arial", 12F);
        btnOpenFolderDia.Location = new Point(641, 294);
        btnOpenFolderDia.Name = "btnOpenFolderDia";
        btnOpenFolderDia.Size = new Size(46, 34);
        btnOpenFolderDia.TabIndex = 2;
        btnOpenFolderDia.TextAlign = ContentAlignment.TopCenter;
        btnOpenFolderDia.UseVisualStyleBackColor = true;
        btnOpenFolderDia.Click += btnOpenFolderDia_Click;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancel.Font = new Font("Arial", 12F);
        btnCancel.Location = new Point(604, 360);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(83, 31);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // label16
        // 
        label16.Anchor = AnchorStyles.Top;
        label16.AutoSize = true;
        label16.Font = new Font("Calibri", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label16.ForeColor = Color.FromArgb(128, 36, 0);
        label16.Location = new Point(232, 66);
        label16.Name = "label16";
        label16.Size = new Size(326, 23);
        label16.TabIndex = 27;
        label16.Text = "Copy and Paste Youtube URL into Textbox";
        label16.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_Title
        // 
        lbl_Title.AutoSize = true;
        lbl_Title.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lbl_Title.ForeColor = Color.Lavender;
        lbl_Title.Location = new Point(400, 110);
        lbl_Title.Name = "lbl_Title";
        lbl_Title.Size = new Size(0, 19);
        lbl_Title.TabIndex = 29;
        lbl_Title.TextAlign = ContentAlignment.TopCenter;
        lbl_Title.Visible = false;
        lbl_Title.TextChanged += lbl_Title_TextChanged;
        // 
        // pbx_loadingGif
        // 
        pbx_loadingGif.BackColor = Color.Transparent;
        pbx_loadingGif.BackgroundImageLayout = ImageLayout.None;
        pbx_loadingGif.Image = (Image)resources.GetObject("pbx_loadingGif.Image");
        pbx_loadingGif.Location = new Point(367, 66);
        pbx_loadingGif.Name = "pbx_loadingGif";
        pbx_loadingGif.Size = new Size(70, 70);
        pbx_loadingGif.SizeMode = PictureBoxSizeMode.Zoom;
        pbx_loadingGif.TabIndex = 28;
        pbx_loadingGif.TabStop = false;
        pbx_loadingGif.Visible = false;
        // 
        // btnOpenFolder
        // 
        btnOpenFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnOpenFolder.Font = new Font("Arial", 12F);
        btnOpenFolder.Location = new Point(12, 360);
        btnOpenFolder.Name = "btnOpenFolder";
        btnOpenFolder.Size = new Size(124, 31);
        btnOpenFolder.TabIndex = 30;
        btnOpenFolder.Text = "Open Directory";
        btnOpenFolder.UseVisualStyleBackColor = true;
        btnOpenFolder.Click += btnOpenFolder_Click;
        // 
        // cbxSaveDefaultFolder
        // 
        cbxSaveDefaultFolder.AutoSize = true;
        cbxSaveDefaultFolder.Font = new Font("Arial", 12F, FontStyle.Italic);
        cbxSaveDefaultFolder.Location = new Point(160, 332);
        cbxSaveDefaultFolder.Name = "cbxSaveDefaultFolder";
        cbxSaveDefaultFolder.Size = new Size(191, 23);
        cbxSaveDefaultFolder.TabIndex = 31;
        cbxSaveDefaultFolder.Text = "Save as Default Folder";
        cbxSaveDefaultFolder.UseVisualStyleBackColor = true;
        // 
        // yotoDLForm
        // 
        AcceptButton = btnProcess;
        AutoScaleDimensions = new SizeF(11F, 22F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(170, 154, 154);
        CancelButton = btnCancel;
        ClientSize = new Size(784, 403);
        Controls.Add(cbxSaveDefaultFolder);
        Controls.Add(btnOpenFolder);
        Controls.Add(lbl_Title);
        Controls.Add(pbx_loadingGif);
        Controls.Add(label16);
        Controls.Add(btnCancel);
        Controls.Add(btnOpenFolderDia);
        Controls.Add(btnProcess);
        Controls.Add(tbxFolder);
        Controls.Add(label15);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Controls.Add(tbxUrl);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5, 4, 5, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "yotoDLForm";
        Text = "Yoto - Youtube Audio Downloader";
        FormClosing += yotoDLForm_FormClosing;
        Load += yotoDLForm_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbx_loadingGif).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox tbxUrl;
    private Label label1;
    private TextBox tbxStartHr;
    private TextBox tbxStartMin;
    private Label label2;
    private Label label3;
    private TextBox tbxStartSec;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox tbxEndSec;
    private Label label7;
    private TextBox tbxEndMin;
    private TextBox tbxEndHr;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private GroupBox groupBox1;
    private Label label15;
    private TextBox tbxFolder;
    private Button btnProcess;
    private Button btnOpenFolderDia;
    private Button btnCancel;
    private Label label16;
    private Label lbl_Title;
    private PictureBox pbx_loadingGif;
    private CheckBox cbx_Full;
    private Button btnOpenFolder;
    private CheckBox cbxSaveDefaultFolder;
}

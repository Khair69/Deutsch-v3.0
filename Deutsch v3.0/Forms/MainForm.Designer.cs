namespace Deutsch_v3._0
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            loadGameBtn = new ReaLTaiizor.Controls.MaterialButton();
            tabs = new ReaLTaiizor.Controls.MaterialTabControl();
            mainMenuTab = new TabPage();
            settingsBtn = new ReaLTaiizor.Controls.MaterialButton();
            newGameBtn = new ReaLTaiizor.Controls.MaterialButton();
            loadGameTab = new TabPage();
            exitBtn_loadgame = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            startSaveBtn = new ReaLTaiizor.Controls.MaterialButton();
            editSaveBtn = new ReaLTaiizor.Controls.MaterialButton();
            deleteSaveBtn = new ReaLTaiizor.Controls.MaterialButton();
            gameSavesLB = new ReaLTaiizor.Controls.MaterialListBox();
            newGameTab = new TabPage();
            exitBtn_newgame = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            saveBtn = new ReaLTaiizor.Controls.MaterialButton();
            langCmb = new ReaLTaiizor.Controls.MaterialComboBox();
            toTxtbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            fromTxtbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pathTxtbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            saveNameTxtbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            gameTab = new TabPage();
            exitGameBtn = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            dWordLbl = new ReaLTaiizor.Controls.MaterialLabel();
            resLbl = new ReaLTaiizor.Controls.MaterialLabel();
            gameProg = new ReaLTaiizor.Controls.MaterialProgressBar();
            ansTxtbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cntBtn = new ReaLTaiizor.Controls.MaterialButton();
            checkBtn = new ReaLTaiizor.Controls.MaterialButton();
            settingsTab = new TabPage();
            darkmodeSwitch = new ReaLTaiizor.Controls.MaterialSwitch();
            exitBtn_settings = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            colorsCmb = new ReaLTaiizor.Controls.MaterialComboBox();
            resaultsTab = new TabPage();
            exitBtn_resualts = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            retryBtn = new ReaLTaiizor.Controls.MaterialButton();
            statsLbl = new ReaLTaiizor.Controls.MaterialLabel();
            tabs.SuspendLayout();
            mainMenuTab.SuspendLayout();
            loadGameTab.SuspendLayout();
            newGameTab.SuspendLayout();
            gameTab.SuspendLayout();
            settingsTab.SuspendLayout();
            resaultsTab.SuspendLayout();
            SuspendLayout();
            // 
            // loadGameBtn
            // 
            loadGameBtn.Anchor = AnchorStyles.None;
            loadGameBtn.AutoSize = false;
            loadGameBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadGameBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadGameBtn.Depth = 0;
            loadGameBtn.HighEmphasis = true;
            loadGameBtn.Icon = null;
            loadGameBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            loadGameBtn.Location = new Point(315, 113);
            loadGameBtn.Margin = new Padding(4, 6, 4, 6);
            loadGameBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            loadGameBtn.Name = "loadGameBtn";
            loadGameBtn.NoAccentTextColor = Color.Empty;
            loadGameBtn.Size = new Size(181, 49);
            loadGameBtn.TabIndex = 0;
            loadGameBtn.Text = "Load Game";
            loadGameBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            loadGameBtn.UseAccentColor = false;
            loadGameBtn.UseVisualStyleBackColor = true;
            loadGameBtn.Click += loadGameBtn_Click;
            // 
            // tabs
            // 
            tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabs.Controls.Add(mainMenuTab);
            tabs.Controls.Add(loadGameTab);
            tabs.Controls.Add(newGameTab);
            tabs.Controls.Add(gameTab);
            tabs.Controls.Add(settingsTab);
            tabs.Controls.Add(resaultsTab);
            tabs.Depth = 0;
            tabs.Location = new Point(3, 24);
            tabs.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabs.Multiline = true;
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(847, 453);
            tabs.TabIndex = 1;
            // 
            // mainMenuTab
            // 
            mainMenuTab.Controls.Add(settingsBtn);
            mainMenuTab.Controls.Add(newGameBtn);
            mainMenuTab.Controls.Add(loadGameBtn);
            mainMenuTab.Location = new Point(4, 24);
            mainMenuTab.Name = "mainMenuTab";
            mainMenuTab.Padding = new Padding(3);
            mainMenuTab.Size = new Size(839, 425);
            mainMenuTab.TabIndex = 0;
            mainMenuTab.Text = "Main Menu";
            mainMenuTab.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            settingsBtn.Anchor = AnchorStyles.None;
            settingsBtn.AutoSize = false;
            settingsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            settingsBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            settingsBtn.Depth = 0;
            settingsBtn.HighEmphasis = true;
            settingsBtn.Icon = null;
            settingsBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            settingsBtn.Location = new Point(315, 237);
            settingsBtn.Margin = new Padding(4, 6, 4, 6);
            settingsBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            settingsBtn.Name = "settingsBtn";
            settingsBtn.NoAccentTextColor = Color.Empty;
            settingsBtn.Size = new Size(181, 49);
            settingsBtn.TabIndex = 0;
            settingsBtn.Text = "SETTINGS";
            settingsBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            settingsBtn.UseAccentColor = false;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // newGameBtn
            // 
            newGameBtn.Anchor = AnchorStyles.None;
            newGameBtn.AutoSize = false;
            newGameBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newGameBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            newGameBtn.Depth = 0;
            newGameBtn.HighEmphasis = true;
            newGameBtn.Icon = null;
            newGameBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            newGameBtn.Location = new Point(315, 175);
            newGameBtn.Margin = new Padding(4, 6, 4, 6);
            newGameBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newGameBtn.Name = "newGameBtn";
            newGameBtn.NoAccentTextColor = Color.Empty;
            newGameBtn.Size = new Size(181, 49);
            newGameBtn.TabIndex = 0;
            newGameBtn.Text = "New Game";
            newGameBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newGameBtn.UseAccentColor = false;
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // loadGameTab
            // 
            loadGameTab.Controls.Add(exitBtn_loadgame);
            loadGameTab.Controls.Add(startSaveBtn);
            loadGameTab.Controls.Add(editSaveBtn);
            loadGameTab.Controls.Add(deleteSaveBtn);
            loadGameTab.Controls.Add(gameSavesLB);
            loadGameTab.Location = new Point(4, 24);
            loadGameTab.Name = "loadGameTab";
            loadGameTab.Padding = new Padding(3);
            loadGameTab.Size = new Size(839, 425);
            loadGameTab.TabIndex = 1;
            loadGameTab.Text = "Load Game";
            loadGameTab.UseVisualStyleBackColor = true;
            // 
            // exitBtn_loadgame
            // 
            exitBtn_loadgame.Depth = 0;
            exitBtn_loadgame.Icon = Properties.Resources.icons8_back_100;
            exitBtn_loadgame.Location = new Point(6, 6);
            exitBtn_loadgame.Mini = true;
            exitBtn_loadgame.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exitBtn_loadgame.Name = "exitBtn_loadgame";
            exitBtn_loadgame.Size = new Size(40, 40);
            exitBtn_loadgame.TabIndex = 4;
            exitBtn_loadgame.UseVisualStyleBackColor = true;
            exitBtn_loadgame.Click += exitBtn_Click;
            // 
            // startSaveBtn
            // 
            startSaveBtn.Anchor = AnchorStyles.None;
            startSaveBtn.AutoSize = false;
            startSaveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            startSaveBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            startSaveBtn.Depth = 0;
            startSaveBtn.HighEmphasis = true;
            startSaveBtn.Icon = null;
            startSaveBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            startSaveBtn.Location = new Point(591, 187);
            startSaveBtn.Margin = new Padding(4, 6, 4, 6);
            startSaveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            startSaveBtn.Name = "startSaveBtn";
            startSaveBtn.NoAccentTextColor = Color.Empty;
            startSaveBtn.Size = new Size(67, 36);
            startSaveBtn.TabIndex = 3;
            startSaveBtn.Text = "START";
            startSaveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            startSaveBtn.UseAccentColor = false;
            startSaveBtn.UseVisualStyleBackColor = true;
            startSaveBtn.Click += startSaveBtn_Click;
            // 
            // editSaveBtn
            // 
            editSaveBtn.Anchor = AnchorStyles.None;
            editSaveBtn.AutoSize = false;
            editSaveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editSaveBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            editSaveBtn.Depth = 0;
            editSaveBtn.HighEmphasis = true;
            editSaveBtn.Icon = null;
            editSaveBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            editSaveBtn.Location = new Point(591, 235);
            editSaveBtn.Margin = new Padding(4, 6, 4, 6);
            editSaveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            editSaveBtn.Name = "editSaveBtn";
            editSaveBtn.NoAccentTextColor = Color.Empty;
            editSaveBtn.Size = new Size(67, 36);
            editSaveBtn.TabIndex = 2;
            editSaveBtn.Text = "EDIT";
            editSaveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            editSaveBtn.UseAccentColor = false;
            editSaveBtn.UseVisualStyleBackColor = true;
            // 
            // deleteSaveBtn
            // 
            deleteSaveBtn.Anchor = AnchorStyles.None;
            deleteSaveBtn.AutoSize = false;
            deleteSaveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteSaveBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteSaveBtn.Depth = 0;
            deleteSaveBtn.HighEmphasis = true;
            deleteSaveBtn.Icon = null;
            deleteSaveBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            deleteSaveBtn.Location = new Point(591, 283);
            deleteSaveBtn.Margin = new Padding(4, 6, 4, 6);
            deleteSaveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            deleteSaveBtn.Name = "deleteSaveBtn";
            deleteSaveBtn.NoAccentTextColor = Color.Empty;
            deleteSaveBtn.Size = new Size(67, 36);
            deleteSaveBtn.TabIndex = 1;
            deleteSaveBtn.Text = "DELETE";
            deleteSaveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteSaveBtn.UseAccentColor = false;
            deleteSaveBtn.UseVisualStyleBackColor = true;
            // 
            // gameSavesLB
            // 
            gameSavesLB.Anchor = AnchorStyles.None;
            gameSavesLB.BackColor = Color.White;
            gameSavesLB.BorderColor = Color.LightGray;
            gameSavesLB.Depth = 0;
            gameSavesLB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            gameSavesLB.Location = new Point(226, 83);
            gameSavesLB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            gameSavesLB.Name = "gameSavesLB";
            gameSavesLB.SelectedIndex = -1;
            gameSavesLB.SelectedItem = null;
            gameSavesLB.Size = new Size(332, 236);
            gameSavesLB.TabIndex = 0;
            // 
            // newGameTab
            // 
            newGameTab.Controls.Add(exitBtn_newgame);
            newGameTab.Controls.Add(saveBtn);
            newGameTab.Controls.Add(langCmb);
            newGameTab.Controls.Add(toTxtbox);
            newGameTab.Controls.Add(fromTxtbox);
            newGameTab.Controls.Add(pathTxtbox);
            newGameTab.Controls.Add(saveNameTxtbox);
            newGameTab.Location = new Point(4, 24);
            newGameTab.Name = "newGameTab";
            newGameTab.Padding = new Padding(3);
            newGameTab.Size = new Size(839, 425);
            newGameTab.TabIndex = 2;
            newGameTab.Text = "New Game";
            newGameTab.UseVisualStyleBackColor = true;
            // 
            // exitBtn_newgame
            // 
            exitBtn_newgame.Depth = 0;
            exitBtn_newgame.Icon = Properties.Resources.icons8_back_100;
            exitBtn_newgame.Location = new Point(6, 6);
            exitBtn_newgame.Mini = true;
            exitBtn_newgame.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exitBtn_newgame.Name = "exitBtn_newgame";
            exitBtn_newgame.Size = new Size(40, 40);
            exitBtn_newgame.TabIndex = 3;
            exitBtn_newgame.UseVisualStyleBackColor = true;
            exitBtn_newgame.Click += exitBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveBtn.Depth = 0;
            saveBtn.HighEmphasis = true;
            saveBtn.Icon = null;
            saveBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            saveBtn.Location = new Point(606, 297);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(64, 36);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // langCmb
            // 
            langCmb.Anchor = AnchorStyles.None;
            langCmb.AutoResize = false;
            langCmb.BackColor = Color.FromArgb(255, 255, 255);
            langCmb.Depth = 0;
            langCmb.DrawMode = DrawMode.OwnerDrawVariable;
            langCmb.DropDownHeight = 174;
            langCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            langCmb.DropDownWidth = 121;
            langCmb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            langCmb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            langCmb.FormattingEnabled = true;
            langCmb.IntegralHeight = false;
            langCmb.ItemHeight = 43;
            langCmb.Items.AddRange(new object[] { "German To English" });
            langCmb.Location = new Point(229, 145);
            langCmb.MaxDropDownItems = 4;
            langCmb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            langCmb.Name = "langCmb";
            langCmb.Size = new Size(331, 49);
            langCmb.StartIndex = 0;
            langCmb.TabIndex = 1;
            // 
            // toTxtbox
            // 
            toTxtbox.Anchor = AnchorStyles.None;
            toTxtbox.AnimateReadOnly = false;
            toTxtbox.AutoCompleteMode = AutoCompleteMode.None;
            toTxtbox.AutoCompleteSource = AutoCompleteSource.None;
            toTxtbox.BackgroundImageLayout = ImageLayout.None;
            toTxtbox.CharacterCasing = CharacterCasing.Normal;
            toTxtbox.Depth = 0;
            toTxtbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            toTxtbox.HelperText = "To";
            toTxtbox.HideSelection = true;
            toTxtbox.Hint = "To";
            toTxtbox.LeadingIcon = null;
            toTxtbox.Location = new Point(418, 285);
            toTxtbox.MaxLength = 32767;
            toTxtbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            toTxtbox.Name = "toTxtbox";
            toTxtbox.PasswordChar = '\0';
            toTxtbox.PrefixSuffixText = null;
            toTxtbox.ReadOnly = false;
            toTxtbox.RightToLeft = RightToLeft.No;
            toTxtbox.SelectedText = "";
            toTxtbox.SelectionLength = 0;
            toTxtbox.SelectionStart = 0;
            toTxtbox.ShortcutsEnabled = true;
            toTxtbox.Size = new Size(142, 48);
            toTxtbox.TabIndex = 0;
            toTxtbox.TabStop = false;
            toTxtbox.TextAlign = HorizontalAlignment.Left;
            toTxtbox.TrailingIcon = null;
            toTxtbox.UseSystemPasswordChar = false;
            toTxtbox.KeyDown += toTxtbox_KeyDown;
            // 
            // fromTxtbox
            // 
            fromTxtbox.Anchor = AnchorStyles.None;
            fromTxtbox.AnimateReadOnly = false;
            fromTxtbox.AutoCompleteMode = AutoCompleteMode.None;
            fromTxtbox.AutoCompleteSource = AutoCompleteSource.None;
            fromTxtbox.BackgroundImageLayout = ImageLayout.None;
            fromTxtbox.CharacterCasing = CharacterCasing.Normal;
            fromTxtbox.Depth = 0;
            fromTxtbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fromTxtbox.HelperText = "From";
            fromTxtbox.HideSelection = true;
            fromTxtbox.Hint = "From";
            fromTxtbox.LeadingIcon = null;
            fromTxtbox.Location = new Point(229, 285);
            fromTxtbox.MaxLength = 32767;
            fromTxtbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            fromTxtbox.Name = "fromTxtbox";
            fromTxtbox.PasswordChar = '\0';
            fromTxtbox.PrefixSuffixText = null;
            fromTxtbox.ReadOnly = false;
            fromTxtbox.RightToLeft = RightToLeft.No;
            fromTxtbox.SelectedText = "";
            fromTxtbox.SelectionLength = 0;
            fromTxtbox.SelectionStart = 0;
            fromTxtbox.ShortcutsEnabled = true;
            fromTxtbox.Size = new Size(142, 48);
            fromTxtbox.TabIndex = 0;
            fromTxtbox.TabStop = false;
            fromTxtbox.TextAlign = HorizontalAlignment.Left;
            fromTxtbox.TrailingIcon = null;
            fromTxtbox.UseSystemPasswordChar = false;
            fromTxtbox.KeyDown += fromTxtbox_KeyDown;
            // 
            // pathTxtbox
            // 
            pathTxtbox.Anchor = AnchorStyles.None;
            pathTxtbox.AnimateReadOnly = false;
            pathTxtbox.AutoCompleteMode = AutoCompleteMode.None;
            pathTxtbox.AutoCompleteSource = AutoCompleteSource.None;
            pathTxtbox.BackgroundImageLayout = ImageLayout.None;
            pathTxtbox.CharacterCasing = CharacterCasing.Normal;
            pathTxtbox.Depth = 0;
            pathTxtbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pathTxtbox.HelperText = "File Name";
            pathTxtbox.HideSelection = true;
            pathTxtbox.Hint = "File Name";
            pathTxtbox.LeadingIcon = Properties.Resources.icons8_file_64;
            pathTxtbox.Location = new Point(229, 219);
            pathTxtbox.MaxLength = 32767;
            pathTxtbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            pathTxtbox.Name = "pathTxtbox";
            pathTxtbox.PasswordChar = '\0';
            pathTxtbox.PrefixSuffixText = null;
            pathTxtbox.ReadOnly = false;
            pathTxtbox.RightToLeft = RightToLeft.No;
            pathTxtbox.SelectedText = "";
            pathTxtbox.SelectionLength = 0;
            pathTxtbox.SelectionStart = 0;
            pathTxtbox.ShortcutsEnabled = true;
            pathTxtbox.Size = new Size(331, 48);
            pathTxtbox.TabIndex = 0;
            pathTxtbox.TabStop = false;
            pathTxtbox.TextAlign = HorizontalAlignment.Left;
            pathTxtbox.TrailingIcon = null;
            pathTxtbox.UseSystemPasswordChar = false;
            pathTxtbox.KeyDown += pathTxtbox_KeyDown;
            // 
            // saveNameTxtbox
            // 
            saveNameTxtbox.Anchor = AnchorStyles.None;
            saveNameTxtbox.AnimateReadOnly = false;
            saveNameTxtbox.AutoCompleteMode = AutoCompleteMode.None;
            saveNameTxtbox.AutoCompleteSource = AutoCompleteSource.None;
            saveNameTxtbox.BackgroundImageLayout = ImageLayout.None;
            saveNameTxtbox.CharacterCasing = CharacterCasing.Normal;
            saveNameTxtbox.Depth = 0;
            saveNameTxtbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            saveNameTxtbox.HelperText = "Preset Name";
            saveNameTxtbox.HideSelection = true;
            saveNameTxtbox.Hint = "Preset Name";
            saveNameTxtbox.LeadingIcon = Properties.Resources.round_bookmark_white_24dp;
            saveNameTxtbox.Location = new Point(229, 73);
            saveNameTxtbox.MaxLength = 32767;
            saveNameTxtbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            saveNameTxtbox.Name = "saveNameTxtbox";
            saveNameTxtbox.PasswordChar = '\0';
            saveNameTxtbox.PrefixSuffixText = null;
            saveNameTxtbox.ReadOnly = false;
            saveNameTxtbox.RightToLeft = RightToLeft.No;
            saveNameTxtbox.SelectedText = "";
            saveNameTxtbox.SelectionLength = 0;
            saveNameTxtbox.SelectionStart = 0;
            saveNameTxtbox.ShortcutsEnabled = true;
            saveNameTxtbox.Size = new Size(331, 48);
            saveNameTxtbox.TabIndex = 0;
            saveNameTxtbox.TabStop = false;
            saveNameTxtbox.TextAlign = HorizontalAlignment.Left;
            saveNameTxtbox.TrailingIcon = null;
            saveNameTxtbox.UseSystemPasswordChar = false;
            saveNameTxtbox.KeyDown += saveNameTxtbox_KeyDown;
            // 
            // gameTab
            // 
            gameTab.Controls.Add(exitGameBtn);
            gameTab.Controls.Add(dWordLbl);
            gameTab.Controls.Add(resLbl);
            gameTab.Controls.Add(gameProg);
            gameTab.Controls.Add(ansTxtbox);
            gameTab.Controls.Add(cntBtn);
            gameTab.Controls.Add(checkBtn);
            gameTab.Location = new Point(4, 24);
            gameTab.Name = "gameTab";
            gameTab.Padding = new Padding(3);
            gameTab.Size = new Size(839, 425);
            gameTab.TabIndex = 3;
            gameTab.Text = "Game";
            gameTab.UseVisualStyleBackColor = true;
            // 
            // exitGameBtn
            // 
            exitGameBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitGameBtn.Depth = 0;
            exitGameBtn.Icon = Properties.Resources.icons8_x_64;
            exitGameBtn.Location = new Point(6, 379);
            exitGameBtn.Mini = true;
            exitGameBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exitGameBtn.Name = "exitGameBtn";
            exitGameBtn.Size = new Size(40, 40);
            exitGameBtn.TabIndex = 7;
            exitGameBtn.UseVisualStyleBackColor = true;
            exitGameBtn.Click += exitGameBtn_Click;
            // 
            // dWordLbl
            // 
            dWordLbl.Anchor = AnchorStyles.None;
            dWordLbl.Depth = 0;
            dWordLbl.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            dWordLbl.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
            dWordLbl.Location = new Point(259, 124);
            dWordLbl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            dWordLbl.Name = "dWordLbl";
            dWordLbl.Size = new Size(300, 58);
            dWordLbl.TabIndex = 6;
            dWordLbl.Text = "Deutsch Word";
            dWordLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resLbl
            // 
            resLbl.Anchor = AnchorStyles.Bottom;
            resLbl.AutoSize = true;
            resLbl.Depth = 0;
            resLbl.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            resLbl.Location = new Point(278, 302);
            resLbl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            resLbl.Name = "resLbl";
            resLbl.Size = new Size(1, 0);
            resLbl.TabIndex = 5;
            resLbl.Visible = false;
            // 
            // gameProg
            // 
            gameProg.Anchor = AnchorStyles.Top;
            gameProg.Depth = 0;
            gameProg.Location = new Point(67, 24);
            gameProg.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            gameProg.Name = "gameProg";
            gameProg.Size = new Size(700, 5);
            gameProg.TabIndex = 4;
            gameProg.UseAccentColor = false;
            // 
            // ansTxtbox
            // 
            ansTxtbox.Anchor = AnchorStyles.None;
            ansTxtbox.AnimateReadOnly = false;
            ansTxtbox.AutoCompleteMode = AutoCompleteMode.None;
            ansTxtbox.AutoCompleteSource = AutoCompleteSource.None;
            ansTxtbox.BackgroundImageLayout = ImageLayout.None;
            ansTxtbox.CharacterCasing = CharacterCasing.Normal;
            ansTxtbox.Depth = 0;
            ansTxtbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ansTxtbox.HideSelection = true;
            ansTxtbox.LeadingIcon = null;
            ansTxtbox.Location = new Point(249, 194);
            ansTxtbox.MaxLength = 32767;
            ansTxtbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ansTxtbox.Name = "ansTxtbox";
            ansTxtbox.PasswordChar = '\0';
            ansTxtbox.PrefixSuffixText = null;
            ansTxtbox.ReadOnly = false;
            ansTxtbox.RightToLeft = RightToLeft.No;
            ansTxtbox.SelectedText = "";
            ansTxtbox.SelectionLength = 0;
            ansTxtbox.SelectionStart = 0;
            ansTxtbox.ShortcutsEnabled = true;
            ansTxtbox.Size = new Size(320, 48);
            ansTxtbox.TabIndex = 0;
            ansTxtbox.TabStop = false;
            ansTxtbox.TextAlign = HorizontalAlignment.Left;
            ansTxtbox.TrailingIcon = null;
            ansTxtbox.UseSystemPasswordChar = false;
            ansTxtbox.KeyDown += ansTxtbox_KeyDown;
            ansTxtbox.TextChanged += ansTxtbox_TextChanged;
            // 
            // cntBtn
            // 
            cntBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cntBtn.AutoSize = false;
            cntBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cntBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            cntBtn.Depth = 0;
            cntBtn.HighEmphasis = true;
            cntBtn.Icon = null;
            cntBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            cntBtn.Location = new Point(655, 285);
            cntBtn.Margin = new Padding(4, 6, 4, 6);
            cntBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cntBtn.Name = "cntBtn";
            cntBtn.NoAccentTextColor = Color.Empty;
            cntBtn.Size = new Size(100, 35);
            cntBtn.TabIndex = 2;
            cntBtn.Text = "Continue";
            cntBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            cntBtn.UseAccentColor = false;
            cntBtn.UseVisualStyleBackColor = true;
            cntBtn.Visible = false;
            cntBtn.Click += cntBtn_Click;
            // 
            // checkBtn
            // 
            checkBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBtn.AutoSize = false;
            checkBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            checkBtn.Depth = 0;
            checkBtn.Enabled = false;
            checkBtn.HighEmphasis = true;
            checkBtn.Icon = null;
            checkBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            checkBtn.Location = new Point(655, 285);
            checkBtn.Margin = new Padding(4, 6, 4, 6);
            checkBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkBtn.Name = "checkBtn";
            checkBtn.NoAccentTextColor = Color.Empty;
            checkBtn.Size = new Size(100, 35);
            checkBtn.TabIndex = 3;
            checkBtn.Text = "Check";
            checkBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            checkBtn.UseAccentColor = false;
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(darkmodeSwitch);
            settingsTab.Controls.Add(exitBtn_settings);
            settingsTab.Controls.Add(colorsCmb);
            settingsTab.Location = new Point(4, 24);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(3);
            settingsTab.Size = new Size(839, 425);
            settingsTab.TabIndex = 4;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // darkmodeSwitch
            // 
            darkmodeSwitch.Anchor = AnchorStyles.None;
            darkmodeSwitch.AutoSize = true;
            darkmodeSwitch.Checked = true;
            darkmodeSwitch.CheckState = CheckState.Checked;
            darkmodeSwitch.Depth = 0;
            darkmodeSwitch.Location = new Point(331, 149);
            darkmodeSwitch.Margin = new Padding(0);
            darkmodeSwitch.MouseLocation = new Point(-1, -1);
            darkmodeSwitch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            darkmodeSwitch.Name = "darkmodeSwitch";
            darkmodeSwitch.Ripple = true;
            darkmodeSwitch.Size = new Size(135, 37);
            darkmodeSwitch.TabIndex = 3;
            darkmodeSwitch.Text = "Dark Mode";
            darkmodeSwitch.UseAccentColor = false;
            darkmodeSwitch.UseVisualStyleBackColor = true;
            darkmodeSwitch.CheckedChanged += darkmodeSwitch_CheckedChanged;
            // 
            // exitBtn_settings
            // 
            exitBtn_settings.Depth = 0;
            exitBtn_settings.Icon = Properties.Resources.icons8_back_100;
            exitBtn_settings.Location = new Point(6, 6);
            exitBtn_settings.Mini = true;
            exitBtn_settings.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exitBtn_settings.Name = "exitBtn_settings";
            exitBtn_settings.Size = new Size(40, 40);
            exitBtn_settings.TabIndex = 2;
            exitBtn_settings.UseVisualStyleBackColor = true;
            exitBtn_settings.Click += exitBtn_Click;
            // 
            // colorsCmb
            // 
            colorsCmb.Anchor = AnchorStyles.None;
            colorsCmb.AutoResize = false;
            colorsCmb.BackColor = Color.FromArgb(255, 255, 255);
            colorsCmb.Depth = 0;
            colorsCmb.DrawMode = DrawMode.OwnerDrawVariable;
            colorsCmb.DropDownHeight = 174;
            colorsCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            colorsCmb.DropDownWidth = 121;
            colorsCmb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            colorsCmb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            colorsCmb.FormattingEnabled = true;
            colorsCmb.Hint = "Select Color Scheme";
            colorsCmb.IntegralHeight = false;
            colorsCmb.ItemHeight = 43;
            colorsCmb.Items.AddRange(new object[] { "Teal", "Green", "Blue Grey", "Red", "Yellow", "Deep Orange", "Lime" });
            colorsCmb.Location = new Point(255, 220);
            colorsCmb.MaxDropDownItems = 4;
            colorsCmb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            colorsCmb.Name = "colorsCmb";
            colorsCmb.Size = new Size(286, 49);
            colorsCmb.StartIndex = 0;
            colorsCmb.TabIndex = 1;
            colorsCmb.SelectedIndexChanged += colorsCmb_SelectedIndexChanged;
            // 
            // resaultsTab
            // 
            resaultsTab.Controls.Add(exitBtn_resualts);
            resaultsTab.Controls.Add(retryBtn);
            resaultsTab.Controls.Add(statsLbl);
            resaultsTab.Location = new Point(4, 24);
            resaultsTab.Name = "resaultsTab";
            resaultsTab.Padding = new Padding(3);
            resaultsTab.Size = new Size(839, 425);
            resaultsTab.TabIndex = 5;
            resaultsTab.Text = "Resaults";
            resaultsTab.UseVisualStyleBackColor = true;
            // 
            // exitBtn_resualts
            // 
            exitBtn_resualts.Depth = 0;
            exitBtn_resualts.Icon = Properties.Resources.icons8_back_100;
            exitBtn_resualts.Location = new Point(6, 6);
            exitBtn_resualts.Mini = true;
            exitBtn_resualts.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exitBtn_resualts.Name = "exitBtn_resualts";
            exitBtn_resualts.Size = new Size(40, 40);
            exitBtn_resualts.TabIndex = 3;
            exitBtn_resualts.UseVisualStyleBackColor = true;
            exitBtn_resualts.Click += exitBtn_Click;
            // 
            // retryBtn
            // 
            retryBtn.Anchor = AnchorStyles.None;
            retryBtn.AutoSize = false;
            retryBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            retryBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            retryBtn.Depth = 0;
            retryBtn.HighEmphasis = true;
            retryBtn.Icon = null;
            retryBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            retryBtn.Location = new Point(628, 345);
            retryBtn.Margin = new Padding(4, 6, 4, 6);
            retryBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            retryBtn.Name = "retryBtn";
            retryBtn.NoAccentTextColor = Color.Empty;
            retryBtn.Size = new Size(158, 36);
            retryBtn.TabIndex = 1;
            retryBtn.Text = "Retry";
            retryBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            retryBtn.UseAccentColor = false;
            retryBtn.UseVisualStyleBackColor = true;
            retryBtn.Click += retryBtn_Click;
            // 
            // statsLbl
            // 
            statsLbl.Depth = 0;
            statsLbl.Dock = DockStyle.Fill;
            statsLbl.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            statsLbl.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H2;
            statsLbl.Location = new Point(3, 3);
            statsLbl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            statsLbl.Name = "statsLbl";
            statsLbl.Size = new Size(833, 419);
            statsLbl.TabIndex = 0;
            statsLbl.Text = "RESAULTS";
            statsLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 480);
            Controls.Add(tabs);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Main Menu";
            ResizeEnd += MainForm_ResizeEnd;
            tabs.ResumeLayout(false);
            mainMenuTab.ResumeLayout(false);
            loadGameTab.ResumeLayout(false);
            newGameTab.ResumeLayout(false);
            newGameTab.PerformLayout();
            gameTab.ResumeLayout(false);
            gameTab.PerformLayout();
            settingsTab.ResumeLayout(false);
            settingsTab.PerformLayout();
            resaultsTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton loadGameBtn;
        private ReaLTaiizor.Controls.MaterialTabControl tabs;
        private TabPage mainMenuTab;
        private TabPage loadGameTab;
        private ReaLTaiizor.Controls.MaterialButton newGameBtn;
        private TabPage newGameTab;
        private TabPage gameTab;
        private ReaLTaiizor.Controls.MaterialListBox gameSavesLB;
        private ReaLTaiizor.Controls.MaterialButton startSaveBtn;
        private ReaLTaiizor.Controls.MaterialButton editSaveBtn;
        private ReaLTaiizor.Controls.MaterialButton deleteSaveBtn;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit ansTxtbox;
        private ReaLTaiizor.Controls.MaterialButton cntBtn;
        private ReaLTaiizor.Controls.MaterialButton checkBtn;
        private ReaLTaiizor.Controls.MaterialProgressBar gameProg;
        private ReaLTaiizor.Controls.MaterialLabel resLbl;
        private ReaLTaiizor.Controls.MaterialComboBox langCmb;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit saveNameTxtbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit pathTxtbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit toTxtbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit fromTxtbox;
        private ReaLTaiizor.Controls.MaterialButton saveBtn;
        private ReaLTaiizor.Controls.MaterialButton settingsBtn;
        private TabPage settingsTab;
        private TabPage resaultsTab;
        private ReaLTaiizor.Controls.MaterialComboBox colorsCmb;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton exitBtn_settings;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton exitBtn_newgame;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton exitBtn_loadgame;
        private ReaLTaiizor.Controls.MaterialLabel dWordLbl;
        private ReaLTaiizor.Controls.MaterialSwitch darkmodeSwitch;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton exitGameBtn;
        private ReaLTaiizor.Controls.MaterialButton retryBtn;
        private ReaLTaiizor.Controls.MaterialLabel statsLbl;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton exitBtn_resualts;
    }
}
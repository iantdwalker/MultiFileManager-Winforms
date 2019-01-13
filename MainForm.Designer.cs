namespace MultiFileManager
{
	partial class Mainform
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._tabControl = new System.Windows.Forms.TabControl();
			this._tabPageFileRenaming = new System.Windows.Forms.TabPage();
			this._buttonFileRenamingClear = new System.Windows.Forms.Button();
			this._buttonExit = new System.Windows.Forms.Button();
			this._progressBarFileRenaming = new System.Windows.Forms.ProgressBar();
			this._richTextBoxFileRenamingOutput = new System.Windows.Forms.RichTextBox();
			this._groupBoxFileRenamingOptions = new System.Windows.Forms.GroupBox();
			this._groupBoxFileTypeFilter = new System.Windows.Forms.GroupBox();
			this._textBoxFileRenamingFileType = new System.Windows.Forms.TextBox();
			this._checkBoxFileTypeFilter = new System.Windows.Forms.CheckBox();
			this._labelFileType = new System.Windows.Forms.Label();
			this._groupBoxCasing = new System.Windows.Forms.GroupBox();
			this._radioButtonAllLower = new System.Windows.Forms.RadioButton();
			this._radioButtonAllUpper = new System.Windows.Forms.RadioButton();
			this._radioButtonNewWordsStartWithCapital = new System.Windows.Forms.RadioButton();
			this._checkBoxCasing = new System.Windows.Forms.CheckBox();
			this._checkBoxRecursive = new System.Windows.Forms.CheckBox();
			this._groupBoxTrim = new System.Windows.Forms.GroupBox();
			this._radioButtonTrimStringOnly = new System.Windows.Forms.RadioButton();
			this._checkBoxTrim = new System.Windows.Forms.CheckBox();
			this._radioButtonTrimAfter = new System.Windows.Forms.RadioButton();
			this._radioButtonTrimBefore = new System.Windows.Forms.RadioButton();
			this._labelTrimString = new System.Windows.Forms.Label();
			this._textBoxFileRenamingTrimString = new System.Windows.Forms.TextBox();
			this._groupBoxFileExtensions = new System.Windows.Forms.GroupBox();
			this._checkBoxModifyExtensions = new System.Windows.Forms.CheckBox();
			this._radioButtonRemoveExtension = new System.Windows.Forms.RadioButton();
			this._radioButtonLowerCaseExtension = new System.Windows.Forms.RadioButton();
			this._checkBoxReplaceUnderscoreWithSpace = new System.Windows.Forms.CheckBox();
			this._buttonFileRenamingProcess = new System.Windows.Forms.Button();
			this._buttonFileRenamingSelectFolder = new System.Windows.Forms.Button();
			this._textBoxFileRenamingCurrentFolder = new System.Windows.Forms.TextBox();
			this._labelFileRenamingFileInputFolder = new System.Windows.Forms.Label();
			this._tabPage7Zip = new System.Windows.Forms.TabPage();
			this._groupBox7ZipFileTypeFilter = new System.Windows.Forms.GroupBox();
			this._textBox7ZipFileTypeExtension = new System.Windows.Forms.TextBox();
			this._checkBox7ZipFilteFileTypes = new System.Windows.Forms.CheckBox();
			this._label7ZipFileTypeExtension = new System.Windows.Forms.Label();
			this._button7ZipSelectOutputDirectory = new System.Windows.Forms.Button();
			this._textBox7ZipOutputDirectory = new System.Windows.Forms.TextBox();
			this._label7ZipFileOutputFolder = new System.Windows.Forms.Label();
			this._button7ZipSelectExe = new System.Windows.Forms.Button();
			this._textBox7ZipExePath = new System.Windows.Forms.TextBox();
			this._label7ZipExe = new System.Windows.Forms.Label();
			this._buttonClear7Zip = new System.Windows.Forms.Button();
			this._buttonExit7Zip = new System.Windows.Forms.Button();
			this._buttonProcess7Zip = new System.Windows.Forms.Button();
			this._progressBar7Zip = new System.Windows.Forms.ProgressBar();
			this._richTextBox7Zip = new System.Windows.Forms.RichTextBox();
			this._buttonSelectDirectory7Zip = new System.Windows.Forms.Button();
			this._textBoxDirectoryPath7Zip = new System.Windows.Forms.TextBox();
			this._labell7ZipFileInputFolder = new System.Windows.Forms.Label();
			this._checkBox7ZipRecursive = new System.Windows.Forms.CheckBox();
			this._tabControl.SuspendLayout();
			this._tabPageFileRenaming.SuspendLayout();
			this._groupBoxFileRenamingOptions.SuspendLayout();
			this._groupBoxFileTypeFilter.SuspendLayout();
			this._groupBoxCasing.SuspendLayout();
			this._groupBoxTrim.SuspendLayout();
			this._groupBoxFileExtensions.SuspendLayout();
			this._tabPage7Zip.SuspendLayout();
			this._groupBox7ZipFileTypeFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tabControl
			// 
			this._tabControl.Controls.Add(this._tabPageFileRenaming);
			this._tabControl.Controls.Add(this._tabPage7Zip);
			this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tabControl.Location = new System.Drawing.Point(0, 0);
			this._tabControl.Name = "_tabControl";
			this._tabControl.SelectedIndex = 0;
			this._tabControl.Size = new System.Drawing.Size(459, 545);
			this._tabControl.TabIndex = 0;
			// 
			// _tabPageFileRenaming
			// 
			this._tabPageFileRenaming.Controls.Add(this._buttonFileRenamingClear);
			this._tabPageFileRenaming.Controls.Add(this._buttonExit);
			this._tabPageFileRenaming.Controls.Add(this._progressBarFileRenaming);
			this._tabPageFileRenaming.Controls.Add(this._richTextBoxFileRenamingOutput);
			this._tabPageFileRenaming.Controls.Add(this._groupBoxFileRenamingOptions);
			this._tabPageFileRenaming.Controls.Add(this._buttonFileRenamingProcess);
			this._tabPageFileRenaming.Controls.Add(this._buttonFileRenamingSelectFolder);
			this._tabPageFileRenaming.Controls.Add(this._textBoxFileRenamingCurrentFolder);
			this._tabPageFileRenaming.Controls.Add(this._labelFileRenamingFileInputFolder);
			this._tabPageFileRenaming.Location = new System.Drawing.Point(4, 22);
			this._tabPageFileRenaming.Name = "_tabPageFileRenaming";
			this._tabPageFileRenaming.Padding = new System.Windows.Forms.Padding(3);
			this._tabPageFileRenaming.Size = new System.Drawing.Size(451, 519);
			this._tabPageFileRenaming.TabIndex = 0;
			this._tabPageFileRenaming.Text = "File Renaming";
			this._tabPageFileRenaming.UseVisualStyleBackColor = true;
			// 
			// _buttonFileRenamingClear
			// 
			this._buttonFileRenamingClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._buttonFileRenamingClear.Location = new System.Drawing.Point(11, 489);
			this._buttonFileRenamingClear.Name = "_buttonFileRenamingClear";
			this._buttonFileRenamingClear.Size = new System.Drawing.Size(75, 23);
			this._buttonFileRenamingClear.TabIndex = 8;
			this._buttonFileRenamingClear.Text = "Clear";
			this._buttonFileRenamingClear.UseVisualStyleBackColor = true;
			this._buttonFileRenamingClear.Click += new System.EventHandler(this._buttonFileRenamingClear_Click);
			// 
			// _buttonExit
			// 
			this._buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonExit.Location = new System.Drawing.Point(368, 488);
			this._buttonExit.Name = "_buttonExit";
			this._buttonExit.Size = new System.Drawing.Size(75, 23);
			this._buttonExit.TabIndex = 7;
			this._buttonExit.Text = "Exit";
			this._buttonExit.UseVisualStyleBackColor = true;
			this._buttonExit.Click += new System.EventHandler(this._buttonExit_Click);
			// 
			// _progressBarFileRenaming
			// 
			this._progressBarFileRenaming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._progressBarFileRenaming.Location = new System.Drawing.Point(11, 291);
			this._progressBarFileRenaming.Name = "_progressBarFileRenaming";
			this._progressBarFileRenaming.Size = new System.Drawing.Size(432, 23);
			this._progressBarFileRenaming.TabIndex = 6;
			// 
			// _richTextBoxFileRenamingOutput
			// 
			this._richTextBoxFileRenamingOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._richTextBoxFileRenamingOutput.Location = new System.Drawing.Point(11, 320);
			this._richTextBoxFileRenamingOutput.Name = "_richTextBoxFileRenamingOutput";
			this._richTextBoxFileRenamingOutput.ReadOnly = true;
			this._richTextBoxFileRenamingOutput.Size = new System.Drawing.Size(432, 162);
			this._richTextBoxFileRenamingOutput.TabIndex = 5;
			this._richTextBoxFileRenamingOutput.Text = "";
			// 
			// _groupBoxFileRenamingOptions
			// 
			this._groupBoxFileRenamingOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._groupBoxFileRenamingOptions.Controls.Add(this._groupBoxFileTypeFilter);
			this._groupBoxFileRenamingOptions.Controls.Add(this._groupBoxCasing);
			this._groupBoxFileRenamingOptions.Controls.Add(this._checkBoxRecursive);
			this._groupBoxFileRenamingOptions.Controls.Add(this._groupBoxTrim);
			this._groupBoxFileRenamingOptions.Controls.Add(this._groupBoxFileExtensions);
			this._groupBoxFileRenamingOptions.Controls.Add(this._checkBoxReplaceUnderscoreWithSpace);
			this._groupBoxFileRenamingOptions.Location = new System.Drawing.Point(9, 32);
			this._groupBoxFileRenamingOptions.Name = "_groupBoxFileRenamingOptions";
			this._groupBoxFileRenamingOptions.Size = new System.Drawing.Size(436, 253);
			this._groupBoxFileRenamingOptions.TabIndex = 4;
			this._groupBoxFileRenamingOptions.TabStop = false;
			this._groupBoxFileRenamingOptions.Text = "Options";
			// 
			// _groupBoxFileTypeFilter
			// 
			this._groupBoxFileTypeFilter.Controls.Add(this._textBoxFileRenamingFileType);
			this._groupBoxFileTypeFilter.Controls.Add(this._checkBoxFileTypeFilter);
			this._groupBoxFileTypeFilter.Controls.Add(this._labelFileType);
			this._groupBoxFileTypeFilter.Location = new System.Drawing.Point(228, 111);
			this._groupBoxFileTypeFilter.Name = "_groupBoxFileTypeFilter";
			this._groupBoxFileTypeFilter.Size = new System.Drawing.Size(202, 86);
			this._groupBoxFileTypeFilter.TabIndex = 6;
			this._groupBoxFileTypeFilter.TabStop = false;
			this._groupBoxFileTypeFilter.Text = "File Type Filter";
			// 
			// _textBoxFileRenamingFileType
			// 
			this._textBoxFileRenamingFileType.Enabled = false;
			this._textBoxFileRenamingFileType.Location = new System.Drawing.Point(120, 39);
			this._textBoxFileRenamingFileType.Name = "_textBoxFileRenamingFileType";
			this._textBoxFileRenamingFileType.Size = new System.Drawing.Size(75, 20);
			this._textBoxFileRenamingFileType.TabIndex = 2;
			// 
			// _checkBoxFileTypeFilter
			// 
			this._checkBoxFileTypeFilter.AutoSize = true;
			this._checkBoxFileTypeFilter.Location = new System.Drawing.Point(7, 19);
			this._checkBoxFileTypeFilter.Name = "_checkBoxFileTypeFilter";
			this._checkBoxFileTypeFilter.Size = new System.Drawing.Size(105, 17);
			this._checkBoxFileTypeFilter.TabIndex = 1;
			this._checkBoxFileTypeFilter.Text = "Filter File Types?";
			this._checkBoxFileTypeFilter.UseVisualStyleBackColor = true;
			this._checkBoxFileTypeFilter.CheckedChanged += new System.EventHandler(this._checkBoxFileTypeFilter_CheckedChanged);
			// 
			// _labelFileType
			// 
			this._labelFileType.AutoSize = true;
			this._labelFileType.Enabled = false;
			this._labelFileType.Location = new System.Drawing.Point(6, 44);
			this._labelFileType.Name = "_labelFileType";
			this._labelFileType.Size = new System.Drawing.Size(112, 13);
			this._labelFileType.TabIndex = 0;
			this._labelFileType.Text = "File Type Extension: *.";
			// 
			// _groupBoxCasing
			// 
			this._groupBoxCasing.Controls.Add(this._radioButtonAllLower);
			this._groupBoxCasing.Controls.Add(this._radioButtonAllUpper);
			this._groupBoxCasing.Controls.Add(this._radioButtonNewWordsStartWithCapital);
			this._groupBoxCasing.Controls.Add(this._checkBoxCasing);
			this._groupBoxCasing.Location = new System.Drawing.Point(6, 111);
			this._groupBoxCasing.Name = "_groupBoxCasing";
			this._groupBoxCasing.Size = new System.Drawing.Size(213, 86);
			this._groupBoxCasing.TabIndex = 5;
			this._groupBoxCasing.TabStop = false;
			this._groupBoxCasing.Text = "File Name Casing";
			// 
			// _radioButtonAllLower
			// 
			this._radioButtonAllLower.AutoSize = true;
			this._radioButtonAllLower.Enabled = false;
			this._radioButtonAllLower.Location = new System.Drawing.Point(79, 63);
			this._radioButtonAllLower.Name = "_radioButtonAllLower";
			this._radioButtonAllLower.Size = new System.Drawing.Size(74, 17);
			this._radioButtonAllLower.TabIndex = 7;
			this._radioButtonAllLower.Text = "All Lower?";
			this._radioButtonAllLower.UseVisualStyleBackColor = true;
			// 
			// _radioButtonAllUpper
			// 
			this._radioButtonAllUpper.AutoSize = true;
			this._radioButtonAllUpper.Enabled = false;
			this._radioButtonAllUpper.Location = new System.Drawing.Point(8, 63);
			this._radioButtonAllUpper.Name = "_radioButtonAllUpper";
			this._radioButtonAllUpper.Size = new System.Drawing.Size(74, 17);
			this._radioButtonAllUpper.TabIndex = 6;
			this._radioButtonAllUpper.Text = "All Upper?";
			this._radioButtonAllUpper.UseVisualStyleBackColor = true;
			// 
			// _radioButtonNewWordsStartWithCapital
			// 
			this._radioButtonNewWordsStartWithCapital.AutoSize = true;
			this._radioButtonNewWordsStartWithCapital.Checked = true;
			this._radioButtonNewWordsStartWithCapital.Enabled = false;
			this._radioButtonNewWordsStartWithCapital.Location = new System.Drawing.Point(8, 40);
			this._radioButtonNewWordsStartWithCapital.Name = "_radioButtonNewWordsStartWithCapital";
			this._radioButtonNewWordsStartWithCapital.Size = new System.Drawing.Size(172, 17);
			this._radioButtonNewWordsStartWithCapital.TabIndex = 5;
			this._radioButtonNewWordsStartWithCapital.TabStop = true;
			this._radioButtonNewWordsStartWithCapital.Text = "New Words Start With Capital?";
			this._radioButtonNewWordsStartWithCapital.UseVisualStyleBackColor = true;
			// 
			// _checkBoxCasing
			// 
			this._checkBoxCasing.AutoSize = true;
			this._checkBoxCasing.Location = new System.Drawing.Point(10, 19);
			this._checkBoxCasing.Name = "_checkBoxCasing";
			this._checkBoxCasing.Size = new System.Drawing.Size(64, 17);
			this._checkBoxCasing.TabIndex = 4;
			this._checkBoxCasing.Text = "Casing?";
			this._checkBoxCasing.UseVisualStyleBackColor = true;
			this._checkBoxCasing.CheckedChanged += new System.EventHandler(this._checkBoxCasing_CheckedChanged);
			// 
			// _checkBoxRecursive
			// 
			this._checkBoxRecursive.AutoSize = true;
			this._checkBoxRecursive.Location = new System.Drawing.Point(16, 203);
			this._checkBoxRecursive.Name = "_checkBoxRecursive";
			this._checkBoxRecursive.Size = new System.Drawing.Size(80, 17);
			this._checkBoxRecursive.TabIndex = 4;
			this._checkBoxRecursive.Text = "Recursive?";
			this._checkBoxRecursive.UseVisualStyleBackColor = true;
			// 
			// _groupBoxTrim
			// 
			this._groupBoxTrim.Controls.Add(this._radioButtonTrimStringOnly);
			this._groupBoxTrim.Controls.Add(this._checkBoxTrim);
			this._groupBoxTrim.Controls.Add(this._radioButtonTrimAfter);
			this._groupBoxTrim.Controls.Add(this._radioButtonTrimBefore);
			this._groupBoxTrim.Controls.Add(this._labelTrimString);
			this._groupBoxTrim.Controls.Add(this._textBoxFileRenamingTrimString);
			this._groupBoxTrim.Location = new System.Drawing.Point(6, 19);
			this._groupBoxTrim.Name = "_groupBoxTrim";
			this._groupBoxTrim.Size = new System.Drawing.Size(213, 86);
			this._groupBoxTrim.TabIndex = 3;
			this._groupBoxTrim.TabStop = false;
			this._groupBoxTrim.Text = "File Name Trimming";
			// 
			// _radioButtonTrimStringOnly
			// 
			this._radioButtonTrimStringOnly.AutoSize = true;
			this._radioButtonTrimStringOnly.Checked = true;
			this._radioButtonTrimStringOnly.Enabled = false;
			this._radioButtonTrimStringOnly.Location = new System.Drawing.Point(6, 60);
			this._radioButtonTrimStringOnly.Name = "_radioButtonTrimStringOnly";
			this._radioButtonTrimStringOnly.Size = new System.Drawing.Size(81, 17);
			this._radioButtonTrimStringOnly.TabIndex = 5;
			this._radioButtonTrimStringOnly.TabStop = true;
			this._radioButtonTrimStringOnly.Text = "Trim String?";
			this._radioButtonTrimStringOnly.UseVisualStyleBackColor = true;
			// 
			// _checkBoxTrim
			// 
			this._checkBoxTrim.AutoSize = true;
			this._checkBoxTrim.Location = new System.Drawing.Point(10, 17);
			this._checkBoxTrim.Name = "_checkBoxTrim";
			this._checkBoxTrim.Size = new System.Drawing.Size(52, 17);
			this._checkBoxTrim.TabIndex = 4;
			this._checkBoxTrim.Text = "Trim?";
			this._checkBoxTrim.UseVisualStyleBackColor = true;
			this._checkBoxTrim.CheckedChanged += new System.EventHandler(this._checkBoxTrim_CheckedChanged);
			// 
			// _radioButtonTrimAfter
			// 
			this._radioButtonTrimAfter.AutoSize = true;
			this._radioButtonTrimAfter.Enabled = false;
			this._radioButtonTrimAfter.Location = new System.Drawing.Point(154, 60);
			this._radioButtonTrimAfter.Name = "_radioButtonTrimAfter";
			this._radioButtonTrimAfter.Size = new System.Drawing.Size(53, 17);
			this._radioButtonTrimAfter.TabIndex = 3;
			this._radioButtonTrimAfter.Text = "After?";
			this._radioButtonTrimAfter.UseVisualStyleBackColor = true;
			// 
			// _radioButtonTrimBefore
			// 
			this._radioButtonTrimBefore.AutoSize = true;
			this._radioButtonTrimBefore.Enabled = false;
			this._radioButtonTrimBefore.Location = new System.Drawing.Point(92, 60);
			this._radioButtonTrimBefore.Name = "_radioButtonTrimBefore";
			this._radioButtonTrimBefore.Size = new System.Drawing.Size(62, 17);
			this._radioButtonTrimBefore.TabIndex = 2;
			this._radioButtonTrimBefore.Text = "Before?";
			this._radioButtonTrimBefore.UseVisualStyleBackColor = true;
			// 
			// _labelTrimString
			// 
			this._labelTrimString.AutoSize = true;
			this._labelTrimString.Enabled = false;
			this._labelTrimString.Location = new System.Drawing.Point(5, 42);
			this._labelTrimString.Name = "_labelTrimString";
			this._labelTrimString.Size = new System.Drawing.Size(60, 13);
			this._labelTrimString.TabIndex = 1;
			this._labelTrimString.Text = "Trim String:";
			// 
			// _textBoxFileRenamingTrimString
			// 
			this._textBoxFileRenamingTrimString.Enabled = false;
			this._textBoxFileRenamingTrimString.Location = new System.Drawing.Point(69, 39);
			this._textBoxFileRenamingTrimString.Name = "_textBoxFileRenamingTrimString";
			this._textBoxFileRenamingTrimString.Size = new System.Drawing.Size(138, 20);
			this._textBoxFileRenamingTrimString.TabIndex = 0;
			// 
			// _groupBoxFileExtensions
			// 
			this._groupBoxFileExtensions.Controls.Add(this._checkBoxModifyExtensions);
			this._groupBoxFileExtensions.Controls.Add(this._radioButtonRemoveExtension);
			this._groupBoxFileExtensions.Controls.Add(this._radioButtonLowerCaseExtension);
			this._groupBoxFileExtensions.Location = new System.Drawing.Point(228, 19);
			this._groupBoxFileExtensions.Name = "_groupBoxFileExtensions";
			this._groupBoxFileExtensions.Size = new System.Drawing.Size(202, 86);
			this._groupBoxFileExtensions.TabIndex = 2;
			this._groupBoxFileExtensions.TabStop = false;
			this._groupBoxFileExtensions.Text = "File Extensions";
			// 
			// _checkBoxModifyExtensions
			// 
			this._checkBoxModifyExtensions.AutoSize = true;
			this._checkBoxModifyExtensions.Location = new System.Drawing.Point(6, 19);
			this._checkBoxModifyExtensions.Name = "_checkBoxModifyExtensions";
			this._checkBoxModifyExtensions.Size = new System.Drawing.Size(117, 17);
			this._checkBoxModifyExtensions.TabIndex = 2;
			this._checkBoxModifyExtensions.Text = "Modify Extensions?";
			this._checkBoxModifyExtensions.UseVisualStyleBackColor = true;
			this._checkBoxModifyExtensions.CheckedChanged += new System.EventHandler(this._checkBoxModifyExtensions_CheckedChanged);
			// 
			// _radioButtonRemoveExtension
			// 
			this._radioButtonRemoveExtension.AutoSize = true;
			this._radioButtonRemoveExtension.Enabled = false;
			this._radioButtonRemoveExtension.Location = new System.Drawing.Point(6, 63);
			this._radioButtonRemoveExtension.Name = "_radioButtonRemoveExtension";
			this._radioButtonRemoveExtension.Size = new System.Drawing.Size(120, 17);
			this._radioButtonRemoveExtension.TabIndex = 1;
			this._radioButtonRemoveExtension.Text = "Remove Extension?";
			this._radioButtonRemoveExtension.UseVisualStyleBackColor = true;
			// 
			// _radioButtonLowerCaseExtension
			// 
			this._radioButtonLowerCaseExtension.AutoSize = true;
			this._radioButtonLowerCaseExtension.Checked = true;
			this._radioButtonLowerCaseExtension.Enabled = false;
			this._radioButtonLowerCaseExtension.Location = new System.Drawing.Point(6, 42);
			this._radioButtonLowerCaseExtension.Name = "_radioButtonLowerCaseExtension";
			this._radioButtonLowerCaseExtension.Size = new System.Drawing.Size(136, 17);
			this._radioButtonLowerCaseExtension.TabIndex = 0;
			this._radioButtonLowerCaseExtension.TabStop = true;
			this._radioButtonLowerCaseExtension.Text = "Lower Case Extension?";
			this._radioButtonLowerCaseExtension.UseVisualStyleBackColor = true;
			// 
			// _checkBoxReplaceUnderscoreWithSpace
			// 
			this._checkBoxReplaceUnderscoreWithSpace.AutoSize = true;
			this._checkBoxReplaceUnderscoreWithSpace.Checked = true;
			this._checkBoxReplaceUnderscoreWithSpace.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxReplaceUnderscoreWithSpace.Location = new System.Drawing.Point(16, 226);
			this._checkBoxReplaceUnderscoreWithSpace.Name = "_checkBoxReplaceUnderscoreWithSpace";
			this._checkBoxReplaceUnderscoreWithSpace.Size = new System.Drawing.Size(189, 17);
			this._checkBoxReplaceUnderscoreWithSpace.TabIndex = 0;
			this._checkBoxReplaceUnderscoreWithSpace.Text = "Replace Underscore With Space?";
			this._checkBoxReplaceUnderscoreWithSpace.UseVisualStyleBackColor = true;
			// 
			// _buttonFileRenamingProcess
			// 
			this._buttonFileRenamingProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonFileRenamingProcess.Enabled = false;
			this._buttonFileRenamingProcess.Location = new System.Drawing.Point(285, 488);
			this._buttonFileRenamingProcess.Name = "_buttonFileRenamingProcess";
			this._buttonFileRenamingProcess.Size = new System.Drawing.Size(75, 23);
			this._buttonFileRenamingProcess.TabIndex = 3;
			this._buttonFileRenamingProcess.Text = "Process";
			this._buttonFileRenamingProcess.UseVisualStyleBackColor = true;
			this._buttonFileRenamingProcess.Click += new System.EventHandler(this._buttonFileRenamingProcess_Click);
			// 
			// _buttonFileRenamingSelectFolder
			// 
			this._buttonFileRenamingSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonFileRenamingSelectFolder.Location = new System.Drawing.Point(416, 4);
			this._buttonFileRenamingSelectFolder.Name = "_buttonFileRenamingSelectFolder";
			this._buttonFileRenamingSelectFolder.Size = new System.Drawing.Size(27, 23);
			this._buttonFileRenamingSelectFolder.TabIndex = 2;
			this._buttonFileRenamingSelectFolder.Text = "...";
			this._buttonFileRenamingSelectFolder.UseVisualStyleBackColor = true;
			this._buttonFileRenamingSelectFolder.Click += new System.EventHandler(this._buttonFileRenamingSelectFolder_Click);
			// 
			// _textBoxFileRenamingCurrentFolder
			// 
			this._textBoxFileRenamingCurrentFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxFileRenamingCurrentFolder.Location = new System.Drawing.Point(94, 6);
			this._textBoxFileRenamingCurrentFolder.Name = "_textBoxFileRenamingCurrentFolder";
			this._textBoxFileRenamingCurrentFolder.ReadOnly = true;
			this._textBoxFileRenamingCurrentFolder.Size = new System.Drawing.Size(318, 20);
			this._textBoxFileRenamingCurrentFolder.TabIndex = 1;
			// 
			// _labelFileRenamingFileInputFolder
			// 
			this._labelFileRenamingFileInputFolder.AutoSize = true;
			this._labelFileRenamingFileInputFolder.Location = new System.Drawing.Point(8, 9);
			this._labelFileRenamingFileInputFolder.Name = "_labelFileRenamingFileInputFolder";
			this._labelFileRenamingFileInputFolder.Size = new System.Drawing.Size(85, 13);
			this._labelFileRenamingFileInputFolder.TabIndex = 0;
			this._labelFileRenamingFileInputFolder.Text = "File Input Folder:";
			// 
			// _tabPage7Zip
			// 
			this._tabPage7Zip.Controls.Add(this._checkBox7ZipRecursive);
			this._tabPage7Zip.Controls.Add(this._groupBox7ZipFileTypeFilter);
			this._tabPage7Zip.Controls.Add(this._button7ZipSelectOutputDirectory);
			this._tabPage7Zip.Controls.Add(this._textBox7ZipOutputDirectory);
			this._tabPage7Zip.Controls.Add(this._label7ZipFileOutputFolder);
			this._tabPage7Zip.Controls.Add(this._button7ZipSelectExe);
			this._tabPage7Zip.Controls.Add(this._textBox7ZipExePath);
			this._tabPage7Zip.Controls.Add(this._label7ZipExe);
			this._tabPage7Zip.Controls.Add(this._buttonClear7Zip);
			this._tabPage7Zip.Controls.Add(this._buttonExit7Zip);
			this._tabPage7Zip.Controls.Add(this._buttonProcess7Zip);
			this._tabPage7Zip.Controls.Add(this._progressBar7Zip);
			this._tabPage7Zip.Controls.Add(this._richTextBox7Zip);
			this._tabPage7Zip.Controls.Add(this._buttonSelectDirectory7Zip);
			this._tabPage7Zip.Controls.Add(this._textBoxDirectoryPath7Zip);
			this._tabPage7Zip.Controls.Add(this._labell7ZipFileInputFolder);
			this._tabPage7Zip.Location = new System.Drawing.Point(4, 22);
			this._tabPage7Zip.Name = "_tabPage7Zip";
			this._tabPage7Zip.Padding = new System.Windows.Forms.Padding(3);
			this._tabPage7Zip.Size = new System.Drawing.Size(451, 519);
			this._tabPage7Zip.TabIndex = 1;
			this._tabPage7Zip.Text = "7-Zip";
			this._tabPage7Zip.UseVisualStyleBackColor = true;
			// 
			// _groupBox7ZipFileTypeFilter
			// 
			this._groupBox7ZipFileTypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._groupBox7ZipFileTypeFilter.Controls.Add(this._textBox7ZipFileTypeExtension);
			this._groupBox7ZipFileTypeFilter.Controls.Add(this._checkBox7ZipFilteFileTypes);
			this._groupBox7ZipFileTypeFilter.Controls.Add(this._label7ZipFileTypeExtension);
			this._groupBox7ZipFileTypeFilter.Location = new System.Drawing.Point(11, 84);
			this._groupBox7ZipFileTypeFilter.Name = "_groupBox7ZipFileTypeFilter";
			this._groupBox7ZipFileTypeFilter.Size = new System.Drawing.Size(432, 69);
			this._groupBox7ZipFileTypeFilter.TabIndex = 18;
			this._groupBox7ZipFileTypeFilter.TabStop = false;
			this._groupBox7ZipFileTypeFilter.Text = "File Type Filter";
			// 
			// _textBox7ZipFileTypeExtension
			// 
			this._textBox7ZipFileTypeExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBox7ZipFileTypeExtension.Enabled = false;
			this._textBox7ZipFileTypeExtension.Location = new System.Drawing.Point(120, 39);
			this._textBox7ZipFileTypeExtension.Name = "_textBox7ZipFileTypeExtension";
			this._textBox7ZipFileTypeExtension.Size = new System.Drawing.Size(306, 20);
			this._textBox7ZipFileTypeExtension.TabIndex = 2;
			// 
			// _checkBox7ZipFilteFileTypes
			// 
			this._checkBox7ZipFilteFileTypes.AutoSize = true;
			this._checkBox7ZipFilteFileTypes.Location = new System.Drawing.Point(7, 19);
			this._checkBox7ZipFilteFileTypes.Name = "_checkBox7ZipFilteFileTypes";
			this._checkBox7ZipFilteFileTypes.Size = new System.Drawing.Size(105, 17);
			this._checkBox7ZipFilteFileTypes.TabIndex = 1;
			this._checkBox7ZipFilteFileTypes.Text = "Filter File Types?";
			this._checkBox7ZipFilteFileTypes.UseVisualStyleBackColor = true;
			this._checkBox7ZipFilteFileTypes.CheckedChanged += new System.EventHandler(this._checkBox7ZipFilteFileTypes_CheckedChanged);
			// 
			// _label7ZipFileTypeExtension
			// 
			this._label7ZipFileTypeExtension.AutoSize = true;
			this._label7ZipFileTypeExtension.Enabled = false;
			this._label7ZipFileTypeExtension.Location = new System.Drawing.Point(6, 44);
			this._label7ZipFileTypeExtension.Name = "_label7ZipFileTypeExtension";
			this._label7ZipFileTypeExtension.Size = new System.Drawing.Size(112, 13);
			this._label7ZipFileTypeExtension.TabIndex = 0;
			this._label7ZipFileTypeExtension.Text = "File Type Extension: *.";
			// 
			// _button7ZipSelectOutputDirectory
			// 
			this._button7ZipSelectOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._button7ZipSelectOutputDirectory.Location = new System.Drawing.Point(416, 30);
			this._button7ZipSelectOutputDirectory.Name = "_button7ZipSelectOutputDirectory";
			this._button7ZipSelectOutputDirectory.Size = new System.Drawing.Size(27, 23);
			this._button7ZipSelectOutputDirectory.TabIndex = 17;
			this._button7ZipSelectOutputDirectory.Text = "...";
			this._button7ZipSelectOutputDirectory.UseVisualStyleBackColor = true;
			this._button7ZipSelectOutputDirectory.Click += new System.EventHandler(this._button7ZipSelectOutputDirectory_Click);
			// 
			// _textBox7ZipOutputDirectory
			// 
			this._textBox7ZipOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBox7ZipOutputDirectory.Location = new System.Drawing.Point(115, 32);
			this._textBox7ZipOutputDirectory.Name = "_textBox7ZipOutputDirectory";
			this._textBox7ZipOutputDirectory.ReadOnly = true;
			this._textBox7ZipOutputDirectory.Size = new System.Drawing.Size(297, 20);
			this._textBox7ZipOutputDirectory.TabIndex = 16;
			// 
			// _label7ZipFileOutputFolder
			// 
			this._label7ZipFileOutputFolder.AutoSize = true;
			this._label7ZipFileOutputFolder.Location = new System.Drawing.Point(8, 35);
			this._label7ZipFileOutputFolder.Name = "_label7ZipFileOutputFolder";
			this._label7ZipFileOutputFolder.Size = new System.Drawing.Size(101, 13);
			this._label7ZipFileOutputFolder.TabIndex = 15;
			this._label7ZipFileOutputFolder.Text = "7-Zip Output Folder:";
			// 
			// _button7ZipSelectExe
			// 
			this._button7ZipSelectExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._button7ZipSelectExe.Location = new System.Drawing.Point(416, 56);
			this._button7ZipSelectExe.Name = "_button7ZipSelectExe";
			this._button7ZipSelectExe.Size = new System.Drawing.Size(27, 23);
			this._button7ZipSelectExe.TabIndex = 14;
			this._button7ZipSelectExe.Text = "...";
			this._button7ZipSelectExe.UseVisualStyleBackColor = true;
			this._button7ZipSelectExe.Click += new System.EventHandler(this._button7ZipSelectExe_Click);
			// 
			// _textBox7ZipExePath
			// 
			this._textBox7ZipExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBox7ZipExePath.Location = new System.Drawing.Point(115, 58);
			this._textBox7ZipExePath.Name = "_textBox7ZipExePath";
			this._textBox7ZipExePath.ReadOnly = true;
			this._textBox7ZipExePath.Size = new System.Drawing.Size(297, 20);
			this._textBox7ZipExePath.TabIndex = 13;
			this._textBox7ZipExePath.Text = "C:\\Program Files\\7-Zip\\7z.exe";
			// 
			// _label7ZipExe
			// 
			this._label7ZipExe.AutoSize = true;
			this._label7ZipExe.Location = new System.Drawing.Point(8, 61);
			this._label7ZipExe.Name = "_label7ZipExe";
			this._label7ZipExe.Size = new System.Drawing.Size(54, 13);
			this._label7ZipExe.TabIndex = 12;
			this._label7ZipExe.Text = "7-Zip exe:";
			// 
			// _buttonClear7Zip
			// 
			this._buttonClear7Zip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._buttonClear7Zip.Location = new System.Drawing.Point(11, 489);
			this._buttonClear7Zip.Name = "_buttonClear7Zip";
			this._buttonClear7Zip.Size = new System.Drawing.Size(75, 23);
			this._buttonClear7Zip.TabIndex = 11;
			this._buttonClear7Zip.Text = "Clear";
			this._buttonClear7Zip.UseVisualStyleBackColor = true;
			this._buttonClear7Zip.Click += new System.EventHandler(this._buttonClear7Zip_Click);
			// 
			// _buttonExit7Zip
			// 
			this._buttonExit7Zip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonExit7Zip.Location = new System.Drawing.Point(368, 488);
			this._buttonExit7Zip.Name = "_buttonExit7Zip";
			this._buttonExit7Zip.Size = new System.Drawing.Size(75, 23);
			this._buttonExit7Zip.TabIndex = 10;
			this._buttonExit7Zip.Text = "Exit";
			this._buttonExit7Zip.UseVisualStyleBackColor = true;
			this._buttonExit7Zip.Click += new System.EventHandler(this._buttonExit7Zip_Click);
			// 
			// _buttonProcess7Zip
			// 
			this._buttonProcess7Zip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonProcess7Zip.Location = new System.Drawing.Point(285, 488);
			this._buttonProcess7Zip.Name = "_buttonProcess7Zip";
			this._buttonProcess7Zip.Size = new System.Drawing.Size(75, 23);
			this._buttonProcess7Zip.TabIndex = 9;
			this._buttonProcess7Zip.Text = "Process";
			this._buttonProcess7Zip.UseVisualStyleBackColor = true;
			this._buttonProcess7Zip.Click += new System.EventHandler(this._buttonProcess7Zip_Click);
			// 
			// _progressBar7Zip
			// 
			this._progressBar7Zip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._progressBar7Zip.Location = new System.Drawing.Point(11, 183);
			this._progressBar7Zip.Name = "_progressBar7Zip";
			this._progressBar7Zip.Size = new System.Drawing.Size(432, 23);
			this._progressBar7Zip.TabIndex = 8;
			// 
			// _richTextBox7Zip
			// 
			this._richTextBox7Zip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._richTextBox7Zip.Location = new System.Drawing.Point(11, 212);
			this._richTextBox7Zip.Name = "_richTextBox7Zip";
			this._richTextBox7Zip.ReadOnly = true;
			this._richTextBox7Zip.Size = new System.Drawing.Size(432, 270);
			this._richTextBox7Zip.TabIndex = 7;
			this._richTextBox7Zip.Text = "";
			// 
			// _buttonSelectDirectory7Zip
			// 
			this._buttonSelectDirectory7Zip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonSelectDirectory7Zip.Location = new System.Drawing.Point(416, 4);
			this._buttonSelectDirectory7Zip.Name = "_buttonSelectDirectory7Zip";
			this._buttonSelectDirectory7Zip.Size = new System.Drawing.Size(27, 23);
			this._buttonSelectDirectory7Zip.TabIndex = 3;
			this._buttonSelectDirectory7Zip.Text = "...";
			this._buttonSelectDirectory7Zip.UseVisualStyleBackColor = true;
			this._buttonSelectDirectory7Zip.Click += new System.EventHandler(this._buttonSelectDirectory7Zip_Click);
			// 
			// _textBoxDirectoryPath7Zip
			// 
			this._textBoxDirectoryPath7Zip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxDirectoryPath7Zip.Location = new System.Drawing.Point(115, 6);
			this._textBoxDirectoryPath7Zip.Name = "_textBoxDirectoryPath7Zip";
			this._textBoxDirectoryPath7Zip.ReadOnly = true;
			this._textBoxDirectoryPath7Zip.Size = new System.Drawing.Size(297, 20);
			this._textBoxDirectoryPath7Zip.TabIndex = 2;
			// 
			// _labell7ZipFileInputFolder
			// 
			this._labell7ZipFileInputFolder.AutoSize = true;
			this._labell7ZipFileInputFolder.Location = new System.Drawing.Point(8, 9);
			this._labell7ZipFileInputFolder.Name = "_labell7ZipFileInputFolder";
			this._labell7ZipFileInputFolder.Size = new System.Drawing.Size(85, 13);
			this._labell7ZipFileInputFolder.TabIndex = 1;
			this._labell7ZipFileInputFolder.Text = "File Input Folder:";
			// 
			// _checkBox7ZipRecursive
			// 
			this._checkBox7ZipRecursive.AutoSize = true;
			this._checkBox7ZipRecursive.Location = new System.Drawing.Point(18, 159);
			this._checkBox7ZipRecursive.Name = "_checkBox7ZipRecursive";
			this._checkBox7ZipRecursive.Size = new System.Drawing.Size(80, 17);
			this._checkBox7ZipRecursive.TabIndex = 19;
			this._checkBox7ZipRecursive.Text = "Recursive?";
			this._checkBox7ZipRecursive.UseVisualStyleBackColor = true;
			// 
			// Mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 545);
			this.Controls.Add(this._tabControl);
			this.Name = "Mainform";
			this.Text = "Multi File Manager";
			this._tabControl.ResumeLayout(false);
			this._tabPageFileRenaming.ResumeLayout(false);
			this._tabPageFileRenaming.PerformLayout();
			this._groupBoxFileRenamingOptions.ResumeLayout(false);
			this._groupBoxFileRenamingOptions.PerformLayout();
			this._groupBoxFileTypeFilter.ResumeLayout(false);
			this._groupBoxFileTypeFilter.PerformLayout();
			this._groupBoxCasing.ResumeLayout(false);
			this._groupBoxCasing.PerformLayout();
			this._groupBoxTrim.ResumeLayout(false);
			this._groupBoxTrim.PerformLayout();
			this._groupBoxFileExtensions.ResumeLayout(false);
			this._groupBoxFileExtensions.PerformLayout();
			this._tabPage7Zip.ResumeLayout(false);
			this._tabPage7Zip.PerformLayout();
			this._groupBox7ZipFileTypeFilter.ResumeLayout(false);
			this._groupBox7ZipFileTypeFilter.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.GroupBox _groupBoxCasing;

		#endregion

		private System.Windows.Forms.TabControl _tabControl;
		private System.Windows.Forms.TabPage _tabPageFileRenaming;
		private System.Windows.Forms.Button _buttonFileRenamingSelectFolder;
		private System.Windows.Forms.TextBox _textBoxFileRenamingCurrentFolder;
		private System.Windows.Forms.Label _labelFileRenamingFileInputFolder;
		private System.Windows.Forms.Button _buttonFileRenamingProcess;
		private System.Windows.Forms.GroupBox _groupBoxFileRenamingOptions;
		private System.Windows.Forms.CheckBox _checkBoxReplaceUnderscoreWithSpace;
		private System.Windows.Forms.RichTextBox _richTextBoxFileRenamingOutput;
		private System.Windows.Forms.ProgressBar _progressBarFileRenaming;
		private System.Windows.Forms.GroupBox _groupBoxFileExtensions;
		private System.Windows.Forms.RadioButton _radioButtonRemoveExtension;
		private System.Windows.Forms.RadioButton _radioButtonLowerCaseExtension;
		private System.Windows.Forms.GroupBox _groupBoxTrim;
		private System.Windows.Forms.RadioButton _radioButtonTrimAfter;
		private System.Windows.Forms.RadioButton _radioButtonTrimBefore;
		private System.Windows.Forms.Label _labelTrimString;
		private System.Windows.Forms.TextBox _textBoxFileRenamingTrimString;
		private System.Windows.Forms.CheckBox _checkBoxTrim;
		private System.Windows.Forms.CheckBox _checkBoxModifyExtensions;
		private System.Windows.Forms.RadioButton _radioButtonTrimStringOnly;
		private System.Windows.Forms.CheckBox _checkBoxRecursive;
		private System.Windows.Forms.Button _buttonExit;
		private System.Windows.Forms.Button _buttonFileRenamingClear;
		private System.Windows.Forms.CheckBox _checkBoxCasing;
		private System.Windows.Forms.RadioButton _radioButtonAllLower;
		private System.Windows.Forms.RadioButton _radioButtonAllUpper;
		private System.Windows.Forms.RadioButton _radioButtonNewWordsStartWithCapital;
		private System.Windows.Forms.GroupBox _groupBoxFileTypeFilter;
		private System.Windows.Forms.TextBox _textBoxFileRenamingFileType;
		private System.Windows.Forms.CheckBox _checkBoxFileTypeFilter;
		private System.Windows.Forms.Label _labelFileType;
		private System.Windows.Forms.TabPage _tabPage7Zip;
		private System.Windows.Forms.Button _buttonSelectDirectory7Zip;
		private System.Windows.Forms.TextBox _textBoxDirectoryPath7Zip;
		private System.Windows.Forms.Label _labell7ZipFileInputFolder;
		private System.Windows.Forms.Button _buttonClear7Zip;
		private System.Windows.Forms.Button _buttonExit7Zip;
		private System.Windows.Forms.Button _buttonProcess7Zip;
		private System.Windows.Forms.ProgressBar _progressBar7Zip;
		private System.Windows.Forms.RichTextBox _richTextBox7Zip;
		private System.Windows.Forms.Button _button7ZipSelectExe;
		private System.Windows.Forms.TextBox _textBox7ZipExePath;
		private System.Windows.Forms.Label _label7ZipExe;
		private System.Windows.Forms.Button _button7ZipSelectOutputDirectory;
		private System.Windows.Forms.TextBox _textBox7ZipOutputDirectory;
		private System.Windows.Forms.Label _label7ZipFileOutputFolder;
		private System.Windows.Forms.GroupBox _groupBox7ZipFileTypeFilter;
		private System.Windows.Forms.TextBox _textBox7ZipFileTypeExtension;
		private System.Windows.Forms.CheckBox _checkBox7ZipFilteFileTypes;
		private System.Windows.Forms.Label _label7ZipFileTypeExtension;
		private System.Windows.Forms.CheckBox _checkBox7ZipRecursive;
	}
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MultiFileManager.FileRenaming;
using MultiFileManager.SevenZip;

namespace MultiFileManager
{
	/// <summary>
	/// Mainform
	/// </summary>
	public partial class Mainform : Form
	{
		#region Private Members

		private BackgroundWorker _fileRenamingWorker;
		private BackgroundWorker _7ZipWorker;
		private	const string	SAME_OUTPUT_DIR = "Same as file input folder";

		#endregion
		
		#region Construction
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Mainform"/> class.
		/// </summary>
		public Mainform()
		{
			InitializeComponent();

			_fileRenamingWorker							= new BackgroundWorker();
			_fileRenamingWorker.WorkerReportsProgress	= true;
			_fileRenamingWorker.ProgressChanged			+= _fileRenamingWorker_ProgressChanged;
			_fileRenamingWorker.DoWork					+= _fileRenamingWorker_DoWork;
			_fileRenamingWorker.RunWorkerCompleted		+= _fileRenamingWorker_RunWorkerCompleted;

			_7ZipWorker									= new BackgroundWorker();
			_7ZipWorker.WorkerReportsProgress			= true;
			_7ZipWorker.ProgressChanged					+= _7ZipWorker_ProgressChanged;
			_7ZipWorker.DoWork							+= _7ZipWorker_DoWork;
			_7ZipWorker.RunWorkerCompleted				+= _7ZipWorker_RunWorkerCompleted;

			_textBox7ZipOutputDirectory.Text			= SAME_OUTPUT_DIR;
		}

		#endregion

		#region File Renaming Event Handlers
		
		/// <summary>
		/// Handles the Click event of the _buttonFileRenamingSelectFolder control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonFileRenamingSelectFolder_Click(object sender, EventArgs e)
		{
			try
			{			
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

				folderBrowserDialog.Description			= "Select a folder with files to modify...";
				folderBrowserDialog.ShowNewFolderButton = true;

				if (_textBoxFileRenamingCurrentFolder.Text != string.Empty)
				{
					folderBrowserDialog.SelectedPath = _textBoxFileRenamingCurrentFolder.Text;
				}
				else
				{
					folderBrowserDialog.RootFolder	= Environment.SpecialFolder.MyComputer;
				}				

				DialogResult result = folderBrowserDialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_textBoxFileRenamingCurrentFolder.Text 	= folderBrowserDialog.SelectedPath;
					_buttonFileRenamingProcess.Enabled 		= true;
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		/// <summary>
		/// Handles the Click event of the _buttonFileRenamingProcess control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonFileRenamingProcess_Click(object sender, EventArgs e)
		{
			_buttonFileRenamingProcess.Enabled	= false;
			_progressBarFileRenaming.Value		= 0;
			PrintOutputMessage("*************START***************\n");
			_fileRenamingWorker.RunWorkerAsync();			
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxTrim control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _checkBoxTrim_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxTrim.Checked)
			{
				_labelTrimString.Enabled				= true;
				_textBoxFileRenamingTrimString.Enabled	= true;
				_radioButtonTrimBefore.Enabled			= true;
				_radioButtonTrimAfter.Enabled			= true;
				_radioButtonTrimStringOnly.Enabled		= true;
			}
			else
			{
				_labelTrimString.Enabled				= false;
				_textBoxFileRenamingTrimString.Enabled	= false;
				_radioButtonTrimBefore.Enabled			= false;
				_radioButtonTrimAfter.Enabled			= false;
				_radioButtonTrimStringOnly.Enabled		= false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxModifyExtensions control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _checkBoxModifyExtensions_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxModifyExtensions.Checked)
			{
				_radioButtonLowerCaseExtension.Enabled	= true;
				_radioButtonRemoveExtension.Enabled		= true;				
			}
			else
			{
				_radioButtonLowerCaseExtension.Enabled	= false;
				_radioButtonRemoveExtension.Enabled		= false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxCasing control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _checkBoxCasing_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxCasing.Checked)
			{
				_radioButtonNewWordsStartWithCapital.Enabled	= true;
				_radioButtonAllUpper.Enabled					= true;
				_radioButtonAllLower.Enabled					= true;
			}
			else
			{
				_radioButtonNewWordsStartWithCapital.Enabled	= false;
				_radioButtonAllUpper.Enabled					= false;
				_radioButtonAllLower.Enabled					= false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxFileTypeFilter control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _checkBoxFileTypeFilter_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxFileTypeFilter.Checked)
			{
				_labelFileType.Enabled					= true;
				_textBoxFileRenamingFileType.Enabled	= true;
			}
			else
			{
				_labelFileType.Enabled					= false;
				_textBoxFileRenamingFileType.Enabled	= false;
			}
		}

		/// <summary>
		/// Handles the Click event of the _buttonFileRenamingClear control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonFileRenamingClear_Click(object sender, EventArgs e)
		{
			_richTextBoxFileRenamingOutput.Clear();
			_progressBarFileRenaming.Value = 0;
		}

		/// <summary>
		/// Handles the Click event of the _buttonExit control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region File Renaming Background Worker Thread

		/// <summary>
		/// Handles the DoWork event of the _fileRenamingWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		private void _fileRenamingWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			IFileRenamerOptions fileRenamerOptions	= GenerateFileRenamerOptions();
			DirectoryInfo		fileDirectory		= new DirectoryInfo(fileRenamerOptions.DirectoryPath);
				
			if (fileDirectory.Exists)
			{
				IFileRenamer	fileRenamer	= new FileRenamer();			
				FileInfo[]		files;					
				if (fileRenamerOptions.Recursive)
				{
					if (fileRenamerOptions.FileTypeFilter != null)
					{
						files = fileDirectory.GetFiles(string.Format("*.{0}", fileRenamerOptions.FileTypeFilter.FileTypeExtension), SearchOption.AllDirectories);
					}
					else
					{
						files = fileDirectory.GetFiles("*.*", SearchOption.AllDirectories);
					}
				}
				else 
				{
					if (fileRenamerOptions.FileTypeFilter != null)
					{
						files = fileDirectory.GetFiles(string.Format("*.{0}", fileRenamerOptions.FileTypeFilter.FileTypeExtension), SearchOption.TopDirectoryOnly);
					}
					else
					{
						files = fileDirectory.GetFiles("*.*", SearchOption.TopDirectoryOnly);
					}
				}

				_fileRenamingWorker.ReportProgress(0, string.Format("There are {0} files to process in total.\n", files.Length));
														
				for (int x = 0; x < files.Length; x++)
				{
					string tempFileName = files[x].Name;
					fileRenamer.RenameFile(files[x], fileRenamerOptions);
					int runningPercentageComplete = ((int)(((decimal)x / (decimal)files.Length) * 100));
					_fileRenamingWorker.ReportProgress(runningPercentageComplete, string.Format("{0}: Finished renaming file: '{1}'. The new file name is: '{2}'.", new object[] { x.ToString(CultureInfo.CurrentCulture), tempFileName, files[x].Name }));
				}
				_fileRenamingWorker.ReportProgress(100);
			}
			else
			{
				throw new InvalidOperationException("The Directory Path supplied cannot be found.");
			}			
		}

		/// <summary>
		/// Handles the ProgressChanged event of the _fileRenamingWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance containing the event data.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		private void _fileRenamingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			_progressBarFileRenaming.Value = e.ProgressPercentage;
			if (e.UserState != null)
			{
				//assumed to be string data type
				PrintOutputMessage(e.UserState as string);
			}
		}

		/// <summary>
		/// Handles the RunWorkerCompleted event of the _fileRenamingWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		private void _fileRenamingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				HandleException(e.Error);
			}
			else
			{
				PrintOutputMessage("\n*************FINISH***************\n");
			}
			
			_buttonFileRenamingProcess.Enabled	= true;			
		}

		#endregion

		#region 7-Zip Event Handlers

		/// <summary>
		/// Handles the Click event of the _buttonSelectDirectory7Zip control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonSelectDirectory7Zip_Click(object sender, EventArgs e)
		{
			try
			{			
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

				folderBrowserDialog.Description			= "Select a folder with files to compress into a 7-Zip archive...";
				folderBrowserDialog.ShowNewFolderButton = true;
								
				if (_textBoxDirectoryPath7Zip.Text != string.Empty)
				{
					folderBrowserDialog.SelectedPath = _textBoxDirectoryPath7Zip.Text;
				}
				else
				{
					folderBrowserDialog.RootFolder	= Environment.SpecialFolder.MyComputer;
				}				

				DialogResult result = folderBrowserDialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_textBoxDirectoryPath7Zip.Text = folderBrowserDialog.SelectedPath;
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		/// <summary>
		/// Handles the Click event of the _button7ZipSelectOutputDirectory control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _button7ZipSelectOutputDirectory_Click(object sender, EventArgs e)
		{
			try
			{			
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

				folderBrowserDialog.Description			= "Select an output folder for the compressed 7-Zip archives...";
				folderBrowserDialog.ShowNewFolderButton = true;
							
				if (_textBox7ZipOutputDirectory.Text != string.Empty)
				{
					folderBrowserDialog.SelectedPath = _textBox7ZipOutputDirectory.Text;
				}
				else
				{
					folderBrowserDialog.RootFolder	= Environment.SpecialFolder.MyComputer;
				}				

				DialogResult result = folderBrowserDialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_textBox7ZipOutputDirectory.Text = folderBrowserDialog.SelectedPath;
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		/// <summary>
		/// Handles the Click event of the _button7ZipSelectExe control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _button7ZipSelectExe_Click(object sender, EventArgs e)
		{
			try
			{			
				OpenFileDialog openFileDialog	= new OpenFileDialog();
				openFileDialog.DefaultExt		= ".exe";
				openFileDialog.Filter			= "Exe files (*.exe) | *.exe";
				
				if (_textBox7ZipExePath.Text != string.Empty)
				{
					openFileDialog.InitialDirectory = _textBox7ZipExePath.Text;
				}
				else
				{
					openFileDialog.InitialDirectory	= "C:\\";
				}				

				DialogResult result = openFileDialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_textBox7ZipExePath.Text = openFileDialog.FileName;
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}		

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBox7ZipFilteFileTypes control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _checkBox7ZipFilteFileTypes_CheckedChanged(object sender, EventArgs e)
		{			
			if (_checkBox7ZipFilteFileTypes.Checked)
			{				
				_label7ZipFileTypeExtension.Enabled		= true;
				_textBox7ZipFileTypeExtension.Enabled	= true;
			}
			else
			{
				_label7ZipFileTypeExtension.Enabled		= false;
				_textBox7ZipFileTypeExtension.Enabled	= false;
			}
		}

		/// <summary>
		/// Handles the Click event of the _buttonProcess7Zip control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonProcess7Zip_Click(object sender, EventArgs e)
		{
			_buttonProcess7Zip.Enabled	= false;
			_progressBar7Zip.Value		= 0;
			PrintOutputMessage("*************START***************\n");
			_7ZipWorker.RunWorkerAsync();
		}

		/// <summary>
		/// Handles the Click event of the _buttonClear7Zip control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonClear7Zip_Click(object sender, EventArgs e)
		{
			_richTextBox7Zip.Clear();
			_progressBar7Zip.Value = 0;
		}
		
		/// <summary>
		/// Handles the Click event of the _buttonExit7Zip control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void _buttonExit7Zip_Click(object sender, EventArgs e)
		{
			this.Close();
		}		
		
		#endregion

		#region Z-Zip Background Worker Thread

		/// <summary>
		/// Handles the DoWork event of the _7ZipWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		private void _7ZipWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				ISevenZipOptions	sevenZipOptions = GenerateSevenZipOptions();
				DirectoryInfo		fileDirectory	= new DirectoryInfo(sevenZipOptions.InputDirectory);
				if (fileDirectory.Exists)
				{
					ISevenZipCompressor	sevenZipCompressor		= new SevenZipCompressor(sevenZipOptions.sevenZipExePath);					
					FileInfo[]			files;
					if (sevenZipOptions.Recursive)
					{
						if (sevenZipOptions.FileTypeFilter != null)
						{
							files = fileDirectory.GetFiles(string.Format("*.{0}", sevenZipOptions.FileTypeFilter.FileTypeExtension), SearchOption.AllDirectories);
						}
						else
						{
							files = fileDirectory.GetFiles("*.*", SearchOption.AllDirectories);
						}
					}
					else
					{
						if (sevenZipOptions.FileTypeFilter != null)
						{
							files = fileDirectory.GetFiles(string.Format("*.{0}", sevenZipOptions.FileTypeFilter.FileTypeExtension), SearchOption.TopDirectoryOnly);
						}
						else
						{
							files = fileDirectory.GetFiles("*.*", SearchOption.TopDirectoryOnly);
						}
					}
					
					_7ZipWorker.ReportProgress(0, string.Format("There are {0} files to process in total.\n", files.Length));
					for (int x = 0; x < files.Length; x++)
					{
						sevenZipCompressor.ZipFile(files[x], sevenZipOptions);
						int	runningPercentageComplete = ((int)(((decimal)x / (decimal)files.Length) * 100));
						_7ZipWorker.ReportProgress(runningPercentageComplete, string.Format("{0}: Finished zipping file: '{1}'.", new object[] { x.ToString(CultureInfo.CurrentCulture), files[x].Name }));
					}
					_7ZipWorker.ReportProgress(100);
				}
				else
				{
					throw new InvalidOperationException("The Directory Path supplied cannot be found.");
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}			
		}

		/// <summary>
		/// Handles the ProgressChanged event of the _7ZipWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance containing the event data.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		private void _7ZipWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			_progressBar7Zip.Value = e.ProgressPercentage;
			if (e.UserState != null)
			{
				//assumed to be string data type
				PrintOutputMessage(e.UserState as string);
			}
		}

		/// <summary>
		/// Handles the RunWorkerCompleted event of the _7ZipWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		private void _7ZipWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				HandleException(e.Error);
			}
			else
			{
				PrintOutputMessage("\n*************FINISH***************\n");
			}
			
			_buttonProcess7Zip.Enabled = true;			
		}

		#endregion
		
		#region Private Members

		#region File Renaming
		
		private IFileRenamerOptions GenerateFileRenamerOptions()
		{
			IFileRenamerOptions					fileRenamerOptions	= new FileRenamerOptions();
			fileRenamerOptions.DirectoryPath						= _textBoxFileRenamingCurrentFolder.Text;
			
			//Trim				
			if (_checkBoxTrim.Checked)
			{				
				ITrim trim		= new Trim();
				trim.TrimString = _textBoxFileRenamingTrimString.Text;
				
				if (_radioButtonTrimBefore.Checked)
				{
					trim.TrimType = FileRenamerTrimTypes.Before;
				}
				else if (_radioButtonTrimAfter.Checked)
				{
					trim.TrimType = FileRenamerTrimTypes.After;
				}
				else if (_radioButtonTrimStringOnly.Checked)
				{
					trim.TrimType = FileRenamerTrimTypes.TrimStringOnly;
				}

				fileRenamerOptions.Trim = trim;
			}

			//Modify Extensions
			if (_checkBoxModifyExtensions.Checked)
			{			
				IModifyExtensions modifyExtensions = new ModifyExtensions();
				if (_radioButtonLowerCaseExtension.Checked)
				{
					modifyExtensions.ExtensionModification = ExtensionModifications.LowerCase;
				}
				else if (_radioButtonRemoveExtension.Checked)
				{
					modifyExtensions.ExtensionModification = ExtensionModifications.Remove;
				}

				fileRenamerOptions.ModifyExtensions = modifyExtensions;
			}
			
			//Casing
			if (_checkBoxCasing.Checked)
			{			
				ICasing casing = new Casing();
				if (_radioButtonNewWordsStartWithCapital.Checked)
				{
					casing.CasingType = CasingTypes.NewWordsStartWithCapital;
				}
				else if (_radioButtonAllUpper.Checked)
				{
					casing.CasingType = CasingTypes.UpperCase;
				}
				else if (_radioButtonAllLower.Checked)
				{
					casing.CasingType = CasingTypes.LowerCase;
				}

				fileRenamerOptions.Casing = casing;
			}
			
			//FileTypeFilter
			if (_checkBoxFileTypeFilter.Checked)
			{
				IFileTypeFilter fileTypeFilter		= new FileTypeFilter();
				fileTypeFilter.FileTypeExtension	= _textBoxFileRenamingFileType.Text;
				fileRenamerOptions.FileTypeFilter	= fileTypeFilter;
			}		
			
			fileRenamerOptions.Recursive					= _checkBoxRecursive.Checked;
			fileRenamerOptions.ReplaceUnderscoresWithSpace	= _checkBoxReplaceUnderscoreWithSpace.Checked;
			
			return fileRenamerOptions;
		}

		#endregion

		#region 7-Zip

		private ISevenZipOptions GenerateSevenZipOptions()
		{
			ISevenZipOptions sevenZipOptions	= new SevenZipOptions();
			
			//Input file folder			
			sevenZipOptions.InputDirectory		= _textBoxDirectoryPath7Zip.Text;

			//Ouput file folder
			if (_textBox7ZipOutputDirectory.Text == SAME_OUTPUT_DIR)
			{
				sevenZipOptions.OutputDirectory = _textBoxDirectoryPath7Zip.Text;
			}
			else
			{
				sevenZipOptions.OutputDirectory = _textBox7ZipOutputDirectory.Text;
			}

			//7-Zip exe file folder
			sevenZipOptions.sevenZipExePath = _textBox7ZipExePath.Text;

			//FileTypeFilter
			if (_checkBox7ZipFilteFileTypes.Checked)
			{
				IFileTypeFilter fileTypeFilter		= new FileTypeFilter();
				
				fileTypeFilter.FileTypeExtension	= _textBox7ZipFileTypeExtension.Text;
				sevenZipOptions.FileTypeFilter		= fileTypeFilter;
			}		
			
			//Recursive
			sevenZipOptions.Recursive	= _checkBox7ZipRecursive.Checked;

			return sevenZipOptions;
		}

		#endregion

		#region Error Handling And Messaging
		
		private void HandleException(Exception ex)
		{
			PrintOutputMessage("****ERROR****");
			PrintOutputMessage(ex.GetType().ToString());
			PrintOutputMessage(ex.Message);
			PrintOutputMessage(ex.StackTrace);
				
			if (ex.InnerException != null)
			{
				PrintOutputMessage("Inner Exception:");
				PrintOutputMessage(ex.InnerException.GetType().ToString());
				PrintOutputMessage(ex.InnerException.Message);
				PrintOutputMessage(ex.InnerException.StackTrace);
			}
			
			MessageBox.Show(this, string.Format("An exception has occurred: {0}\n\n{1}", new object[] { ex.Message, ex.StackTrace }), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void PrintOutputMessage(string message)
		{			
			
			if (_tabControl.SelectedTab == _tabControl.TabPages[_tabPageFileRenaming.Name])
			{
				if (!string.IsNullOrEmpty(_richTextBoxFileRenamingOutput.Text))
				{
					_richTextBoxFileRenamingOutput.Text = string.Format("{0}\n{1}", new object[] { _richTextBoxFileRenamingOutput.Text, message });
				}
				else
				{
					_richTextBoxFileRenamingOutput.Text = message;
				}
			}
			else if (_tabControl.SelectedTab == _tabControl.TabPages[_tabPage7Zip.Name])
			{				
				if (!string.IsNullOrEmpty(_richTextBox7Zip.Text))
				{
					_richTextBox7Zip.Text = string.Format("{0}\n{1}", new object[] { _richTextBox7Zip.Text, message });
				}
				else
				{
					_richTextBox7Zip.Text = message;
				}
			}
		}

		#endregion		

		#endregion		
	}
}

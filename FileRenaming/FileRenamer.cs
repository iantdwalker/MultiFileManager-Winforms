using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// FileRenamer.
	/// </summary>
	public class FileRenamer : IFileRenamer
	{
		#region Private Members

		private TextInfo _textInfo;

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="FileRenamer"/> class.
		/// </summary>
		public FileRenamer()
		{
			_textInfo = new CultureInfo("en-GB", false).TextInfo;
		}

		#endregion
		
		#region IFileRenamer Members

		/// <summary>
		/// Renames the file using the supplied options.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="fileRenamerOptions">The file renamer options.</param>
		/// <exception cref="System.ArgumentNullException">fileRenamerOptions</exception>
		public void RenameFile(FileInfo file, IFileRenamerOptions fileRenamerOptions)
		{
			if (file				== null)	throw new ArgumentNullException("file");
			if (fileRenamerOptions	== null)	throw new ArgumentNullException("fileRenamerOptions");
			
			string fileNameOnly = file.Name.Substring(0, file.Name.IndexOf(file.Extension));
					
			//Trim?
			if (fileRenamerOptions.Trim != null)
			{
				if (fileRenamerOptions.Trim.TrimType == FileRenamerTrimTypes.Before)
				{
					//remove all chars before the trim string's start index
					int trimStringStartIndex	= fileNameOnly.IndexOf(fileRenamerOptions.Trim.TrimString, 0, StringComparison.CurrentCultureIgnoreCase);
					if (trimStringStartIndex >= 0)
					{					
						fileNameOnly			= fileNameOnly.Substring(trimStringStartIndex, fileNameOnly.Length-1);
					}
				}
				else if (fileRenamerOptions.Trim.TrimType == FileRenamerTrimTypes.After)
				{
					//remove all chars after the trim string
					int trimStringLength		= fileRenamerOptions.Trim.TrimString.Length;
					int trimStringStartIndex	= fileNameOnly.IndexOf(fileRenamerOptions.Trim.TrimString, 0, StringComparison.CurrentCultureIgnoreCase);
					if (trimStringStartIndex >= 0)
					{				
						int length					= trimStringStartIndex + trimStringLength;
							fileNameOnly			= fileNameOnly.Substring(0, length);
					}
				}
				else if (fileRenamerOptions.Trim.TrimType == FileRenamerTrimTypes.TrimStringOnly)
				{
					//remove trim string itself
					int trimStringStartIndex	= fileNameOnly.IndexOf(fileRenamerOptions.Trim.TrimString, 0, StringComparison.CurrentCultureIgnoreCase);
					if (trimStringStartIndex >= 0)
					{						
						fileNameOnly = fileNameOnly.Remove(trimStringStartIndex, fileRenamerOptions.Trim.TrimString.Length);
					}
				}
			}
			
			//Modify Extensions?
			string newExtension = null;
			if (fileRenamerOptions.ModifyExtensions != null)
			{				
				if (fileRenamerOptions.ModifyExtensions.ExtensionModification == ExtensionModifications.LowerCase)
				{		
					newExtension = file.Extension.ToLower(CultureInfo.CurrentCulture);
				}
				else if (fileRenamerOptions.ModifyExtensions.ExtensionModification == ExtensionModifications.Remove)
				{
					newExtension = string.Empty;
				}				
			}
			else
			{
				newExtension = file.Extension;
			}

			//Casing?
			if (fileRenamerOptions.Casing != null)
			{
				if (fileRenamerOptions.Casing.CasingType == CasingTypes.NewWordsStartWithCapital)
				{
					fileNameOnly = _textInfo.ToTitleCase(fileNameOnly);
				}
				else if (fileRenamerOptions.Casing.CasingType == CasingTypes.UpperCase)
				{
					fileNameOnly = _textInfo.ToUpper(fileNameOnly);
				}
				else if (fileRenamerOptions.Casing.CasingType == CasingTypes.LowerCase)
				{
					fileNameOnly = _textInfo.ToLower(fileNameOnly);
				}
			}			
			
			//ReplaceUnderscoresWithSpace
			if (fileRenamerOptions.ReplaceUnderscoresWithSpace)
			{				
				fileNameOnly = fileNameOnly.Replace('_', ' ');
			}			
					
			//Finalise and commit the new file name
			file.MoveTo(string.Format("{0}\\{1}{2}", new object[] { fileRenamerOptions.DirectoryPath, fileNameOnly, newExtension }));		
		}

		#endregion
	}
}

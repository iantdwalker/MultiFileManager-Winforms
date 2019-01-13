using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.SevenZip
{
	/// <summary>
	/// SevenZipCompressor.
	/// </summary>
	public class SevenZipCompressor : ISevenZipCompressor
	{
		#region Private Members

		private Process				_sevenZipProcess;
		private	ProcessStartInfo	_sevenZipProcessStartInfo;

		#endregion
		
		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SevenZipCompressor" /> class.
		/// </summary>
		/// <param name="sevenZipExePath">The seven zip executable path.</param>
		public SevenZipCompressor(string sevenZipExePath)
		{
			if (sevenZipExePath == null) throw new ArgumentNullException("sevenZipExePath");
			
			_sevenZipProcess						= new Process();
			_sevenZipProcessStartInfo				= new ProcessStartInfo();
			_sevenZipProcessStartInfo.WindowStyle	= ProcessWindowStyle.Hidden;
			_sevenZipProcessStartInfo.FileName		= sevenZipExePath;
		}

		#endregion
		
		#region ISevenZipCompressor Members

		/// <summary>
		/// Zips the file.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="sevenZipOptions">The seven zip options.</param>
		/// <exception cref="System.ArgumentNullException">
		/// file
		/// or
		/// sevenZipOptions
		/// </exception>
		public void ZipFile(FileInfo file, ISevenZipOptions sevenZipOptions)
		{
			if (file			== null) throw new ArgumentNullException("file");
			if (sevenZipOptions == null) throw new ArgumentNullException("sevenZipOptions");
			
			string	fileNameOnly						= file.Name.Substring(0, file.Name.IndexOf(file.Extension));
					_sevenZipProcessStartInfo.Arguments	= string.Format("a -t7z \"{0}\\{1}.7z\" \"{2}\\{3}\"", new object[] { sevenZipOptions.OutputDirectory, fileNameOnly, file.DirectoryName, file.Name });
					_sevenZipProcess.StartInfo			= _sevenZipProcessStartInfo;
					_sevenZipProcess.Start();
					_sevenZipProcess.WaitForExit();
		}

		#endregion
	}
}

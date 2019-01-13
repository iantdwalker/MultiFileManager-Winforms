using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.SevenZip
{
	/// <summary>
	/// ISevenZipCompressor.
	/// </summary>
	public interface ISevenZipCompressor
	{
		/// <summary>
		/// Zips the file.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="sevenZipOptions">The seven zip options.</param>
		void ZipFile(FileInfo file, ISevenZipOptions sevenZipOptions);
	}
}

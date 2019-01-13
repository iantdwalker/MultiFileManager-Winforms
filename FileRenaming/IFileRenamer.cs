using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// IFileRenamer.
	/// </summary>
	public interface IFileRenamer
	{
		/// <summary>
		/// Renames the file using the supplied options.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="fileRenamerOptions">The file renamer options.</param>
		void RenameFile(FileInfo file, IFileRenamerOptions fileRenamerOptions);
	}
}

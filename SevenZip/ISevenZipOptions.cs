using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.SevenZip
{
	/// <summary>
	/// ISevenZipOptions.
	/// </summary>
	public interface ISevenZipOptions
	{
		/// <summary>
		/// Gets or sets the input directory.
		/// </summary>
		/// <value>
		/// The input directory.
		/// </value>
		string InputDirectory { get; set; }

		/// <summary>
		/// Gets or sets the output directory.
		/// </summary>
		/// <value>
		/// The output directory.
		/// </value>
		string OutputDirectory { get; set; }
		
		/// <summary>
		/// Gets or sets the seven zip executable path.
		/// </summary>
		/// <value>
		/// The seven zip executable path.
		/// </value>
		string sevenZipExePath { get; set; }

		/// <summary>
		/// Gets or sets the file type filter.
		/// </summary>
		/// <value>
		/// The file type filter.
		/// </value>
		IFileTypeFilter FileTypeFilter { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ISevenZipOptions"/> is recursive.
		/// </summary>
		/// <value>
		///   <c>true</c> if recursive; otherwise, <c>false</c>.
		/// </value>
		bool Recursive { get; set; }
	}
}

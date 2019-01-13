using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.SevenZip
{
	/// <summary>
	/// SevenZipOptions.
	/// </summary>
	public class SevenZipOptions : ISevenZipOptions
	{
		#region ISevenZipOptions Members

		/// <summary>
		/// Gets or sets the input directory.
		/// </summary>
		/// <value>
		/// The input directory.
		/// </value>
		public string InputDirectory
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the output directory.
		/// </summary>
		/// <value>
		/// The output directory.
		/// </value>
		public string OutputDirectory
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the seven zip executable path.
		/// </summary>
		/// <value>
		/// The seven zip executable path.
		/// </value>
		/// <exception cref="System.NotImplementedException">
		/// </exception>
		public string sevenZipExePath
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the file type filter.
		/// </summary>
		/// <value>
		/// The file type filter.
		/// </value>
		public IFileTypeFilter FileTypeFilter
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ISevenZipOptions" /> is recursive.
		/// </summary>
		/// <value>
		///   <c>true</c> if recursive; otherwise, <c>false</c>.
		/// </value>
		public bool Recursive
		{ 
			get;
			set;
		}
		
		#endregion
	}
}

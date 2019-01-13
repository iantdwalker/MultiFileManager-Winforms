using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// IFileRenamerOptions
	/// </summary>
	public interface IFileRenamerOptions
	{
		/// <summary>
		/// Gets or sets the directory path.
		/// </summary>
		/// <value>
		/// The directory path.
		/// </value>
		string DirectoryPath { get; set; }

		/// <summary>
		/// Gets or sets the trim object that holds the trimming information.
		/// </summary>
		/// <value>
		/// The trim.
		/// </value>
		ITrim Trim { get; set; }

		/// <summary>
		/// Gets or sets the modify extensions.
		/// </summary>
		/// <value>
		/// The modify extensions.
		/// </value>
		IModifyExtensions ModifyExtensions { get; set; }

		/// <summary>
		/// Gets or sets the Casing object.
		/// </summary>
		/// <value>
		/// The Casing.
		/// </value>
		ICasing Casing { get; set; }

		/// <summary>
		/// Gets or sets the file type filter.
		/// </summary>
		/// <value>
		/// The file type filter.
		/// </value>
		IFileTypeFilter FileTypeFilter { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="IFileRenamerOptions"/> is recursive.
		/// </summary>
		/// <value>
		///   <c>true</c> if recursive; otherwise, <c>false</c>.
		/// </value>
		bool Recursive { get; set; }
		
		/// <summary>
		/// Gets or sets a value indicating whether [replace underscores with space].
		/// </summary>
		/// <value>
		/// <c>true</c> if [replace underscores with space]; otherwise, <c>false</c>.
		/// </value>
		bool ReplaceUnderscoresWithSpace { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// FileRenamerOptions.
	/// </summary>
	public class FileRenamerOptions : IFileRenamerOptions
	{
		#region IFileRenamerOptions Members

		/// <summary>
		/// Gets or sets the directory path.
		/// </summary>
		/// <value>
		/// The directory path.
		/// </value>
		public string DirectoryPath
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the trim object that holds the trimming information.
		/// </summary>
		/// <value>
		/// The trim.
		/// </value>
		/// <exception cref="System.NotImplementedException">
		/// </exception>
		public ITrim Trim
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the modify extensions.
		/// </summary>
		/// <value>
		/// The modify extensions.
		/// </value>
		public IModifyExtensions ModifyExtensions
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the Casing object.
		/// </summary>
		/// <value>
		/// The Casing.
		/// </value>
		public ICasing Casing
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
		/// Gets or sets a value indicating whether this <see cref="IFileRenamerOptions" /> is recursive.
		/// </summary>
		/// <value>
		///   <c>true</c> if recursive; otherwise, <c>false</c>.
		/// </value>
		public bool Recursive
		{ 
			get;
			set;
		}
		
		/// <summary>
		/// Gets or sets a value indicating whether [replace underscores with space].
		/// </summary>
		/// <value>
		/// <c>true</c> if [replace underscores with space]; otherwise, <c>false</c>.
		/// </value>
		/// <exception cref="System.NotImplementedException">
		/// </exception>
		public bool ReplaceUnderscoresWithSpace
		{
			get;
			set;			
		}				

		#endregion
	}
}

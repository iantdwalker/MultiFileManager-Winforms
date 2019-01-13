using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager
{
	/// <summary>
	/// FileTypeFilter.
	/// </summary>
	public class FileTypeFilter : IFileTypeFilter
	{
		#region IFileTypeFilter Members

		/// <summary>
		/// Gets or sets the file type extension to be filtered. Excludes the '.' portion of the extension.
		/// </summary>
		/// <value>
		/// The file type extension.
		/// </value>
		/// <exception cref="System.NotImplementedException">
		/// </exception>
		public string FileTypeExtension
		{
			get;			
			set;			
		}

		#endregion
	}
}

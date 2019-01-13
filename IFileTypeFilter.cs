using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager
{
	/// <summary>
	/// IFileTypeFilter
	/// </summary>
	public interface IFileTypeFilter
	{
		/// <summary>
		/// Gets or sets the file type extension to be filtered. Excludes the '.' portion of the extension.
		/// </summary>
		/// <value>
		/// The file type extension.
		/// </value>
		string FileTypeExtension { get; set; }
	}
}

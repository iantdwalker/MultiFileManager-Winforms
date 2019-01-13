using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// ITrim
	/// </summary>
	public interface ITrim
	{
		/// <summary>
		/// Gets or sets the trim string.
		/// </summary>
		/// <value>
		/// The trim string.
		/// </value>
		string TrimString { get; set; }

		/// <summary>
		/// Gets or sets the type of the trim.
		/// </summary>
		/// <value>
		/// The type of the trim.
		/// </value>
		FileRenamerTrimTypes TrimType { get; set; }
	}
}

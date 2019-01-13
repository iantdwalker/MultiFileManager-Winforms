using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// FileRenamerTrimTypes
	/// </summary>
	public enum FileRenamerTrimTypes
	{
		/// <summary>
		/// Trim before the trim string
		/// </summary>
		Before,

		/// <summary>
		/// Trim after the trim string
		/// </summary>
		After,

		/// <summary>
		/// Trim the trim string only
		/// </summary>
		TrimStringOnly
	}
}

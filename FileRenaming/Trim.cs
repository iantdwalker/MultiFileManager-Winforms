using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// Trim.
	/// </summary>
	public class Trim : ITrim
	{
		#region ITrim Members

		/// <summary>
		/// Gets or sets the trim string.
		/// </summary>
		/// <value>
		/// The trim string.
		/// </value>
		public string TrimString
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the type of the trim.
		/// </summary>
		/// <value>
		/// The type of the trim.
		/// </value>
		public FileRenamerTrimTypes TrimType
		{
			get;
			set;
		}

		#endregion
	}
}

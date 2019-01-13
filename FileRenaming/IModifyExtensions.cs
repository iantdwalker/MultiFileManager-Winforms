using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// IModifyExtensions.
	/// </summary>
	public interface IModifyExtensions
	{
		/// <summary>
		/// Gets or sets the type of the extension modification.
		/// </summary>
		/// <value>
		/// The type of the extension modification.
		/// </value>
		ExtensionModifications ExtensionModification { get; set; }
	}
}

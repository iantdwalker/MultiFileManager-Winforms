using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// ModifyExtensions.
	/// </summary>
	public class ModifyExtensions : IModifyExtensions
	{
		#region IModifyExtensions Members

		/// <summary>
		/// Gets or sets the type of the extension modification.
		/// </summary>
		/// <value>
		/// The type of the extension modification.
		/// </value>
		public ExtensionModifications ExtensionModification
		{
			get;
			set;
		}

		#endregion
	}
}

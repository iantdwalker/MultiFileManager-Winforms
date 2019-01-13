using System;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// Casing.
	/// </summary>
	public class Casing : ICasing
	{
		#region ICasing Members
		
		/// <summary>
		/// Gets or sets the type of the casing.
		/// </summary>
		/// <value>
		/// The type of the casing.
		/// </value>
		public CasingTypes CasingType
		{
			get;
			set;
		}
		
		#endregion
	}
}

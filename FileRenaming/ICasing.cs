using System;

namespace MultiFileManager.FileRenaming
{
	/// <summary>
	/// ICasing.
	/// </summary>
	public interface ICasing
	{
		/// <summary>
		/// Gets or sets the type of the casing.
		/// </summary>
		/// <value>
		/// The type of the casing.
		/// </value>
		CasingTypes CasingType { get; set; }
	}
}

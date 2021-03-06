﻿using System;

namespace NControl.Mvvm
{
	/// <summary>
	/// I view model.
	/// </summary>
	public interface IViewModel
	{
		/// <summary>
		/// Gets or sets the presentation mode.
		/// </summary>
		/// <value>The presentation mode.</value>
		PresentationMode PresentationMode { get; set; }
	}
}


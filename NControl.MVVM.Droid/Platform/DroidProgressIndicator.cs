﻿using System;
using Android.App;

namespace NControl.MVVM
{
	/// <summary>
	/// Droid activity indicator.
	/// </summary>
	public class DroidActivityIndicator: IActivityIndicator
	{
		#region Class Members

		/// <summary>
		/// The progress dialog.
		/// </summary>
		private ProgressDialog _progressDialog;

		#endregion

		#region IActivityIndicator implementation

		/// <summary>
		/// Updates the progress.
		/// </summary>
		/// <param name="visible">If set to <c>true</c> visible.</param>
		/// <param name="title">Title.</param>
		/// <param name="subtitle">Subtitle.</param>
		public void UpdateProgress (bool visible, string title = "", string subtitle = "")
		{
			if (_progressDialog == null) {
				_progressDialog = new ProgressDialog (Xamarin.Forms.Forms.Context);
				_progressDialog.SetCancelable(false);
			}

			_progressDialog.SetMessage(title);
			if(visible && !_progressDialog.IsShowing)
				_progressDialog.Show();

			if (!visible && _progressDialog.IsShowing)
				_progressDialog.Hide ();
		}
		#endregion
	}
}
﻿namespace Append.Blazor.Printing
{
	/// <summary>
	/// Adapts the <see cref="PrintOptions"/> to the JavaScript version.
	/// </summary>
	internal record PrintOptionsAdapter
	{
		public string Printable { get; init; }
		public string Type { get; init; }
		public bool ShowModal { get; init; }
		public string ModalMessage { get; init; } = "Retrieving Document...";
		public bool? Base64 { get; set; }
		public bool ScanStyles { get; set; }
		public string Style { get; set; }
		public string TargetStyles { get; set; }
		public string[] IgnoreElements { get; set; }
		public string DocumentTitle { get; set; }
		public string OnLoadingStart { get; set; }
		public string OnLoadingEnd { get; set; }

		public PrintOptionsAdapter(PrintOptions options)
		{
			Printable = options.Printable;
			Type = options.Type.ToPrintJsString();
			ShowModal = options.ShowModal;
			ModalMessage = options.ModalMessage;
			Base64 = options.Base64 == true ? true : null;
			Style = options.Style;
			TargetStyles = options.TargetStyles;
			ScanStyles = options.ScanStyles;
			IgnoreElements = options.IgnoreElements;
			DocumentTitle = options.DocumentTitle;
			OnLoadingStart = options.OnLoadingStart;
			OnLoadingEnd = options.OnLoadingEnd;
		}
	}
}

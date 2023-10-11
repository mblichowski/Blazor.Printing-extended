namespace Append.Blazor.Printing;

/// <summary>
/// Options for a specific print.
/// </summary>
public record PrintOptions
{
    public PrintOptions()
    {

    }
    public PrintOptions(string printable)
    {
        Printable = printable;
    }

    public PrintOptions(string printable, string modalMessage, PrintType printType = PrintType.Pdf)
    {
        Printable = printable;
        ModalMessage = modalMessage;
        ShowModal = true;
        Type = printType;
    }
    /// <summary>
    /// Function to be executed after PDF has loaded.
    /// </summary>
    public string OnLoadingEnd { get; set; }
    /// <summary>
    /// Function to be executed when PDF is being loaded.
    /// </summary>
    public string OnLoadingStart { get; set; }
    /// <summary>
    /// When printing html, image or json, this will be shown as the document title.
    /// </summary>
    public string DocumentTitle { get; set; } = "Document";
    /// <summary>
    /// Accepts an array of html ids that should be ignored when printing a parent html element.
    /// </summary>
    public string[] IgnoreElements { get; set; }
    /// <summary>
    /// When set to false, the library will not process styles applied to the html being printed. Useful when using the css parameter.
    /// </summary>
    public bool ScanStyles { get; set; } = true;
    /// <summary>
    /// This allow us to pass a string with custom style that should be applied to the html being printed.
    /// </summary>
    public string Style { get; set; }
    /// <summary>
    /// Same as `targetStyle`, however, this will process any a range of styles.Ex.: ['border', 'padding'], will include 'border-bottom', 'border-top', 'border-left', 'border-right', 'padding-top', etc.
    ///	You can also pass['*'] to process all styles.
    /// </summary>
    public string TargetStyles { get; set; } = "['*']";
    /// <summary>
    /// Document source: pdf url or base64.
    /// </summary>
    public string Printable { get; init; }
    /// <summary>
    /// Printable type.
    /// </summary>
    public PrintType Type { get; init; }
    /// <summary>
    /// Enable this option to show user feedback when retrieving or processing large PDF files.
    /// </summary>
    public bool ShowModal { get; init; }
    /// <summary>
    /// Message displayed to users when <see cref="ShowModal"/> is set to true.
    /// </summary>
    public string ModalMessage { get; init; } = "Retrieving Document...";
    /// <summary>
    /// Used when printing PDF documents passed as base64 data.
    /// </summary>
    public bool Base64 { get; set; }
    /// <summary>
    /// If true, the print.js internals will ignore the default setting of 12px font size.
    /// </summary>
    public bool OverrideDefaultFontSize { get; set; }
}

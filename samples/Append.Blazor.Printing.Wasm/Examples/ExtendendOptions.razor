@inject IPrintingService PrintingService
<Example Name="@this.GetType().Name">
    <Documentation>
        <h3>HTML with extended options</h3>
        <p>Print a HTML element with a specific Id and additional options.</p>
        <p>@_options.ToString()</p>
    </Documentation>
    <Code>
        <form id="printable-form">
            <div class="form-group">
                <label for="exampleInputEmail1">Email address</label>
                <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
                <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password</label>
                <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
            </div>
            <div class="form-check">
                <input type="checkbox" class="form-check-input" id="exampleCheck1">
                <label class="form-check-label text-primary" for="exampleCheck1">Check me out</label>
            </div>
            <div id="@_ignoredElementId1">
                <p>This content will not be printed</p>
            </div>
            <div id="@_ignoredElementId2">
                <p>This content will not be printed too</p>
            </div>
        </form>

        <button @onclick="@(_ => PrintingService.Print(_options))">
            Print Form
        </button>
    </Code>
</Example>

@code {
    private static string _ignoredElementId1 = "ignored-element-1";
    private static string _ignoredElementId2 = "ignored-element-2";

    private readonly PrintOptions _options = new()
    {
        Printable = "printable-form",
        Type = PrintType.Html,
        DocumentTitle = "Custom document title",
        IgnoreElements = new[] { _ignoredElementId1, _ignoredElementId2 },
        Style = "color: red !important;",        
    };

}
using Microsoft.AspNetCore.Blazor.Browser.Interop;

public class ExampleJsInterop
{
    public static string Prompt(string message)
    {
        return RegisteredFunction.Invoke<string>(
            "ExampleJsInterop.Prompt",
            message);
    }
}
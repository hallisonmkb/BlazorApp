Blazor.registerFunction('ExampleJsInterop.Prompt', function (message) {
    return prompt(message, 'Type anything here');
});
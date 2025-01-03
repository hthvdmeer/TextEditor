﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading;
using System.Threading.Tasks;

namespace Blazored.TextEditor
{
    public static class Interop
    {
        internal static ValueTask<object> CreateQuill(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            ElementReference toolbar,
            bool readOnly,
            string placeholder,
            string theme,
            string[] formats,
            string debugLevel,
            bool syntax)
        {
            return jsRuntime.InvokeAsync<object>(
                "QuillFunctions.createQuill", 
                quillElement, toolbar, readOnly, 
                placeholder, theme, formats, debugLevel, syntax);
        }

        internal static ValueTask<string> GetText(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<string>(
                "QuillFunctions.getQuillText",
                cancellationToken,
                quillElement);
        }

        internal static ValueTask<string> GetHTML(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<string>(
                "QuillFunctions.getQuillHTML",
                cancellationToken,
                quillElement);
        }

#if NET6_0_OR_GREATER
        internal static ValueTask<IJSStreamReference> GetHTMLAsStream(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<IJSStreamReference>(
                "QuillFunctions.getQuillEncodedHTML",
                cancellationToken,
                quillElement);
        }
#endif

        internal static ValueTask<string> GetContent(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<string>(
                "QuillFunctions.getQuillContent",
                cancellationToken,
                quillElement);
        }

        internal static ValueTask<object> LoadQuillContent(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string Content,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<object>(
                "QuillFunctions.loadQuillContent",
                cancellationToken,
                quillElement, Content);
        }

        internal static ValueTask<object> LoadQuillHTMLContent(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string quillHTMLContent,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<object>(
                "QuillFunctions.loadQuillHTMLContent",
                cancellationToken,
                quillElement, quillHTMLContent);
        }

        internal static ValueTask<object> EnableQuillEditor(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            bool mode,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<object>(
                "QuillFunctions.enableQuillEditor",
                cancellationToken,
                quillElement, mode);
        }

        internal static ValueTask<object> InsertQuillImage(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string imageURL,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<object>(
                "QuillFunctions.insertQuillImage",
                cancellationToken,
                quillElement, imageURL);
        }

        internal static ValueTask<object> InsertQuillText(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string text,
            CancellationToken cancellationToken = default)
        {
            return jsRuntime.InvokeAsync<object>(
                "QuillFunctions.insertQuillText",
                cancellationToken,
                quillElement, text);
        }
    }
}
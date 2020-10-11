using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace AbpIoAzureDevops.Blazor.Components
{
    public class PartTemplateBase : ComponentBase
    {
        [Inject] IJSRuntime JSRuntime { get; set; }
        [Parameter] public string Title { get; set; }
        [Parameter] public string Href { get; set; }
        [Parameter] public string PrevHref { get; set; }
        [Parameter] public string NextHref { get; set; }
        [Parameter] public string PageIdentifier { get; set; }
        [Parameter] public RenderFragment Part { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("Prism.highlightAll");
        }
    }
}
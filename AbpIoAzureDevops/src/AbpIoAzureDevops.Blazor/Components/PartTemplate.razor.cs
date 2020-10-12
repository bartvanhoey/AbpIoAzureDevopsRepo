using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Volo.Abp;

namespace AbpIoAzureDevops.Blazor.Components
{
  public class PartTemplateBase : ComponentBase
  {
    [Inject] IJSRuntime JSRuntime { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }
    [Parameter] public string Title { get; set; }
    [Parameter] public string Href { get; set; }
    [Parameter] public string PrevHref { get; set; }
    [Parameter] public string NextHref { get; set; }
    [Parameter] public string PageIdentifier { get; set; }
    [Parameter] public RenderFragment Part { get; set; }

    protected int PreviousPage = -1;
    protected int CurrentPage = -1;
    protected int NextPage = -1;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
      await JSRuntime.InvokeVoidAsync("Prism.highlightAll");
    }




    protected override void OnParametersSet()
    {
      if (!string.IsNullOrWhiteSpace(PrevHref))
      {
        int.TryParse(Regex.Match(PrevHref, @"\d+").Value, out var iPreviousPage);
        PreviousPage = iPreviousPage;
      }

      if (!string.IsNullOrWhiteSpace(Href))
      {
        int.TryParse(Regex.Match(Href, @"\d+").Value, out var iCurrentPage);
        CurrentPage = iCurrentPage;
      }

      if (!string.IsNullOrWhiteSpace(NextHref))
      {
        int.TryParse(Regex.Match(NextHref, @"\d+").Value, out var iNextPage);
        NextPage = iNextPage;
      }
    }


    protected void NavigateToPage(string hRef) => NavigationManager.NavigateTo(hRef);

  }
}
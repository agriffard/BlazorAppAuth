using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ZBlazorAppAuth.Components.Layout;
public partial class TopMenu : ComponentBase
{
    private Offcanvas offcanvasUser = default!;
    private async Task OnShowOffcanvasUserClick() => await offcanvasUser.ShowAsync();
    private async Task OnHideOffcanvasUserClick() => await offcanvasUser.HideAsync();
}

#pragma checksum "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3efb79355c0518a1de619795c73c65b87c5e0bf6"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskUltimate.App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\_Imports.razor"
using TaskUltimate.App.Componentes;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<TaskUltimate.App.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.App\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskUltimate.App.Services.Apiservice apiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskUltimate.App.Services.ApiTarefa apiTarefa { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\CardProjeto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0228eb092d98062dcebfce834c12341d2742ab13"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskUltimate.Server.Componentes
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using TaskUltimate.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using TaskUltimate.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using TaskUltimateBibliotec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using TaskUltimateBibliotec.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using TaskUltimate.Server.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using TaskUltimate.Server.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using TaskUltimate.Server.Componentes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
    public partial class CardProjeto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CardProjeto</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\CardProjeto.razor"
       
    [Parameter]
    public int ProjetoId { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Apiservice apiService { get; set; }
    }
}
#pragma warning restore 1591

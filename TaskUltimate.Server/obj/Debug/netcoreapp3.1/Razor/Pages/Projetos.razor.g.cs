#pragma checksum "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b5c6b9f3075326db8bde41662ae7f235e7ff34d"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskUltimate.Server.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/projetos")]
    public partial class Projetos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
 if (projetos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1>Carregando .........</h1>\r\n");
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
     foreach (Projeto elemento in projetos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 10 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
                  "/pagetarefa/"+ elemento.ProjetoId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Numero projeto ");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
                                                                      elemento.ProjetoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 11 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
        
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
      
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Pages\Projetos.razor"
       
private List<Projeto> projetos;
    protected override async Task OnInitializedAsync()
    {
        projetos = await apiService.apiProjeto.GetAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Apiservice apiService { get; set; }
    }
}
#pragma warning restore 1591

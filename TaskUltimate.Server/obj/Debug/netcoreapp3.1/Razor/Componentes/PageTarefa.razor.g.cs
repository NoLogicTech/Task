#pragma checksum "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b49a0d136580cb7e1313bb7a77ce84496084c32f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagetarefa/{ProjetoId}")]
    public partial class PageTarefa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<TaskUltimate.Server.Componentes.FormTarefa>(0);
            __builder.AddAttribute(1, "ProjetoId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
                       Convert.ToInt32(ProjetoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, @"<style>
    .draggable {
        border: 1px solid #ccc;
        border-radius: 5px;
        margin: 1rem;
        padding: 1rem;
        display: inline-block;
        cursor: move;
    }

    .drop-target {
        border: 1px dashed #ebebeb;
        margin: 1rem;
        padding: 1rem;
        display: inline-block;
    }
</style>
");
#nullable restore
#line 21 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
 if (temp == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<h1>Careegando.......</h1>\r\n");
#nullable restore
#line 24 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
     foreach (Tarefa elemento in temp)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenComponent<TaskUltimate.Server.Componentes.CardTarefa>(7);
            __builder.AddAttribute(8, "tarefa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TaskUltimateBibliotec.Models.Tarefa>(
#nullable restore
#line 29 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
                             elemento

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 30 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 33 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
 if (dropMessage != null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, 
#nullable restore
#line 35 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
     dropMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
                
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\NoLogicTech\Documents\GitHub\Task\TaskUltimate.Server\Componentes\PageTarefa.razor"
      
    public List<Tarefa> temp { get; set; }

    [Parameter]
    public string ProjetoId { get; set; }

    [Parameter]
    public int ParenteId { get; set; }

    string dropMessage = null;

    public async Task OnDrop(Tarefa data)
    {
        dropMessage = $"Dropped: {data}";
        await apiService.apiTarefa.InsertAsync(data.TarefaId, 1, data);
        // Important: Invoke StateHasChanged() to update the page
        StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        if (ParenteId != 0)
            temp = await apiService.apiTarefa.GetFilho(ParenteId);
        else
            temp = await apiService.apiTarefa.GetParentByProject(Convert.ToInt32(ProjetoId));

        // se existe algum projeto com a mesma chave do contador ela é ordenada
        temp.Sort(delegate (Tarefa p1, Tarefa p2)
        {
            return $"{p1.TarefaPosicao}".CompareTo($"{p2.TarefaPosicao}");
        });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Apiservice apiService { get; set; }
    }
}
#pragma warning restore 1591

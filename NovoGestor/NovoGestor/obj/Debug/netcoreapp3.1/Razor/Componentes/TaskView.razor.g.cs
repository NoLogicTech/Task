#pragma checksum "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\Componentes\TaskView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c2818a7308349117d0483c0928f8079217271e"
// <auto-generated/>
#pragma warning disable 1591
namespace NovoGestor.Componentes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TaskView")]
    public partial class TaskView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #taskView {
        width: 90%;
        align-items: center;
        justify-content: center;
    }

    #conteudo {
        width: 100%;
        padding: 5px;
    }

    h2 {
        margin-top: 5px;
        width: 100%;
        margin-left: 2px;
        margin-right: 2px;
        font-size: 14pt;
    }

    #editar {
        background-color: #0C6291;
        color: #FBFEF9;
        margin-right: 4px;
        margin-top: 5px;
    }

    #finalizar {
        background-color: #297045;
        color: #FBFEF9;
        margin-left: 4px;
        margin-top: 5px;
    }

    #conteudo ul li {
        display: inline-block;
        margin: 4px;
    }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "id", "taskView");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "conteudo");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "id", "buttons ");
            __builder.AddAttribute(10, "class", "btn-group");
            __builder.AddAttribute(11, "role", "group");
            __builder.AddAttribute(12, "aria-label", "Basic example");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "id", "editar");
            __builder.AddAttribute(17, "class", "btn btn-secondary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\Componentes\TaskView.razor"
                                                                                  Editar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "id", "finalizar");
            __builder.AddAttribute(24, "class", "btn btn-secondary");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\Componentes\TaskView.razor"
                                                                                     Finalizar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Finalizar");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n    ");
            __builder.AddMarkupContent(30, "<table class=\"table\">\r\n        <tbody>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"30\" height=\"30\" fill=\"currentColor\" class=\"bi bi-check2-circle\" viewBox=\"0 0 16 16\">\r\n                        <path d=\"M2.5 8a5.5 5.5 0 0 1 8.25-4.764.5.5 0 0 0 .5-.866A6.5 6.5 0 1 0 14.5 8a.5.5 0 0 0-1 0 5.5 5.5 0 1 1-11 0z\"></path>\r\n                        <path d=\"M15.354 3.354a.5.5 0 0 0-.708-.708L8 9.293 5.354 6.646a.5.5 0 1 0-.708.708l3 3a.5.5 0 0 0 .708 0l7-7z\"></path>\r\n                    </svg>\r\n\r\n                    <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"25\" height=\"25\" fill=\"currentColor\" class=\"bi bi-circle\" viewBox=\"0 0 16 16\">\r\n                        <path d=\"M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z\"></path>\r\n                    </svg>\r\n                </th>\r\n                <td>\r\n                    <div id=\"conteudo\">\r\n                        <h2>Ordem da Tarefa - Nome da tarefa</h2>\r\n\r\n                        <ul id=\"info\">\r\n                            <li>\r\n                                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-calendar-week\" viewBox=\"0 0 16 16\">\r\n                                    <path d=\"M11 6.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1zm-3 0a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1zm-5 3a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1zm3 0a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1z\"></path>\r\n                                    <path d=\"M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z\"></path>\r\n                                </svg>\r\n\r\n                                Data para coclusao Seg, 7 julho\r\n                            </li>\r\n                            <li>\r\n                                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-circle\" viewBox=\"0 0 16 16\">\r\n                                    <path d=\"M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z\"></path>\r\n                                </svg>\r\n                                Categoria Vermelha\r\n                            </li>\r\n\r\n                            <li>\r\n                                Atribuido a Nome da Pessoa\r\n                            </li>\r\n\r\n                            <li>\r\n                                Criado po Nome da pessoa\r\n                            </li>\r\n                        </ul>\r\n\r\n                    </div>\r\n\r\n                </td>\r\n                <td>\r\n                    <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"25\" height=\"25\" fill=\"currentColor\" class=\"bi bi-star\" viewBox=\"0 0 16 16\">\r\n                        <path d=\"M2.866 14.85c-.078.444.36.791.746.593l4.39-2.256 4.389 2.256c.386.198.824-.149.746-.592l-.83-4.73 3.522-3.356c.33-.314.16-.888-.282-.95l-4.898-.696L8.465.792a.513.513 0 0 0-.927 0L5.354 5.12l-4.898.696c-.441.062-.612.636-.283.95l3.523 3.356-.83 4.73zm4.905-2.767-3.686 1.894.694-3.957a.565.565 0 0 0-.163-.505L1.71 6.745l4.052-.576a.525.525 0 0 0 .393-.288L8 2.223l1.847 3.658a.525.525 0 0 0 .393.288l4.052.575-2.906 2.77a.565.565 0 0 0-.163.506l.694 3.957-3.686-1.894a.503.503 0 0 0-.461 0z\"></path>\r\n                    </svg>\r\n\r\n                    <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"25\" height=\"25\" fill=\"currentColor\" class=\"bi bi-star-fill\" viewBox=\"0 0 16 16\" color=\"red\">\r\n                        <path d=\"M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z\"></path>\r\n                    </svg>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\NoLogicTech\Documents\GitHub\NovoGestor\NovoGestor\Componentes\TaskView.razor"
      
    private void Editar()
    {
    }

    private void Finalizar()
    {
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1d09ba411b392bcc969ee4c3e0ae04b0fe438a"
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
#line 1 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\_Imports.razor"
using NovoGestor.Componentes;

#line default
#line hidden
#nullable disable
    public partial class TarefaForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #taskView {
        width: 90%;
        align-items: center;
        justify-content: center;
        border-bottom: 2px solid #C2C2C2;
        padding: 0px 4px 0px 4px;
    }

    #conteudo {
        width: 100%;
        padding: 5px;
    }

    h2 {
        margin-top: 1px;
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

    #rowTarefa {
        /*box-shadow: 2px 2px 4px ;*/
        padding: 5px 2px 5px 2px;
    }
    /*-----------------------------------------------------------------------------*/

    .optionIcon {
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center
    }

    .inputValor {
        width: 50%%;
        padding: 4px 0px 4px 8px;
        margin: 2px 0;
        box-sizing: border-box;
        border: none;
        border-radius: 4px;
    }
</style>

");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 64 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                 tarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 64 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.AddAttribute(8, "id", "taskView");
                __builder2.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                                                   Selecionar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row");
                __builder2.AddAttribute(13, "id", "rowTarefa");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "id", true);
                __builder2.AddAttribute(17, "class", "col-1 optionIcon");
                __builder2.AddMarkupContent(18, "\r\n");
#nullable restore
#line 68 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                 if (selecionado)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "                    ");
                __builder2.AddMarkupContent(20, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-check2-circle"" viewBox=""0 0 16 16"">
                        <path d=""M2.5 8a5.5 5.5 0 0 1 8.25-4.764.5.5 0 0 0 .5-.866A6.5 6.5 0 1 0 14.5 8a.5.5 0 0 0-1 0 5.5 5.5 0 1 1-11 0z""></path>
                        <path d=""M15.354 3.354a.5.5 0 0 0-.708-.708L8 9.293 5.354 6.646a.5.5 0 1 0-.708.708l3 3a.5.5 0 0 0 .708 0l7-7z""></path>
                    </svg>
");
#nullable restore
#line 74 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(21, "\r\n");
#nullable restore
#line 76 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                 if (!selecionado)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(22, "                    ");
                __builder2.AddMarkupContent(23, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-circle"" viewBox=""0 0 16 16"">
                        <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z""></path>
                    </svg>
");
#nullable restore
#line 81 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-10");
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "id", "conteudo");
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", " container row");
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-auto");
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.AddMarkupContent(38, "<label for=\"TarefaPosicao\">Tarefa</label>\r\n                            ");
                __Blazor.NovoGestor.Componentes.TarefaForm.TypeInference.CreateInputNumber_0(__builder2, 39, 40, "TarefaPosicao", 41, "inputValor", 42, 
#nullable restore
#line 91 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                                                                                           tarefa.TarefaPosicao

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tarefa.TarefaPosicao = __value, tarefa.TarefaPosicao)), 44, () => tarefa.TarefaPosicao);
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.AddMarkupContent(47, "<div class=\"col-auto\">\r\n                            <p>-</p>\r\n                        </div>\r\n                        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-auto");
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "id", "TarefaNome");
                __builder2.AddAttribute(53, "class", "inputValor");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 97 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                                                                                      tarefa.TarefaNome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tarefa.TarefaNome = __value, tarefa.TarefaNome))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tarefa.TarefaNome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        <div class=\"col-auto\"></div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(60, "ul");
                __builder2.AddAttribute(61, "id", "info");
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.OpenElement(63, "li");
                __builder2.AddMarkupContent(64, "\r\n                            ");
                __builder2.AddMarkupContent(65, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-calendar-week"" viewBox=""0 0 16 16"">
                                <path d=""M11 6.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1zm-3 0a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1zm-5 3a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1zm3 0a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1z""></path>
                                <path d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z""></path>
                            </svg>
                            ");
                __builder2.AddMarkupContent(66, "<label for=\"TarefaDataLimite\">Data para coclusao</label>\r\n                            ");
                __Blazor.NovoGestor.Componentes.TarefaForm.TypeInference.CreateInputDate_1(__builder2, 67, 68, "TarefaDataLimite", 69, "inputValor", 70, 
#nullable restore
#line 110 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                                                                                            tarefa.TarefaDatalimite

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tarefa.TarefaDatalimite = __value, tarefa.TarefaDatalimite)), 72, () => tarefa.TarefaDatalimite);
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.AddMarkupContent(75, @"<li>
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-circle"" viewBox=""0 0 16 16"">
                                <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z""></path>
                            </svg>
                            Categoria Vermelha
                        </li>

                        ");
                __builder2.OpenElement(76, "li");
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "p");
                __builder2.AddContent(79, "Atribuido a: ");
                __builder2.AddContent(80, 
#nullable restore
#line 120 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                                             tarefa.UtilizadorIdatribuido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n                        ");
                __builder2.OpenElement(83, "li");
                __builder2.AddMarkupContent(84, "\r\n                            ");
                __builder2.OpenElement(85, "p");
                __builder2.AddContent(86, "Criado por: ");
                __builder2.AddContent(87, 
#nullable restore
#line 124 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
                                            tarefa.UtilizadorIdcriador

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.AddMarkupContent(93, @"<div class=""col-1 optionIcon"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-star"" viewBox=""0 0 16 16"">
                    <path d=""M2.866 14.85c-.078.444.36.791.746.593l4.39-2.256 4.389 2.256c.386.198.824-.149.746-.592l-.83-4.73 3.522-3.356c.33-.314.16-.888-.282-.95l-4.898-.696L8.465.792a.513.513 0 0 0-.927 0L5.354 5.12l-4.898.696c-.441.062-.612.636-.283.95l3.523 3.356-.83 4.73zm4.905-2.767-3.686 1.894.694-3.957a.565.565 0 0 0-.163-.505L1.71 6.745l4.052-.576a.525.525 0 0 0 .393-.288L8 2.223l1.847 3.658a.525.525 0 0 0 .393.288l4.052.575-2.906 2.77a.565.565 0 0 0-.163.506l.694 3.957-3.686-1.894a.503.503 0 0 0-.461 0z""></path>
                </svg>

                <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-star-fill"" viewBox=""0 0 16 16"" color=""red"">
                    <path d=""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z""></path>
                </svg>
            </div>
            <input type=""submit"">
        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "C:\Users\NoLogicTech\Documents\GitHub\Task\NovoGestor\NovoGestor\Componentes\TarefaForm.razor"
      
    [Parameter]
    public Tarefa tarefa { get; set; }

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    public bool selecionado = false;

    private void Selecionar(MouseEventArgs mouseEventArgs)
    {
        if (!selecionado)
        {
            selecionado = true;
        }
        else
        {
            selecionado = false;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NovoGestor.Services.ApiService apiService { get; set; }
    }
}
namespace __Blazor.NovoGestor.Componentes.TarefaForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
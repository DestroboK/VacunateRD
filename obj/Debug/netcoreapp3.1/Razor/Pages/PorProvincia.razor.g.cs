#pragma checksum "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe8f4d09b244c24e3337c3ba56215e8283c0a81"
// <auto-generated/>
#pragma warning disable 1591
namespace Vacunate_RD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Vacunate_RD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Vacunate_RD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Vacunate_RD.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\VacunateRD\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/por_provincia")]
    public partial class PorProvincia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n  ");
            __builder.OpenElement(3, "center");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<h1>Vacunados por provincia</h1>\r\n    <hr style=\"background-color: white\" class=\"mt-2\">\r\n \r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                   VacunadoX

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n");
                __Blazor.Vacunate_RD.Pages.PorProvincia.TypeInference.CreateInputSelect_0(__builder2, 10, 11, "width: 25%;", 12, "form-control ml-2", 13, 
#nullable restore
#line 8 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                                                        VacunadoX.Provincia

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => VacunadoX.Provincia = __value, VacunadoX.Provincia)), 15, () => VacunadoX.Provincia, 16, (__builder3) => {
                    __builder3.AddMarkupContent(17, "\r\n");
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
 foreach (Provincia prov in GetProvincias)
    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(18, "        ");
                    __builder3.OpenElement(19, "option");
                    __builder3.AddAttribute(20, "value", 
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                         prov.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(21, 
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                       prov.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(22, "\r\n");
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(23, "\r\n\r\n");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "class", "btn btn-warning");
                __builder2.AddAttribute(26, "type", "submit");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                                        Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table table-bordered mt-2");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, @"<thead>
                    <tr>
                        <th>Id</th>
                        <th>Cedula</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>Telefono</th>
                        <th>Provincia</th>
                        <th>Fecha nacimiento</th>
                        <th>TipoVacuna</th>
                        <th>Fecha Dosis</th>
                        <th>Signo zodiaco</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(35, "tbody");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 33 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                     foreach (Vacunado vacu in GetFiltro)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                        ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 36 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 37 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 39 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 40 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 42 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 43 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.TipoVacuna

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 44 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Fecha_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 45 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
      
  List<Provincia> GetProvincias = new VacunateRDContext().Provincias.ToList();

  Vacunado VacunadoX = new Vacunado();
  List<Vacunado> GetFiltro = new VacunateRDContext().Vacunados.ToList();
  void Buscar(){
      GetFiltro = new VacunateRDContext().Vacunados.Where(x => x.Provincia.Contains(VacunadoX.Provincia)).ToList();
        
  }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Vacunate_RD.Pages.PorProvincia
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

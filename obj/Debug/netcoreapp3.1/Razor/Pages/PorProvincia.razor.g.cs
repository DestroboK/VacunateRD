#pragma checksum "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a81aa8a54b0e7f201bb19bfe833517e51dba9514"
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
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n  <center>\r\n    <h1>Vacunados por provincia</h1>\r\n    <hr style=\"background-color: white\" class=\"mt-2\">\r\n  </center>\r\n</div>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                   VacunadoX

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n");
                __Blazor.Vacunate_RD.Pages.PorProvincia.TypeInference.CreateInputSelect_0(__builder2, 5, 6, "form-group", 7, 
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                             VacunadoX.Provincia

#line default
#line hidden
#nullable disable
                , 8, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => VacunadoX.Provincia = __value, VacunadoX.Provincia)), 9, () => VacunadoX.Provincia, 10, (__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n");
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
 foreach (Provincia prov in GetProvincias)
    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(12, "        ");
                    __builder3.OpenElement(13, "option");
                    __builder3.AddAttribute(14, "value", 
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                         prov.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(15, 
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                       prov.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(16, "\r\n");
#nullable restore
#line 13 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(17, "\r\n");
                __builder2.OpenElement(18, "button");
                __builder2.AddAttribute(19, "type", "submit");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(21, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-bordered mt-2");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, @"<thead>
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
            __builder.OpenElement(28, "tbody");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 33 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                     foreach (Vacunado vacu in GetFiltro)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 36 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 37 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 39 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 40 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 42 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 43 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.TipoVacuna

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                            ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 44 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.Fecha_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 45 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                                 vacu.signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Administrador\Desktop\VacunateRD\Pages\PorProvincia.razor"
      
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
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
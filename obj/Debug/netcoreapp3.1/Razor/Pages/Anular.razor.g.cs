#pragma checksum "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b30cb2b38d0fe66665fd142fda6902083f6601"
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
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
using Vacunate_RD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eliminar")]
    public partial class Anular : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #paw{\r\n        justify-content: center;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1 style=\"text-align: center; color: white; height: 65px\" class=\"mt-2 pt-2 mb-4\">Eliminar Registros</h1>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "paw");
            __builder.AddAttribute(7, "class", "row ml-auto");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "style", "width: 25%;");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control ml-2");
            __builder.AddAttribute(13, "placeholder", "Cedula");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                                                                                      elegir

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => elegir = __value, elegir));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-warning ml-2 mb-3");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                                                            ValidarCedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        <br>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
 if (@valor == 1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.AddMarkupContent(25, "<div class=\"alert alert-success mt-2 mb-3\" role=\"alert\">Registro eliminado</div>\r\n");
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
}
else if (@valor == 5)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.AddMarkupContent(27, "<div class=\"alert alert-danger mt-2 mb-3\" role=\"alert\">Favor de ingresar todos los numeros de la cédula</div>\r\n");
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table table-bordered mt-2");
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.AddMarkupContent(32, @"<thead>
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
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
         foreach (Vacunado vacu in GetVacunados())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 50 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 52 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 53 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 54 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 55 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 56 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 57 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.TipoVacuna

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 58 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.Fecha_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 59 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
                     vacu.signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 61 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Anular.razor"
       
    string elegir;
    int valor = 0;

    public void Borrar(String varo)
    {

        using (VacunateRDContext con = new VacunateRDContext())
        {
            con.Vacunados.RemoveRange(con.Vacunados.Where(x => x.Cedula == varo));
            con.SaveChanges();
            valor = 1;
        }


    }

    public void ValidarCedula()
    {

        if (elegir.Length >= 11)
        {
            Borrar(elegir);
        }
        else
        {
            valor = 5;
        }
    }

    List<Vacunado> GetVacunados() => new VacunateRDContext().Vacunados.ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

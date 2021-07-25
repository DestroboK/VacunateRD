#pragma checksum "C:\Users\Administrador\Desktop\VacunateRD\Pages\Zodiaco.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93453a779f421ba563ab919dbe304b99035b4f77"
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
#line 2 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Zodiaco.razor"
using Vacunate_RD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/zodiaco")]
    public partial class Zodiaco : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n  <center>\r\n    <h1 style=\" text-align: center; color: white; height: 65px\" class=\"mt-2 pt-2 mb-4\">Vacunados por signo zodiaco</h1>\r\n    <hr style=\"background-color: white\" class=\"mt-2\">\r\n  </center>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-bordered");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Signo</th>\r\n            <th>Personas vacunadas</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Zodiaco.razor"
         foreach (var vacu in GetVacunados())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 21 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Zodiaco.razor"
                     vacu.Signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Zodiaco.razor"
                     vacu.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Zodiaco.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Zodiaco.razor"
      
    List<DataZodiaco> GetVacunados() =>
    (
        from p in new VacunateRDContext().Vacunados
        group p by p.signo_zodiaco into g
        select new DataZodiaco
        {
            Signo_zodiaco = g.Key,
            Cantidad = g.Count()
        }
    ).ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c990d4d75aad3b1396eced4a0d6380377af20a7b"
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
#line 2 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
using Vacunate_RD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/consulta_vacunados")]
    public partial class Consultavacu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #p{\r\n        justify-content: center;\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"container\">\r\n  <center>\r\n    <h1 style=\" text-align: center; color: white; height: 65px\" class=\"mt-2 col-md-12 pt-2 mb-4\">Consulta de Vacunados</h1>\r\n    <hr style=\"background-color: white\" class=\"mt-2\">\r\n  </center>\r\n</div>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "p");
            __builder.AddAttribute(7, "class", "form-inline mb-3");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<label style=\"font-size: 32px;\" for=\"nombre\">Buscar:</label>\r\n        ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control ml-2");
            __builder.AddAttribute(13, "placeholder", "Nombre o Apellido");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                                            filtroText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filtroText = __value, filtroText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    \r\n");
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
     if (@filtroText != ""){  

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
         if (GetFiltro().Count() == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table table-bordered mt-2");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, @"<thead>
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
            __builder.OpenElement(23, "tbody");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 43 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                     foreach (Vacunado vacu in GetFiltroApellido())
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 46 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 48 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 49 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 50 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 52 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 53 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.TipoVacuna

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 54 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Fecha_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 55 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 57 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 61 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
        }else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "            ");
            __builder.OpenElement(63, "table");
            __builder.AddAttribute(64, "class", "table table-bordered");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.AddMarkupContent(66, @"<thead>
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
            __builder.OpenElement(67, "tbody");
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 78 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                     foreach (Vacunado vacu in GetFiltro())
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                        ");
            __builder.OpenElement(70, "tr");
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 81 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 82 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 83 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 84 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                            ");
            __builder.OpenElement(84, "td");
            __builder.AddContent(85, 
#nullable restore
#line 85 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "td");
            __builder.AddContent(88, 
#nullable restore
#line 86 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.OpenElement(90, "td");
            __builder.AddContent(91, 
#nullable restore
#line 87 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                            ");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 88 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.TipoVacuna

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 89 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Fecha_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.OpenElement(99, "td");
            __builder.AddContent(100, 
#nullable restore
#line 90 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 92 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 96 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
         
        
        
    }else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "        ");
            __builder.OpenElement(107, "table");
            __builder.AddAttribute(108, "class", "table table-bordered");
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.AddMarkupContent(110, @"<thead>
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
            __builder.OpenElement(111, "tbody");
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 116 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                 foreach (Vacunado vacu in GetVacunados())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "                    ");
            __builder.OpenElement(114, "tr");
            __builder.AddMarkupContent(115, "\r\n                            ");
            __builder.OpenElement(116, "td");
            __builder.AddContent(117, 
#nullable restore
#line 119 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.OpenElement(119, "td");
            __builder.AddContent(120, 
#nullable restore
#line 120 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                            ");
            __builder.OpenElement(122, "td");
            __builder.AddContent(123, 
#nullable restore
#line 121 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                            ");
            __builder.OpenElement(125, "td");
            __builder.AddContent(126, 
#nullable restore
#line 122 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                            ");
            __builder.OpenElement(128, "td");
            __builder.AddContent(129, 
#nullable restore
#line 123 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                            ");
            __builder.OpenElement(131, "td");
            __builder.AddContent(132, 
#nullable restore
#line 124 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                            ");
            __builder.OpenElement(134, "td");
            __builder.AddContent(135, 
#nullable restore
#line 125 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                            ");
            __builder.OpenElement(137, "td");
            __builder.AddContent(138, 
#nullable restore
#line 126 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.TipoVacuna

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                            ");
            __builder.OpenElement(140, "td");
            __builder.AddContent(141, 
#nullable restore
#line 127 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.Fecha_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                            ");
            __builder.OpenElement(143, "td");
            __builder.AddContent(144, 
#nullable restore
#line 128 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                                 vacu.signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 130 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(147, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n");
#nullable restore
#line 134 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(150, "\r\n\r\n\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Consultavacu.razor"
      
    string filtroText =string.Empty;
    List<Vacunado> GetVacunados() => new VacunateRDContext().Vacunados.ToList();
    List<Vacunado> GetFiltro() => new VacunateRDContext().Vacunados.Where(x => x.Nombre.Contains(filtroText)).ToList();
    List<Vacunado> GetFiltroApellido() => new VacunateRDContext().Vacunados.Where(x => x.Apellido.Contains(filtroText)).ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703a8943e3fbaf4f8eff0c0d5b92904bc3cfe3be"
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
#line 2 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
using Vacunate_RD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/confi")]
    public partial class Confi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Provincias</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(4, "<h4>ID: </h4>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "style", "width: 50%;");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "placeholder", "ID");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                                                                             prueba

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => prueba = __value, prueba));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(13, "<h4>Provincia: </h4>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "style", "width: 50%;");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "placeholder", "Digite el nombre de la provincia");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                                                                             Provincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Provincia = __value, Provincia));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                                              ValdiarDatos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Registrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-warning");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                                              Actualizar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Actualzar");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
 if (@valor == 1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.AddMarkupContent(34, "<div class=\"alert alert-success mt-2\" role=\"alert\">Procesado sastifactoria mente</div>\r\n");
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
}
else if (@valor == 5)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.AddMarkupContent(36, "<div class=\"alert alert-danger\" role=\"alert\">Favor de ingresar la provincia que desea agregar</div>\r\n");
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n<br>\r\n ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row");
            __builder.AddMarkupContent(40, "\r\n    <div class=\"col-md-3\"></div>\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-md-6");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "class", "table table-bordered");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<thead>\r\n                <tr>\r\n                    <th>id</th>\r\n                    <th>Nombre</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(48, "tbody");
            __builder.AddMarkupContent(49, "\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                 foreach (Provincia prov in GetProvincias())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                    ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 46 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                             prov.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                             prov.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 49 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    <div class=\"col-md-4\"></div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
      
    string Provincia = "";
    int valor = 0;
    //int id;
    string prueba = "";
    public void Registrar(String valor1)
    {
        Data.Provincia prov = new Data.Provincia();
        prov.Nombre = valor1;

        using (VacunateRDContext context = new VacunateRDContext())
        {
            context.Add(prov);
            context.SaveChanges();
            valor = 1;
        }

    }
    public void ValdiarDatos()
    {

        if (Provincia.Length > 0)
        {
            Registrar(Provincia);
        }
        else
        {
            valor = 5;
        }
    }
    List<Provincia> GetProvincias() => new VacunateRDContext().Provincias.ToList();

    public void Actualizar()
    {
        int noID = int.Parse(prueba);
        using (VacunateRDContext mctx = new VacunateRDContext())
        {
            var editarInfr = new Provincia();

            editarInfr.id = noID;


            editarInfr.Nombre = Provincia;

            mctx.Provincias.Attach(editarInfr);
            mctx.Entry(editarInfr).Property(x => x.Nombre).IsModified = true;
            mctx.SaveChanges();
            valor = 1;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

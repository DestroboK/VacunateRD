// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/configuracion")]
    public partial class Confi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Administrador\Desktop\VacunateRD\Pages\Confi.razor"
      
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

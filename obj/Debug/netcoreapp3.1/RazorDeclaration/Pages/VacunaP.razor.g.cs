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
#line 2 "C:\Users\Administrador\Desktop\VacunateRD\Pages\VacunaP.razor"
using Vacunate_RD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacun")]
    public partial class VacunaP : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Administrador\Desktop\VacunateRD\Pages\VacunaP.razor"
      
    string Vacuna = "";
    int valo = 0;
    //int id;
    string prue = "";
    public void Registr(String valor1)
    {
        Data.Vacuna Vacu = new Data.Vacuna();
        Vacu.Nombre = valor1;

        using (VacunateRDContext context = new VacunateRDContext())
        {
            context.Add(Vacu);
            context.SaveChanges();
            valo = 1;
        }

    }
    public void ValdiarDat()
    {

        if (Vacuna.Length > 0)
        {
            Registr(Vacuna);
        }
        else
        {
            valo = 5;
        }
    }
    List<Vacuna> GetVacuna() => new VacunateRDContext().Vacunas.ToList();

    public void Actualiza()
    {
        int noID = int.Parse(prue);
        using (VacunateRDContext mctx = new VacunateRDContext())
        {
            var editarInfr = new Vacuna();

            editarInfr.id = noID;


            editarInfr.Nombre = Vacuna;

            mctx.Vacunas.Attach(editarInfr);
            mctx.Entry(editarInfr).Property(x => x.Nombre).IsModified = true;
            mctx.SaveChanges();
            valo = 1;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

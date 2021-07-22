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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Registrar")]
    public partial class RegistrarVacuna : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\VacunateRD\Pages\RegistrarVacuna.razor"
       
    int dia_zodiaco, mes_zodiaco;

  Vacunado VacunadoX = new Vacunado();
  List<Provincia> GetProvincias = new VacunateRDContext().Provincias.ToList();
  List<Vacuna> GetVacuna = new VacunateRDContext().Vacunas.ToList();


    void Registrar()
    {
        using (VacunateRDContext context = new VacunateRDContext())
        {
            context.Add(VacunadoX);
            context.SaveChanges();
        }

    }

    void Prob(){
        using(VacunateRDContext contexto = new VacunateRDContext()){
            if(contexto.Vacunados.Any(a => a.Cedula == VacunadoX.Cedula) == true){
                Vacunado Temp = contexto.Vacunados.Where(e => e.Cedula == VacunadoX.Cedula).FirstOrDefault();
                VacunadoX = Temp;
            }
        }
    }
    void DeterminarSigno(){
        dia_zodiaco = VacunadoX.Fecha_nacimiento.Date.Day;
        mes_zodiaco = VacunadoX.Fecha_nacimiento.Date.Month;
        if ((dia_zodiaco >= 21 && mes_zodiaco == 3) || (dia_zodiaco <= 20 && mes_zodiaco == 4))
        VacunadoX.signo_zodiaco = "Aries";

    if ((dia_zodiaco >= 24 && mes_zodiaco == 9) || (dia_zodiaco <= 23 && mes_zodiaco == 10))
        VacunadoX.signo_zodiaco = "Libra";

    if ((dia_zodiaco >= 21 && mes_zodiaco == 4) || (dia_zodiaco <= 21 && mes_zodiaco == 5))
        VacunadoX.signo_zodiaco = "Tauro";

    if ((dia_zodiaco >= 24 && mes_zodiaco == 10) || (dia_zodiaco <= 22 && mes_zodiaco == 11))
        VacunadoX.signo_zodiaco = "Escorpio";

    if ((dia_zodiaco >= 22 && mes_zodiaco == 5) || (dia_zodiaco <= 21 && mes_zodiaco == 6))
        VacunadoX.signo_zodiaco = "Géminis";

    if ((dia_zodiaco >= 23 && mes_zodiaco == 11) || (dia_zodiaco <= 21 && mes_zodiaco == 12))
        VacunadoX.signo_zodiaco = "Sagitario";

    if ((dia_zodiaco >= 21 && mes_zodiaco == 6) || (dia_zodiaco <= 23 && mes_zodiaco == 7))
        VacunadoX.signo_zodiaco = "Cáncer";

    if ((dia_zodiaco >= 22 && mes_zodiaco == 12) || (dia_zodiaco <= 20 && mes_zodiaco == 1))
        VacunadoX.signo_zodiaco = "Capricornio";

    if ((dia_zodiaco >= 24 && mes_zodiaco == 7) || (dia_zodiaco <= 23 && mes_zodiaco == 8))
        VacunadoX.signo_zodiaco = "Leo";

    if ((dia_zodiaco >= 21 && mes_zodiaco == 1) || (dia_zodiaco <= 19 && mes_zodiaco == 2))
        VacunadoX.signo_zodiaco = "Acuario";

    if ((dia_zodiaco >= 24 && mes_zodiaco == 8) || (dia_zodiaco <= 23 && mes_zodiaco == 9))
        VacunadoX.signo_zodiaco = "Virgo";

    if ((dia_zodiaco >= 20 && mes_zodiaco == 2) || (dia_zodiaco <= 20 && mes_zodiaco == 3))
        VacunadoX.signo_zodiaco = "Piscis";

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

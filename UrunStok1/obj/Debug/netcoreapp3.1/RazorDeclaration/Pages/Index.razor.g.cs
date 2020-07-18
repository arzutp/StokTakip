#pragma checksum "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1789bcdc61cdfdf922bae3e3451c63a71b0e9f2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UrunStok1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using UrunStok1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\_Imports.razor"
using UrunStok1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
using UrunStok1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
       


    List<Urun> Urunler = new List<Urun>();

    string searchName = "";

    //arama fonksiyonu

    private async Task SearchUrunData()
    {
        await RefresUrunler();

        if (searchName != "")
            Urunler = Urunler.Where<Urun>(x => x.UrunAdi.Contains(searchName.ToString())).ToList<Urun>();

    }

    //----------sıralama işlemleri
    private bool isSortedAscending;
    private string activeSortColumn;

    private void SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            Urunler = Urunler.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            isSortedAscending = true;
            activeSortColumn = columnName;

        }
        else
        {
            if (isSortedAscending)
            {
                Urunler = Urunler.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }
            else
            {
                Urunler = Urunler.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }

            isSortedAscending = !isSortedAscending;
        }
    }

    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }

    //---
    protected override async Task OnInitializedAsync()
    {
        await RefresUrunler();
    }

    private async Task RefresUrunler()
    {
        Urunler = await service.GetUrunAsync();
    }

    public Urun NewUrun { get; set; } = new Urun();
    private async Task AddNewUrun()
    {
        await service.AddUrunAsync(NewUrun);
        NewUrun = new Urun();
        await RefresUrunler();
    }

    Urun UpdateUrun = new Urun();
    private void SetUrunForUpdate(Urun urun)
    {
        UpdateUrun = urun;
    }

    private async Task UpdateUrunData()
    {
        await service.UpdateUrunAsync(UpdateUrun);
        await RefresUrunler();
    }

    private async Task DeleteUrun(Urun urun)
    {
        await service.DeleteUrunAsync(urun);
        await RefresUrunler();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UrunServices service { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1789bcdc61cdfdf922bae3e3451c63a71b0e9f2"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-inline");
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n        ");
            __builder.AddMarkupContent(6, "<label class=\"sr-only \" for=\"filter\">Search </label>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(10, "id", "parentValue");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                                      searchName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchName = __value, searchName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "class", "btn btn-primary mr-sm-2 mb-2");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                             SearchUrunData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, " Search  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row bg-light");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table table-bordered table-hover");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "thead");
            __builder.AddAttribute(28, "class", "thead-dark");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.AddMarkupContent(32, "<th>Urun Id</th>\r\n                    \r\n                    ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "class", "sort-th");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                    () => SortTable("UrunAdi")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                        Urun Adi\r\n                        ");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", "fa" + " " + (
#nullable restore
#line 27 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                          SetSortIcon("UrunAdi")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    \r\n                    ");
            __builder.OpenElement(41, "th");
            __builder.AddAttribute(42, "class", "sort-th");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                    () => SortTable("Stok")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                        Stok\r\n                        ");
            __builder.OpenElement(45, "span");
            __builder.AddAttribute(46, "class", "fa" + " " + (
#nullable restore
#line 32 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                          SetSortIcon("Stok")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.AddMarkupContent(49, "<th>Aciklama</th>\r\n                    ");
            __builder.OpenElement(50, "th");
            __builder.AddAttribute(51, "class", "sort-th");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                    () => SortTable("Fiyat")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\r\n                        Fiyat\r\n                        ");
            __builder.OpenElement(54, "span");
            __builder.AddAttribute(55, "class", "fa" + " " + (
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                          SetSortIcon("Fiyat")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.AddMarkupContent(58, "<th>Delete Urun</th>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "tbody");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 44 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                 if (Urunler.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                     foreach (var urun in Urunler)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                ");
            __builder.OpenElement(64, "tr");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                              (() => SetUrunForUpdate(urun))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 49 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                         urun.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 50 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                         urun.UrunAdi

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "                   \r\n                    ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 51 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                         urun.Stok

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 52 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                         urun.Aciklama

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 53 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                         urun.Fiyat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "td");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "btn btn-danger");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                 (() => DeleteUrun(urun))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                    ");
            __builder.AddMarkupContent(90, "<tr><td colspan=\"6\"><strong>No urun available</strong></td></tr>\r\n");
#nullable restore
#line 61 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n    ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "row m-5");
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-5 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(100, "\r\n\r\n            ");
            __builder.AddMarkupContent(101, "<div class=\"p-3 mb-3 bg-primary text-white text-center\">Add New Urun</div>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(102);
            __builder.AddAttribute(103, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 73 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                              NewUrun

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(105, "\r\n                ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.AddMarkupContent(109, "<label for=\"UrunAdi\">Urun Adı</label>\r\n                    ");
                __builder2.OpenElement(110, "input");
                __builder2.AddAttribute(111, "type", "text");
                __builder2.AddAttribute(112, "id", "urunAdi");
                __builder2.AddAttribute(113, "class", "form-control");
                __builder2.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                                       NewUrun.UrunAdi

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewUrun.UrunAdi = __value, NewUrun.UrunAdi));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n\r\n                ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "form-group");
                __builder2.AddMarkupContent(120, "\r\n                    ");
                __builder2.AddMarkupContent(121, "<label for=\"Stok\">Stok</label>\r\n                    ");
                __builder2.OpenElement(122, "input");
                __builder2.AddAttribute(123, "type", "text");
                __builder2.AddAttribute(124, "id", "Stok");
                __builder2.AddAttribute(125, "class", "form-control");
                __builder2.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                              NewUrun.Stok

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewUrun.Stok = __value, NewUrun.Stok));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n\r\n                ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "form-group");
                __builder2.AddMarkupContent(132, "\r\n                    ");
                __builder2.AddMarkupContent(133, "<label for=\"Aciklama\">Açıklama</label>\r\n                    ");
                __builder2.OpenElement(134, "input");
                __builder2.AddAttribute(135, "type", "text");
                __builder2.AddAttribute(136, "id", "Aciklama");
                __builder2.AddAttribute(137, "class", "form-control");
                __builder2.AddAttribute(138, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                                  NewUrun.Aciklama

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(139, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewUrun.Aciklama = __value, NewUrun.Aciklama));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n\r\n                ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "form-group");
                __builder2.AddMarkupContent(144, "\r\n                    ");
                __builder2.AddMarkupContent(145, "<label for=\"Fiyat\">Fiyat</label>\r\n                    ");
                __builder2.OpenElement(146, "input");
                __builder2.AddAttribute(147, "type", "text");
                __builder2.AddAttribute(148, "id", "Fiyat");
                __builder2.AddAttribute(149, "class", "form-control");
                __builder2.AddAttribute(150, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                               NewUrun.Fiyat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(151, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewUrun.Fiyat = __value, NewUrun.Fiyat));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "text-center p-3 mb-3");
                __builder2.AddMarkupContent(156, "\r\n                    ");
                __builder2.OpenElement(157, "button");
                __builder2.AddAttribute(158, "class", "btn btn-info");
                __builder2.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                           AddNewUrun

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(160, " Add Urun");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n\r\n        ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "col-5 bg-light m-2 justify-content-end");
            __builder.AddMarkupContent(167, "\r\n            ");
            __builder.AddMarkupContent(168, "<div class=\"p-3 mb-1 bg-primary text-white text-center\">Update Urun</div>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(169);
            __builder.AddAttribute(170, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 104 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                              UpdateUrun

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(171, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(172, "\r\n                ");
                __builder2.OpenElement(173, "div");
                __builder2.AddAttribute(174, "class", "form-group");
                __builder2.AddMarkupContent(175, "\r\n                    ");
                __builder2.AddMarkupContent(176, "<label for=\"UrunAdi\">Urun Adı</label>\r\n                    ");
                __builder2.OpenElement(177, "input");
                __builder2.AddAttribute(178, "type", "text");
                __builder2.AddAttribute(179, "id", "UrunAdi");
                __builder2.AddAttribute(180, "class", "form-control");
                __builder2.AddAttribute(181, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 107 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                                       UpdateUrun.UrunAdi

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(182, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateUrun.UrunAdi = __value, UpdateUrun.UrunAdi));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n\r\n                ");
                __builder2.OpenElement(185, "div");
                __builder2.AddAttribute(186, "class", "form-group");
                __builder2.AddMarkupContent(187, "\r\n                    ");
                __builder2.AddMarkupContent(188, "<label for=\"Stok\">Stok</label>\r\n                    ");
                __builder2.OpenElement(189, "input");
                __builder2.AddAttribute(190, "type", "text");
                __builder2.AddAttribute(191, "id", "Stok");
                __builder2.AddAttribute(192, "class", "form-control");
                __builder2.AddAttribute(193, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 112 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                              UpdateUrun.Stok

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(194, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateUrun.Stok = __value, UpdateUrun.Stok));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(196, "\r\n\r\n                ");
                __builder2.OpenElement(197, "div");
                __builder2.AddAttribute(198, "class", "form-group");
                __builder2.AddMarkupContent(199, "\r\n                    ");
                __builder2.AddMarkupContent(200, "<label for=\"Aciklama\">Açıklama</label>\r\n                    ");
                __builder2.OpenElement(201, "input");
                __builder2.AddAttribute(202, "type", "text");
                __builder2.AddAttribute(203, "id", "Aciklama");
                __builder2.AddAttribute(204, "class", "form-control");
                __builder2.AddAttribute(205, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 117 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                                  UpdateUrun.Aciklama

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(206, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateUrun.Aciklama = __value, UpdateUrun.Aciklama));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(207, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(208, "\r\n\r\n                ");
                __builder2.OpenElement(209, "div");
                __builder2.AddAttribute(210, "class", "form-group");
                __builder2.AddMarkupContent(211, "\r\n                    ");
                __builder2.AddMarkupContent(212, "<label for=\"Fiyat\">Fiyat</label>\r\n                    ");
                __builder2.OpenElement(213, "input");
                __builder2.AddAttribute(214, "type", "text");
                __builder2.AddAttribute(215, "id", "Fiyat");
                __builder2.AddAttribute(216, "class", "form-control");
                __builder2.AddAttribute(217, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 122 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                                               UpdateUrun.Fiyat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(218, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateUrun.Fiyat = __value, UpdateUrun.Fiyat));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(219, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n\r\n                ");
                __builder2.OpenElement(221, "div");
                __builder2.AddAttribute(222, "class", "text-center p-3 mb-3");
                __builder2.AddMarkupContent(223, "\r\n                    ");
                __builder2.OpenElement(224, "button");
                __builder2.AddAttribute(225, "class", "btn btn-info");
                __builder2.AddAttribute(226, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\Asus\Desktop\Yeni klasör (7)\UrunStok1\UrunStok1\Pages\Index.razor"
                                                           UpdateUrunData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(227, " Update Urun");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(228, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(229, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(230, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n");
            __builder.CloseElement();
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

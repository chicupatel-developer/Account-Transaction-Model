#pragma checksum "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e1b999f4fd4e5d0ce27a04b48ca536cf06d398"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer_Transaction.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using BlazorServer_Transaction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using BlazorServer_Transaction.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
using EFCore_Transaction.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
using Service_Transaction.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactionsByUser")]
    public partial class _TransactionsByUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .filterDiv {\r\n        padding-top: 30px;\r\n    }\r\n\r\n    .filterBtn {\r\n        padding-top: 20px;\r\n    }\r\n\r\n    .noData {\r\n        color: red;\r\n        font-size: x-large;\r\n        font-weight: bold;\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<h1>Transactions By User!</h1>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container filterDiv");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudGrid>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudItem>(8);
                __builder2.AddAttribute(9, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                     3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n            ");
                    __Blazor.BlazorServer_Transaction.Pages._TransactionsByUser.TypeInference.CreateMudSelect_0(__builder3, 12, 13, "Origin.BottomCenter", 14, "Select - User", 15, 
#nullable restore
#line 36 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                       Color.Secondary

#line default
#line hidden
#nullable disable
                    , 16, 
#nullable restore
#line 33 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                    selectedUser

#line default
#line hidden
#nullable disable
                    , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedUser = __value, selectedUser)), 18, (__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n");
#nullable restore
#line 37 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                 foreach (var data in users)
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(20, "                    ");
                        __Blazor.BlazorServer_Transaction.Pages._TransactionsByUser.TypeInference.CreateMudSelectItem_1(__builder4, 21, 22, 
#nullable restore
#line 39 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                           data

#line default
#line hidden
#nullable disable
                        , 23, (__builder5) => {
                            __builder5.AddContent(24, 
#nullable restore
#line 39 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                  data.UserName

#line default
#line hidden
#nullable disable
                            );
                        }
                        );
                        __builder4.AddMarkupContent(25, "\r\n");
#nullable restore
#line 40 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(26, "            ");
                    }
                    );
                    __builder3.AddMarkupContent(27, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudItem>(29);
                __builder2.AddAttribute(30, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 43 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                     3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "filterBtn");
                    __builder3.AddMarkupContent(35, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(36);
                    __builder3.AddAttribute(37, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 45 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                        (x) => SetTransactionsForSelectedUser(selectedUser)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                       Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 48 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                  Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(42, "Get Transactions!");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudItem>(46);
                __builder2.AddAttribute(47, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                     3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "filterBtn");
                    __builder3.AddMarkupContent(52, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(53);
                    __builder3.AddAttribute(54, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 53 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                        (x) => GetChartDatas(selectedUser)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                       Icons.Material.Filled.BarChart

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 56 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                  Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(59, "Display Chart!");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n<p></p>\r\n");
            __builder.OpenComponent<MudBlazor.MudPaper>(65);
            __builder.AddAttribute(66, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "Class", "d-flex justify-space-around");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n    \r\n");
#nullable restore
#line 64 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
     if (transactions != null && transactions.Count() > 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(70, "        ");
                __Blazor.BlazorServer_Transaction.Pages._TransactionsByUser.TypeInference.CreateMudTable_2(__builder2, 71, 72, 
#nullable restore
#line 66 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                          transactions

#line default
#line hidden
#nullable disable
                , 73, 
#nullable restore
#line 68 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                              Breakpoint.Sm

#line default
#line hidden
#nullable disable
                , 74, 
#nullable restore
#line 69 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                  true

#line default
#line hidden
#nullable disable
                , 75, 
#nullable restore
#line 70 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                          hover

#line default
#line hidden
#nullable disable
                , 76, (__builder3) => {
                    __builder3.AddMarkupContent(77, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(78);
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(80, "#");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(82);
                    __builder3.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(84, "Payee");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(86);
                    __builder3.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(88, "Account");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(90);
                    __builder3.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(92, "Type");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(94);
                    __builder3.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(96, "Amount");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(98);
                    __builder3.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(100, "Status");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(102);
                    __builder3.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(104, "Current Balance");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(106);
                    __builder3.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(108, "Last Balance");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(110);
                    __builder3.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(112, "Ref-Code");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(114);
                    __builder3.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(116, "Date");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\r\n            ");
                }
                , 118, (context) => (__builder3) => {
                    __builder3.AddMarkupContent(119, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(120);
                    __builder3.AddAttribute(121, "DataLabel", "TransactionId");
                    __builder3.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(123, 
#nullable restore
#line 84 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                  context.TransactionId

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(125);
                    __builder3.AddAttribute(126, "DataLabel", "PayeeId");
                    __builder3.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(128, 
#nullable restore
#line 85 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                            context.PayeeId

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(130);
                    __builder3.AddAttribute(131, "DataLabel", "AccountId");
                    __builder3.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(133, 
#nullable restore
#line 86 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                              context.AccountId

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(135);
                    __builder3.AddAttribute(136, "DataLabel", "TransactionType");
                    __builder3.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(138, 
#nullable restore
#line 87 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                    GetTransactionType(context.TransactionType)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(139, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(140);
                    __builder3.AddAttribute(141, "DataLabel", "TransactionAmount");
                    __builder3.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(143, 
#nullable restore
#line 88 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                      context.TransactionAmount

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(145);
                    __builder3.AddAttribute(146, "DataLabel", "TransactionStatus");
                    __builder3.AddAttribute(147, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(148, 
#nullable restore
#line 89 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                      GetTransactionStatus(context.TransactionStatus)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(149, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(150);
                    __builder3.AddAttribute(151, "DataLabel", "CurrentBalance");
                    __builder3.AddAttribute(152, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(153, 
#nullable restore
#line 90 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                   context.CurrentBalance

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(154, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(155);
                    __builder3.AddAttribute(156, "DataLabel", "LastBalance");
                    __builder3.AddAttribute(157, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(158, 
#nullable restore
#line 91 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                context.LastBalance

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(159, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(160);
                    __builder3.AddAttribute(161, "DataLabel", "RefCode");
                    __builder3.AddAttribute(162, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(163, 
#nullable restore
#line 92 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                            context.RefCode

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(164, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(165);
                    __builder3.AddAttribute(166, "DataLabel", "TransactionDate");
                    __builder3.AddAttribute(167, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(168, 
#nullable restore
#line 93 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                    Convert.ToDateTime(@context.TransactionDate).ToString("dd, MMM yy")

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(169, "\r\n            ");
                }
                , 170, (__builder3) => {
                    __builder3.AddMarkupContent(171, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTablePager>(172);
                    __builder3.AddAttribute(173, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 96 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                                                new int[] { 50, 100 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(174, "\r\n            ");
                }
                , 175, (__value) => {
#nullable restore
#line 67 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
                        table = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(176, "\r\n");
#nullable restore
#line 99 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(177, "        ");
                __builder2.OpenComponent<MudBlazor.MudPaper>(178);
                __builder2.AddAttribute(179, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(180, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudCard>(181);
                    __builder3.AddAttribute(182, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(183, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(184);
                        __builder4.AddAttribute(185, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(186, "\r\n                    ");
                            __builder5.AddMarkupContent(187, "<span class=\"noData\">\r\n                        Transactions Not Available!\r\n                    </span>\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(188, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(189, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(190, "\r\n");
#nullable restore
#line 111 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(191, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionsByUser.razor"
       

    // select list
    private List<UserList> users = new List<UserList>();
    private UserList selectedUser = new UserList();


    public Array transactionTypes = Enum.GetValues(typeof(TransactionType));
    public Array transactionStatus = Enum.GetValues(typeof(TransactionStatus));

    private bool hover = true;

    // very first load of table for transactions,,, displays number of rows
    // in table
    // @ref="table" code in table configuration
    private MudTable<Transaction> table = new MudTable<Transaction>();
    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        table.SetRowsPerPage(50);
        return base.OnAfterRenderAsync(firstRender);
    }

    private List<Transaction> transactions = new List<Transaction>();

    private string GetTransactionType(int trType)
    {
        return transactionTypes.GetValue(trType).ToString();
    }
    private string GetTransactionStatus(int trStatus)
    {
        return transactionStatus.GetValue(trStatus).ToString();
    }

    private async Task SetTransactionsForSelectedUser(UserList selectedUser)
    {
        transactions = await transactionService.GetTransactionsByUser(selectedUser.UserId);
    }


    protected override async Task OnInitializedAsync()
    {
        users = await userService.GetUserList();
        transactions = await transactionService.GetTransactionsByUser(0);
    }


    // chart-data
    // List<MonthlyTotalInOut>
    private List<MonthlyTotalInOut> chartDatas = new List<MonthlyTotalInOut>();
    private async Task GetChartDatas(UserList selectedUser)
    {
        chartDatas = await chartService.GetMonthly_Total_InOut_ChartReport(selectedUser.UserId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Service_Transaction.Contracts.IChartRepository chartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Service_Transaction.Contracts.IUserRepository userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Service_Transaction.Contracts.ITransactionRepository transactionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorServer_Transaction.ApiCallHelpers.TransactionApiClient transactionApi { get; set; }
    }
}
namespace __Blazor.BlazorServer_Transaction.Pages._TransactionsByUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.Color __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "AnchorOrigin", __arg0);
        __builder.AddAttribute(__seq1, "HelperText", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentColor", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::MudBlazor.Breakpoint __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::MudBlazor.MudTable<T>> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Breakpoint", __arg1);
        __builder.AddAttribute(__seq2, "MultiSelection", __arg2);
        __builder.AddAttribute(__seq3, "Hover", __arg3);
        __builder.AddAttribute(__seq4, "HeaderContent", __arg4);
        __builder.AddAttribute(__seq5, "RowTemplate", __arg5);
        __builder.AddAttribute(__seq6, "PagerContent", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::MudBlazor.MudTable<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

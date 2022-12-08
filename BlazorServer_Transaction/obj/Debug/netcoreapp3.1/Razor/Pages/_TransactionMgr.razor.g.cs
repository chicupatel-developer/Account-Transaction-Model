#pragma checksum "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f07e10b591376ea23f6497d16a3037f6809e81"
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
#line 6 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
using EFCore_Transaction.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
using Service_Transaction.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactionmgr")]
    public partial class _TransactionMgr : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .refreshBtn {
        font-size: medium;
        padding: 30px;
        margin: 10px;
    }

    .addTransactionsBtn {
        font-size: medium;
        padding: 30px;
        margin: 10px;
    }

    .btnHeader {
        padding-bottom: 10px;
        margin-bottom: 10px;
        font-weight: bold;
        font-size: x-large;
    }

    .btnDetails {
        margin-top: 25px;
        margin-bottom: 50px;
        font-size: large;
        color: blue;
        font-weight: bold;
        background-color: white;
        padding: 10px;
    }

    .bkpResponse {
        margin-top: 15px;
        font-size: x-large;
        color: white;
        font-weight: bold;
        background-color: black;
        padding: 10px;
    }

    .noData {
        color: red;
        font-size: x-large;
        font-weight: bold;
    }
</style>
");
            __builder.AddMarkupContent(1, "<h1>Manage Transactions!</h1>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container d-flex justify-space-around");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudButton>(5);
            __builder.AddAttribute(6, "Class", "addTransactionsBtn");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                            (x) => CallWorkerProcess_DB()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 60 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 61 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                      Color.Tertiary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, @"<span>
            <span class=""oi oi-file btnHeader"" aria-hidden=""true"">
                Add Transactions To DataBase
            </span>
            <br>
            <span class=""btnDetails"">
                [Blazor App --&gt;&gt; Web API [Transaction-Controller --&gt;&gt; Worker-Service(StartAsync)] ]
            </span>
        </span>
    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<p></p>\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "container d-flex justify-space-around");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 76 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
     if (BKP_Response_DB.Response != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container bkpResponse d-flex justify-space-around");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddContent(22, 
#nullable restore
#line 79 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
             BKP_Response_DB.Response

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 81 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n<p></p>\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudPaper>(26);
            __builder.AddAttribute(27, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 86 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "Class", "d-flex justify-space-around");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n    \r\n    ");
                __Blazor.BlazorServer_Transaction.Pages._TransactionMgr.TypeInference.CreateMudTable_0(__builder2, 31, 32, 
#nullable restore
#line 88 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                      transactions

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 90 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                          Breakpoint.Sm

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 91 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                              true

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 92 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                      hover

#line default
#line hidden
#nullable disable
                , 36, (__builder3) => {
                    __builder3.AddMarkupContent(37, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(38);
                    __builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(40, "#");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(42);
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, "Payee");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(46);
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(48, "Account");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(50);
                    __builder3.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(52, "Type");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(54);
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(56, "Amount");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(58);
                    __builder3.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(60, "Status");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(62);
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(64, "Current Balance");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(66);
                    __builder3.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(68, "Last Balance");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(70);
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(72, "Ref-Code");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(74);
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(76, "Date");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n        ");
                }
                , 78, (context) => (__builder3) => {
                    __builder3.AddMarkupContent(79, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(80);
                    __builder3.AddAttribute(81, "DataLabel", "TransactionId");
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(83, 
#nullable restore
#line 106 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                              context.TransactionId

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(85);
                    __builder3.AddAttribute(86, "DataLabel", "PayeeId");
                    __builder3.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(88, 
#nullable restore
#line 107 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                        context.PayeeId

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(90);
                    __builder3.AddAttribute(91, "DataLabel", "AccountId");
                    __builder3.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(93, 
#nullable restore
#line 108 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                          context.AccountId

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(95);
                    __builder3.AddAttribute(96, "DataLabel", "TransactionType");
                    __builder3.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(98, 
#nullable restore
#line 109 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                                GetTransactionType(context.TransactionType)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(100);
                    __builder3.AddAttribute(101, "DataLabel", "TransactionAmount");
                    __builder3.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(103, 
#nullable restore
#line 110 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                                  context.TransactionAmount

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(105);
                    __builder3.AddAttribute(106, "DataLabel", "TransactionStatus");
                    __builder3.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(108, 
#nullable restore
#line 111 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                                  GetTransactionStatus(context.TransactionStatus)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(110);
                    __builder3.AddAttribute(111, "DataLabel", "CurrentBalance");
                    __builder3.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(113, 
#nullable restore
#line 112 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                               context.CurrentBalance

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(115);
                    __builder3.AddAttribute(116, "DataLabel", "LastBalance");
                    __builder3.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(118, 
#nullable restore
#line 113 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                            context.LastBalance

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(120);
                    __builder3.AddAttribute(121, "DataLabel", "RefCode");
                    __builder3.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(123, 
#nullable restore
#line 114 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                        context.RefCode

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(125);
                    __builder3.AddAttribute(126, "DataLabel", "TransactionDate");
                    __builder3.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(128, 
#nullable restore
#line 115 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                                Convert.ToDateTime(@context.TransactionDate).ToString("dd, MMM yy")

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\r\n        ");
                }
                , 130, (__builder3) => {
                    __builder3.AddMarkupContent(131, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTablePager>(132);
                    __builder3.AddAttribute(133, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 118 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                                            new int[] { 50, 100 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\r\n        ");
                }
                , 135, (__value) => {
#nullable restore
#line 89 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
                    table = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(136, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Transaction-Model\APITransaction\BlazorServer_Transaction\Pages\_TransactionMgr.razor"
       

    public Array transactionTypes = Enum.GetValues(typeof(TransactionType));
    public Array transactionStatus = Enum.GetValues(typeof(TransactionStatus));

    private bool hover = true;

    // very first load of table for transactions,,, displays number of rows
    // in table
    // @ref="table" code in table configuration
    private MudTable<Transaction> table;
    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        table.SetRowsPerPage(50);
        return base.OnAfterRenderAsync(firstRender);
    }

    // response from background-worker-process
    private BKProcessResponse BKP_Response_DB = new BKProcessResponse();
    private BKProcessResponse BKP_Response_CSVFile = new BKProcessResponse();

    private List<Transaction> transactions = new List<Transaction>();

    private string GetTransactionType(int trType)
    {
        return transactionTypes.GetValue(trType).ToString();
    }
    private string GetTransactionStatus(int trStatus)
    {
        return transactionStatus.GetValue(trStatus).ToString();
    }


    // add transactions to db
    // call worker-process
    // via web-api call
    private async Task CallWorkerProcess_DB()
    {
        BKP_Response_DB = await transactionApi.AddTransactionsToDB_BackgroundWorkerProcessAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        // call to api-transaction-controller
        // this transaction-controller[api-worker-service-controller],,,
        // next uses transaction-repository[data-access-service] to access database
        transactions = await transactionApi.GetTransactionsAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Service_Transaction.Contracts.ITransactionRepository transactionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorServer_Transaction.ApiCallHelpers.TransactionApiClient transactionApi { get; set; }
    }
}
namespace __Blazor.BlazorServer_Transaction.Pages._TransactionMgr
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::MudBlazor.Breakpoint __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::System.Action<global::MudBlazor.MudTable<T>> __arg7)
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

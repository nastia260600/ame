#pragma checksum "C:\Users\user\source\repos\Shop\Shop\Views\Goods\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f8c60f69ccf8b03138331fc4584ead4c979af49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goods_List), @"mvc.1.0.view", @"/Views/Goods/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Goods/List.cshtml", typeof(AspNetCore.Views_Goods_List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\user\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 3 "C:\Users\user\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f8c60f69ccf8b03138331fc4584ead4c979af49", @"/Views/Goods/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d841c3562b9c08f00d8e393d61c0b2ce13085563", @"/Views/_ViewImports.cshtml")]
    public class Views_Goods_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "value", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4694, true);
            WriteLiteral(@"<!-- Тут будет SHOP -->
<!-- Header Area End -->

<div class=""shop_sidebar_area"">

    <!-- ##### Single Widget ##### -->
    <div class=""widget catagory mb-50"">
        <!-- Widget Title -->
        <h6 class=""widget-title mb-30"">Catagories</h6>

        <!--  Catagories  -->
        <div class=""catagories-menu"">
            <ul>
                <li class=""active""><a href=""/Goods/List/Chairs"">Chairs</a></li>
                <li><a href=""/Goods/List/Beds"">Beds</a></li>
                <li><a href=""/Goods/List/Accesoires"">Accesoires</a></li>
                <li><a href=""/Goods/List/Furniture"">Furniture</a></li>
                <li><a href=""/Goods/List/Bathroom"">Bathroom</a></li>
                <li><a href=""/Goods/List/Tables"">Tables</a></li>
            </ul>
        </div>
    </div>

    <!-- ##### Single Widget ##### -->
    <div class=""widget brands mb-50"">
        <!-- Widget Title -->
        <h6 class=""widget-title mb-30"">Brands</h6>

        <div class=""widget-desc"">
     ");
            WriteLiteral(@"       <!-- Single Form Check -->
            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" value="""" id=""amado"">
                <label class=""form-check-label"" for=""amado"">Amado</label>
            </div>
            <!-- Single Form Check -->
            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" value="""" id=""ikea"">
                <label class=""form-check-label"" for=""ikea"">Ikea</label>
            </div>
            <!-- Single Form Check -->
            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" value="""" id=""furniture"">
                <label class=""form-check-label"" for=""furniture"">Furniture Inc</label>
            </div>
            <!-- Single Form Check -->
            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" value="""" id=""artdeco"">
                <label class=""form-check-label"" for=""artdeco"">Artdeco</la");
            WriteLiteral(@"bel>
            </div>
        </div>
    </div>

    <!-- ##### Single Widget ##### -->
    <div class=""widget color mb-50"">
        <!-- Widget Title -->
        <h6 class=""widget-title mb-30"">Color</h6>

        <div class=""widget-desc"">
            <ul class=""d-flex"">
                <li><a href=""#"" class=""color1""></a></li>
                <li><a href=""#"" class=""color2""></a></li>
                <li><a href=""#"" class=""color3""></a></li>
                <li><a href=""#"" class=""color4""></a></li>
                <li><a href=""#"" class=""color5""></a></li>
                <li><a href=""#"" class=""color6""></a></li>
                <li><a href=""#"" class=""color7""></a></li>
                <li><a href=""#"" class=""color8""></a></li>
            </ul>
        </div>
    </div>

    <!-- ##### Single Widget ##### -->
    <div class=""widget price mb-50"">
        <!-- Widget Title -->
        <h6 class=""widget-title mb-30"">Price</h6>

        <div class=""widget-desc"">
            <div class=""slid");
            WriteLiteral(@"er-range"">
                <div data-min=""10"" data-max=""1000"" data-unit=""$"" class=""slider-range-price ui-slider ui-slider-horizontal ui-widget ui-widget-content ui-corner-all"" data-value-min=""10"" data-value-max=""1000"" data-label-result="""">
                    <div class=""ui-slider-range ui-widget-header ui-corner-all""></div>
                    <span class=""ui-slider-handle ui-state-default ui-corner-all"" tabindex=""0""></span>
                    <span class=""ui-slider-handle ui-state-default ui-corner-all"" tabindex=""0""></span>
                </div>
                <div class=""range-price"">$10 - $1000</div>
            </div>
        </div>
    </div>
</div>

<div class=""amado_product_area section-padding-100"">
    <div class=""container-fluid"">

        <div class=""row"">
            <div class=""col-12"">
                <div class=""product-topbar d-xl-flex align-items-end justify-content-between"">
                    <!-- Total Products -->
                    <div class=""total-products"">
 ");
            WriteLiteral(@"                       <p>Showing 1-8 0f 25</p>
                        <div class=""view d-flex"">
                            <a href=""#""><i class=""fa fa-th-large"" aria-hidden=""true""></i></a>
                            <a href=""#""><i class=""fa fa-bars"" aria-hidden=""true""></i></a>
                        </div>
                    </div>
                    <!-- Sorting -->
                    <div class=""product-sorting d-flex"">
                        <div class=""sort-by-date d-flex align-items-center mr-15"">
                            <p>Sort by</p>
                            ");
            EndContext();
            BeginContext(4694, 406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72427aa554c34c528b41ad1060245cc3", async() => {
                BeginContext(4724, 110, true);
                WriteLiteral("\r\n                                <select name=\"select\" id=\"sortBydate\">\r\n                                    ");
                EndContext();
                BeginContext(4834, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d00c817a02478895335655306f17a1", async() => {
                    BeginContext(4856, 4, true);
                    WriteLiteral("Date");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4869, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4907, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "958ab258592c41ce89ba1515634adf8a", async() => {
                    BeginContext(4929, 6, true);
                    WriteLiteral("Newest");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4944, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4982, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff32ef508eb43f2aa6afb4c3b03d7c7", async() => {
                    BeginContext(5004, 7, true);
                    WriteLiteral("Popular");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5020, 73, true);
                WriteLiteral("\r\n                                </select>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5100, 181, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"view-product d-flex align-items-center\">\r\n                            <p>View</p>\r\n                            ");
            EndContext();
            BeginContext(5281, 467, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0cf3ad8288f43cf8d8bee51845ee9f8", async() => {
                BeginContext(5311, 111, true);
                WriteLiteral("\r\n                                <select name=\"select\" id=\"viewProduct\">\r\n                                    ");
                EndContext();
                BeginContext(5422, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8c00e562e3c4b199cacb291f2dda506", async() => {
                    BeginContext(5444, 2, true);
                    WriteLiteral("12");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5455, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(5493, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db196f65ae84942bbbc7fe42de3236e", async() => {
                    BeginContext(5515, 2, true);
                    WriteLiteral("24");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5526, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(5564, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccc566f24fe4a97b82d1210c679de20", async() => {
                    BeginContext(5586, 2, true);
                    WriteLiteral("48");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5597, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(5635, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dcca48d4d9e4bfd99252112f565ffa2", async() => {
                    BeginContext(5657, 2, true);
                    WriteLiteral("96");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5668, 73, true);
                WriteLiteral("\r\n                                </select>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5748, 151, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 133 "C:\Users\user\source\repos\Shop\Shop\Views\Goods\List.cshtml"
              
                foreach (Goods goods in Model.allGoods)
                {
                    

#line default
#line hidden
            BeginContext(6012, 27, false);
#line 136 "C:\Users\user\source\repos\Shop\Shop\Views\Goods\List.cshtml"
               Write(Html.Partial("Shop", goods));

#line default
#line hidden
            EndContext();
#line 136 "C:\Users\user\source\repos\Shop\Shop\Views\Goods\List.cshtml"
                                                
                }
            

#line default
#line hidden
            BeginContext(6075, 710, true);
            WriteLiteral(@"        </div>

        <div class=""row"">
            <div class=""col-12"">
                <!-- Pagination -->
                <nav aria-label=""navigation"">
                    <ul class=""pagination justify-content-end mt-50"">
                        <li class=""page-item active""><a class=""page-link"" href=""#"">01.</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">02.</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">03.</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">04.</a></li>
                    </ul>
                </nav>
            </div>
        </div>

    </div>
</div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

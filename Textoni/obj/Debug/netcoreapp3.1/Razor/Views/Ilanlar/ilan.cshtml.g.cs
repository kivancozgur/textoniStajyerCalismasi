#pragma checksum "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869d3ba3d2773e86f46d6c510ec850644d978e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ilanlar_ilan), @"mvc.1.0.view", @"/Views/Ilanlar/ilan.cshtml")]
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
#nullable restore
#line 1 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\_ViewImports.cshtml"
using Textoni;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\_ViewImports.cshtml"
using Textoni.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
using Textoni.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869d3ba3d2773e86f46d6c510ec850644d978e13", @"/Views/Ilanlar/ilan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659a26b946475789d993509f4f2dade0b0bdc71b", @"/Views/_ViewImports.cshtml")]
    public class Views_Ilanlar_ilan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Advert>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline search-full form-inline search animated-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline justify-content-lg-start justify-content-center mt-lg-0 mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#eee;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869d3ba3d2773e86f46d6c510ec850644d978e135544", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, shrink-to-fit=no"">
    <title>Çeviri | Textoni </title>
    <link rel=""icon"" type=""image/x-icon"" href=""assets/img/favicon.ico"" />
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:300,400,500"" rel=""stylesheet"">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,600,700' rel='stylesheet' type='text/css'>
    <link href=""/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/bootstrap/css/bootstrap.min.css"">
    <link href=""/plugins/sliders/owlCarousel/css/owl.carousel.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/plugins/sliders/owlCarousel/css/owl.theme.default.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/plugins/flaticon/style.css"">
    <link href=""/assets/css");
                WriteLiteral(@"/myCustom/myCustom.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Üst Bar İçin gereken css -->
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/pages/landing-page/style.css"">
    <!-- BEGIN GLOBAL MANDATORY STYLES -->
    <link href=""/assets/css/plugins.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- END GLOBAL MANDATORY STYLES -->
    <!--  BEGIN CUSTOM STYLE FILE  -->
    <link href=""/assets/css/apps/mailbox.css"" rel=""stylesheet"" type=""text/css"" />
    <!--  END CUSTOM STYLE FILE  -->
    <!-- BEGIN PAGE LEVEL PLUGINS/CUSTOM STYLES -->
    <link href=""/plugins/maps/vector/jvector/jquery-jvectormap-2.0.3.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/plugins/charts/chartist/chartist.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""/assets/css/default-dashboard/style.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- END PAGE LEVEL PLUGINS/CUSTOM STYLES -->
    <!--  BEGIN CUSTOM STYLE FILE  -->
    <link href=""/assets/css/ui-kit/custom-tooltips_and_popovers.css");
                WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n    <!--  END CUSTOM STYLE FILE  -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869d3ba3d2773e86f46d6c510ec850644d978e138809", async() => {
                WriteLiteral(@"
    <div id=""eq-loader"">
        <div class=""eq-loader-div"">
            <div class=""eq-loading dual-loader mx-auto mb-5""></div>
        </div>
    </div>
    <!--  BEGIN NAVBAR  -->
    <div id=""navHeadWrapper"" class=""navHeaderWrapper header-image"">
        <nav class=""navbar navbar-expand-lg bg-faded header-nav"">
            <div class=""container"">
                <!-- MARKA LOGOSU -->
                <div class=""col-xl-4 col-lg-3 col-6 mx-auto "">
                    <a class=""navbar-brand"" href=""anasayfa.html"">
                        <img src=""/assets/img/textoni-logo-sabit-157x38px.png"">
                    </a>
                </div>

                <!-- TOGGLE BUTON -->
                <div class=""col-6 text-right d-lg-none d-block"">
                    <button class=""navbar-toggler collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#nav-content""
                            aria-controls=""nav-content"" aria-expanded=""false"" aria-label=""Toggle navigation"">
               ");
                WriteLiteral(@"         <span class=""navbar-toggler-icon flaticon-left-menu""></span>
                    </button>
                </div>

                <!-- LİNKLER -->
                <div class=""col-xl-8 col-lg-9"">
                    <div class=""collapse navbar-collapse justify-content-end"" id=""nav-content"">
                        <ul class=""navbar-nav text-center mt-lg-0 mt-5"">
                            <li class=""nav-item ml-4 d-lg-none d-sm-block d-none"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869d3ba3d2773e86f46d6c510ec850644d978e1310672", async() => {
                    WriteLiteral(@"
                                    <i class=""flaticon-search-1 d-lg-none d-block""></i>
                                    <input type=""text"" class=""form-control search-form-control  ml-lg-auto"" placeholder=""Search..."">
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link js-scroll-trigger"" href=""user_login_1.html"">Giriş</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link js-scroll-trigger"" href=""user_register_1.html"">Kayıt ol</a>
                            </li>
                            <li class=""nav-item"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869d3ba3d2773e86f46d6c510ec850644d978e1312925", async() => {
                    WriteLiteral("\r\n                                    <button class=\"btn ml-xl-4\" type=\"submit\">Keşfet</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </div> <!-- END NAVBAR -->\r\n    <!-- Ana Bölüm Başlangıç -->\r\n");
#nullable restore
#line 97 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
     foreach (var item in Model)
    {


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
         if (item.ID == 1)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""container mt-5"">
                <!-- Kategori Bilgileri Başlangıç -->
                <div class=""col-xl-12 col-lg-6 col-md-12 col-sm-12 layout-spacing mr-2"">
                    <!-- Card Bölümü Başlangıcı -->
                    <div class=""row"">
                        <div class=""col-xl-8 col-lg-6 col-md-6 col-sm-12"">
                            <!-- İlan fotoğrafı ve açıklaması başlangıç -->
                            <div class=""row layout-spacing"">
                                <div class=""col-xl-12 col-lg-6 col-md-6 col-sm-12"">
                                    <div class=""statbox widget box box-shadow"">
                                        <div class=""widget-content widget-content-area product-cat6-header  px-0 py-0"">
                                            <div class=""row"">
                                                <div class=""col-12"">
                                                    <div class=""col-xl-12 text-center"">
                     ");
                WriteLiteral("                                   <img");
                BeginWriteAttribute("src", " src=\"", 6265, "\"", 6282, 1);
#nullable restore
#line 117 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
WriteAttributeValue("", 6271, item.image, 6271, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid"">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-xl-12 col-lg-6 col-md-6 col-sm-12"">
                                    <div class=""statbox widget box box-shadow"">
                                        <div class=""widget-content widget-content-area product-cat6-konu-basligi  px-0 py-0"">
                                            <div class=""row"">
                                                <div class=""col-12"">
                                                    <div class=""col-xl-12"">
                                                        <h4 class=""card-title mt-4 ml-3"">");
#nullable restore
#line 130 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                                    Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                                        <h6>");
#nullable restore
#line 131 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                       Write(item.categoryAndServiceType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                                        <p class=\"card-des px-2\">\r\n                                                            ");
#nullable restore
#line 133 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                       Write(item.advertDeatils);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </p>
                                                        <div class=""col-lg-12 layout-spacing"">
                                                            <div class=""statbox widget box box-shadow"">
                                                                <div class=""widget-content widget-content-area tooltip-section"">
                                                                    <div class=""row"">
                                                                        <div class=""col-lg-12"">
                                                                            <h6>Anahtar Kelimeler</h6>
");
#nullable restore
#line 141 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                               string word = "";
                                                                                foreach (var key in item.keyWord)
                                                                                {
                                                                                    if (key != ',')
                                                                                    {
                                                                                        word = word + key.ToString();
                                                                                    }

                                                                                    else
                                                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                                        <a href=""javascript:void(0);""
                                                                                           class=""btn btn-primary mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                           title=""Default Tooltip"">
                                                                                            ");
#nullable restore
#line 154 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                                       Write(word);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                                        </a>\r\n");
#nullable restore
#line 156 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                                        word = "";
                                                                                    }
                                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                                <a href=""javascript:void(0);""
                                                                                   class=""btn btn-primary mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                   title=""Default Tooltip"">
                                                                                    ");
#nullable restore
#line 162 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                               Write(word);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                                </a>\r\n");
                WriteLiteral(@"                                                                        </div>

                                                                        <div class=""col-lg-12"">
                                                                            <h6>Detaylar</h6>
                                                                            <button type=""button"" class=""btn btn-primary mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                    data-placement=""top"" title=""Tooltip on top"">
                                                                                Dil: ");
#nullable restore
#line 175 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                                Write(item.language);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                            </button>
                                                                            <button type=""button"" class=""btn btn-primary mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                    data-placement=""right"" title=""Tooltip on right"">
                                                                                Kelime Sayisi: ");
#nullable restore
#line 179 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                                          Write(item.wordCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                            </button>
                                                                        </div>
                                                                        <div class=""col-lg-12"">
                                                                            <h6>Alt Başlıklar</h6>
");
#nullable restore
#line 184 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                               string header = "";
                                                                                foreach (var key in item.subHeaders)
                                                                                {
                                                                                    if (key != ',')
                                                                                    {
                                                                                        header = header + key.ToString();
                                                                                    }

                                                                                    else
                                                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                                        <button type=""button""
                                                                                                class=""btn btn-light mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                                data-toggle=""tooltip"" style=""width: 100%;"" data-html=""true""");
                BeginWriteAttribute("title", "\r\n                                                                                                title=\"", 13766, "\"", 13871, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                                            ");
#nullable restore
#line 198 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                                       Write(header);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                                        </button>\r\n");
#nullable restore
#line 200 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                                        header = "";
                                                                                    }
                                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                                <button type=""button""
                                                                                        class=""btn btn-light mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                        data-toggle=""tooltip"" style=""width: 100%;"" data-html=""true""");
                BeginWriteAttribute("title", "\r\n                                                                                        title=\"", 14742, "\"", 14839, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                                    ");
#nullable restore
#line 207 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                               Write(header);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                                </button>\r\n");
                WriteLiteral(@"

                                                                        </div>
                                                                        <div class=""col-lg-12"">
                                                                            <h6>Fiyat</h6>
                                                                            <button type=""button"" class=""btn btn-success mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                    data-toggle=""tooltip"" data-html=""true""");
                BeginWriteAttribute("title", " title=\"", 15658, "\"", 15666, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                                ");
#nullable restore
#line 217 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                                           Write(item.earning);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                            </button>
                                                                        </div>
                                                                        <div class=""col-lg-12 text-right"">
                                                                            <button type=""button""
                                                                                    class=""btn-custom btn-outline-success mb-4 mr-2 rounded bs-tooltip ml-2""
                                                                                    data-toggle=""tooltip"" data-html=""true""");
                BeginWriteAttribute("title", " title=\"", 16419, "\"", 16427, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                                                Başvur
                                                                            </button>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Brief Bölümü Başlangıcı -->
                        <div class=""col-xl-4 col-lg-6 col-");
                WriteLiteral(@"md-6 col-sm-12 layout-spacing"">
                            <div class=""statbox widget box box-shadow"">
                                <div class=""widget-content widget-content-area product-cat6 pb-3 px-0 py-0"">
                                    <div class=""row layout-spacing"">
                                        <div class=""col-12"">
                                            <div class=""card"">
                                                <div class=""wrapper"">
                                                    <div class=""row"">
                                                        <div class=""col-xl-12"">
                                                            <!-- <span class=""badge badge-success"">Yeni</span> -->
                                                            <img alt=""image-product""");
                BeginWriteAttribute("src", " src=\"", 18287, "\"", 18309, 1);
#nullable restore
#line 251 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
WriteAttributeValue("", 18293, item.brandImage, 18293, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid"">
                                                        </div>
                                                        <div class=""col-xl-12 text-center"">
                                                            <h4 class=""card-title"">Marka Açıklaması</h4>
                                                            <p class=""card-des pl-4 pr-4"">
                                                                ");
#nullable restore
#line 256 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
                                                           Write(item.brandDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                            </p>
                                                            <!-- <p class=""card-text"">300 TL</p> -->
                                                        </div>
                                                        <!-- <div class=""col-xl-12 text-center mt-2 mb-2 card-bottom-section"">
                                                                <a href=""#""> <button class=""btn"">İlan Detayı</button></a>
                                                            </div> -->
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <!-- Brief Bölümü Bitişi -->

                    </div>
             ");
                WriteLiteral("       <!-- Card Bölümü Bitişi -->\r\n                </div>\r\n                <!--  Kategori Bilgileri Bitiş -->\r\n            </div>\r\n");
#nullable restore
#line 279 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 279 "C:\Users\tfati\Documents\GitHub\textoniStajyerCalismasi\Textoni\Views\Ilanlar\ilan.cshtml"
         
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Ana Bölüm Bitiş -->

    <script src=""/assets/js/libs/jquery-3.1.1.min.js""></script>
    <script src=""/assets/js/loader.js""></script>
    <script src=""/bootstrap/js/popper.min.js""></script>
    <script src=""/bootstrap/js/bootstrap.min.js""></script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Advert>> Html { get; private set; }
    }
}
#pragma warning restore 1591

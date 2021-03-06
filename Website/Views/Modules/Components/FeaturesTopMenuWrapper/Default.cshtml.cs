﻿using System.Threading.Tasks;
using Olive.Mvc;

namespace Olive.Hub
{
    public class FeaturesTopMenuWrapperView : BasePage<ViewModel.FeaturesTopMenuWrapper>
    {
        public FeaturesTopMenuWrapperView(ViewModel.FeaturesTopMenuWrapper vm) : base(vm)
        {
        }

        public override Task<string> Render()
        {
            var result = $@"                    
                            <div data-module=""FeaturesTopMenuWrapper"">
                               {Html.StartupActionsJson()}
                               {info.Markup.Raw()}
                               <button type=""button"" id=""sidebarCollapse"" class=""navbar-btn d-none d-lg-block""><i class=""fa fa-chevron-left"" aria-hidden=""true""></i></button>
                               <ul class='features-sub-menu feature-top-menu d-none d-lg-flex'>
                               </ul>
                               <script id=""sumMenu-template"" type=""text/x-handlebars-template"">
                                  {{{{#menus}}}}
                                  <ul class=""nav navbar-nav"">
                                     {{{{#Children}}}}
                                     <li class=""feature-menu-item"" data-nodeid=""{{{{ID}}}}"">
                                        <i class=""{{{{Icon}}}}"" aria-hidden=""true""></i>
                                        <a href=""{{{{LoadUrl}}}}"" data-service="""" {{{{#if UseIframe}}}} {{{{else}}}} data-redirect=""ajax"" {{{{/if}}}}>{{{{Title}}}}</a>
                                        <ul>
                                           {{{{#Children}}}}
                                           <li class=""feature-menu-item"" data-nodeid=""{{{{ID}}}}"">
                                              <i class=""{{{{Icon}}}}"" aria-hidden=""true""></i>
                                              <a href=""{{{{LoadUrl}}}}"" data-service="""" {{{{#if UseIframe}}}} {{{{else}}}} data-redirect=""ajax"" {{{{/if}}}}>{{{{Title}}}}</a>
                                              <ul>
                                                 {{{{#Children}}}}
                                                 <li class=""feature-menu-item"" data-nodeid=""{{{{ID}}}}"">
                                                    <i class=""fa {{{{Icon}}}}"" aria-hidden=""true""></i>
                                                    <a href=""{{{{LoadUrl}}}}"" data-service="""" {{{{#if UseIframe}}}} {{{{else}}}} data-redirect=""ajax"" {{{{/if}}}}>{{{{Title}}}}</a>
                                                 </li>
                                                 {{{{/Children}}}}
                                              </ul>
                                           </li>
                                           {{{{/Children}}}}
                                        </ul>
                                     </li>
                                     {{{{/Children}}}}
                                  </ul>
                                  {{{{/menus}}}}
                               </script>
                            </div>";

            return Task.Run(() => result);
        }
    }
}

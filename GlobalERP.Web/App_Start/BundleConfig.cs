using System.Web.Optimization;

namespace GlobalERP.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            bundles.Add(new StyleBundle("~/Bundles/vendor/GlobalMandatoryStyle")
       .Include("~/assets/global/plugins/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform())
       .Include("~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css", new CssRewriteUrlTransform())
       .Include("~/assets/global/plugins/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform())
       .Include("~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css", new CssRewriteUrlTransform())
       );
            // PAGE LEVEL PLUGINS 
            bundles.Add(new StyleBundle("~/Bundles/vendor/PageLevelPlugin")
                .Include("~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/morris/morris.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/fullcalendar/fullcalendar.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/jqvmap/jqvmap/jqvmap.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/select2/css/select2.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/select2/css/select2-bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/datatables/datatables.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.css", new CssRewriteUrlTransform())
            );
            //THEME GLOBAL STYLES 
            bundles.Add(new StyleBundle("~/Bundles/vendor/GlobalStyles")
                .Include("~/assets/global/css/components-md.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/css/plugins-md.min.css", new CssRewriteUrlTransform())
            );
            //LAYOUT STYLES 
            bundles.Add(new StyleBundle("~/Bundles/vendor/LayoutStyles")
                .Include("~/assets/layouts/layout4/css/layout.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/layouts/layout4/css/themes/default.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/layouts/layout4/css/custom.min.css", new CssRewriteUrlTransform())
            );
            //VENDOR RESOURCES

            //~/Bundles/App/vendor/css
            bundles.Add(
                new StyleBundle("~/Bundles/App/vendor/css")                    
                    .Include("~/Content/toastr.min.css", new CssRewriteUrlTransform())
                    .Include("~/Scripts/sweetalert/sweet-alert.css", new CssRewriteUrlTransform())
                    .Include("~/Content/flags/famfamfam-flags.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                );

            //~/Bundles/App/vendor/js
            bundles.Add(
                new ScriptBundle("~/Bundles/App/vendor/js")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/json2.min.js",
                        "~/Scripts/modernizr-2.8.3.js",                         
                        "~/Scripts/jquery-ui-1.11.4.min.js",
                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/Scripts/sweetalert/sweet-alert.min.js",
                        "~/Scripts/others/spinjs/spin.js",
                        "~/Scripts/others/spinjs/jquery.spin.js",

                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-animate.min.js",
                        "~/Scripts/angular-sanitize.min.js",
                        "~/Scripts/angular-ui-router.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                        "~/Scripts/angular-ui/ui-utils.min.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js",
                        "~/Abp/Framework/scripts/libs/angularjs/abp.ng.js",

                        "~/Scripts/jquery.signalR-2.2.0.min.js"
                    )
                );

            //APPLICATION RESOURCES

            //~/Bundles/App/Main/css
            bundles.Add(
                new StyleBundle("~/Bundles/App/Main/css")
                    .IncludeDirectory("~/App/Main", "*.css", true)
                );

            bundles.Add(
                 new ScriptBundle("~/Bundles/js/CorePlugin")

                        .Include("~/Scripts/jquery-2.2.0.min.js")
                    //.Include("~/assets/global/plugins/jquery.min.js")
                    .Include("~/assets/global/plugins/bootstrap/js/bootstrap.min.js")
                    .Include("~/assets/global/plugins/js.cookie.min.js")
                    .Include("~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js")
                    .Include("~/assets/global/plugins/jquery.blockui.min.js")
                    .Include("~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js")
                );
            bundles.Add(
                 new ScriptBundle("~/Bundles/js/PageLevelPlugin")

                   .Include("~/assets/global/plugins/moment.min.js")
                    .Include("~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.js")
                    .Include("~/assets/global/plugins/morris/morris.min.js")
                    .Include("~/assets/global/plugins/morris/raphael-min.js")
                    .Include("~/assets/global/plugins/counterup/jquery.waypoints.min.js")
                    .Include("~/assets/global/plugins/counterup/jquery.counterup.min.js")
                    .Include("~/assets/global/plugins/amcharts/amcharts/amcharts.js")
                    .Include("~/assets/global/plugins/amcharts/amcharts/serial.js")
                    .Include("~/assets/global/plugins/amcharts/amcharts/pie.js")
                    .Include("~/assets/global/plugins/amcharts/amcharts/radar.js")
                    .Include("~/assets/global/plugins/amcharts/amcharts/themes/light.js")
                    .Include("~/assets/global/plugins/amcharts/amcharts/themes/patterns.js")
                    .Include("~/assets/global/plugins/amcharts/amcharts/themes/chalk.js")
                    .Include("~/assets/global/plugins/amcharts/ammap/ammap.js")
                    .Include("~/assets/global/plugins/amcharts/ammap/maps/js/worldLow.js")
                    .Include("~/assets/global/plugins/amcharts/amstockcharts/amstock.js")
                    .Include("~/assets/global/plugins/fullcalendar/fullcalendar.min.js")
                    .Include("~/assets/global/plugins/horizontal-timeline/horizontal-timeline.js")
                    .Include("~/assets/global/plugins/flot/jquery.flot.min.js")
                    .Include("~/assets/global/plugins/flot/jquery.flot.resize.min.js")
                    .Include("~/assets/global/plugins/flot/jquery.flot.categories.min.js")
                    .Include("~/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js")
                    .Include("~/assets/global/plugins/jquery.sparkline.min.js")
                    .Include("~/assets/global/plugins/jqvmap/jqvmap/jquery.vmap.js")
                    .Include("~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.russia.js")
                    .Include("~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.world.js")
                    .Include("~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.europe.js")
                    .Include("~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.germany.js")
                    .Include("~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.usa.js")
                    .Include("~/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js")


            );
            bundles.Add(
                     new ScriptBundle("~/Bundles/js/GlobalScript")
                        .Include("~/assets/global/scripts/app.min.js")
            );
            bundles.Add(
                      new ScriptBundle("~/Bundles/js/PageLevelScript")
                        .Include("~/assets/pages/scripts/dashboard.min.js")
            );
            bundles.Add(
                     new ScriptBundle("~/Bundles/js/LayoutScript")
                        .Include("~/assets/layouts/layout4/scripts/layout.min.js")
                        .Include("~/assets/layouts/layout4/scripts/demo.min.js")
                        .Include("~/assets/layouts/global/scripts/quick-sidebar.min.js")
                        .Include("~/assets/layouts/global/scripts/quick-nav.min.js")
            );
            new StyleBundle("~/Bundles/login")
             .Include("~/Content/Login.css");
            //~/Bundles/App/Main/js
            bundles.Add(
                new ScriptBundle("~/Bundles/App/Main/js")
                    .IncludeDirectory("~/Common/Scripts", "*.js", true)
                    .IncludeDirectory("~/App/Main", "*.js", true)
                );
        }
    }
}
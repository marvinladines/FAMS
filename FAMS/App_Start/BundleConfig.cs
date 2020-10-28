using System.Web;
using System.Web.Optimization;

namespace FAMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // CSS style (bootstrap/inspinia)
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.css",
                      "~/Content/style.css",
                      "~/Content/CustomStyle.css"));

            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/fonts/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.min.js"));

            // jQueryUI CSS
            bundles.Add(new ScriptBundle("~/Scripts/plugins/jquery-ui/jqueryuiStyles").Include(
                        "~/Scripts/plugins/jquery-ui/jquery-ui.min.css"));

            // jQueryUI 
            bundles.Add(new StyleBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/plugins/jquery-ui/jquery-ui.min.js"));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.min.js"));

            // Inspinia script
            bundles.Add(new ScriptBundle("~/bundles/inspinia").Include(
                      "~/Scripts/plugins/metisMenu/jquery.metisMenu.js",
                      "~/Scripts/plugins/pace/pace.min.js",
                      "~/Scripts/app/inspinia.js"));

            // Inspinia skin config script
            bundles.Add(new ScriptBundle("~/bundles/skinConfig").Include(
                      "~/Scripts/app/skin.config.min.js"));

            // Sweet alert Styless
            bundles.Add(new StyleBundle("~/plugins/sweetalert2Styles").Include(
                      "~/Content/plugins/sweetalert/sweetalert2.css",
                      "~/Content/plugins/sweetalert/sweetalert2.min.css"));

            // Sweet alert
            bundles.Add(new ScriptBundle("~/plugins/sweetalert2").Include(
                      "~/Scripts/plugins/sweetalert/sweetalert2.all.js",
                      "~/Scripts/plugins/sweetalert/sweetalert2.all.min.js"));

            //Core
            bundles.Add(new ScriptBundle("~/plugins/core").Include(
                      "~/Scripts/plugins/core/core.js"));

            // SlimScroll
            bundles.Add(new ScriptBundle("~/plugins/slimScroll").Include(
                      "~/Scripts/plugins/slimscroll/jquery.slimscroll.min.js"));

            // dataTables css styles
            bundles.Add(new StyleBundle("~/Content/plugins/dataTables/dataTablesStyles").Include(
                      "~/Content/plugins/dataTables/datatables.min.css"));

            // dataTables 
            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
                      "~/Scripts/plugins/dataTables/datatables.min.js",
                      "~/Scripts/plugins/dataTables/dataTables.bootstrap4.min.js"));

            // Footable Styles
            bundles.Add(new StyleBundle("~/plugins/footableStyles").Include(
                    "~/Content/plugins/footable/footable.core.css", new CssRewriteUrlTransform()));

            // Footable JS
            bundles.Add(new ScriptBundle("~/plugins/footable").Include(
                      "~/Scripts/plugins/footable/footable.all.min.js"));

            // dataPicker styles
            bundles.Add(new StyleBundle("~/plugins/dataPickerStyles").Include(
                      "~/Content/plugins/datapicker/datepicker3.css"));

            // dataPicker 
            bundles.Add(new ScriptBundle("~/plugins/dataPicker").Include(
                      "~/Scripts/plugins/datapicker/bootstrap-datepicker.js"));

            // Date range picker Styless
            bundles.Add(new StyleBundle("~/plugins/dateRangeStyles").Include(
                      "~/Content/plugins/daterangepicker/daterangepicker-bs3.css"));

            // Date range picker
            bundles.Add(new ScriptBundle("~/plugins/dateRange").Include(
                      // Date range use moment.js same as full calendar plugin 
                      "~/Scripts/plugins/fullcalendar/moment.min.js",
                      "~/Scripts/plugins/daterangepicker/daterangepicker.js"));

            // chosen styles
            bundles.Add(new StyleBundle("~/Content/plugins/chosen/chosenStyles").Include(
                      "~/Content/plugins/chosen/bootstrap-chosen.css"));

            // chosen 
            bundles.Add(new ScriptBundle("~/plugins/chosen").Include(
                      "~/Scripts/plugins/chosen/chosen.jquery.js"));

            // Select2 Styless
            bundles.Add(new StyleBundle("~/plugins/select2Styles").Include(
                      "~/Content/plugins/select2/select2.min.css"));

            // Select2
            bundles.Add(new ScriptBundle("~/plugins/select2").Include(
                      "~/Scripts/plugins/select2/select2.full.min.js"));


        }
    }
}

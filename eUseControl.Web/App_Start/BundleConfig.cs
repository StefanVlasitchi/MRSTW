using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
{
    public static class BundleConfig
    {
        public static void RegiterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap.min/css").Include(
                "~/Content/assets/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/2/css").Include(
                "~/Content/assets/css/default-css.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/3/css").Include(
                "~/Content/assets/css/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/4/css").Include(
                "~/Content/assets/css/magnific-popup.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/5/css").Include(
                "~/Content/assets/css/owl.carousel.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/6/css").Include(
                "~/Content/assets/css/responsive.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/7/css").Include(
                 "~/Content/assets/css/slicknav.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/8/css").Include(
                 "~/Content/assets/css/styles.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/9/css").Include(
                 "~/Content/assets/css/typography.css", new CssRewriteUrlTransform()));



            bundles.Add(new ScriptBundle("~/bundles/11/js").Include(
                "~/Content/assets/js/bootstrap.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/22/js").Include(
                "~/Content/assets/js/google-maps.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/33/js").Include(
                "~/Content/assets/js/jquery.magnific-popup.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/44/js").Include(
                "~/Content/assets/js/jquery.slicknav.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/55/js").Include(
                "~/Content/assets/js/owl.carousel.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/66/js").Include(
                "~/Content/assets/js/plugins.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/77/js").Include(
                "~/Content/assets/js/scripts.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/88/js").Include(
                 "~/Content/assets/js/vendor/modernizr-2.8.3.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/99/js").Include(
                 "~/Content/assets/js/vendor/jquery-2.2.4.min.js", new CssRewriteUrlTransform()));
          }
    }
}
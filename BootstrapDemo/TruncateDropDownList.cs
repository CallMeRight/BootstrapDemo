using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace BootstrapDemo
{
    public static class TruncateDropDownList
    {
        public static MvcHtmlString TruncateDropDown(this HtmlHelper helper, string name, ListItem[] values, Object htmlAttributes)
        {


            List<SelectListItem> Textes = new List<SelectListItem>();
            foreach (ListItem item in values)
            {
                SelectListItem selItem = new SelectListItem();
                if (item.Text.Length <= 20)
                    selItem.Text = item.Text;
                else
                    selItem.Text = item.Text.Substring(0, 20) + "...";
                Textes.Add(selItem);
            }

            //return System.Web.Mvc.Html.SelectExtensions.DropDownList(helper,
            //                                                         name,
            //                                                         Textes,
            //                                                         htmlAttributes);

            var drop = System.Web.Mvc.Html.SelectExtensions.DropDownList(helper,
                                                                     name,
                                                                     Textes,
                                                                     htmlAttributes);
            var sb = new StringBuilder();
            sb.AppendFormat("<div class='{0}'>", "select-box");

            sb.Append(drop);
            sb.AppendFormat("</div>");
            return MvcHtmlString.Create(sb.ToString());

        }

        public static MvcHtmlString DropDownListFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            List<dynamic> selectedValue)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("<div class='{0}'>", "select-box");

            // I want to put something here to put the dropdwodn list extend into this div
            var items = from value in selectedValue
                        select new SelectListItem()
                        {
                            Text = value.ToString(),
                            Value = value.ToString()
                        };

            sb.AppendFormat("</div>");
            //how to apply this stringbuilder to the dropdownlist
            //return htmlHelper.DropDownListFor(expression, selectedValue);


            var drop = htmlHelper.DropDownListFor(expression, selectedValue);
            return MvcHtmlString.Create(sb.ToString());
        }

    }
}

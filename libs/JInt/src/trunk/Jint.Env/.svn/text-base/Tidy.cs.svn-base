using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Jint.Env
{
    public class Tidy
    {
        private const string attributePattern = @"(?<attributeName>[A-Za-z][A-Za-z0-9:_-]*)=(?<quote>[""']?)(?<attributeValue>.*?)\k<quote>";
        private Regex attributes = new Regex(attributePattern, RegexOptions.Compiled);
        private Regex autoClosing;
        public Tidy()
            : this("img|meta|link|hr|br|input")
        {

        }

        public Tidy(string autoClosingTags)
        {
            AutoClosingTagsPattern = autoClosingTags;
            autoClosing = new Regex(@"<(?<tagName>" + AutoClosingTagsPattern + @")\s+(?<attributes>(" + attributePattern + @"\s*)*)(?<notAutoClosing>>[^<]*(?!</\k<tagName>>))?");
        }

        public string AutoClosingTagsPattern { get; set; }

        public string Parse(string htmlString)
        {
            htmlString = autoClosing.Replace(htmlString, ReplaceTag);

            return htmlString;
        }

        private string ReplaceTag(Match m)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            sb.Append(m.Groups["tagName"].Value);
            sb.Append(' ');
            sb.Append(attributes.Replace(m.Groups["attributes"].Value, ReplaceAttribute));
            if (m.Groups["notAutoClosing"].Success)
                sb.Append(" />");
            return sb.ToString();
        }

        private string ReplaceAttribute(Match m)
        {
            return m.Groups["attributeName"].Value + "=" + m.Groups["quote"].Value + m.Groups["attributeValue"].Value.Replace("<", "&lt;").Replace(">", "&gt;") + m.Groups["quote"].Value;
        }

    }
}

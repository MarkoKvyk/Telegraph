using Kvyk.Telegraph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvyk.Telegraph.Parsers
{
    public class TelegraphMarkdown
    {
        #region ParseParseMarkdown

        public async Task<List<Node>> ParseMarkdownAsync(string markdown)
        {
            return await Task.Run(() => ParseMarkdown(markdown));
        }

        public List<Node> ParseMarkdown(string markdown)
        {
            var html = Markdig.Markdown.ToHtml(markdown);
            var telegraphHTML = new TelegraphHTML();
            return telegraphHTML.ParseHTML(html);
        }

        #endregion
    }
}

using HtmlAgilityPack;
using Kvyk.Telegraph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvyk.Telegraph.Parsers
{
    public class TelegraphHTML
    {
        #region ParseHTML

        public async Task<List<Node>> ParseHTMLAsync(string html)
        {
            return await Task.Run(() => ParseHTML(html));
        }

        public List<Node> ParseHTML(string html)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var htmlNode = doc.DocumentNode;

            if (htmlNode.ChildNodes.Any(v => v.Name == "body"))
                htmlNode = htmlNode.ChildNodes["body"];

            var list = new List<Node>();

            foreach (var item in htmlNode.ChildNodes)
            {
                list.Add(SelectHTMLNodes(item));
            }

            return list;
        }

        private Node SelectHTMLNodes(HtmlNode htmlNode)
        {
            Node node = null;

            switch (htmlNode.Name)
            {
                case "#text":
                    node = new Node(htmlNode.InnerText);
                    return node;

                case "p":
                    node = Node.P();
                    break;

                case "h1":
                case "h2":
                case "h3":
                    node = Node.H3();
                    break;

                case "h4":
                case "h5":
                case "h6":
                    node = Node.H4();
                    break;

                case "a":
                    node = Node.A(htmlNode.Attributes["href"]?.Value);
                    break;

                case "b":
                    node = Node.B();
                    break;

                case "i":
                    node = Node.I();
                    break;

                case "em":
                    node = Node.Em();
                    break;

                case "u":
                    node = Node.U();
                    break;

                case "s":
                    node = Node.S();
                    break;

                case "br":
                    node = Node.Br();
                    break;

                case "code":
                    node = Node.Code();
                    break;

                case "pre":
                    node = Node.Pre();
                    break;

                case "strong":
                    node = Node.Strong();
                    break;

                case "aside":
                    node = Node.Aside();
                    break;

                case "blockquote":
                    node = Node.Blockquote();
                    break;

                case "hr":
                    node = Node.Hr();
                    break;

                case "li":
                    node = Node.Li();
                    break;

                case "ol":
                    node = Node.Ol();
                    break;

                case "ul":
                    node = Node.Ul();
                    break;

                case "img":
                    node = Node.Img(htmlNode.Attributes["src"]?.Value);
                    break;

                case "video":
                    node = Node.Video(htmlNode.Attributes["src"]?.Value);
                    break;

                case "iframe":
                    node = Node.Iframe(htmlNode.Attributes["src"]?.Value);
                    break;

                case "figcaption":
                    node = Node.Figcaption();
                    break;

                case "figure":
                    node = Node.Figure();
                    break;

                default:
                    node = Node.P();
                    break;
            }

            foreach (var item in htmlNode.ChildNodes)
            {
                node.Children.Add(SelectHTMLNodes(item));
            }

            return node;
        }

        #endregion
    }
}

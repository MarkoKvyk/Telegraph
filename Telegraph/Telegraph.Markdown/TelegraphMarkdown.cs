using Kvyk.Telegraph.Models;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kvyk.Telegraph.Markdown
{
    public class TelegraphMarkdown
    {
        #region ParseMarkdown

        public async Task<List<Node>> ParseMarkdownAsync(string markdown)
        {
            return await Task.Run(() => ParseMarkdown(markdown));
        }

        public List<Node> ParseMarkdown(string markdown)
        {
            var doc = Markdig.Markdown.Parse(markdown);

            var list = new List<Node>();
            foreach (var item in doc)
            {
                list.AddRange(ParseBlock(item));
            }

            return list;
        }
        
        private List<Node> ParseBlock(Block item)
        {
            var list = new List<Node>();

            switch (item)
            {
                case HeadingBlock block:
                    if (block.Level == 1)
                        list.Add(Node.H3(ParseContainer(block.Inline)));
                    else
                        list.Add(Node.H4(ParseContainer(block.Inline)));
                    break;

                case CodeBlock block:
                    list.Add(Node.Pre(ParseContainer(block.Inline)));
                    break;

                case ListBlock block:
                    
                    break;

                case ListItemBlock block:

                    break;

                case ParagraphBlock block:
                    list.Add(Node.P(ParseContainer(block.Inline)));
                    break;

                case QuoteBlock block:
                    list.Add(Node.Blockquote(ParseBlock(block)));
                    break;

                case ThematicBreakBlock block:
                    list.Add(Node.Hr());
                    break;

                case EmptyBlock:
                case BlankLineBlock:
                default:
                    list.Add(Node.P());
                    break;
            }

            return list;
        }

        private List<Node> ParseContainer(ContainerInline block)
        {
            var list = new List<Node>();

            foreach (var item in block)
            {
                switch (item)
                {
                    case Markdig.Syntax.Inlines.AutolinkInline:

                        break;
                    default:
                        break;
                }
            }

            return list;
        }

        #endregion
    }
}

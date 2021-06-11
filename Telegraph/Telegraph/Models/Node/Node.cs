using Kvyk.Telegraph.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kvyk.Telegraph.Models
{
    public partial class Node
    {
        #region Static Methods

        #region P

        /// <summary>
        /// Create new Node with tag p
        /// </summary>
        public static Node P() => new Node { Tag = TagEnum.P };

        /// <summary>
        /// Create new Node with tag p and children text
        /// </summary>
        public static Node P(string text)
        {
            var node = P();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag p and children nodes
        /// </summary>
        public static Node P(IEnumerable<Node> nodes)
        {
            var node = P();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag p and children nodes
        /// </summary>
        public static Node P(params Node[] nodes) => P(nodes.ToList());

        #endregion

        #region H3

        /// <summary>
        /// Create new Node with tag H3
        /// </summary>
        public static Node H3() => new Node { Tag = TagEnum.H3 };

        /// <summary>
        /// Create new Node with tag H3 and children text
        /// </summary>
        public static Node H3(string text)
        {
            var node = H3();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag H3 and children nodes
        /// </summary>
        public static Node H3(IEnumerable<Node> nodes)
        {
            var node = H3();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag H3 and children nodes
        /// </summary>
        public static Node H3(params Node[] nodes) => H3(nodes.ToList());

        #endregion
        
        #region H4

        /// <summary>
        /// Create new Node with tag H4
        /// </summary>
        public static Node H4() => new Node { Tag = TagEnum.H4 };

        /// <summary>
        /// Create new Node with tag H4 and children text
        /// </summary>
        public static Node H4(string text)
        {
            var node = H4();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag H4 and children nodes
        /// </summary>
        public static Node H4(IEnumerable<Node> nodes)
        {
            var node = H4();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag H4 and children nodes
        /// </summary>
        public static Node H4(params Node[] nodes) => H4(nodes.ToList());

        #endregion

        #region A

        /// <summary>
        /// Create new Node with tag A
        /// </summary>
        public static Node A() => new Node { Tag = TagEnum.A, Artibutes = new TagAttributes() };

        /// <summary>
        /// Create new Node with tag A and href
        /// </summary>
        public static Node A(string href)
        {
            var node = A();
            node.Artibutes.Href = href;
            return node;
        }
        
        /// <summary>
        /// Create new Node with tag A, href and text
        /// </summary>
        public static Node A(string href, string text)
        {
            var node = A(href);
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag A, href and children nodes
        /// </summary>
        public static Node A(string href, IEnumerable<Node> nodes)
        {
            var node = A(href);
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag A, href and children nodes
        /// </summary>
        public static Node A(string href, params Node[] nodes) => A(href, nodes.ToList());

        #endregion

        #region B

        /// <summary>
        /// Create new Node with tag B
        /// </summary>
        public static Node B() => new Node { Tag = TagEnum.B };

        /// <summary>
        /// Create new Node with tag B and children text
        /// </summary>
        public static Node B(string text)
        {
            var node = B();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag B and children nodes
        /// </summary>
        public static Node B(IEnumerable<Node> nodes)
        {
            var node = B();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag B and children nodes
        /// </summary>
        public static Node B(params Node[] nodes) => B(nodes.ToList());

        #endregion
        
        #region I

        /// <summary>
        /// Create new Node with tag I
        /// </summary>
        public static Node I() => new Node { Tag = TagEnum.I };

        /// <summary>
        /// Create new Node with tag I and children text
        /// </summary>
        public static Node I(string text)
        {
            var node = I();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag I and children nodes
        /// </summary>
        public static Node I(IEnumerable<Node> nodes)
        {
            var node = I();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag I and children nodes
        /// </summary>
        public static Node I(params Node[] nodes) => I(nodes.ToList());

        #endregion

        #region Em

        /// <summary>
        /// Create new Node with tag Em
        /// </summary>
        public static Node Em() => new Node { Tag = TagEnum.Em };

        /// <summary>
        /// Create new Node with tag Em and children text
        /// </summary>
        public static Node Em(string text)
        {
            var node = Em();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Em and children nodes
        /// </summary>
        public static Node Em(IEnumerable<Node> nodes)
        {
            var node = Em();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Em and children nodes
        /// </summary>
        public static Node Em(params Node[] nodes) => Em(nodes.ToList());

        #endregion
        
        #region U

        /// <summary>
        /// Create new Node with tag U
        /// </summary>
        public static Node U() => new Node { Tag = TagEnum.U };

        /// <summary>
        /// Create new Node with tag U and children text
        /// </summary>
        public static Node U(string text)
        {
            var node = U();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag U and children nodes
        /// </summary>
        public static Node U(IEnumerable<Node> nodes)
        {
            var node = U();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag U and children nodes
        /// </summary>
        public static Node U(params Node[] nodes) => U(nodes.ToList());

        #endregion

        #region S

        /// <summary>
        /// Create new Node with tag S
        /// </summary>
        public static Node S() => new Node { Tag = TagEnum.S };

        /// <summary>
        /// Create new Node with tag S and children text
        /// </summary>
        public static Node S(string text)
        {
            var node = S();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag S and children nodes
        /// </summary>
        public static Node S(IEnumerable<Node> nodes)
        {
            var node = S();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag S and children nodes
        /// </summary>
        public static Node S(params Node[] nodes) => S(nodes.ToList());

        #endregion
        
        #region Br

        /// <summary>
        /// Create new Node with tag Br
        /// </summary>
        public static Node Br() => new Node { Tag = TagEnum.Br };

        #endregion

        #region Code

        /// <summary>
        /// Create new Node with tag Code
        /// </summary>
        public static Node Code() => new Node { Tag = TagEnum.Code };

        /// <summary>
        /// Create new Node with tag Code and children text
        /// </summary>
        public static Node Code(string text)
        {
            var node = Code();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Code and children nodes
        /// </summary>
        public static Node Code(IEnumerable<Node> nodes)
        {
            var node = Code();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Code and children nodes
        /// </summary>
        public static Node Code(params Node[] nodes) => Code(nodes.ToList());

        #endregion

        #region Pre

        /// <summary>
        /// Create new Node with tag Pre
        /// </summary>
        public static Node Pre() => new Node { Tag = TagEnum.Pre };

        /// <summary>
        /// Create new Node with tag Pre and children text
        /// </summary>
        public static Node Pre(string text)
        {
            var node = Pre();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Pre and children nodes
        /// </summary>
        public static Node Pre(IEnumerable<Node> nodes)
        {
            var node = Pre();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Pre and children nodes
        /// </summary>
        public static Node Pre(params Node[] nodes) => Pre(nodes.ToList());

        #endregion

        #region Strong

        /// <summary>
        /// Create new Node with tag Strong
        /// </summary>
        public static Node Strong() => new Node { Tag = TagEnum.Strong };

        /// <summary>
        /// Create new Node with tag Strong and children text
        /// </summary>
        public static Node Strong(string text)
        {
            var node = Strong();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Strong and children nodes
        /// </summary>
        public static Node Strong(IEnumerable<Node> nodes)
        {
            var node = Strong();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Strong and children nodes
        /// </summary>
        public static Node Strong(params Node[] nodes) => Strong(nodes.ToList());

        #endregion
        
        #region Aside

        /// <summary>
        /// Create new Node with tag Aside
        /// </summary>
        public static Node Aside() => new Node { Tag = TagEnum.Aside };

        /// <summary>
        /// Create new Node with tag Aside and children text
        /// </summary>
        public static Node Aside(string text)
        {
            var node = Aside();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Aside and children nodes
        /// </summary>
        public static Node Aside(IEnumerable<Node> nodes)
        {
            var node = Aside();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Aside and children nodes
        /// </summary>
        public static Node Aside(params Node[] nodes) => Aside(nodes.ToList());

        #endregion
        
        #region Blockquote

        /// <summary>
        /// Create new Node with tag Blockquote
        /// </summary>
        public static Node Blockquote() => new Node { Tag = TagEnum.Blockquote };

        /// <summary>
        /// Create new Node with tag Blockquote and children text
        /// </summary>
        public static Node Blockquote(string text)
        {
            var node = Blockquote();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Blockquote and children nodes
        /// </summary>
        public static Node Blockquote(IEnumerable<Node> nodes)
        {
            var node = Blockquote();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Blockquote and children nodes
        /// </summary>
        public static Node Blockquote(params Node[] nodes) => Blockquote(nodes.ToList());

        #endregion
        
        #region Hr

        /// <summary>
        /// Create new Node with tag Hr
        /// </summary>
        public static Node Hr() => new Node { Tag = TagEnum.Hr };

        #endregion

        #region Li

        /// <summary>
        /// Create new Node with tag Li
        /// </summary>
        public static Node Li() => new Node { Tag = TagEnum.Li };

        /// <summary>
        /// Create new Node with tag Li and children text
        /// </summary>
        public static Node Li(string text)
        {
            var node = Li();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Li and children nodes
        /// </summary>
        public static Node Li(IEnumerable<Node> nodes)
        {
            var node = Li();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Li and children nodes
        /// </summary>
        public static Node Li(params Node[] nodes) => Li(nodes.ToList());

        #endregion

        #region Ol

        /// <summary>
        /// Create new Node with tag Ol
        /// </summary>
        public static Node Ol() => new Node { Tag = TagEnum.Ol };

        /// <summary>
        /// Create new Node with tag Ol and children nodes
        /// </summary>
        public static Node Ol(IEnumerable<Node> nodes)
        {
            var node = Ol();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Ol and children nodes
        /// </summary>
        public static Node Ol(params Node[] nodes) => Ol(nodes.ToList());

        /// <summary>
        /// Create new Node with tag Ol and children Li nodes with children nodes
        /// </summary>
        public static Node Ol(IEnumerable<IEnumerable<Node>> lists)
        {
            var node = Ol();
            node.Children.AddRange(lists.Select(v => Li(v)));
            return node;
        }

        #endregion
        
        #region Ul

        /// <summary>
        /// Create new Node with tag Ul
        /// </summary>
        public static Node Ul() => new Node { Tag = TagEnum.Ul };

        /// <summary>
        /// Create new Node with tag Ul and children nodes
        /// </summary>
        public static Node Ul(IEnumerable<Node> nodes)
        {
            var node = Ul();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Ul and children nodes
        /// </summary>
        public static Node Ul(params Node[] nodes) => Ul(nodes.ToList());

        /// <summary>
        /// Create new Node with tag Ul and children Li nodes with children nodes
        /// </summary>
        public static Node Ul(IEnumerable<IEnumerable<Node>> lists)
        {
            var node = Ul();
            node.Children.AddRange(lists.Select(v => Li(v)));
            return node;
        }

        #endregion

        #region Img

        /// <summary>
        /// Create new Node with tag Img
        /// </summary>
        public static Node Img() => new Node { Tag = TagEnum.Img, Artibutes = new TagAttributes() };

        /// <summary>
        /// Create new Node with tag Img with img link
        /// </summary>
        public static Node Img(string src)
        {
            var node = Img();
            node.Artibutes.Src = src;
            return node;
        }

        #endregion
        
        #region Video

        /// <summary>
        /// Create new Node with tag Video
        /// </summary>
        public static Node Video() => new Node { Tag = TagEnum.Video, Artibutes = new TagAttributes() };

        /// <summary>
        /// Create new Node with tag Video with Video link
        /// </summary>
        public static Node Video(string src)
        {
            var node = Video();
            node.Artibutes.Src = src;
            return node;
        }

        #endregion

        #region Iframe

        /// <summary>
        /// Create new Node with tag Iframe
        /// </summary>
        public static Node Iframe() => new Node { Tag = TagEnum.Iframe, Artibutes = new TagAttributes() };

        /// <summary>
        /// Create new Node with tag Iframe with Youtube, Vimeo or Twitter link
        /// </summary>
        public static Node Iframe(string src)
        {
            var resources = new Dictionary<string, string>
            {
                { "youtube\\.com",      "youtube" },
                { "youtu\\.be",         "youtube" },
                { "twitter\\.com",      "twitter" },
                { "vimeo\\.com",        "vimeo" },
            };

            var linkValidator = new Regex(@$"(http(s)?://)?(?<resource>({string.Join(")|(", resources.Keys)}))(/.*)?");

            if (!linkValidator.IsMatch(src))
                throw new TelegraphException($"Invalid link. Allowed resources: {string.Join(", ", resources.Values.Distinct())}");

            var resource = linkValidator.Match(src)
                .Groups["resource"]
                .Value;

            var node = Iframe();
            node.Artibutes.Src = $"/embed/{resources[resource.Replace(".", "\\.")]}?url={src}";
            return node;
        }

        #endregion

        #region Figcaption

        /// <summary>
        /// Create new Node with tag Figcaption
        /// </summary>
        public static Node Figcaption() => new Node { Tag = TagEnum.Figcaption };

        /// <summary>
        /// Create new Node with tag Figcaption and children text
        /// </summary>
        public static Node Figcaption(string text)
        {
            var node = Figcaption();
            node.Children.Add(text);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Figcaption and children nodes
        /// </summary>
        public static Node Figcaption(IEnumerable<Node> nodes)
        {
            var node = Figcaption();
            node.Children.AddRange(nodes);
            return node;
        }

        /// <summary>
        /// Create new Node with tag Figcaption and children nodes
        /// </summary>
        public static Node Figcaption(params Node[] nodes) => Figcaption(nodes.ToList());

        #endregion

        #region Figure

        /// <summary>
        /// Create new Node with tag Figure
        /// </summary>
        public static Node Figure() => new Node { Tag = TagEnum.Figure };

        /// <summary>
        /// Create new Node with tag Figure with embed node (img, iframe, video) and caption node (Figcaption)
        /// </summary>
        public static Node Figure(Node node, Node caption)
        {
            var fig = Figure();
            fig.Children.Add(node);
            fig.Children.Add(caption);
            return fig;
        }

        /// <summary>
        /// Create new Node with tag Figure with img and caption
        /// </summary>
        public static Node ImageFigure(string imgSrc, IEnumerable<Node> captionNodes) => Figure(Img(imgSrc), Figcaption(captionNodes));
        
        /// <summary>
        /// Create new Node with tag Figure with img and caption
        /// </summary>
        public static Node ImageFigure(string imgSrc, params Node[] caption) => ImageFigure(imgSrc, caption.ToList());

        /// <summary>
        /// Create new Node with tag Figure with video and caption
        /// </summary>
        public static Node VideoFigure(string videoSrc, IEnumerable<Node> captionNodes) => Figure(Video(videoSrc), Figcaption(captionNodes));

        /// <summary>
        /// Create new Node with tag Figure with video and caption
        /// </summary>
        public static Node VideoFigure(string videoSrc, params Node[] caption) => VideoFigure(videoSrc, caption.ToList());
        
        /// <summary>
        /// Create new Node with tag Figure with Iframe and caption
        /// </summary>
        public static Node IframeFigure(string iframeSrc, IEnumerable<Node> captionNodes) => Figure(Iframe(iframeSrc), Figcaption(captionNodes));

        /// <summary>
        /// Create new Node with tag Figure with Iframe and caption
        /// </summary>
        public static Node IframeFigure(string iframeSrc, params Node[] caption) => IframeFigure(iframeSrc, caption.ToList());

        #endregion

        #endregion
    }
}

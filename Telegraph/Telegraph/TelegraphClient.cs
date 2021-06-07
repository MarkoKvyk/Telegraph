using Kvyk.Telegraph.Exceptions;
using Kvyk.Telegraph.Models;
using Kvyk.Telegraph.Models.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kvyk.Telegraph
{
    public class TelegraphClient
    {
        #region Properties

        /// <summary>
        /// Access token of the Telegraph account.
        /// </summary>
        public string AccessToken { get; set; }

        #endregion

        #region Constructors

        public TelegraphClient()
        {

        }

        public TelegraphClient(string accessToken)
        {
            AccessToken = accessToken;
        }

        #endregion

        #region Methods

        #region Account

        /// <summary>
        /// Use this method to create a new Telegraph account. Most users only need one account, but this can be useful for channel administrators who would like to keep individual author names and profile links for each of their channels.
        /// <para/><see href="https://telegra.ph/api#createAccount">Telegraph documentation</see>
        /// </summary>
        /// <param name="shortName">Required. Account name, helps users with several accounts remember which they are currently using. Displayed to the user above the "Edit/Publish" button on Telegra.ph, other users don't see this name.</param>
        /// <param name="authorName">Default author name used when creating new articles.</param>
        /// <param name="authorUrl">Default profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.</param>
        /// <returns>On success, returns an Account object with the regular fields and an additional access_token field.</returns>
        public async Task<Account> CreateAccount(string shortName, string authorName = null, string authorUrl = null)
        {
            ValidateStringParametr(shortName, nameof(shortName));

            var request = new CreateAccount()
            {
                AuthorName = authorName,
                AuthorUrl = authorUrl,
                ShortName = shortName,
            };

            var result = await SendRequest<Account>(Constants.CreateAccount, GetJsonContent(request));

            return ReturnResult(result);
        }

        /// <summary>
        /// Use this method to update information about a Telegraph account. Pass only the parameters that you want to edit.
        /// <para/><see href="https://telegra.ph/api#editAccountInfo">Telegraph documentation</see>
        /// </summary>
        /// <param name="shortName">New account name.</param>
        /// <param name="authorName">New default author name used when creating new articles.</param>
        /// <param name="authorUrl">New default profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.</param>
        /// <returns>On success, returns an Account object with the default fields.</returns>
        public async Task<Account> EditAccountInfo(string shortName = null, string authorName = null, string authorUrl = null)
        {
            ValidateAccessToken();

            var request = new EditAccountInfo()
            {
                AccessToken = AccessToken,
                AuthorName = authorName,
                AuthorUrl = authorUrl,
                ShortName = shortName,
            };

            var result = await SendRequest<Account>(Constants.EditAccountInfo, GetJsonContent(request));

            return ReturnResult(result);
        }

        /// <summary>
        /// Use this method to get information about a Telegraph account.
        /// <para/><see href="https://telegra.ph/api#getAccountInfo">Telegraph documentation</see>
        /// </summary>
        /// <returns>Returns an Account object on success.</returns>
        public async Task<Account> GetAccountInfo()
        {
            ValidateAccessToken();

            var request = new GetAccountInfo()
            {
                AccessToken = AccessToken
            };

            var result = await SendRequest<Account>(Constants.GetAccountInfo, GetJsonContent(request));

            return ReturnResult(result);
        }

        /// <summary>
        /// Use this method to revoke access_token and generate a new one, for example, if the user would like to reset all connected sessions, or you have reasons to believe the token was compromised.
        /// <para/><see href="https://telegra.ph/api#revokeAccessToken">Telegraph documentation</see>
        /// </summary>
        /// <returns>On success, returns an Account object with new access_token and auth_url fields.</returns>
        public async Task<Account> RevokeAccessToken()
        {
            ValidateAccessToken();

            var request = new AccessTokenRequest()
            {
                AccessToken = AccessToken
            };

            var result = await SendRequest<Account>(Constants.RevokeAccessToken, GetJsonContent(request));

            return ReturnResult(result);
        }

        #endregion

        #region Page

        /// <summary>
        /// Use this method to create a new Telegraph page.
        /// <para/><see href="https://telegra.ph/api#createPage">Telegraph documentation</see>
        /// </summary>
        /// <param name="title">Required. Page title.</param>
        /// <param name="content">Required. Content of the page.</param>
        /// <param name="authorName">Author name, displayed below the article's title.</param>
        /// <param name="authorUrl">Profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.</param>
        /// <returns>On success, returns a Page object.</returns>
        public async Task<Page> CreatePage(string title, List<Node> content, string authorName = null, string authorUrl = null)
        {
            ValidateAccessToken();
            ValidateStringParametr(title, nameof(title));

            if (content == null)
                throw new ArgumentNullException(nameof(content));

            var request = new CreatePage()
            {
                AccessToken = AccessToken,
                Title = title,
                AuthorName = authorName,
                AuthorUrl = authorUrl,
                Content = content
            };

            var result = await SendRequest<Page>(Constants.CreatePage, GetJsonContent(request));

            return ReturnResult(result);
        }

        /// <summary>
        /// Use this method to edit an existing Telegraph page.
        /// <para/><see href="https://telegra.ph/api#editPage">Telegraph documentation</see>
        /// </summary>
        /// <param name="path">Required. Path to the page.</param>
        /// <param name="title">Required. Page title.</param>
        /// <param name="content">Required. Content of the page.</param>
        /// <param name="authorName">Author name, displayed below the article's title.</param>
        /// <param name="authorUrl">Profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.</param>
        /// <returns>On success, returns a Page object.</returns>
        public async Task<Page> EditPage(string path, string title, List<Node> content, string authorName = null, string authorUrl = null)
        {
            ValidateAccessToken();
            ValidateStringParametr(title, nameof(title));
            ValidateStringParametr(path, nameof(path));

            if (content == null)
                throw new ArgumentNullException(nameof(content));

            var request = new EditPage()
            {
                AccessToken = AccessToken,
                Path = path,
                Title = title,
                AuthorName = authorName,
                AuthorUrl = authorUrl,
                Content = content
            };

            var result = await SendRequest<Page>(Constants.EditPage, GetJsonContent(request));

            return ReturnResult(result);
        }

        /// <summary>
        /// Use this method to get a Telegraph page.
        /// <para/><see href="https://telegra.ph/api#getPage">Telegraph documentation</see>
        /// </summary>
        /// <param name="path">Required. Path to the Telegraph page.</param>
        /// <returns>Returns a Page object on success.</returns>
        public async Task<Page> GetPage(string path)
        {
            ValidateStringParametr(path, nameof(path));

            path = GetTelegraphPath(path);

            var request = new GetPage()
            {
                Path = path,
            };

            var result = await SendRequest<Page>(Constants.GetPage, GetJsonContent(request));

            return ReturnResult(result);
        }

        /// <summary>
        /// Use this method to get a list of pages belonging to a Telegraph account.
        /// <para/><see href="https://telegra.ph/api#getPageList">Telegraph documentation</see>
        /// </summary>
        /// <param name="offset">Sequential number of the first page to be returned.</param>
        /// <param name="limit">Limits the number of pages to be retrieved. (0-200)</param>
        /// <returns></returns>
        public async Task<PageList> GetPageList(int offset = 0, int limit = 50)
        {
            ValidateAccessToken();

            var request = new GetPageList()
            {
                AccessToken = AccessToken,
                Offset = offset,
                Limit = limit,
            };

            var result = await SendRequest<PageList>(Constants.GetPageList, GetJsonContent(request));

            return ReturnResult(result);
        }

        /// <summary>
        /// Use this method to get the number of views for a Telegraph article.
        /// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
        /// </summary>
        /// <param name="path">Required. Path to the Telegraph page.</param>
        /// <param name="year">Required if month is passed. If passed, the number of page views for the requested year will be returned.</param>
        /// <param name="month">Required if day is passed. If passed, the number of page views for the requested month will be returned.</param>
        /// <param name="day">Required if hour is passed. If passed, the number of page views for the requested day will be returned.</param>
        /// <param name="hour">If passed, the number of page views for the requested hour will be returned.</param>
        /// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
        public async Task<PageViews> GetViews(string path, int year, int month, int day, int hour)
        {
            return await GetViewsGeneral(path, year, month, day, hour);
        }
        
        /// <summary>
        /// Use this method to get the number of views for a Telegraph article.
        /// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
        /// </summary>
        /// <param name="path">Required. Path to the Telegraph page.</param>
        /// <param name="year">Required if month is passed. If passed, the number of page views for the requested year will be returned.</param>
        /// <param name="month">Required if day is passed. If passed, the number of page views for the requested month will be returned.</param>
        /// <param name="day">Required if hour is passed. If passed, the number of page views for the requested day will be returned.</param>
        /// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
        public async Task<PageViews> GetViews(string path, int year, int month, int day)
        {
            return await GetViewsGeneral(path, year, month, day);
        }

        /// <summary>
        /// Use this method to get the number of views for a Telegraph article.
        /// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
        /// </summary>
        /// <param name="path">Required. Path to the Telegraph page.</param>
        /// <param name="year">Required if month is passed. If passed, the number of page views for the requested year will be returned.</param>
        /// <param name="month">Required if day is passed. If passed, the number of page views for the requested month will be returned.</param>
        /// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
        public async Task<PageViews> GetViews(string path, int year, int month)
        {
            return await GetViewsGeneral(path, year, month);
        }

        /// <summary>
        /// Use this method to get the number of views for a Telegraph article.
        /// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
        /// </summary>
        /// <param name="path">Required. Path to the Telegraph page.</param>
        /// <param name="year">Required if month is passed. If passed, the number of page views for the requested year will be returned.</param>
        /// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
        public async Task<PageViews> GetViews(string path, int year)
        {
            return await GetViewsGeneral(path, year);
        }
        
        /// <summary>
        /// Use this method to get the number of views for a Telegraph article.
        /// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
        /// </summary>
        /// <param name="path">Required. Path to the Telegraph page.</param>
        /// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
        public async Task<PageViews> GetViews(string path)
        {
            return await GetViewsGeneral(path);
        }

        private async Task<PageViews> GetViewsGeneral(string path, int? year = null, int? month = null, int? day = null, int? hour = null)
        {
            ValidateStringParametr(path, nameof(path));

            path = GetTelegraphPath(path);

            var request = new GetViews()
            {
                Path = path,
                Year = year,
                Month = month,
                Day = day,
                Hour = hour,
            };

            var result = await SendRequest<PageViews>(Constants.GetViews, GetJsonContent(request));

            return ReturnResult(result);
        }

        #endregion

        #endregion

        #region Private Methods

        private StringContent GetJsonContent<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType.CharSet = null;
            return content;
        }

        private async Task<TelegraphAPIResponse<T>> SendRequest<T>(string url, StringContent body)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, body);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<TelegraphAPIResponse<T>>(content);

                return result;
            }
        }

        private T ReturnResult<T>(TelegraphAPIResponse<T> result)
        {
            if (result.Ok)
            {
                return result.Result;
            }
            else
            {
                throw new TelegraphException(result.Error);
            }
        }

        private void ValidateAccessToken()
        {
            if (string.IsNullOrEmpty(AccessToken))
                throw new Exception("Please, provide AccessToken.\nclient.AccessToken = token;");

        }
        
        private void ValidateStringParametr(string parametr, string name)
        {
            if (parametr == null)
                throw new ArgumentNullException(name);

            if (parametr == string.Empty)
                throw new ArgumentException("Should not be empty", name);
        }

        private string GetTelegraphPath(string path)
        {
            try
            {
                path = new Regex(@"(http(s)?://telegra.ph/)?(?<path>[^#]+)(#.+)?")
                    .Match(path)
                    .Groups["path"]?
                    .Value;
            }
            catch (Exception)
            {
                throw new ArgumentException("Path is not valid");
            }

            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Path is not valid");

            return path;
        }

        #endregion
    }
}

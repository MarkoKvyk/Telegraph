using System.Collections.Generic;
using System.Threading.Tasks;
using Telegraph.Models;

namespace Telegraph.Contracts;

/// <summary>
///  Interface for Telegraph API client
/// </summary>
public interface ITelegraphClient
{
	/// <summary>
	/// Access token of the Telegraph account.
	/// </summary>
	string AccessToken { get; set; }

	/// <summary>
	/// Use this method to create a new Telegraph account. Most users only need one account, but this can be useful for channel administrators who would like to keep individual author names and profile links for each of their channels.
	/// <para/><see href="https://telegra.ph/api#createAccount">Telegraph documentation</see>
	/// </summary>
	/// <param name="shortName">Required. Account name, helps users with several accounts remember which they are currently using. Displayed to the user above the "Edit/Publish" button on Telegra.ph, other users don't see this name.</param>
	/// <param name="authorName">Default author name used when creating new articles.</param>
	/// <param name="authorUrl">Default profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.</param>
	/// <returns>On success, returns an Account object with the regular fields and an additional access_token field.</returns>
	Task<Account> CreateAccount(string shortName, string authorName = null, string authorUrl = null);

	/// <summary>
	/// Use this method to update information about a Telegraph account. Pass only the parameters that you want to edit.
	/// <para/><see href="https://telegra.ph/api#editAccountInfo">Telegraph documentation</see>
	/// </summary>
	/// <param name="shortName">New account name.</param>
	/// <param name="authorName">New default author name used when creating new articles.</param>
	/// <param name="authorUrl">New default profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.</param>
	/// <returns>On success, returns an Account object with the default fields.</returns>
	Task<Account> EditAccountInfo(string shortName = null, string authorName = null, string authorUrl = null);

	/// <summary>
	/// Use this method to get information about a Telegraph account.
	/// <para/><see href="https://telegra.ph/api#getAccountInfo">Telegraph documentation</see>
	/// </summary>
	/// <returns>Returns an Account object on success.</returns>
	Task<Account> GetAccountInfo();

	/// <summary>
	/// Use this method to revoke access_token and generate a new one, for example, if the user would like to reset all connected sessions, or you have reasons to believe the token was compromised.
	/// <para/><see href="https://telegra.ph/api#revokeAccessToken">Telegraph documentation</see>
	/// </summary>
	/// <returns>On success, returns an Account object with new access_token and auth_url fields.</returns>
	Task<Account> RevokeAccessToken();

	/// <summary>
	/// Use this method to create a new Telegraph page.
	/// <para/><see href="https://telegra.ph/api#createPage">Telegraph documentation</see>
	/// </summary>
	/// <param name="title">Required. Page title.</param>
	/// <param name="content">Required. Content of the page.</param>
	/// <param name="authorName">Author name, displayed below the article's title.</param>
	/// <param name="authorUrl">Profile link, opened when users click on the author's name below the title. Can be any link, not necessarily to a Telegram profile or channel.</param>
	/// <returns>On success, returns a Page object.</returns>
	Task<Page> CreatePage(string title, List<Node> content, string authorName = null,
		string authorUrl = null);

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
	Task<Page> EditPage(string path, string title, List<Node> content, string authorName = null,
		string authorUrl = null);

	/// <summary>
	/// Use this method to get a Telegraph page.
	/// <para/><see href="https://telegra.ph/api#getPage">Telegraph documentation</see>
	/// </summary>
	/// <param name="path">Required. Path to the Telegraph page.</param>
	/// <returns>Returns a Page object on success.</returns>
	Task<Page> GetPage(string path);

	/// <summary>
	/// Use this method to get a list of pages belonging to a Telegraph account.
	/// <para/><see href="https://telegra.ph/api#getPageList">Telegraph documentation</see>
	/// </summary>
	/// <param name="offset">Sequential number of the first page to be returned.</param>
	/// <param name="limit">Limits the number of pages to be retrieved. (0-200)</param>
	/// <returns></returns>
	Task<PageList> GetPageList(int offset = 0, int limit = 50);

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
	Task<PageViews> GetViews(string path, int year, int month, int day, int hour);

	/// <summary>
	/// Use this method to get the number of views for a Telegraph article.
	/// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
	/// </summary>
	/// <param name="path">Required. Path to the Telegraph page.</param>
	/// <param name="year">Required if month is passed. If passed, the number of page views for the requested year will be returned.</param>
	/// <param name="month">Required if day is passed. If passed, the number of page views for the requested month will be returned.</param>
	/// <param name="day">Required if hour is passed. If passed, the number of page views for the requested day will be returned.</param>
	/// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
	Task<PageViews> GetViews(string path, int year, int month, int day);

	/// <summary>
	/// Use this method to get the number of views for a Telegraph article.
	/// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
	/// </summary>
	/// <param name="path">Required. Path to the Telegraph page.</param>
	/// <param name="year">Required if month is passed. If passed, the number of page views for the requested year will be returned.</param>
	/// <param name="month">Required if day is passed. If passed, the number of page views for the requested month will be returned.</param>
	/// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
	Task<PageViews> GetViews(string path, int year, int month);

	/// <summary>
	/// Use this method to get the number of views for a Telegraph article.
	/// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
	/// </summary>
	/// <param name="path">Required. Path to the Telegraph page.</param>
	/// <param name="year">Required if month is passed. If passed, the number of page views for the requested year will be returned.</param>
	/// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
	Task<PageViews> GetViews(string path, int year);

	/// <summary>
	/// Use this method to get the number of views for a Telegraph article.
	/// <para/><see href="https://telegra.ph/api#getViews">Telegraph documentation</see>
	/// </summary>
	/// <param name="path">Required. Path to the Telegraph page.</param>
	/// <returns>Returns a PageViews object on success. By default, the total number of page views will be returned.</returns>
	Task<PageViews> GetViews(string path);

	/// <summary>
	/// Upload files to telegraph cloud
	/// </summary>
	/// <param name="files">Files to upload. Files should be less then 5MB, available MIME types: image/gif, image/jpeg, image/jpg, image/png, video/mp4</param>
	/// <returns>List of uploaded files</returns>
	Task<List<TelegraphFile>> UploadFiles(IEnumerable<FileToUpload> files);

	/// <summary>
	/// Upload file to telegraph cloud
	/// </summary>
	/// <param name="files">File to upload. File should be less then 5MB, available MIME types: image/gif, image/jpeg, image/jpg, image/png, video/mp4</param>
	/// <returns>Uploaded file</returns>
	Task<TelegraphFile> UploadFile(FileToUpload file);
}
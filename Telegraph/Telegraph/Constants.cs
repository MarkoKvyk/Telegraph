using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvyk.Telegraph
{
    internal static class Constants
    {
        public const string TELEGPAPH_API = "https://api.telegra.ph/";

        public const string CREATE_ACCOUNT = "createAccount";
        public const string EDIT_ACCOUNT_INFO = "editAccountInfo";
        public const string GET_ACCOUNT_INFO = "getAccountInfo";
        public const string REVOKE_ACCESS_TOKEN = "revokeAccessToken";
        public const string CREATE_PAGE = "createPage";
        public const string EDIT_PAGE = "editPage";
        public const string GET_PAGE = "getPage";
        public const string GET_PAGE_LIST = "getPageList";
        public const string GET_VIEWS = "getViews";

        public static string CreateAccount => TELEGPAPH_API + CREATE_ACCOUNT;
        public static string EditAccountInfo => TELEGPAPH_API + EDIT_ACCOUNT_INFO;
        public static string GetAccountInfo => TELEGPAPH_API + GET_ACCOUNT_INFO;
        public static string RevokeAccessToken => TELEGPAPH_API + REVOKE_ACCESS_TOKEN;
        public static string CreatePage => TELEGPAPH_API + CREATE_PAGE;
        public static string EditPage => TELEGPAPH_API + EDIT_PAGE;
        public static string GetPage => TELEGPAPH_API + GET_PAGE;
        public static string GetPageList => TELEGPAPH_API + GET_PAGE_LIST;
        public static string GetViews => TELEGPAPH_API + GET_VIEWS;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Niqiu.Core.Domain.Config
{
    public class PortalConfig
    {
        public const string UserCookieName = "portal.user";
        public const string PortalCacheStatic = "portal_cache_static";
        public const string PortalCacheRequest = "portal_cache_per_request";

        public const string WebSiteName = "好油菜";

        public const int QuestionRat = 75;

        public const string SystemEmail = "haoyoucai@163.com";
        public const string SystemWeiXinAppId = "SystemWeiXinAppId";

        public static bool CanAnswerQuesitonMoreThanOneTime = true;
        public static int AnswserTimes = 2;
        public static bool CanAnswerOwnQuestion = false;


        public static bool IsDevelopEnvironment = true;

        public static bool AddFirendNeedAgree = false;

        public static bool CanCancelPraise = false;

        public static bool CanPraiseSelf = false;
    }
}

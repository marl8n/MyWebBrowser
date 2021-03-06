﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyWebBrowser.utils
{
    class UrlUtils
    {
        public static string NormalizeUrl(string url)
        {
            url.Trim();
            // ^(https)?(http)?(://)?\w{3}?\.?\w+\.?\w{3,5}.*$
            // ^([(https)(http)])+(://)?\w{3}?\.?\w+\.?\w{3,5}.*$
            Regex completeUrl = new Regex("^([(https)(http)])+(://)?\\w{3}?\\.?\\w+\\.?\\w{3,5}.*$");

            if ( !completeUrl.IsMatch(url) )
            {
                return $"https://{url}";
            }

            return url;
        }
    }
}

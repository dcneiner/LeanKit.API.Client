﻿//------------------------------------------------------------------------------
// <copyright company="LeanKit Inc.">
//     Copyright (c) LeanKit Inc.  All rights reserved.
// </copyright> 
//------------------------------------------------------------------------------

using System.Configuration;

namespace LeanKit.API.Client.Library
{
	public class LeanKitAccountAuthBase : ILeanKitAccountAuth
	{
		public LeanKitAccountAuthBase()
        {
            UrlTemplateOverride = ConfigurationManager.AppSettings["UrlTemplateOverride"] ?? "https://{0}.leankit.com";
        }

        public string Hostname { get; set; }
        public string UrlTemplateOverride { get; set; }

        public string GetAccountUrl()
        {
            return string.Format(UrlTemplateOverride, Hostname);
        }
	}
}

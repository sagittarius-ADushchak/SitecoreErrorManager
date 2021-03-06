﻿#region Copyright (C) Unic AG

// Copyright (C) Unic AG
// http://www.unic.com
// 
// This module is free software: you can redistribute it and/or modify
// it under the terms of the  GNU Lesser General Public License 
// Version 3.0 as published by the Free Software Foundation.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this module. If not, see http://opensource.org/licenses/lgpl-3.0.

#endregion

using System;
using Unic.SitecoreCMS.Modules.ErrorManager.Controls;

namespace Unic.SitecoreCMS.Modules.ErrorManager.Website.sitecore_modules.Web.Error_Manager
{
    /// <summary>
    /// Page for status code 403 (forbidden). It inherits from the <see cref="BaseError"/>, which does all needed stuff.
    /// </summary>
    /// <author>Kevin Brechbühl - Unic AG</author>
    public partial class _403 : BaseError
    {
        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Load"/> event and sets the settings key and status code for the current error page.
        /// </summary>
        /// <param name="e">The <see cref="T:System.EventArgs"/> object that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            // set properties
            base.SettingsKey = "NoAccessUrl";
            base.StatusCode = 403;

            // go
            base.OnLoad(e);
        }
    }
}
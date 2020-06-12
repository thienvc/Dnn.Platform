﻿
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information


using System;

using DotNetNuke.Framework;

namespace DotNetNuke.Services.Search.Internals
{
    /// <summary>
    /// Internal Search Controller. This is an Internal class and should not be used outside of Core
    /// </summary>
    public class InternalSearchController : ServiceLocator<IInternalSearchController, InternalSearchController>
    {
        protected override Func<IInternalSearchController> GetFactory()
        {
            return () => new InternalSearchControllerImpl();
        }
    }
}

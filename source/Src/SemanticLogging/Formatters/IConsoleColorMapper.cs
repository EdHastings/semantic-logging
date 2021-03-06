﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Diagnostics.Tracing;

namespace Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Formatters
{
    /// <summary>
    /// Provides mapping between an <see cref="EventLevel"/> and a console foreground color.
    /// </summary>
    public interface IConsoleColorMapper
    {
        /// <summary>
        /// Maps the specified <see cref="Microsoft.Diagnostics.Tracing.EventLevel"/> to a <see cref="System.ConsoleColor"/>
        /// </summary>
        /// <param name="eventLevel">The <see cref="Microsoft.Diagnostics.Tracing.EventLevel"/>.</param>
        /// <returns>The <see cref="System.ConsoleColor"/>.</returns>
        ConsoleColor? Map(EventLevel eventLevel);
    }
}

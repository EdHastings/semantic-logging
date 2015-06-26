// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Formatters;

namespace Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects
{
    public class MockDefaultConsoleColorMapper : DefaultConsoleColorMapper
    {
        public ConsoleColor? Color { get; private set; }

        public override ConsoleColor? Map(EventLevel eventLevel)
        {
            this.Color = base.Map(eventLevel);
            return this.Color;
        } 
    }
}

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Metadata.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static class ConventionAnnotatableExtensions
    {
        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public static void SetOrRemoveAnnotation(
           [NotNull] this ConventionAnnotatable annotatable,
           [NotNull] string name,
           [CanBeNull] object value,
           ConfigurationSource configurationSource)
        {
            if (value == null)
            {
                annotatable.RemoveAnnotation(name);
            }
            else
            {
                annotatable.SetAnnotation(name, value, configurationSource);
            }
        }
    }
}
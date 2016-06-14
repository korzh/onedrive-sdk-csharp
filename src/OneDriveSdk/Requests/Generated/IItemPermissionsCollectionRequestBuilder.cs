// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.Graph;

    /// <summary>
    /// The interface IItemPermissionsCollectionRequestBuilder.
    /// </summary>
    public partial interface IItemPermissionsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IItemPermissionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IItemPermissionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPermissionRequestBuilder"/> for the specified Permission.
        /// </summary>
        /// <param name="id">The ID for the Permission.</param>
        /// <returns>The <see cref="IPermissionRequestBuilder"/>.</returns>
        IPermissionRequestBuilder this[string id] { get; }
    }
}
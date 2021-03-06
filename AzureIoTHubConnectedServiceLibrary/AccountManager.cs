﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See license.txt file in the project root for full license information.

using Microsoft.VisualStudio.Services.Client.AccountManagement;
using Microsoft.VisualStudio.WindowsAzure.Authentication;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AzureIoTHubConnectedService
{
    public interface IAzureIoTHubAccountManager
    {
        Task<IEnumerable<IAzureIoTHub>> EnumerateIoTHubAccountsAsync(IAzureRMSubscription subscription, CancellationToken cancellationToken);
        Task<IEnumerable<ResourceGroup>> EnumerateResourceGroupsAsync(IAzureRMSubscription subscription, CancellationToken cancellationToken);

        Task<IEnumerable<ResourceLocation>> EnumerateLocationsAsync(IAzureRMSubscription subscription, CancellationToken cancellationToken);

        Task<IAzureIoTHub> CreateIoTHubAsync(IAzureRMSubscription subscription, IServiceProvider serviceProvider, Account userAccount, string rgName, string location, string hubName, CancellationToken cancellationToken);
        Task<ResourceGroup> CreateResourceGroupAsync(IAzureRMSubscription subscription, IServiceProvider serviceProvider, Account userAccount, string rgName, CancellationToken cancellationToken);
    }
}
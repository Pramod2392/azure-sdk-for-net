// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of DiskEncryptionSet and their operations over a ResourceGroup. </summary>
    public partial class DiskEncryptionSetContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="DiskEncryptionSetContainer"/> class for mocking. </summary>
        protected DiskEncryptionSetContainer()
        {
        }

        /// <summary> Initializes a new instance of DiskEncryptionSetContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DiskEncryptionSetContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DiskEncryptionSetsRestOperations _restClient => new DiskEncryptionSetsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="diskEncryptionSet"/> is null. </exception>
        public virtual Response<DiskEncryptionSet> CreateOrUpdate(string diskEncryptionSetName, DiskEncryptionSetData diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(diskEncryptionSetName, diskEncryptionSet, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="diskEncryptionSet"/> is null. </exception>
        public async virtual Task<Response<DiskEncryptionSet>> CreateOrUpdateAsync(string diskEncryptionSetName, DiskEncryptionSetData diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(diskEncryptionSetName, diskEncryptionSet, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="diskEncryptionSet"/> is null. </exception>
        public virtual DiskEncryptionSetCreateOrUpdateOperation StartCreateOrUpdate(string diskEncryptionSetName, DiskEncryptionSetData diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken);
                return new DiskEncryptionSetCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="diskEncryptionSet"/> is null. </exception>
        public async virtual Task<DiskEncryptionSetCreateOrUpdateOperation> StartCreateOrUpdateAsync(string diskEncryptionSetName, DiskEncryptionSetData diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken).ConfigureAwait(false);
                return new DiskEncryptionSetCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DiskEncryptionSet> Get(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.Get");
            scope.Start();
            try
            {
                if (diskEncryptionSetName == null)
                {
                    throw new ArgumentNullException(nameof(diskEncryptionSetName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DiskEncryptionSet>> GetAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.Get");
            scope.Start();
            try
            {
                if (diskEncryptionSetName == null)
                {
                    throw new ArgumentNullException(nameof(diskEncryptionSetName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiskEncryptionSet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DiskEncryptionSet> GetIfExists(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetIfExists");
            scope.Start();
            try
            {
                if (diskEncryptionSetName == null)
                {
                    throw new ArgumentNullException(nameof(diskEncryptionSetName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DiskEncryptionSet>(null, response.GetRawResponse())
                    : Response.FromValue(new DiskEncryptionSet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DiskEncryptionSet>> GetIfExistsAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetIfExists");
            scope.Start();
            try
            {
                if (diskEncryptionSetName == null)
                {
                    throw new ArgumentNullException(nameof(diskEncryptionSetName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DiskEncryptionSet>(null, response.GetRawResponse())
                    : Response.FromValue(new DiskEncryptionSet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (diskEncryptionSetName == null)
                {
                    throw new ArgumentNullException(nameof(diskEncryptionSetName));
                }

                var response = GetIfExists(diskEncryptionSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (diskEncryptionSetName == null)
                {
                    throw new ArgumentNullException(nameof(diskEncryptionSetName));
                }

                var response = await GetIfExistsAsync(diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the disk encryption sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskEncryptionSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskEncryptionSet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiskEncryptionSet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DiskEncryptionSet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the disk encryption sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskEncryptionSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskEncryptionSet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskEncryptionSet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DiskEncryptionSet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DiskEncryptionSet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DiskEncryptionSetOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DiskEncryptionSet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DiskEncryptionSetOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, DiskEncryptionSet, DiskEncryptionSetData> Construct() { }
    }
}

// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedApplicationServiceClientSnippets
    {
        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationRequestObject()
        {
            // Snippet: CreateApplication(CreateApplicationRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            // Make the request
            Application response = applicationServiceClient.CreateApplication(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationRequestObjectAsync()
        {
            // Snippet: CreateApplicationAsync(CreateApplicationRequest, CallSettings)
            // Additional: CreateApplicationAsync(CreateApplicationRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplication()
        {
            // Snippet: CreateApplication(string, Application, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            Application application = new Application();
            // Make the request
            Application response = applicationServiceClient.CreateApplication(parent, application);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationAsync()
        {
            // Snippet: CreateApplicationAsync(string, Application, CallSettings)
            // Additional: CreateApplicationAsync(string, Application, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            Application application = new Application();
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(parent, application);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationResourceNames()
        {
            // Snippet: CreateApplication(ProfileName, Application, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            ProfileName parent = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            Application application = new Application();
            // Make the request
            Application response = applicationServiceClient.CreateApplication(parent, application);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationResourceNamesAsync()
        {
            // Snippet: CreateApplicationAsync(ProfileName, Application, CallSettings)
            // Additional: CreateApplicationAsync(ProfileName, Application, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProfileName parent = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            Application application = new Application();
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(parent, application);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationRequestObject()
        {
            // Snippet: GetApplication(GetApplicationRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            // Make the request
            Application response = applicationServiceClient.GetApplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationRequestObjectAsync()
        {
            // Snippet: GetApplicationAsync(GetApplicationRequest, CallSettings)
            // Additional: GetApplicationAsync(GetApplicationRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            // Make the request
            Application response = await applicationServiceClient.GetApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplication()
        {
            // Snippet: GetApplication(string, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]/applications/[APPLICATION]";
            // Make the request
            Application response = applicationServiceClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationAsync()
        {
            // Snippet: GetApplicationAsync(string, CallSettings)
            // Additional: GetApplicationAsync(string, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]/applications/[APPLICATION]";
            // Make the request
            Application response = await applicationServiceClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationResourceNames()
        {
            // Snippet: GetApplication(ApplicationName, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            // Make the request
            Application response = applicationServiceClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationResourceNamesAsync()
        {
            // Snippet: GetApplicationAsync(ApplicationName, CallSettings)
            // Additional: GetApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            // Make the request
            Application response = await applicationServiceClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplicationRequestObject()
        {
            // Snippet: UpdateApplication(UpdateApplicationRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Application response = applicationServiceClient.UpdateApplication(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationRequestObjectAsync()
        {
            // Snippet: UpdateApplicationAsync(UpdateApplicationRequest, CallSettings)
            // Additional: UpdateApplicationAsync(UpdateApplicationRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Application response = await applicationServiceClient.UpdateApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplication()
        {
            // Snippet: UpdateApplication(Application, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            Application application = new Application();
            // Make the request
            Application response = applicationServiceClient.UpdateApplication(application);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationAsync()
        {
            // Snippet: UpdateApplicationAsync(Application, CallSettings)
            // Additional: UpdateApplicationAsync(Application, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Application application = new Application();
            // Make the request
            Application response = await applicationServiceClient.UpdateApplicationAsync(application);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationRequestObject()
        {
            // Snippet: DeleteApplication(DeleteApplicationRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            // Make the request
            applicationServiceClient.DeleteApplication(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationRequestObjectAsync()
        {
            // Snippet: DeleteApplicationAsync(DeleteApplicationRequest, CallSettings)
            // Additional: DeleteApplicationAsync(DeleteApplicationRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            // Make the request
            await applicationServiceClient.DeleteApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplication()
        {
            // Snippet: DeleteApplication(string, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]/applications/[APPLICATION]";
            // Make the request
            applicationServiceClient.DeleteApplication(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationAsync()
        {
            // Snippet: DeleteApplicationAsync(string, CallSettings)
            // Additional: DeleteApplicationAsync(string, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]/applications/[APPLICATION]";
            // Make the request
            await applicationServiceClient.DeleteApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationResourceNames()
        {
            // Snippet: DeleteApplication(ApplicationName, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            // Make the request
            applicationServiceClient.DeleteApplication(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationResourceNamesAsync()
        {
            // Snippet: DeleteApplicationAsync(ApplicationName, CallSettings)
            // Additional: DeleteApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            // Make the request
            await applicationServiceClient.DeleteApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsRequestObject()
        {
            // Snippet: ListApplications(ListApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsRequestObjectAsync()
        {
            // Snippet: ListApplicationsAsync(ListApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplicationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplications()
        {
            // Snippet: ListApplications(string, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsAsync()
        {
            // Snippet: ListApplicationsAsync(string, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsResourceNames()
        {
            // Snippet: ListApplications(ProfileName, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            ProfileName parent = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsResourceNamesAsync()
        {
            // Snippet: ListApplicationsAsync(ProfileName, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProfileName parent = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}

﻿//----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//----------------------------------------------------------------------

using System.IO;
using System.Net;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Test.ADAL.NET.Unit.Mocks
{
    internal class MockHttpWebResponse : IHttpWebResponse
    {
        public MockHttpWebResponse()
        {
            Headers = new WebHeaderCollection();    
        }

        public void Dispose()
        {
        }

        public Stream Stream { get; set; }

        public HttpStatusCode StatusCode { get; internal set; }

        public WebHeaderCollection Headers { get; internal set; }

        public Stream GetResponseStream()
        {
            return Stream;
        }

        public void Close()
        {
            if (Stream != null)
            {
                Stream.Close();
            }
        }
    }
}

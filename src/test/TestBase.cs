//-----------------------------------------------------------------------------
// <copyright file="TestBase.cs" company="Amazon.com">
//      Copyright 2020 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//
//      Licensed under the Apache License, Version 2.0 (the "License").
//      You may not use this file except in compliance with the License.
//      A copy of the License is located at
//
//      http://aws.amazon.com/apache2.0
//
//      or in the "license" file accompanying this file. This file is distributed
//      on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
//      express or implied. See the License for the specific language governing
//      permissions and limitations under the License.
// </copyright>
//-----------------------------------------------------------------------------

using Amazon.XRay.Recorder.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amazon.XRay.Recorder.AutoInstrumentation.Unittests
{
    public class TestBase
    {
        protected static readonly string TraceId = Core.Internal.Entities.TraceId.NewId();

        [TestCleanup]
        public void TestCleanup()
        {
            AWSXRayRecorder.Instance.TraceContext.ClearEntity();
        }
    }
}

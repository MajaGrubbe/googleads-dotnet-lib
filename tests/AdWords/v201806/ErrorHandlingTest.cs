﻿// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Ads.AdWords.v201806;

using NUnit.Framework;

using CSharpExamples = Google.Api.Ads.AdWords.Examples.CSharp.v201806;
using VBExamples = Google.Api.Ads.AdWords.Examples.VB.v201806;

namespace Google.Api.Ads.AdWords.Tests.v201806 {

  /// <summary>
  /// Test cases for all the code examples under v201806\ErrorHandling.
  /// </summary>
  internal class ErrorHandlingTest : VersionedExampleTestsBase {
    private long campaignId;
    private long adGroupId;

    /// <summary>
    /// Inits this instance.
    /// </summary>
    [SetUp]
    public void Init() {
      campaignId = utils.CreateSearchCampaign(user, BiddingStrategyType.MANUAL_CPC);
      adGroupId = utils.CreateAdGroup(user, campaignId);
    }

    /// <summary>
    /// Tests the HandlePartialFailures VB.NET code example.
    /// </summary>
    [Test]
    public void TestHandlePartialFailuresVBExample() {
      RunExample(delegate () {
        new VBExamples.HandlePartialFailures().Run(user, adGroupId);
      });
    }

    /// <summary>
    /// Tests the HandlePartialFailures C# code example.
    /// </summary>
    [Test]
    public void TestHandlePartialFailuresCSharpExample() {
      RunExample(delegate () {
        new CSharpExamples.HandlePartialFailures().Run(user, adGroupId);
      });
    }

    /// <summary>
    /// Tests the HandlePolicyViolationError VB.NET code example.
    /// </summary>
    [Test]
    public void TestHandlePolicyViolationErrorVBExample() {
      RunExample(delegate () {
        new VBExamples.HandlePolicyViolationError().Run(user, adGroupId);
      });
    }

    /// <summary>
    /// Tests the HandlePolicyViolationError C# code example.
    /// </summary>
    [Test]
    public void TestHandlePolicyViolationErrorCSharpExample() {
      RunExample(delegate () {
        new CSharpExamples.HandlePolicyViolationError().Run(user, adGroupId);
      });
    }
  }
}

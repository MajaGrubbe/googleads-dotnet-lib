// Copyright 2011, Google Inc. All Rights Reserved.
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

// Author: api.anash@gmail.com (Anash P. Oommen)

using Google.Api.Ads.Dfp.Lib;
using Google.Api.Ads.Dfp.v201107;

using System;

namespace Google.Api.Ads.Dfp.Examples.v201107 {
  /// <summary>
  /// This code example gets all ad unit sizes in the network.
  ///
  /// Tags: InventoryService.getAdUnitSizes
  /// </summary>
  class GetAdUnitSizes : SampleBase {
    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description {
      get {
        return "This code example gets all ad unit sizes in the network.";
      }
    }

    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      SampleBase codeExample = new GetAdUnitSizes();
      Console.WriteLine(codeExample.Description);
      codeExample.Run(new DfpUser());
    }

    /// <summary>
    /// Run the code example.
    /// </summary>
    /// <param name="user">The DFP user object running the code example.</param>
    public override void Run(DfpUser user) {
      // Get the InventoryService.
      InventoryService inventoryService =
          (InventoryService) user.GetService(DfpService.v201107.InventoryService);

      try {
        // Get all ad unit sizes.
        AdUnitSize[] adUnitSizes = inventoryService.getAdUnitSizes();

        // Display results.
        if (adUnitSizes != null) {
          for (int i = 0; i < adUnitSizes.Length; i++) {
            AdUnitSize adUnitSize = adUnitSizes[i];
            Console.WriteLine("{0}) Ad unit size ({1}x{2}) was found.\n", i,
                adUnitSize.size.width, adUnitSize.size.height);
          }
        } else {
          Console.WriteLine("No ad unit sizes found.");
        }
      } catch (Exception ex) {
        Console.WriteLine("Failed to get ad unit sizes. Exception says \"{0}\"", ex.Message);
      }
    }
  }
}

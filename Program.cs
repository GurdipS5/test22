using System.Collections.Generic;
using Pulumi;

return await Deployment.RunAsync(() =>
{
   // Add your resources here ssdffds
   // e.g. var resource = new Resource("name", new ResourceArgs { });

   // Export outputs here
   return new Dictionary<string, object?>
   {
      ["outputKey"] = "outputValue"
   };
});

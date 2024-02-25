using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Helpers.Plugin;
using System.Linq;

namespace Rappen.XRM.Helpers.PluginTest
{
    public class PluginMultipleRecords : PluginBase
    {
        public override void Execute(PluginBag bag)
        {
            bag.Logger.Log($"{bag.EntityTypeCollection.Count()} records");
            foreach (var recordtypes in bag.EntityTypeCollection)
            {
                var account = recordtypes.Target;
                bag.Logger.Log($"Checking {recordtypes.Complete["name"]}");
                var preimage = recordtypes.PreImage;
                var newfax = account.GetAttributeValue("fax", string.Empty);
                var prefax = preimage.GetAttributeValue("fax", string.Empty);
                if (string.IsNullOrEmpty(newfax) != string.IsNullOrEmpty(prefax))
                {
                    throw new InvalidPluginExecutionException("If you have fax, you have fax. If not, you'll never get a fax.");
                }
            }
        }
    }
}
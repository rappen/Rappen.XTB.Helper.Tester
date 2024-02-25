using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Helpers.Plugin;

namespace Rappen.XRM.Helpers.PluginTest
{
    public class PluginMultipleRecords : PluginBase
    {
        public override void Execute(PluginBag bag)
        {
            foreach (var recordtypes in bag.EntityTypeCollection)
            {
                var account = recordtypes.Target;
                var preimage = recordtypes.PreImage;

                VerifyFax(account, preimage);
            }
        }

        private static void VerifyFax(Entity account, Entity preimage)
        {
            var newfax = account.GetAttributeValue("fax", string.Empty);
            var prefax = preimage.GetAttributeValue("fax", string.Empty);
            if (string.IsNullOrEmpty(newfax) != string.IsNullOrEmpty(prefax))
            {
                throw new InvalidPluginExecutionException("If you have fax, you have fax. If not, you'll never get a fax.");
            }
        }
    }
}
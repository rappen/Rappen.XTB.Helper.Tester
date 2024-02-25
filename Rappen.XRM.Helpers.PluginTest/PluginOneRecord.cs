using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Helpers.Plugin;

namespace Rappen.XRM.Helpers.PluginTest
{
    public class PluginOneRecord : PluginBase
    {
        public override void Execute(PluginBag bag)
        {
            var account = bag.EntityType.Target;
            bag.Logger.Log($"Checking {bag.EntityType.Complete["name"]}");
            var preimage = bag.EntityType.PreImage;
            var newfax = account.GetAttributeValue("fax", string.Empty);
            var prefax = preimage.GetAttributeValue("fax", string.Empty);
            if (string.IsNullOrEmpty(newfax) != string.IsNullOrEmpty(prefax))
            {
                throw new InvalidPluginExecutionException("If you have fax, you have fax. If not, you'll never get a fax.");
            }
        }
    }
}
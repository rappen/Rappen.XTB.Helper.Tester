using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Helpers.Plugin;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace Rappen.XRM.Helpers.PluginTest
{
    public class PluginOneRecord : PluginBase
    {
        public override void Execute(PluginBag bag)
        {
            var account = bag.ContextEntity[ContextEntityType.Complete];
            var preimage = bag.ContextEntity[ContextEntityType.PreImage];

            Features.VerifyRevenue(bag.Logger, account, preimage);

            var primaryContact = account.GetAttributeValue("primarycontactid", new EntityReference());
            if (!primaryContact.Id.Equals(Guid.Empty))
            {
                Features.SummarizeBossRevenues(bag, primaryContact);
            }
        }
    }
}
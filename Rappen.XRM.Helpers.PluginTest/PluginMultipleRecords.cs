using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Helpers.Plugin;
using System;
using System.Linq;

namespace Rappen.XRM.Helpers.PluginTest
{
    public class PluginMultipleRecords : PluginBase
    {
        public override void Execute(PluginBag bag)
        {
            bag.ContextEntityCollection.ToList()
                .ForEach(cec => Features.VerifyRevenue(bag.Logger, cec[ContextEntityType.Complete], cec[ContextEntityType.PreImage]));

            var primaryContacts = bag.ContextEntityCollection
                 .Select(cec => cec[ContextEntityType.Complete].GetAttributeValue("primarycontactid", new EntityReference()))
                 .Where(c => !c.Id.Equals(Guid.Empty))
                 .Distinct();
            primaryContacts.ToList().ForEach(c => Features.SummarizeBossRevenues(bag, c));
        }
    }
}
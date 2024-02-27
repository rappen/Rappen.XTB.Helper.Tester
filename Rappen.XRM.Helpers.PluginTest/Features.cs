using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Helpers.Interfaces;
using System.Linq;

namespace Rappen.XRM.Helpers.PluginTest
{
    internal static class Features
    {
        internal static void VerifyRevenue(ILogger log, Entity account, Entity preaccount)
        {
            var nowRev = account.GetAttributeValue("revenue", new Money()).Value;
            var preRev = preaccount.GetAttributeValue("revenue", new Money()).Value;
            if (preRev > 0 && nowRev <= 0)
            {
                throw new InvalidPluginExecutionException($"Accounts can't decrease revenue. {account["name"]} is wrong.");
            }
            log.Log($"{account["name"]} looks ok.");
        }

        internal static void SummarizeBossRevenues(IBag bag, EntityReference contactRef) => SummarizeBossRevenues(bag.Service, bag.Logger as ITracingService, contactRef);

        internal static void SummarizeBossRevenues(IOrganizationService service, ITracingService logger, EntityReference contactRef)
        {
            logger.Trace($"Summarizing {contactRef.Name ?? (contactRef.LogicalName + " " + contactRef.Id)}");
            var accRevs = service.RetrieveMultiple(new QueryExpression("account")
            {
                ColumnSet = new ColumnSet("name", "revenue"),
                Criteria =
                {
                    Conditions =
                    {
                        new ConditionExpression("statecode", ConditionOperator.Equal, 0),
                        new ConditionExpression("primarycontactid", ConditionOperator.Equal, contactRef.Id)
                    }
                }
            });

            var sumRev = accRevs.Entities.Sum(e => e.GetAttributeValue("revenue", new Money()).Value);
            var contact = new Entity(contactRef.LogicalName, contactRef.Id);
            contact["description"] = $"Total revenues: {sumRev:0}";
            service.Update(contact);
        }
    }
}
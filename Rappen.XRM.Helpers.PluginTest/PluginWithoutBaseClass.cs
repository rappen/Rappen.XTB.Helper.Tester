using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Helpers.Plugin;
using System;
using System.Linq;

namespace Rappen.XRM.Helpers.PluginTest
{
    public class PluginWithoutBaseClass
    {
        public class PluginOneRecordRaw : IPlugin
        {
            public void Execute(IServiceProvider serviceProvider)
            {
                var logger = new PluginLogger(serviceProvider);
                var Context = (IPluginExecutionContext5)serviceProvider.GetService(typeof(IPluginExecutionContext5));
                var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                var Service = serviceFactory.CreateOrganizationService(Context.InitiatingUserId);

                var account = Context.InputParameters["Target"] as Entity;
                var preimage = Context.PreEntityImages.FirstOrDefault().Value;

                Features.VerifyRevenue(logger, account, preimage);

                var primaryContact = account.GetAttributeValue("primarycontactid", new EntityReference());
                if (!primaryContact.Id.Equals(Guid.Empty))
                {
                    Features.SummarizeBossRevenues(Service, logger, primaryContact);
                }
            }
        }

        public class PluginMultipleRecordsRaw : IPlugin
        {
            public void Execute(IServiceProvider serviceProvider)
            {
                var logger = new PluginLogger(serviceProvider);
                var Context = (IPluginExecutionContext5)serviceProvider.GetService(typeof(IPluginExecutionContext5));
                var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                var Service = serviceFactory.CreateOrganizationService(Context.InitiatingUserId);

                var entities = Context.InputParameters["Targets"] as EntityCollection;

                for (var i = 0; i < entities.Entities.Count; i++)
                {
                    var account = entities.Entities[i];
                    var preimage = Context.PreEntityImagesCollection[i].FirstOrDefault().Value;

                    Features.VerifyRevenue(logger, account, preimage);

                    var primaryContact = account.GetAttributeValue("primarycontactid", new EntityReference());
                    if (!primaryContact.Id.Equals(Guid.Empty))
                    {
                        Features.SummarizeBossRevenues(Service, logger, primaryContact);
                    }
                }
            }
        }
    }
}
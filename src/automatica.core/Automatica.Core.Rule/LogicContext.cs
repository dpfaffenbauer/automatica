﻿using Automatica.Core.Base.IO;
using Automatica.Core.Base.License;
using Automatica.Core.Base.Templates;
using Automatica.Core.EF.Models;
using Microsoft.Extensions.Logging;

namespace Automatica.Core.Logic
{
    /// <summary>
    /// Implementation of the <see cref="ILogicContext"/>
    /// </summary>
    public class LogicContext : ILogicContext
    {
        public LogicContext(RuleInstance ruleInstance, IDispatcher dispatcher, ILogicTemplateFactory factory, IRuleInstanceVisuNotify notify, ILogger logger, IServerCloudApi api, ILicenseContract licenseContract)
        {
            RuleInstance = ruleInstance;
            Dispatcher = dispatcher;
            Factory = factory;
            Notify = notify;
            Logger = logger;
            CloudApi = api;
            LicenseContract = licenseContract;
        }

        public RuleInstance RuleInstance { get; }
        public IDispatcher Dispatcher { get; }
        public ILogicTemplateFactory Factory { get; }
        public IRuleInstanceVisuNotify Notify { get; }

        public ILogger Logger { get; }
        public IServerCloudApi CloudApi { get; }

        public ILicenseContract LicenseContract { get; }
    }
}

﻿using Microsoft.AspNetCore.Modules;
using Microsoft.Extensions.DependencyInjection;
using Orchard.MetaWeblog;

namespace Orchard.Markdown.RemotePublishing
{

    [Feature("Orchard.RemotePublishing")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMetaWeblogDriver, MarkdownMetaWeblogDriver>();
        }
    }
}

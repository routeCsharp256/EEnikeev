using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace OzonEdu.merchandise_service.Infrastructure.StartupFilters
{
    public class SwaggerStartupFilter: IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                next(app);
            };
        }
    }
}
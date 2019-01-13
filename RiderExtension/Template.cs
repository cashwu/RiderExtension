using JetBrains.Annotations;

namespace RiderExtension
{
    public static class Template
    {
        [SourceTemplateAttribute]
        [Macro(Target = "dbcontext", Editable = 1)]
        public static void _dbcontext<T>(this T source)
        {
            /*$ 
             services.AddDbContext<$dbcontext$>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"), optionsBuilder =>
                {
                    optionsBuilder.CommandTimeout(30);
                    optionsBuilder.EnableRetryOnFailure(3, TimeSpan.FromSeconds(10), new List<string>());
                    optionsBuilder.RemoteCertificateValidationCallback((sender, certificate, chain, errors) => true);
                });
                options.EnableSensitiveDataLogging();
            });*/
        }
    }
}
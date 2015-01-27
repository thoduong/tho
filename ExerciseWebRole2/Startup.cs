using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExerciseWebRole2.Startup))]
namespace ExerciseWebRole2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

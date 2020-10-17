using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieQuiz.Startup))]
namespace MovieQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

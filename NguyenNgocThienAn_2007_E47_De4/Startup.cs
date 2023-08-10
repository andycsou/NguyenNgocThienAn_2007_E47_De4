using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenNgocThienAn_2007_E47_De4.Startup))]
namespace NguyenNgocThienAn_2007_E47_De4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

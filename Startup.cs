using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using ScoolManagement_3.Models;

[assembly: OwinStartupAttribute(typeof(ScoolManagement_3.Startup))]
namespace ScoolManagement_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }
        public void CreateRolesandUsers()
        {
            var context = new ApplicationDbContext();
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@schm.com",
                BirthDate = System.DateTime.Now
            };
            var password = "password";
            var usr = usermanager.Create(user, password);
            if (usr.Succeeded)
            {
                var result = usermanager.AddToRole(user.Id, "Admin");
            }
            if (!rolemanager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                rolemanager.Create(role);}
            if (!rolemanager.RoleExists("Teacher"))
            {
                var role = new IdentityRole();
                role.Name = "Teacher";
                rolemanager.Create(role);
            }
            if (!rolemanager.RoleExists("Supervisor"))
            {
                var role = new IdentityRole();
                role.Name = "Supervisor";
                rolemanager.Create(role);
            }



            }
    }

   
}

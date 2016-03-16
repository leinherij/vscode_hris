using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using HRISVSC.Models;
using HRISVSC.Repository;

namespace HRISVSC
{
    public class Startup
    {
        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
            Configuration["Data:DefaultConnection:ConnectionString"] = 

            $@"Data Source=Noah-pc;Initial Catalog=hris_atlantic;Persist Security Info=True;User ID=sa;Password=innosoft";
            //$@"Data Source=SimeoNoeme-PC;Initial Catalog=hris_atlantic;Persist Security Info=True;User ID=sa;Password=SimeoNoeme";
        }

        public IConfigurationRoot Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            var conn = Configuration["Data:DefaultConnection:ConnectionString"];
            services.AddEntityFramework()
            .AddSqlServer()
            .AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conn));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();
            
            services.AddScoped<MstAccountRI, MstAccountR>();
            services.AddScoped<MstBranchRI, MstBranchR>();
            services.AddScoped<MstCitizenshipRI, MstCitizenshipR>();
            services.AddScoped<MstCompanyRI, MstCompanyR>();
            services.AddScoped<MstDayTypeDayRI, MstDayTypeDayR>();
            services.AddScoped<MstDayTypeRI, MstDayTypeR>();
            services.AddScoped<MstDepartmentRI, MstDepartmentR>();
            services.AddScoped<MstDivisionRI, MstDivisionR>();
            services.AddScoped<MstEmployeeLoanRI, MstEmployeeLoanR>();
            services.AddScoped<MstEmployeeMemoRI, MstEmployeeMemoR>();
            services.AddScoped<MstEmployeeRI, MstEmployeeR>();
            services.AddScoped<MstEmployeeShiftCodeRI, MstEmployeeShiftCodeR>();
            services.AddScoped<MstLeaveRI, MstLeaveR>();
            services.AddScoped<MstMandatoryTableRI, MstMandatoryTableR>();
            services.AddScoped<MstMonthRI, MstMonthR>();
            services.AddScoped<MstOtherDeductionRI, MstOtherDeductionR>();
            services.AddScoped<MstOtherIncomeRI, MstOtherIncomeR>();
            services.AddScoped<MstPayrollGroupRI, MstPayrollGroupR>();
            services.AddScoped<MstPayrollTypeRI, MstPayrollTypeR>();
            services.AddScoped<MstPeriodRI, MstPeriodR>();
            services.AddScoped<MstPositionRI, MstPositionR>();
            services.AddScoped<MstReligionRI, MstReligionR>();
            services.AddScoped<MstShiftCodeDayRI, MstShiftCodeDayR>();
            services.AddScoped<MstShiftCodeRI, MstShiftCodeR>();
            services.AddScoped<MstTableHDMFRI, MstTableHDMFR>();
            services.AddScoped<MstTablePHICRI, MstTablePHICR>();
            services.AddScoped<MstTableSSSRI, MstTableSSSR>();
            services.AddScoped<MstTableWTaxMonthlyRI, MstTableWTaxMonthlyR>();
            services.AddScoped<MstTableWTaxSemiMonthlyRI, MstTableWTaxSemiMonthlyR>();
            services.AddScoped<MstTableWTaxYearlyRI, MstTableWTaxYearlyR>();
            services.AddScoped<MstTaxCodeRI, MstTaxCodeR>();
            services.AddScoped<MstUserRI, MstUserR>();
            services.AddScoped<MstUserFormRI, MstUserFormR>();
            services.AddScoped<MstUserPayrollGroupRI, MstUserPayrollGroupR>();
            services.AddScoped<MstZipCodeRI, MstZipCodeR>();
            services.AddScoped<SysFormRI, SysFormR>();
            services.AddScoped<TrnChangeShiftRI, TrnChangeShiftR>();
            services.AddScoped<TrnChangeShiftLineRI, TrnChangeShiftLineR>();
            services.AddScoped<TrnDTRRI, TrnDTRR>();
            services.AddScoped<TrnDTRLineRI, TrnDTRLineR>();
            services.AddScoped<TrnDTRLogRI, TrnDTRLogR>();
            services.AddScoped<TrnLastWithholdingTaxRI, TrnLastWithholdingTaxR>();
            services.AddScoped<TrnLastWithholdingTaxLineRI, TrnLastWithholdingTaxLineR>();
            services.AddScoped<TrnLeaveApplicationRI, TrnLeaveApplicationR>();
            services.AddScoped<TrnLeaveApplicationLineRI, TrnLeaveApplicationLineR>();
            services.AddScoped<TrnLeaveLedgerRI, TrnLeaveLedgerR>();
            services.AddScoped<TrnLoanLedgerRI, TrnLoanLedgerR>();
            services.AddScoped<TrnOverTimeRI, TrnOverTimeR>();
            services.AddScoped<TrnOverTimeLineRI, TrnOverTimeLineR>();
            services.AddScoped<TrnPayrollRI, TrnPayrollR>();
            services.AddScoped<TrnPayrollLineRI, TrnPayrollLineR>();
            services.AddScoped<TrnPayrollOtherDeductionRI, TrnPayrollOtherDeductionR>();
            services.AddScoped<TrnPayrollOtherDeductionLineRI, TrnPayrollOtherDeductionLineR>();
            services.AddScoped<TrnPayrollOtherIncomeRI, TrnPayrollOtherIncomeR>();
            services.AddScoped<TrnPayrollOtherIncomeLineRI, TrnPayrollOtherIncomeLineR>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                try
                {
                    using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                        .CreateScope())
                    {
                        serviceScope.ServiceProvider.GetService<ApplicationDbContext>()
                             .Database.Migrate();
                    }
                }
                catch { }
            }

            app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

            app.UseStaticFiles();

            app.UseIdentity();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");                   
            });            
        }

        public static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
    }
}

using Microsoft.AspNetCore.Builder;
using AdminLTEPro;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AdminLTEProWebTestModule>();

public partial class Program
{
}

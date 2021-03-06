using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ScaffoldingAndGrpc
{
    public class Program
    {
        public static Greeter2.Greeter2Client Useless { get; set; }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void GrpcOutOfTreeProtoDef()
        {
            Useless = new Greeter2.Greeter2Client(GrpcChannel.ForAddress("invalid"));
        }
    }
}

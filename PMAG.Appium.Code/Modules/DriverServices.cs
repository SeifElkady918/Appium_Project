using DriverService_gRPC;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAG.CU.Appium.Code.Modules
{
    public class DriverService : DriverService_gRPC.DriverService_gRPC.DriverService_gRPCBase
    {
        public readonly Driver driver;

        public DriverService(Driver driver)
        {
            this.driver = driver;
        }

        public override Task<OpenSettingsResponse> OpenSettings(OpenSettingsRequest request, ServerCallContext context)
        {
            driver.OpenSettings();
            return Task.FromResult(new OpenSettingsResponse());
        }
    }
}

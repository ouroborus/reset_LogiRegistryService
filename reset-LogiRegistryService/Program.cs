using System.ServiceProcess;

namespace reset_LogiRegistryService {
    class Program {
        static int Main(string[] args) {
            ServiceController serviceController = new ServiceController("LogiRegistryService");
            try {
                if (serviceController.Status.Equals(ServiceControllerStatus.Running)) {
                    serviceController.Stop();
                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                    serviceController.Start();
                    serviceController.WaitForStatus(ServiceControllerStatus.Running);
                }
            }
            catch {
                return -1;
            }
            return 0;
        }
    }
}

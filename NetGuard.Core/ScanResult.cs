/*
needs

hostname -> string
can be reached -> bool
ports -> list  ,   status (opeb or closed)

*/
namespace NetGuard.Core{
    public class ScanResult{
        public string? Hostname { get; set; }
        public bool IsReachable { get; set; }
        public List<PortResult> Ports { get; set; } = new List<PortResult>();

    }
}
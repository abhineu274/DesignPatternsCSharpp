namespace DesignPatternsCSharpp.Structural
{
    // Target interface
    public interface ITarget
    {
        void Request();
    }

    // Adaptee (incompatible)
    public class LegacyService
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest() in LegacyService.");
        }
    }

    // Adapter
    public class Adapter : ITarget
    {
        private readonly LegacyService _legacyService;

        public Adapter(LegacyService legacyService)
        {
            _legacyService = legacyService;
        }

        public void Request()
        {
            _legacyService.SpecificRequest();
        }
    }

    public static class AdapterPattern
    {
        public static void Run()
        {
            //Here, the Adapter Pattern is being used to adapt the LegacyService to the ITarget interface.
            //This allows the client code to interact with the LegacyService without modifying it.
            //The Adapter class implements the ITarget interface and uses an instance of LegacyService to fulfill the request.
            // This example demonstrates the Adapter Pattern by adapting a legacy service to a new interface.

            Console.WriteLine("Running Adapter Pattern Example:");
            LegacyService legacyService = new LegacyService();
            ITarget target = new Adapter(legacyService);

            target.Request();
        }
    }
}

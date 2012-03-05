
using StructureMap;



namespace MvcMusicStore {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            
                          // x.For<IBar>().Use<Bar>();
                        });
            return ObjectFactory.Container;
        }
    }
}
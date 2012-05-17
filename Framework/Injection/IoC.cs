using StructureMap;

namespace Framework.Injection
{
    public static class IoC
    {
        public static T Resolve<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }

        public static T Resolve<T>(string name)
        {
            return ObjectFactory.GetNamedInstance<T>(name);
        }

        public static void BuildUp(object target)
        {
            ObjectFactory.BuildUp(target);
        }
    }
}

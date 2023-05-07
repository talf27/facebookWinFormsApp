using System;
using System.Reflection;

namespace BasicFacebookFeatures
{
    internal static class Singleton<T>
        where T : class
    {
        private static volatile T s_Instance = null;
        private static object s_LockObj = new object();

        static Singleton()
        {
        }

        internal static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            ConstructorInfo constructor = null;

                            try
                            {
                                constructor = typeof(T).GetConstructor(
                                    BindingFlags.Instance | BindingFlags.NonPublic,
                                    null,
                                    Type.EmptyTypes,
                                    null);
                            }
                            catch (Exception exception)
                            {
                                throw new Exception();
                            }
                            if (constructor == null || constructor.IsAssembly)
                            {
                                throw new Exception(
                                    string.Format(
                                        "A private or protected constructor is missing for '{0}'.",
                                        typeof(T).Name));
                            }

                            s_Instance = constructor.Invoke(null) as T;
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}

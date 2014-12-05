using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Reflection;

namespace DemoProxyDynamic
{
    class Proxy : RealProxy
    {
        Type serviceType;

        public Proxy(Type itfType,Type type) : base(itfType)
        {
            this.serviceType = type;
        }

        public override IMessage Invoke(IMessage msg)
        {
            IMethodCallMessage mcm = (IMethodCallMessage)msg;
            IMethodMessage methodCall = (IMethodMessage)msg;

            object[] args = methodCall.Args;
            MethodBase method = methodCall.MethodBase;


            var svc = Activator.CreateInstance(serviceType);

            /*object svc = null;
            switch (serviceName)
            {
                case "Composant": svc = Activator.CreateInstance(typeof(Composant)); break;
            }*/

            object retval = method.Invoke(svc, args);
            ReturnMessage rm = new ReturnMessage(retval, null, 0, null, mcm);

            return rm;
        }
    }

    static class Factory
    {
        public static IT GetService<IT, T>()
        {
            var p = new Proxy(typeof(IT),typeof(T));

            return (IT)p.GetTransparentProxy();
        }
    }
}

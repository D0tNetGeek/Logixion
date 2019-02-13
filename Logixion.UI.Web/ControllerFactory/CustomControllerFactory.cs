using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Logixion.UI.Web.ControllerFactory
{
    public class CustomControllerFactory: DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public CustomControllerFactory(IKernel standardKernel)
        {
            _kernel = standardKernel;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }

        
    }
}
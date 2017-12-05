using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetMvc4ScopedDependencyResolver
{
    public class ScopedControllerFactory : DefaultControllerFactory
    {
        public ScopedControllerFactory(IUnityContainer container)
        {
            this.container = container;
            this.controllerToContainerMap = new Dictionary<IController, IUnityContainer>();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            var childContainer = container.CreateChildContainer();
            var controller = (IController)childContainer.Resolve(controllerType);

            this.controllerToContainerMap.Add(controller, childContainer);

            return controller;
        }

        public override void ReleaseController(IController controller)
        {
            var childContainer = this.controllerToContainerMap[controller];

            childContainer.Dispose();
        }

        private readonly IDictionary<IController, IUnityContainer> controllerToContainerMap;
        private readonly IUnityContainer container;
    }
}
using System;
using System.Web.Mvc;
using System.Web.Routing;
using HR.DataModel.DAL;
using Ninject;


namespace HR.Web.Helpers
{
    public class DIControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public DIControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // returns the controller of the requested type
            return (controllerType == null) 
                ? null 
                : ninjectKernel.Get(controllerType) as IController;
        }

        private void AddBindings()
        {
            // put additional bindings here
            ninjectKernel.Bind<IHRRepository>().To<EFHRRepository>();
        }
    }
}
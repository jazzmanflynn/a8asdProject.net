using BoDi;
using TechTalk.SpecFlow;

namespace TheProject.Test
{
    [Binding]
    public class Hooks
    {
        private static LuberController controller;
        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeFeature()]
        public static void BeforeFeature()
        {
            controller = new LuberController();
            controller.AddDriver("Boris");
            controller.AddDriver("George");
            controller.AddDriver("John");
            controller.AddPassenger("Pat");
        }

        [BeforeScenario]
        public void AssignController()
        {
            objectContainer.RegisterInstanceAs(controller);
        }
    }
}
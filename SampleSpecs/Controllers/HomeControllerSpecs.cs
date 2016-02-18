using System.Web.Mvc;
using NUnit.Framework;
using specsfor_sample_for_roger.Web.Controllers;
using Should;
using SpecsFor;
using SpecsFor.Helpers.Web.Mvc;

namespace SampleSpecs.Controllers
{
    public class HomeControllerSpecs
    {
        public class when_viewing_the_index_action : SpecsFor<HomeController>
        {
            private ActionResult _result;

            protected override void When()
            {
                _result = SUT.Index();
            }

            [Test]
            public void then_it_returns_a_view_result()
            {
                //This will fail, because it checks for the exact type specified, not that the type
                //can be cast to the specified type.
                //_result.ShouldBeType<ActionResult>();
                _result.ShouldBeType<ViewResult>();
                //You can also do this with SpecsFor.Web.Helpers:
                //_result.ShouldRenderDefaultView();
            }
        }
    }
}
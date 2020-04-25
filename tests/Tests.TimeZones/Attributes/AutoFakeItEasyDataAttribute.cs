using System;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.AutoFakeItEasy;
using AutoFixture.Xunit2;

namespace Tests.Services.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AutoFakeItEasyDataAttribute : AutoDataAttribute
    {
        public AutoFakeItEasyDataAttribute() : base(FixtureFactory)
        {
        }

        private static IFixture FixtureFactory()
        {
            return new Fixture().Customize(new AutoFakeItEasyCustomization());
        }
    }
}

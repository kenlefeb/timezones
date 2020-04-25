using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class InlineAutoFakeItEasyDataAttribute : InlineAutoDataAttribute
    {
        private readonly object[] _values;

        public InlineAutoFakeItEasyDataAttribute(params object[] values) : base(new AutoFakeItEasyDataAttribute(), values)
        {
            this._values = values;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var data = base.GetData(testMethod).ToList();

            for (var i = 0; i < this._values.Length; i++)
            {
                data[0][i] = this._values[i];
            }

            return data;
        }
    }
}

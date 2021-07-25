using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xunit_bug_testfilter
{
	public class FindTest
	{
		[Fact]
		public void FindNameOfTest()
		{
			var typesDerivingFromMyTestComponent = typeof(FindTest).Assembly
											                       .GetTypes()
											                       .Where(typeof(MyTestComponent).IsAssignableFrom)
											                       .Where(type => type != typeof(MyTestComponent))
											                       .ToList();

			Assert.Equal(1, typesDerivingFromMyTestComponent.Count);
			Assert.Equal("xunit_bug_testfilter.Test__", typesDerivingFromMyTestComponent[0].FullName);
		}
	}
}

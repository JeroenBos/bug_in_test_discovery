using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Rendering;
using Xunit;

public abstract class MyTestComponent
{
	protected virtual void BuildRenderTree(RenderTreeBuilder builder) { }
	[Fact]
	public void RazorTests() { }
}

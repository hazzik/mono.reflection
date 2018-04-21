using System;
using System.IO;
using NUnit.Framework;

namespace Mono.Reflection
{
	[SetUpFixture]
	public class FixtureSetUp {

		[OneTimeSetUp]
		public void RunBeforeAnyTests() {
			var dir = Path.GetDirectoryName(new Uri(typeof(FixtureSetUp).Assembly.CodeBase).LocalPath);

			Directory.SetCurrentDirectory(dir);
		}
	}
}
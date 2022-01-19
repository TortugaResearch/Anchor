using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tortuga.Anchor.DataAnnotations;
using Tortuga.Dragnet;

namespace Tests.DataAnnotations;

[TestClass]
public class ValidationResultCollectionTests
{
	[TestMethod]
	public void ValidationResultCollection_Test1()
	{
		using (var verify = new Verify())
		{
			var collection = new ValidationResultCollection();
			var result = collection.Add("Test", "FirstName", "LastName");
			verify.AreEqual("Test", result.ErrorMessage, "Error message");
			verify.AreEqual("FirstName", result.MemberNames.ToList()[0], "member 0");
			verify.AreEqual("LastName", result.MemberNames.ToList()[1], "member 1");
		}
	}

}

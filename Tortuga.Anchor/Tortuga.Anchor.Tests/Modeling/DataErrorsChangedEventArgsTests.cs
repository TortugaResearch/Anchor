﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace Tests.Modeling;

/// <summary>
///This is a test class for DataErrorsChangedEventArgsTest and is intended
///to contain all DataErrorsChangedEventArgsTest Unit Tests
///</summary>
[TestClass()]
public class DataErrorsChangedEventArgsTests
{
	[TestMethod()]
	public void DataErrorsChangedEventArgs_Test()
	{
		var propertyName = "abc";
		var target = new DataErrorsChangedEventArgs(propertyName);
		Assert.AreEqual(propertyName, target.PropertyName);
	}
}

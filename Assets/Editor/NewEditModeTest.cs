using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest {

	private StorageModel storageModel = new StorageModel(); 

	[Test]
	public void Test1() {
		Assert.AreEqual (storageModel.GetUnits (), 0);
	}
}

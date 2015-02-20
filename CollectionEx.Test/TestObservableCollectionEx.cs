using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionEx.Test
{
    [TestClass]
    public class TestObservableCollectionEx
    {
        [TestMethod]
        public void TestAssignFromList()
        {
            var from = new List<string>()
            {
                "a",
                "b",
                "c"
            };
            var to = new ObservableCollection<string>();
            to.Assign(from);
            CollectionAssert.AreEqual(from, to);
        }
    }
}

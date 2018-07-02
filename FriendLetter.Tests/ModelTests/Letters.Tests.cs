using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FriendLetter;
namespace FriendLetter.Tests
{
    [TestClass]
    public class LettersTest
    {
        [TestMethod]
        public void DoIPass_TestToSeeIfThisWorks_True()
        {
            Letters newObject = new Letters();
            Assert.AreEqual(true, newObject.DoIPass());
        }
    }
}

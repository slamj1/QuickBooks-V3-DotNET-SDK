﻿using Intuit.Ipp.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Intuit.Ipp.Exception.Test
{
    /// <summary>
    ///This is a test class for ChannelTerminatedExceptionTest and is intended
    ///to contain all ChannelTerminatedExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ChannelTerminatedExceptionTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for ChannelTerminatedException Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelTerminatedExceptionConstructorTest()
        {
            string errorMessage = "Unauthorized";
            string errorCode = "401";
            string source = "Intuit.Ipp.Test";
            ChannelTerminatedException target = new ChannelTerminatedException(errorMessage, errorCode, source);
            Assert.AreEqual(target.Message, errorMessage);
            Assert.AreEqual(target.ErrorCode, errorCode);
            Assert.AreEqual(target.Source, source);
        }

        /// <summary>
        ///A test for ChannelTerminatedException Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelTerminatedExceptionConstructorTest1()
        {
            string errorMessage = "Unauthorized";
            string errorCode = "401";
            string source = "Intuit.Ipp.Test";
            System.Exception innerException = new ArgumentNullException();
            ChannelTerminatedException target = new ChannelTerminatedException(errorMessage, errorCode, source, innerException);
            Assert.AreEqual(target.Message, errorMessage);
            Assert.AreEqual(target.ErrorCode, errorCode);
            Assert.AreEqual(target.Source, source);
            Assert.ReferenceEquals(target.InnerException, innerException);
        }

        /// <summary>
        ///A test for ChannelTerminatedException Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelTerminatedExceptionConstructorTest2()
        {
            string errorMessage = "Unauthorized";
            string errorCode = "401";
            string source = "Intuit.Ipp.Test";
            System.Exception innerException = new ArgumentNullException();
            ChannelTerminatedException target = new ChannelTerminatedException(errorMessage, errorCode, source, innerException);
            ChannelTerminatedException newTarget = null;
            using (Stream s = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, target);
                s.Position = 0; // Reset stream position
                newTarget = (ChannelTerminatedException)formatter.Deserialize(s);
            }

            Assert.IsNotNull(newTarget);
            Assert.AreEqual(newTarget.Message, errorMessage);
            Assert.AreEqual(newTarget.ErrorCode, errorCode);
            Assert.AreEqual(newTarget.Source, source);
            Assert.ReferenceEquals(newTarget.InnerException, innerException);
        }

        /// <summary>
        ///A test for ChannelTerminatedException Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelTerminatedExceptionConstructorTest3()
        {
            string message = "The communicating channel was terminated.";
            ChannelTerminatedException target = new ChannelTerminatedException();
            Assert.AreEqual(target.Message, message);
        }

        /// <summary>
        ///A test for ChannelTerminatedException Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelTerminatedExceptionConstructorTest4()
        {
            string errorMessage = "This is an error message.";
            ChannelTerminatedException target = new ChannelTerminatedException(errorMessage);
            Assert.AreEqual(target.Message, errorMessage);
        }

        /// <summary>
        ///A test for ChannelTerminatedException Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelTerminatedExceptionConstructorTest5()
        {
            string errorMessage = "This is an error message.";
            System.Exception innerException = new ArgumentNullException();
            ChannelTerminatedException target = new ChannelTerminatedException(errorMessage, innerException);
            Assert.AreEqual(target.Message, errorMessage);
            Assert.ReferenceEquals(target.InnerException, innerException);
        }
    }
}

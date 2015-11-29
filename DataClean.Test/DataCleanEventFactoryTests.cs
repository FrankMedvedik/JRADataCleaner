using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DataClean.DataCleaner;
using DataClean.Interfaces;
using DataClean.Models;
using DataClean.Repository.Mgr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataClean.Test
{
    [TestClass]
    public class DataCleanEventFactoryTests
    {
      //  private DataCleaner.DataCleaner _dataCleaner;
      //private DataCleanRespository _dataCleanRepository; 
        private DataCleanEventFactory  _dataCleanEventFactory;

        public DataCleanEventFactoryTests()
        {
            _dataCleanEventFactory = new DataCleanEventFactory( new DataCleaner.DataCleaner(ConfigurationManager.AppSettings)
                , new DataCleanRespository());

        }


        private OutputStreetAddress _goodOutputStreetAddress = new OutputStreetAddress()
        {
            Results = ParseResultDictionary.VALID_ADDRESS_RESULTS_LIST.ToList()
        };

        [TestMethod]
        public void ValidateGoodAddressTest()
        {
            var e = _dataCleanEventFactory.ValidateAddress(TestData.GoodAddresstoClean);
            Assert.IsTrue(e.HasBeenDataCleaned);
            Assert.IsTrue(e.Output.OkComplete);
            Assert.IsTrue(e.Output.OkMailingAddress);
            Assert.IsTrue(e.Output.OkPhone);
            Assert.IsTrue(e.Output.OkEmailAddress);
        }


        [TestMethod]
        public void CleanBadPostalCodeAddressTest()
        {

            var e = _dataCleanEventFactory.ValidateAddress(TestData.BadPostalCodetoClean);
            Assert.IsFalse(e.Output.OkComplete);
            Assert.IsTrue(e.Output.OkMailingAddress);
            Assert.IsTrue(e.Output.OkPhone);
            Assert.IsTrue(e.Output.OkEmailAddress);

            Assert.IsTrue(e.Output.HasNewPostalCode);
        }

        [TestMethod]
        public void CleanBadStreetAddressTest()
        {
            var e = _dataCleanEventFactory.ValidateAddress(TestData.BadStreetAddressToClean);
            Assert.IsFalse(e.Output.OkComplete);
            Assert.IsFalse(e.Output.OkMailingAddress);
            Assert.IsTrue(e.Output.OkPhone);
            Assert.IsTrue(e.Output.OkEmailAddress);

        }


        [TestMethod]
        public void CleanBadStateAddressTest()
        {
            var e = _dataCleanEventFactory.ValidateAddress(TestData.MissingStateToClean);
            Assert.IsFalse(e.Output.OkComplete);
            Assert.IsTrue(e.Output.OkMailingAddress);
            Assert.IsTrue(e.Output.OkPhone);
            Assert.IsTrue(e.Output.OkEmailAddress);


            Assert.IsTrue(e.Output.HasNewStateCode);
        }

        [TestMethod]
        public void CleanBadPhoneAddressTest()
        {
            var e = _dataCleanEventFactory.ValidateAddress(TestData.BadPhoneToClean);
            Assert.IsFalse(e.Output.OkComplete);
            Assert.IsTrue(e.Output.OkMailingAddress);
            Assert.IsFalse(e.Output.OkPhone);
            Assert.IsTrue(e.Output.OkEmailAddress);
        }

        [TestMethod]
        public void CleanBadEmailAddressTest()
        {
            var e = _dataCleanEventFactory.ValidateAddress(TestData.BadEmailToClean);
            Assert.IsFalse(e.Output.OkComplete);
            Assert.IsTrue(e.Output.OkMailingAddress);
            Assert.IsTrue(e.Output.OkPhone);
            Assert.IsFalse(e.Output.OkEmailAddress);
        }


        [TestMethod]
        public void CleanBadFirstNameTest()
        {
            var e = _dataCleanEventFactory.ValidateAddress(TestData.BadFirstNameToClean);
            Assert.IsTrue(e.Output.OkComplete);
            Assert.IsTrue(e.Output.OkMailingAddress);
            Assert.IsTrue(e.Output.OkPhone);
            Assert.IsTrue(e.Output.OkEmailAddress);

        }


        [TestMethod]
        public void CleanBadLastNameTest()
        {
            var e = _dataCleanEventFactory.ValidateAddress(TestData.BadLastNameToClean);
            Assert.IsTrue(e.Output.OkComplete);
            Assert.IsTrue(e.Output.OkMailingAddress);
            Assert.IsTrue(e.Output.OkPhone);
            Assert.IsTrue(e.Output.OkEmailAddress);
        }

    }
}

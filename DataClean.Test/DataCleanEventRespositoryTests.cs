﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataClean.Interfaces;
using DataClean.Models;
using DataClean.Repository.Mgr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataClean.Test
{
    [TestClass]
    public class DataCleanEventRespositoryTests
    {
     
        private OutputStreetAddress _goodOutputStreetAddress = new OutputStreetAddress()
        {
            Results = ParseResultDictionary.VALID_ADDRESS_RESULTS_LIST.ToList()
        };

        [TestMethod]
        public void CanSaveEventTest()
        {
            var testTime = DateTime.Now;
            var db = new DataCleanRespository();
            var e = new DataCleanEvent()
            {
                Input = TestData.GoodAddresstoClean,
                DataCleanDate = testTime,
                Output = _goodOutputStreetAddress
            };

            var id = e.ID;
            db.SaveEvent(e);
            var d = db.GetEvent(e.ID);
            Assert.IsTrue(d.ID == e.ID);
            Assert.IsTrue(d.DataCleanDate == testTime);
        }
        [TestMethod]
        public void CantSaveUncleanEventTest()
        {
            var db = new DataCleanRespository();
            var e = new DataCleanEvent()
            {
                Input = TestData.GoodAddresstoClean
                //DataCleanDate = DateTime.Now  

               // We dont want to save an event with out a data clean date! 
            };
            var id = e.ID;
            try
            {
                db.SaveEvent(e);
            }
            catch( Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("date"));
            }
        }

        [TestMethod]
        public void CantSaveEmptyEventTest()
        {
            var db = new DataCleanRespository();
            var e = new DataCleanEvent();
            var id = e.ID;
            try
            {
                db.SaveEvent(e);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("event"));
            }
        }


        [TestMethod]
        public void CantSaveWithoutInputTest()
        {
            var db = new DataCleanRespository();
            var e = new DataCleanEvent()
            {
                DataCleanDate = DateTime.Now,
                Output = new OutputStreetAddress()
                 
            };
            var id = e.ID;
            try
            {
                 
                db.SaveEvent(e);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("input"));
            }
        }
        [TestMethod]
        public void CantSaveWithoutOutputTest()
        {
            var db = new DataCleanRespository();
            var e = new DataCleanEvent()
            {
                DataCleanDate = DateTime.Now,
                Input = TestData.GoodAddresstoClean
            };
            var id = e.ID;
            try
            {

                db.SaveEvent(e);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("output"));
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using CoopCheck.Web.Controllers;
using DataClean.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DataClean.Web.Tests.Controllers
{
    [TestClass]
    public  class DataCleanWebTests
    {

        [TestMethod]
        public async void TestValidateAddresses()
        {
            HttpResponseMessage response;
            List<DataCleanEvent> retVal = new List<DataCleanEvent>();
            //var credentials = new NetworkCredential("fmedvedik@reckner.com", "(manos)3k");
            //var client = new System.Net.Http.HttpClient(new System.Net.Http.HttpClientHandler { Credentials = credentials });
            using (
                var client =
                    new System.Net.Http.HttpClient(new System.Net.Http.HttpClientHandler()
                    {
                        UseDefaultCredentials = true
                    }))
            {
                client.BaseAddress = new Uri("http://localhost:37432/");
                //client.BaseAddress = new Uri(Settings.Default.SwiftPaySite);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    // HTTP POST
                    response =
                        await
                            client.PostAsJsonAsync<List<InputStreetAddress>>("api/DataCleanEvent/CleanAddresses",
                                TestData.InputAddresList);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = response.Content.ReadAsStringAsync().Result;
                        var dceList = JsonConvert.DeserializeObject<List<DataCleanEvent>>(jsonContent);
                        foreach (DataCleanEvent e in dceList)
                            Console.WriteLine("\tID: " + e.ID + ", " + e.DataCleanDate + ", " + e.Output.OkComplete);
                            Assert.IsTrue(dceList.Count > 0);
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }
        }

        [TestMethod]
        public async void TestValidate()
        {
            HttpResponseMessage response;
            var retVal = new List<DataCleanEvent>();
            var controller = new DataCleanEventController();
            var result = controller.CleanAddresses(TestData.InputAddresList);
            var lst = result.ToList();
            foreach (DataCleanEvent e in lst)
                Console.WriteLine("\tID: " + e.ID + ", " + e.DataCleanDate + ", " + e.Output.OkComplete);
           Assert.IsTrue(lst.Count > 0);
                    }
                }
            }
        
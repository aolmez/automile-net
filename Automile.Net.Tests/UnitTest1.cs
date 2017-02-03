﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automile.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Automile.Net.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private AutomileClient client;
        private TokenPair token;

        [TestInitialize]
        public void Initialize()
        {
            string tokenJson = System.IO.File.ReadAllText(@"c:\temp\token.json");
            token = JsonConvert.DeserializeObject<TokenPair>(tokenJson);
            client = new AutomileClient(token);
            Console.WriteLine("TestClass1.TestInit()");
        }

        [TestMethod]
        public void TestGetVehicles()
        {
            IEnumerable<Vehicle2Model> vehicles = client.GetVehicles();
            Assert.IsNotNull(vehicles);
        }

        [TestMethod]
        public void TestGetVehicleById()
        {
            Vehicle2DetailModel vehicle = client.GetVehicleById(33553);
            Assert.IsNotNull(vehicle);
        }

        [TestMethod]
        public void TestGetStatusForVehicles()
        {
            IEnumerable<VehicleStatusModel> status = client.GetStatusForVehicles();
            Assert.IsNotNull(status);
        }

        [TestMethod]
        public void TestGetTrips()
        {
            IEnumerable<TripModel> trips = client.GetTrips(1);
            Assert.IsNotNull(trips);
        }

        [TestMethod]
        public void TestGetTrip()
        {
            TripDetailModel trip = client.GetTripById(31826384);
            Assert.IsNotNull(trip);
        }

        [TestMethod]
        public void TestGetTripStartStop()
        {
            TripStartEndGeoModel tripStartStop = client.GetTripStartStopLatitudeLongitude(31826384);
            Assert.IsNotNull(tripStartStop);
        }

        [TestMethod]
        public void TestGetTripSpeed()
        {
            IEnumerable<VehicleSpeedModel> speed = client.GetTripSpeed(31826384);
            Assert.IsNotNull(speed);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationLibrary;
using System.Collections.Generic;
using System;

namespace CalculationLibraryTests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void GetApplicationsCount_WithZeroApplications_Return0()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            Calculation testCalc = new Calculation(applications);
            int expected = 0;

            // Act
            int actual = testCalc.GetApplicationsCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetApplicationsCount_With1Applications_Return1()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            Calculation testCalc = new Calculation(applications);
            int expected = 1;

            // Act
            int actual = testCalc.GetApplicationsCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetApplicationsCount_With2Applications_Return2()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            applications.Add(new MyApplication(2, new DateTime(2024, 4, 28), "eq2", "def2", "client2", "prob2"));
            Calculation testCalc = new Calculation(applications);
            int expected = 2;

            // Act
            int actual = testCalc.GetApplicationsCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDefectsStatistics_WithZeroApplications_ReturnNull()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            Calculation testCalc = new Calculation(applications);
            string expected = null;

            // Act
            string actual = testCalc.GetDefectsStatistics();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDefectsStatistics_WithSameAmountDeffects_ReturnDef1()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            applications.Add(new MyApplication(2, new DateTime(2024, 4, 28), "eq2", "def2", "client2", "prob2"));
            Calculation testCalc = new Calculation(applications);
            string expected = "def1";

            // Act
            string actual = testCalc.GetDefectsStatistics();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDefectsStatistics_WithDifferentAmountDeffects_ReturnDef2()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            applications.Add(new MyApplication(2, new DateTime(2024, 4, 28), "eq2", "def2", "client2", "prob2"));
            applications.Add(new MyApplication(3, new DateTime(2024, 4, 26), "eq3", "def2", "client3", "prob3"));
            Calculation testCalc = new Calculation(applications);
            string expected = "def2";

            // Act
            string actual = testCalc.GetDefectsStatistics();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAverageTime_WithZeroApplications_Return0()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            Calculation testCalc = new Calculation(applications);
            int expected = 0;

            // Act
            int actual = testCalc.GetAverageTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAverageTime_WithAllUndoneApplications_Return0()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            applications.Add(new MyApplication(2, new DateTime(2024, 4, 28), "eq2", "def2", "client2", "prob2"));
            Calculation testCalc = new Calculation(applications);
            int expected = 0;

            // Act
            int actual = testCalc.GetAverageTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAverageTime_With1Undone_1DoneApplications_Return2()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            applications[0].Status = "Выполнено";
            applications[0].DateEnd = new DateTime(2024, 4, 29);
            applications.Add(new MyApplication(2, new DateTime(2024, 4, 26), "eq2", "def2", "client2", "prob2"));
            Calculation testCalc = new Calculation(applications);
            int expected = 2;

            // Act
            int actual = testCalc.GetAverageTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAverageTime_With1Undone_2DoneApplications_Return1()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            applications[0].Status = "Выполнено";
            applications[0].DateEnd = new DateTime(2024, 4, 29);
            applications.Add(new MyApplication(2, new DateTime(2024, 4, 26), "eq2", "def2", "client2", "prob2"));
            applications.Add(new MyApplication(3, new DateTime(2024, 4, 28), "eq3", "def3", "client3", "prob3"));
            applications[2].Status = "Выполнено";
            applications[2].DateEnd = new DateTime(2024, 4, 29);
            Calculation testCalc = new Calculation(applications);
            int expected = 1;

            // Act
            int actual = testCalc.GetAverageTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAverageTime_WithAllDoneApplications_Return1()
        {
            // Arrange
            List<MyApplication> applications = new List<MyApplication>();
            applications.Add(new MyApplication(1, new DateTime(2024, 4, 27), "eq1", "def1", "client1", "prob1"));
            applications[0].Status = "Выполнено";
            applications[0].DateEnd = new DateTime(2024, 4, 29);
            applications.Add(new MyApplication(3, new DateTime(2024, 4, 28), "eq3", "def3", "client3", "prob3"));
            applications[1].Status = "Выполнено";
            applications[1].DateEnd = new DateTime(2024, 4, 29);
            Calculation testCalc = new Calculation(applications);
            int expected = 1;

            // Act
            int actual = testCalc.GetAverageTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
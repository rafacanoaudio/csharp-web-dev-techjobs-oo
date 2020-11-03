using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsOO
{
    [TestClass]
    public class JobTests
    {
        // Arrange: testInitialize to create 2 Job objects with empty constructor
        Job testJob1;
        Job testJob2;
        Job testJob3;

        [TestInitialize]
        public void CreateTwoJobObjects()
        {
            testJob1 = new Job();
            testJob2 = new Job();
        }

        //[TestCleanup]
        //public void CleanUpAfterTest()
        //{
        //    testJob1 = null;
        //    testJob2 = null;
        //}

        //empty constructor sets different ID values
        [TestMethod]
        public void Job_AssignsDifferentIds_ReturnTrue()
        {
            Assert.IsFalse(testJob1.Id == testJob2.Id);
        }

        //empty constructor sets ID values in increments of 1
        [TestMethod]
        public void Job_IcrementsIdsBy1_ReturnTrue()
        {
            Assert.IsTrue((testJob2.Id - testJob1.Id) == 1);
        }

        //Job objects should correctly set 6 properties
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Arrange
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");
            testJob3 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);

            //Assert
            Assert.AreEqual(7, testJob3.Id); // job ID is 7 because TestInitialize runs 3 times, creating 6 Job objects...
            Assert.AreEqual("Product tester", testJob3.Name.ToString());
            Assert.AreEqual("ACME", testJob3.EmployerName.ToString());
            Assert.AreEqual("Desert", testJob3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", testJob3.JobType.ToString());
            Assert.AreEqual("Persistence", testJob3.JobCoreCompetency.ToString());
        }

        //Jobs are only equal when they have the same ID
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");
            Job testJob4 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            Job testJob5 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);

            Assert.IsFalse(testJob4.Equals(testJob5));
        }

        //TODO: Build The ToString Method

    }
}

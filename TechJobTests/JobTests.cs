using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsOO
{
    [TestClass]
    public class JobTests
    {
        // Arrange 
        Job testJob1;
        Job testJob2;
        Job testJob3;
        readonly Employer testEmployer = new Employer("ACME");
        readonly Location testLocation = new Location("Desert");
        readonly PositionType testPositionType = new PositionType("Quality control");
        readonly CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");
        Job testJob4;
        Job testJob5;

        [TestInitialize]
        public void CreateTwoJobObjects()
        {
            testJob1 = new Job();
            testJob2 = new Job();
        }

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
            testJob4 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);
            testJob5 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);

            Assert.IsFalse(testJob4.Equals(testJob5));
        }

        //TODO: Build The ToString Method

        //Should return a string with a blank line before and after the job information
        [TestMethod]
        public void JobToString_AddsBlankLines_ReturnTrue()
        {
            Job testJob6 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);

            //Assert.IsTrue(string.IsNullOrEmpty(testJob6.ToString()));
            Assert.IsTrue(testJob6.ToString().Contains(null));
            //Assert.IsTrue(testJob6.ToString().Contains(string.Empty));

        }
    }
}

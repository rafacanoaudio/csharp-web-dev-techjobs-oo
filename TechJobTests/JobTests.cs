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
            string str = testJob6.ToString();
            Assert.AreEqual("\n", str.Substring(0, 1));
            Assert.AreEqual("\n", str.Substring(str.Length - 1, 1));

        }


        // TODO: string should contain a label for each field,
        //followed by the data stored in that field. Each field should be on its own line.
        [TestMethod]
        public void JobToString_LabelsEachFields_And_PutsEachOnOwnLine_ReturnTrue()
        {
            Job testJob7 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCompetency);

            Assert.AreEqual("\nID: 17\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", testJob7.ToString());
        }

        [TestMethod]
        public void JobToString_EmptyFieldsAddsMessageAfterLabel_ReturnTrue()
        {
            Employer testEmployer = new Employer("");
            Location testLocation = new Location("");
            PositionType testPositionType = new PositionType("");
            CoreCompetency testCoreCompetency = new CoreCompetency("");

            Job testJob8 = new Job(null, testEmployer, testLocation, testPositionType, testCoreCompetency);
            //Job testJob8 = new Job();
            Assert.AreEqual("\nID: 20\nName: Data not available\n" +
                "Employer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n", testJob8.ToString());
        }

    }
}

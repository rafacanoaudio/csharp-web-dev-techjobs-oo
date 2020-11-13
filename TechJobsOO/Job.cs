using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string aName, Employer aEmployerName, Location aEmployerLocation, PositionType aJobType, CoreCompetency aJobCoreCompetency) : this()
        {
            Name = aName;
            EmployerName = aEmployerName;
            EmployerLocation = aEmployerLocation;
            JobType = aJobType;
            JobCoreCompetency = aJobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string dna = "Data not available";

            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return "Oops! This job does not seem to exist.";
            }

            //"Oops! This job does not seem to exist."
        

            if (Name == null)
            {
                Name = dna;
            }
            if (String.IsNullOrWhiteSpace(EmployerName.Value))
            {
                EmployerName.Value = dna;
            }
            if (String.IsNullOrWhiteSpace(EmployerLocation.Value))
            {
                EmployerLocation.Value = dna;
            }
            if (String.IsNullOrWhiteSpace(JobType.Value))
            {
                JobType.Value = dna;
            }
            if (String.IsNullOrWhiteSpace(JobCoreCompetency.Value))
            {
                JobCoreCompetency.Value = dna;
            }
            return $"\nID: {Id}\nName: {Name}\nEmployer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\nCore Competency: {JobCoreCompetency}\n";
        }


    }
}

using System;

namespace TechJobs.Models
{
    public class Job : JobField
    {
        public int ID { get; set; } //changed 'ID' to "FieldID' 
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }
        public CoreCompetency CoreCompetency { get; set; }
        public PositionType PositionType { get; set; }

        public Job()
        {
            ID = nextId;
            nextId++;
        }

        
    }
}

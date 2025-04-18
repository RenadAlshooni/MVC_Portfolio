using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class AboutViewModel
    {

        private List<About> _info = new List<About>
        {
            new About
            {
                Birthday = "5 May 2004",
                Website = "https://www.linkedin.com/in/renad-alshooni-3a05792a6",
                Age = "21",
                Degree = "CS Student",
                Freelance = "Available",
                Address = "Tanta, Egypt",
                Phone = "+201128411383",
                Email = "renadalshooni@gmail.com"

            }
        };
        public List<About> Info => _info;

        private List<Stats> _stats = new List<Stats>
        {
            new Stats
            {
                H_CLients = 100,
                Projects = 10,
                HoursOfSupport= 150,
                HardWorkers = 267
            }
        };

        public List<Stats> Stats => _stats;

        private List<Skills> _skills = new List<Skills>
        {
            new Skills
            {
                skill1="C#",
                skill1_rate=90,

                skill2="Responsive Design",
                skill2_rate=93,

                skill3 = "Entity Framework Core (Code First / Database First)",
                skill3_rate= 80,

                skill4= "SQL Server",
                skill4_rate=78,

                skill5= "Debugging & Testing",
                skill5_rate=80,

                skill6="Problem-solving",
                skill6_rate=82,

                 skill7= "ASP .NET Core (MVC / RAZOR PAGES)",
                 skill7_rate=88,

                 skill8= "API INTEGRATION",
                 skill8_rate=75,

            }
        };

        public List<Skills> Skills => _skills;
    }
}

namespace SportzClubManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AthleteManagement athleteManagement = new AthleteManagement();
            int athlete1 = athleteManagement.RegisterAthlete("Lebron", "James", 38, "Basketball", DateTime.Now.AddYears(-10));
            int athlete2 = athleteManagement.RegisterAthlete("Sachin", "Tendulkar", 45, "Cricket", DateTime.Now.AddYears(-20));
            int athlete3 = athleteManagement.RegisterAthlete("Sania", "Mirza", 35, "Tennis", DateTime.Now.AddYears(-15));
            int athlete4 = athleteManagement.RegisterAthlete("Anup", "Kumar", 40, "Kabaddi", DateTime.Now.AddYears(-8));
            int athlete5 = athleteManagement.RegisterAthlete("Virat", "Kohli", 35, "Cricket", DateTime.Now.AddYears(-12));

           
            Console.WriteLine(athleteManagement.ViewAthleteDetails(4));

            athleteManagement.UpdateAthleteDetails(4, "Anup", "Kumar", 32, "Kabaddi");//athlete age changed
            Console.WriteLine(athleteManagement.ViewAthleteDetails(4));

            //athleteManagement.RemoveAthlete(4);
            //Console.WriteLine(athleteManagement.ViewAthleteDetails(4));


            EventManagement eventManagement = new EventManagement();
            int event1 = eventManagement.CreateEvent("Football Tournament", "Tournament", DateTime.Now.AddDays(20));
            int event2 = eventManagement.CreateEvent("Cricket Net Practice", "Training", DateTime.Now.AddDays(1));
            int event3 = eventManagement.CreateEvent("Badminton Match", "Match", DateTime.Now.AddDays(5));

            Console.WriteLine(eventManagement.ViewEventDetails(3));

            eventManagement.UpdateEventDetails(3,"Badminton Match", "Match", DateTime.Now.AddDays(7));//event schedule changed
            Console.WriteLine(eventManagement.ViewEventDetails(3));

           // eventManagement.RemoveEvent(2);
            //Console.WriteLine(eventManagement.ViewEventDetails(2));

            PerformanceTracking performanceTracking = new PerformanceTracking();
            performanceTracking.RecordAthletePerformance(athlete2,event2,"Excellent");

            performanceTracking.ViewAthletePerformance(athlete2,event2);

            //Get athletes by sport
            var cricketPlayers = athleteManagement.GetAthletesBySport("Cricket");
            foreach (var athlete in cricketPlayers)
            {
                Console.WriteLine($"{athlete.FirstName} {athlete.LastName}");
            }


            //Get events by Type
           var trainingEvents = eventManagement.GetEventsByType("Training");
            foreach(var e in trainingEvents)
            {
                Console.WriteLine(e);
            }

            //Get Upcoming Events
            var upcomingEvents =eventManagement.GetUpcomingEvents();
            foreach (var ev in upcomingEvents)
            {
                Console.WriteLine(ev);
            }

        }
    }
}
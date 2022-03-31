using System;
using System.Collections.Generic; // for list class
namespace _Objects_Class__ListOfObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Here is a sample of the program:
             * 
             * 1) Set participant name
             * 2) Set participant join time
             * 3) Set participant leave time
             * 4) Show current participant
             * 5) Add participant
             * 6) Show all participant
             * 7) Remove participant
             * 0) Exit program
             * 
             * */
            // Create a new list of Participant
            List<Participant> participants = new List<Participant>();
            // Create a new participant for Kevin and set LeaveTime to 5 minutes from now
            Participant participant1 = new Participant("Kevin");
            participant1.LeaveTime = DateTime.Now.AddMinutes(5);
            // Add participant1 to our list of participant
            participants.Add(participant1);

            // Create a new participant for Nino and set LeaveTime to 10 minutes from now
            Participant participant2 = new Participant("Nino");
            participant2.LeaveTime = DateTime.Now.AddMinutes(10);
            // Add participant2 to our list of participant
            participants.Add(participant2);

            // Create a new participant for Prabin and set LeaveTime to 15 minutes from now
            Participant participant3 = new Participant("Prabin");
            participant3.LeaveTime = DateTime.Now.AddMinutes(15);
            // Add participant3 to our list of participant
            participants.Add(participant3);

            // Display the Name, JoinTime and LeaveTime for each participant
            foreach (Participant currentParticipant in participants)
            {
                Console.WriteLine($"{currentParticipant.Name, -15} {currentParticipant.JoinTime, -15} {currentParticipant.LeaveTime, -15}");              
            }

            /* Here is a challenge:
             * 
             * 1) Set participant name    - Create new participant      
             * 4) Show current participant - Display the current participant
             * 5) Add participant           - Add current participant to List of Participants
             * 6) Show all participant      - Show the Name and JoinTime for each participant in the list
             * 7) End Meeting - Set the LeaveTime for all participants to the current DateTime
             *                - save to a text the list of participants
             * 0) Exit program
             * 
             * */


        }
    }
}

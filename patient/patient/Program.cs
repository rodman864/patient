using System;
using System.Collections;
using System.Collections.Generic;

namespace patient
{
    public class Hospital
    {
        private Queue<int> waitingRoomQueue = new Queue<int>();

        public void addPatientToQueue(int parameter)
        {
            waitingRoomQueue.Enqueue(parameter);
        }

        public void showPaitent()
        {
            Console.Write("I have these many" +
                                 waitingRoomQueue.Count +
                                     "patients");
        }
        public void actualPatients()
        {
            foreach(var item in waitingRoomQueue)
            {
                Console.WriteLine("Patient: " + item);
            }
        }
        public void patientSeen()
        {
            waitingRoomQueue.Dequeue();
        }

        static void Main(string[] args)
        {
            Hospital hospitalPatient = new Hospital();
            hospitalPatient.addPatientToQueue(1);
            hospitalPatient.addPatientToQueue(2);
            hospitalPatient.addPatientToQueue(3);
            hospitalPatient.addPatientToQueue(4);
            hospitalPatient.addPatientToQueue(5);
            hospitalPatient.addPatientToQueue(6);

            hospitalPatient.patientSeen();

            hospitalPatient.actualPatients();




        }
    }
}

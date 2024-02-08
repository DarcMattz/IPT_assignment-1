namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfVaccine = 0;
            do
            {
                Console.Write("Enter the number of vaccines: 1-10: ");
                    numOfVaccine = Convert.ToInt16(Console.ReadLine());
                if (numOfVaccine < 10 && numOfVaccine > 0) break;
                Console.WriteLine("The number of vaccines should be 1-10 only!");
            } while(true);

            int[] strengthOfVaccine = new int[numOfVaccine];
            int totalStrength = 0;
            for (int i = 0; i < numOfVaccine; i++)
            {
                Console.Write($"Enter vaccine strength for vaccine {i + 1}: ");
                    strengthOfVaccine[i] = Convert.ToInt16(Console.ReadLine());
                totalStrength += strengthOfVaccine[i];
            }
            int[] patientMCount = new int[numOfVaccine];
            int totalMCount = 0;
            for (int i = 0; i < numOfVaccine; i++)
            {
                Console.Write($"Enter midichlorians count({i + 1}) for patient: ");
                    patientMCount[i] = Convert.ToInt16(Console.ReadLine());
                totalMCount += patientMCount[i];
            }

            Console.WriteLine($"Vaccine Strength Total: {totalStrength}\nPatient Midichlorians Total: {totalMCount}");
            Console.WriteLine(totalStrength >= totalMCount ? "Final Result: YES" : "Final Result: NO");
        }
    }
}
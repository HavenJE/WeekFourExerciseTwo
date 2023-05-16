
// Exercise 2
// Write a program named CheckZips that is used by a package delivery service to check delivery areas.
// The program contains an array that holds the 10 zip codes of areas to which the company makes deliveries.
// Prompt a user to enter a zip code, and display a message indicating whether the zip code is in the company’s delivery areas.

class CheckZips
{
    static void Main()
    {
        int userZipCode;
        bool isValid = false;
        int[] zipCodes = { 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010 };

        Console.WriteLine("Enter your zipcode area below: ");
        userZipCode = Convert.ToInt32(Console.ReadLine());

        // Checking if the user zipcode matching any of the eight zipcodes from the array by looping through them
        for (int i = 0; i < zipCodes.Length; i++)
        {
            if (zipCodes[i] == userZipCode)
            {
                isValid = true;
            }
        }
        if (isValid)
        {
            Console.WriteLine("Good news! Your area zip code ({0}) is within our delivery range!", userZipCode);
        }
        else
        {
            Console.WriteLine("Sorry! Delivery to zip code ({0}) is not available.", userZipCode);
        }
    }
}
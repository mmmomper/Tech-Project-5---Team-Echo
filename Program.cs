//Tech Project 5: Echo Group: Marisa Momper, Raleigh Sullivan, Duy Ho, Mardeja Bivens, Josh Palathinkal
using System;

namespace Tech_Project_5___Team_Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declares a variable to hold the value for the number of candidates the user inputs
            int number_of_candidates = int.Parse(Console.ReadLine());

            //creates an empty array that will hold the names of the candidates and is the size of the number of candidates
            String[] candididate_name = new string[number_of_candidates];

            //creates an empty array that will hold the party names for each candidate
            String[] candididate_party_name = new string[number_of_candidates];

            //creation of variable which holds the value for the number of candidate entries
            int candidate_entry = number_of_candidates * 2;

            //variable to hold the first index value
            int index = 1;

            //variable to hold the first index value of the candidate_name array
            int name_index = 0;

            //variable to hold the first index value of the candidate_party_name
            int party_index = 0;

            //start of while loop that checks that the current index is not larger than the number of entries and that the name_index and party_index are not larger than the length of their arrays
            while (index <= candidate_entry && name_index <= number_of_candidates && party_index <= number_of_candidates)
            {
                //checks to see if the index is odd
                if (index % 2 != 0)
                {
                    //reads the user input for the line and assigns it to a variable
                    String name = Console.ReadLine();
                    //replaces an element of the candidate name array with the inputted name
                    candididate_name[name_index] = name;
                    //increments the value of name_index by one
                    name_index++;
                }

                //checks to see if the index is even
                if (index % 2 == 0)
                {
                    //reads the user input for the line and assigns it to a variable
                    String party = Console.ReadLine();
                    //replaces an element of the candidate_party_name array with the inputted party
                    candididate_party_name[party_index] = party;
                    //increments the value of the party_index by one
                    party_index++;
                }
                //increments the value of index by one
                index++;
            }

            //declares a variable to hold the value for the number of ridings that the user inputs
            int number_of_ridings = int.Parse(Console.ReadLine());

            //variable to hold the first index value
            int riding_index = 1;

            //variable to hold the index value for the riding_results array
            int array_index = 0;

            //variable to hold the current highest count of a candidate name
            int highest_count = 0;

            //variable to hold the current second highest count of a candidate name
            int second_highest_count = 0;

            //variable to hold the current count for a candidate name
            int count = 0;

            //variable to be used to hold the index of the candidate name with the highest count
            int highest_index = -1;

            //creates an array to hold the riding results input by the user and is the size of the number of ridings
            String[] riding_results = new string[number_of_ridings];

            //creates a variable to hold the value of the party of the winning candidate
            string winning_party;

            //start of while loop which checks to see if the riding index is not larger than the number of ridings
            while (riding_index <= number_of_ridings)
            {
                //checks to see if the index for element in the array is not larger than the highest index value in the array
                if (array_index <= number_of_ridings - 1)
                {
                    //Assigns the input of the user to the current element held by array_index
                    riding_results[array_index] = Console.ReadLine();
                    //increments the value of array_index by one
                    array_index++;
                    //increments the value of riding_index by one
                    riding_index++;
                }
            }

            //first for loop to iterate through each element in the array
            for (int i = 0; i <= number_of_candidates - 1; i++)
            {
                //second nested for loop that interates through each element in the array
                for (int i2 = 0; i2 <= number_of_ridings - 1; i2++)
                {
                    //checks to see if the current element from the first loop is equal to the current element from the second loop
                    if (candididate_name[i] == riding_results[i2])
                    {
                        //increments the count of the occurence by one
                        count++;
                    }
                }
                //checks to see if the value for highest count is larger or equal to the current value for count
                if (highest_count <= count)
                {
                    //assigns the older highest count to the second_highest count variable
                    second_highest_count = highest_count;
                    //assigns the value for count to the new highest_count
                    highest_count = count;
                    //Sets the highest_index to the index of the candidate_name element with the highest count
                    highest_index = i;
                }
                //resets the count to 0 before continuing with the next candidate_name
                count = 0;
            }
            //checks to see if the highest_count is equal to the second_highest_count
            if (highest_count == second_highest_count)
            {
                //Returns that there is a tie if so
                Console.WriteLine("tie");
            }
            //checks to see if the highest_count is not equal to the second_highest_count
            if(highest_count != second_highest_count)
            {
                //assigns the value of the winning candidate's party to winning_party variable
                winning_party = candididate_party_name[highest_index];
                //Returns the name of the winning party
                Console.WriteLine(winning_party);
            }
        }
    }
}

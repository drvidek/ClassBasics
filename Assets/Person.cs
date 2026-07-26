using UnityEngine;

// Write the following script together with the learners
// Take time with how to structure classes and methods
// Reinforce concepts they've already learned as you go
    // What do they remember about each data type?
    // How do we combine strings?
    // etc
// When done, make 3-4 capsules and give each one a Person component
// Have the learners fill out each one as a different person
// Demonstrate the script working in play mode
// Point out that each Person component works independently from each other


///// Homework / if there is extra time in the lesson

/// We're going to simulate aging in a simple way.

// 1. Declare a variable to track "days passed"
// 2. In Update, increase the variable by 1
// 3. If the days passed is greater than 365...
    // Increase age by 1
    // Set the days passed to 0 (to start a new year)

// When you press play, a person should automatically get older, and become an adult when reaching 18.

public class Person : MonoBehaviour
{
    // The person's first name
    public string firstName;
    // The person's age, in years
    public int age;
    // The person's height, in cm
    public float height;
    // Whether the person is over 18 or not
    public bool isAdult;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Print a message in the console
        Debug.Log(firstName + " was created at " + age + " years old!");
    }

    // Update is called once per frame
    void Update()
    {
        // Check our age every frame
        CheckAge();
    }

    ////// TEACHER! Challenge the learners to write this method themselves
    /// Write only the comments and give them 5 minutes to write the code on their own
    /// Offer to give help if they need it
    /// Encourage them to try typing even if they aren't sure
    void CheckAge()
    {
        // If our age is larger or equal to 18...
        if (age >= 18)
        {
            // Set isAdult to true
            isAdult = true;
        }
        else // Otherwise...
        {
            // Set isAdult to false
            isAdult = false;
        }
    }
}

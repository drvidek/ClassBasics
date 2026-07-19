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

    void CheckAge()
    {
        // If our age is larger or equal to 18...
        if (age >= 18)
        {
            // Flag that we're an adult
            isAdult = true;
        }
        else // Otherwise...
        {
            // Flag that we're not an adult
            isAdult = false;
        }
    }
}

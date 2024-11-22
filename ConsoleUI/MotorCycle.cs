using System;

namespace ConsoleUI;

public class MotorCycle : Vehicle
{
    /*
     * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
     * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
     * Provide the implementations for the abstract methods
     * Only in the Motorcycle class will you override the virtual drive method
     */
    public bool HasSideCart { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine("Is a MotorCycle Drive");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Different Motercycle");
    }
}
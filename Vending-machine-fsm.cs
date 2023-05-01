using System;



public enum VendingMachineState
{
    WaitingForSelection,
    ProcessingSelection,
    Vending
}

public class VendingMachine
{
    private VendingMachineState currentState;

    public VendingMachine()
    {
        currentState = VendingMachineState.WaitingForSelection;
    }

    public void InsertCoin()
    {
        if (currentState == VendingMachineState.WaitingForSelection)
        {
            Console.WriteLine("Coin inserted");
            currentState = VendingMachineState.ProcessingSelection;
        }
        else
        {
            Console.WriteLine("Invalid action");
        }
    }

    public void SelectProduct()
    {
        if (currentState == VendingMachineState.ProcessingSelection)
        {
            Console.WriteLine("Product selected");
            currentState = VendingMachineState.Vending;
        }
        else
        {
            Console.WriteLine("Invalid action");
        }
    }

    public void DispenseProduct()
    {
        if (currentState == VendingMachineState.Vending)
        {
            Console.WriteLine("Product dispensed");
            currentState = VendingMachineState.WaitingForSelection;
        }
        else
        {
            Console.WriteLine("Invalid action");
        }
    }
}

public class Program
{
    public static void Main()
    {
        VendingMachine machine = new VendingMachine();

        machine.InsertCoin(); // Coin inserted

        machine.InsertCoin(); // Invalid action (the machine is already processing)

        machine.SelectProduct(); // Product selected

        machine.InsertCoin(); // Invalid action (the machine is waiting to dispense)

        machine.SelectProduct(); // Invalid action (the product is already selected)

        machine.DispenseProduct(); // Product dispensed

    }
}

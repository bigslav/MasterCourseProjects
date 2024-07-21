using ConsoleHelpers;
using InheritanceMiniProject.Models;

namespace InheritanceMiniProject;

public class InventoryManager
{
    public bool NeedFinish => _needFinish;

    readonly InventoryModel _inventory;

    bool _needFinish;

    public InventoryManager(InventoryModel inventory)
    {
        _inventory = inventory;
    }

    public void ProcessInventoryManagementStep()
    {
        string response = ConsoleHelpers.ConsoleHelpers.RequestString("\nWhat do you want to do? (Type Rent, Return, Purchase or Exit)",
            new List<string> {"Rent", "Return", "Purchase", "Exit"});

        switch (response.ToLower())
        {
            case "rent":
                List<string> availableForRentItemNames = _inventory.GetAvailableForRentItemNames();

                if (availableForRentItemNames.Count != 0)
                {
                    ProcessRentResponse(availableForRentItemNames);
                }
                else
                {
                    Console.WriteLine("\nThere are no items to rent right now");
                }

                break;

            case "return":
                List<string> availableForReturnItemNames = _inventory.GetAvailableForReturnItemNames();

                if (availableForReturnItemNames.Count != 0)
                {
                    ProcessReturnResponse(availableForReturnItemNames);
                }
                else
                {
                    Console.WriteLine("\nThere are no items to return right now");
                }

                break;

            case "purchase":
                List<string> availableForPurchaseItemNames = _inventory.GetAvailableForPurchaseItemNames();

                if (availableForPurchaseItemNames.Count != 0)
                {
                    ProcessPurchaseResponse(availableForPurchaseItemNames);
                }
                else
                {
                    Console.WriteLine("\nThere are no items to purchase right now");
                }

                break;

            case "exit":
                _needFinish = true;

                break;
        }
    }

    void ProcessRentResponse(List<string> availableForRentItemNames)
    {
        Console.WriteLine("\nYou can rent:");

        foreach (string name in availableForRentItemNames)
        {
            Console.WriteLine(name);
        }

        string rentResponse = ConsoleHelpers.ConsoleHelpers.RequestString("\nWhat do you want to rent? (Type item name from list above)", availableForRentItemNames, true);
        _inventory.RentItem(rentResponse);
    }

    void ProcessReturnResponse(List<string> availableForReturnItemNames)
    {
        Console.WriteLine("\nYou can return:");

        foreach (string name in availableForReturnItemNames)
        {
            Console.WriteLine(name);
        }

        string returnResponse = ConsoleHelpers.ConsoleHelpers.RequestString("\nWhat do you want to return? (Type item name from list above)", availableForReturnItemNames, true);
        _inventory.ReturnItem(returnResponse);
    }

    void ProcessPurchaseResponse(List<string> availableForPurchaseItemNames)
    {
        Console.WriteLine("\nYou can purchase:");

        foreach (string item in availableForPurchaseItemNames)
        {
            Console.WriteLine(item);
        }

        string purchaseResponse = ConsoleHelpers.ConsoleHelpers.RequestString("\nWhat do you want to purchase? (Type item name from list above)", availableForPurchaseItemNames, true);
        _inventory.PurchaseItem(purchaseResponse);
    }
}

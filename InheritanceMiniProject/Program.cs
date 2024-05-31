using InheritanceMiniProject;
using InheritanceMiniProject.Models;

var inventory = new InventoryModel();
inventory.AddItem(new CarModel("Nissan"));
inventory.AddItem(new FoodModel("Green Apple"));
inventory.AddItem(new FoodModel("Watermelon"));
inventory.AddItem(new StadiumModel("Stark Arena"));

var inventoryManager = new InventoryManager(inventory);

do
{
    inventoryManager.ProcessInventoryManagementStep();
} while (!inventoryManager.NeedFinish);

Console.WriteLine();
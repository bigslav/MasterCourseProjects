using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public class InventoryModel
{
    readonly List<InventoryItemModel> _inventoryItems = new List<InventoryItemModel>();

    public void AddItem(InventoryItemModel item)
    {
        _inventoryItems.Add(item);
    }

    public void RentItem(string itemName)
    {
        var item = (IRentable)_inventoryItems.First(item => item.Name == itemName && item is IRentable rentable && !rentable.IsRented);
        item.Rent();
    }

    public void ReturnItem(string itemName)
    {
        var item = (IRentable)_inventoryItems.First(item => item.Name == itemName && item is IRentable rentable && rentable.IsRented);
        item.Return();
    }

    public void PurchaseItem(string itemName)
    {
        var item = (IPurchasable)_inventoryItems.First(item => item.Name == itemName && item is IPurchasable);
        item.Purchase();
    }

    public List<string> GetAvailableForRentItemNames()
    {
        var rentableItems = new List<string>();

        foreach (InventoryItemModel item in _inventoryItems)
        {
            switch (item)
            {
                case IPurchasable purchasableItem when purchasableItem.IsPurchased:
                    continue;

                case IRentable rentableItem when !rentableItem.IsRented:
                    rentableItems.Add(item.Name);
                    break;
            }
        }

        return rentableItems;
    }

    public List<string> GetAvailableForReturnItemNames()
    {
        var rentableItems = new List<string>();

        foreach (InventoryItemModel item in _inventoryItems)
        {
            if (item is IRentable rentableItem && rentableItem.IsRented)
                rentableItems.Add(item.Name);
        }

        return rentableItems;
    }

    public List<string> GetAvailableForPurchaseItemNames()
    {
        var purchasableItems = new List<string>();

        foreach (InventoryItemModel item in _inventoryItems)
        {
            switch (item)
            {
                case IRentable rentable when rentable.IsRented:
                    continue;

                case IPurchasable purchasable when !purchasable.IsPurchased:
                    purchasableItems.Add(item.Name);
                    break;
            }
        }

        return purchasableItems;
    }
}
using System.Collections.Generic;
using Xunit;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;

        #region Constructor
        public Testing()
        {
            
        }
        #endregion
        [Fact]
        public void AddInventory()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 6,
                ProductId = 6,
                Quantity = 15,
                Price = 50,
                CreationDateTime = System.DateTime.UtcNow,
            };
            var program = new Program();
            var list = program.AddInventory(inventory);
            Assert.Equal(6, db.InventoryList.Count);

        }


        [Fact]
        public void DeleteInventory()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 2,
                ProductId = 2,
            };
            var program = new Program();
            var list = program.DeleteInventory(inventory);
            Assert.Equal(5, db.InventoryList.Count);
        }

        [Fact]
        public void UpdateInventory()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 2,
                ProductId = 2,
                Quantity = 222
            };
            var program = new Program();
            var list = program.UpdateInventory(inventory);

            Assert.Equal(inventory.Quantity, list.Quantity);
        }

        [Fact]
        public void CheckOutCartAndUpdateInventory()
        {
            List < Cart> cart = new List<Cart>();
            var program = new Program();
            var db = new Database();
            var inventory = new Cart()
            {
                Id = 2,
                ProductId = 2,
                OrderedQuantity = 30
            };
            cart.Add(inventory);

            var inventory1 = new Inventory()
            {
                Id = 2,
                ProductId = 2,
                Quantity = 30
            };
            var list = program.UpdateInventory(inventory1);
            Assert.Equal(inventory1.Quantity, list.Quantity);
        }

        public void ProductExists()
        {
            int flag = 0;
            var inventory = new Inventory()
            {
                Id = 2,
                ProductId = 2,
            };
            var db = new Database();
            foreach( var inventory1 in db.InventoryList)
            {
                Assert.Equal(inventory1.ProductId, inventory.ProductId);
            }
        }


    }
}

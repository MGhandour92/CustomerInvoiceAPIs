using DAL;
using Domain.Entities;

namespace APIs.Helpers
{
    public static class MockDataHelpers
    {
        public static void AddCustomerData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<AppDBContext>();

            var customer1 = new Customer
            {
                Id = 1,
                Name = "Customer Name 1"
            };

            var customer2 = new Customer
            {
                Id = 2,
                Name = "Customer Name 2"
            };

            var customer3 = new Customer
            {
                Id = 3,
                Name = "Customer Name 3"
            };

            db.Customers.Add(customer1);
            db.Customers.Add(customer2);
            db.Customers.Add(customer3);

            db.SaveChanges();
        }

        public static void AddItemData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<AppDBContext>();

            var item1 = new Item
            {
                Id = 1,
                Code = "Item_Code_1",
                UnitPrice = 10
            };

            var item2 = new Item
            {
                Id = 2,
                Code = "Item_Code_2",
                UnitPrice = 20
            };

            var item3 = new Item
            {
                Id = 3,
                Code = "Item_Code_3",
                UnitPrice = 30
            };

            db.Items.Add(item1);
            db.Items.Add(item2);
            db.Items.Add(item3);

            db.SaveChanges();
        }

        public static void AddInvoiceData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<AppDBContext>();

            var invHeader1 = new InvoiceHeader
            {
                Id = 1,
                CustomerId = 1,
                InvoiceNumber = 1
            };

            var invLine1 = new InvoiceLine
            {
                Id = 1,
                InvoiceHeaderId = 1,
                ItemId = 1,
                Quantity = 10
            };

            var invLine2 = new InvoiceLine
            {
                Id = 2,
                InvoiceHeaderId = 1,
                ItemId = 2,
                Quantity = 20
            };
            

            db.InvoiceHeaders.Add(invHeader1);
            db.InvoiceLines.Add(invLine1);
            db.InvoiceLines.Add(invLine2);

            db.SaveChanges();
        }
    }
}

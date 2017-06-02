using CourseProject.DAL;
using System.IO;

namespace CourseProject.BLL
{
    class Shop
    {
        private string fileName;
        private ProductList productFileStorage;
        
        public Shop(string fileName)
        {
            if (!File.Exists(fileName) || new FileInfo(fileName).Length == 0)
            {
                DataAccess.WriteFile(fileName, new ProductList());
            }
            productFileStorage = DataAccess.ReadFile(fileName);
            ProductBasket = new PurchaseList();
            SearchResult = productFileStorage;
            IsSaved = true;
            this.fileName = fileName;
        }

        public PurchaseList ProductBasket { get; private set; }

        public ProductList SearchResult { get; private set; }

        public bool IsSaved { get; private set; }

        public bool IsBasketEmpty
        {
            get
            {
                return ProductBasket == null || ProductBasket.Count == 0;
            }
        }

        public void AddToStorage(string name, double price, double amount, 
                                        string measure, string deliveryDate)
        {
            if (measure == "кг")
            {
                productFileStorage.Add(
                    new WeightProduct(
                        name, price, amount, deliveryDate));
            }
            else if (measure == "шт")
            {
                productFileStorage.Add(
                    new DiscreteProduct(
                        name, price, amount, deliveryDate));
            }
            else
            {
                productFileStorage.Add(
                    new VolumeProduct(
                        name, price, amount, deliveryDate));
            }
            IsSaved = false;
        }

        public bool Search(string key)
        {
            if (key == "")
            {
                SearchResult = productFileStorage;
            }
            else
            {
                SearchResult = new ProductList();
                foreach (Product product in productFileStorage)
                {
                    if ((product.Name.ToLower()).Contains(key.ToLower()))
                    {
                        SearchResult.Add(product);
                    }
                }
            }
            if (SearchResult.Count != 0)
            {
                return true;
            }
            return false;
        }

        public Product SearchForName(string name)
        {
            foreach (Product prod in productFileStorage)
            {
                if (prod.Name == name)
                {
                    return prod;
                }
            }
            return null;
        }

        public void DeleteFromStorage(string name, double quantity)
        {
            int index;

            for (index = 0; index < productFileStorage.Count; index++)
            {
                if (productFileStorage[index].Name == name) break;
            }
            if (index < productFileStorage.Count)
            {
                productFileStorage[index].Amount -= quantity;
                if (productFileStorage[index].Amount <= 0)
                {
                    productFileStorage.RemoveAt(index);
                }
            }
            SearchResult = productFileStorage;
            IsSaved = false;
        }

        public void SaveChanges()
        {
            DataAccess.WriteFile(fileName, productFileStorage);
            IsSaved = true;
        }

        public void AddToBasket(Product product, double quantity)
        {
            foreach (Purchase item in ProductBasket)
            {
                if (item.Name == product.Name)
                {
                    item.Quantity = quantity;
                    return;
                }
            }

            ProductBasket.Add(new Purchase(product, quantity));
        }

        public void Annulment()
        {
            ProductBasket = new PurchaseList();
        }

        public void CreateCheck(string fileName)
        {
            DataAccess.WriteFile(fileName, ProductBasket);

            foreach (Purchase purchase in ProductBasket)
            {
                DeleteFromStorage(purchase.Name, purchase.Quantity);
            }

            SaveChanges();
            Annulment();
        }
    }
}

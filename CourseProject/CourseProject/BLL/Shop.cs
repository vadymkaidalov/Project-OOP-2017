using CourseProject.DAL;
using System.IO;

namespace CourseProject.BLL
{
    class Shop
    {
        public ProductList ProductFileStorage;
        public PurchaseList ProductBasket;
        public ProductList SearchResult;
        public string FileName;

        public bool IsSaved { get; private set; }

        public bool IsBasketEmpty { get; private set; }

        public Shop(string fileName)
        {
            if (!File.Exists(fileName) || new FileInfo(fileName).Length == 0)
            {
                DataAccess.WriteFile(fileName, new ProductList());
            }
            ProductFileStorage = DataAccess.ReadFile(fileName);
            ProductBasket = new PurchaseList();
            SearchResult = ProductFileStorage;
            IsSaved = true;
            IsBasketEmpty = true;
            FileName = fileName;
        }

        public void AddToStorage(string name, double price, double amount, string measure, string deliveryDate)
        {
            if (measure == "кг")
            {
                ProductFileStorage.Add(new WeightProduct(name, price, amount, deliveryDate));
            }
            else if (measure == "шт")
            {
                ProductFileStorage.Add(new DiscreteProduct(name, price, amount, deliveryDate));
            }
            else
            {
                ProductFileStorage.Add(new VolumeProduct(name, price, amount, deliveryDate));
            }
            IsSaved = false;
        }

        public bool Search(string key)
        {
            if (key == "")
            {
                SearchResult = ProductFileStorage;
            }
            else
            {
                SearchResult = new ProductList();
                foreach (Product product in ProductFileStorage)
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

        public void DeleteFromStorage(string name, double quantity)
        {
            int index;
            for (index = 0; index < ProductFileStorage.Count; index++)
            {
                if (ProductFileStorage[index].Name == name) break;
            }
            if (index < ProductFileStorage.Count)
            {
                ProductFileStorage[index].Amount -= quantity;
                if (ProductFileStorage[index].Amount <= 0)
                {
                    ProductFileStorage.RemoveAt(index);
                }
            }
            SearchResult = ProductFileStorage;
            IsSaved = false;
        }

        public void SaveChanges()
        {
            DataAccess.WriteFile(FileName, ProductFileStorage);
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
            IsBasketEmpty = false;
        }

        public void Annulment()
        {
            ProductBasket = new PurchaseList();
            IsBasketEmpty = true;
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

using CourseProject.DAL;
using System.IO;

namespace CourseProject.BLL
{
    class Shop
    {
        public ProductList ProductFileStorage;
        public ProductList ProductBasket;
        public ProductList SearchResult;
        public string FileName;

        public bool IsSaved { get; set; }

        public Shop(string fileName)
        {
            if (new FileInfo(fileName).Length == 0)
            {
                DataAccess.WriteFile(fileName, new ProductList());
            }
            ProductFileStorage = DataAccess.ReadFile(fileName);
            ProductBasket = new ProductList();
            SearchResult = ProductFileStorage;
            IsSaved = true;
            FileName = fileName;
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
    }
}

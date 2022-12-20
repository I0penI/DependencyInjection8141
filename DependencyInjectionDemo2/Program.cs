namespace DependencyInjectionDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger= new DatabaseLogger();
            ProductService productService = new ProductService(logger);
            productService.Add();

            CategoryService categoryService = new CategoryService();
            categoryService.Update(new FileLogger());
            categoryService.Update(new DatabaseLogger());

            StoreService storeService = new StoreService()
            {
                Logger = new FileLogger()
            };
            storeService.Delete();
        }
    }
    class ProductService
    {
        private readonly ILogger _logger;
        #region Constructor Injection
        public ProductService(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            Console.WriteLine("Product Added");
            _logger.Log();
        }
        #endregion
    }
    class CategoryService
    {
        public void Update(ILogger logger) // method injection
        {
            Console.WriteLine("Category update");
            logger.Log();
        }
    }
    class StoreService
    {
        public ILogger Logger { get; set; } // property injection

        public void Delete()
        {
            Console.WriteLine("Store deleted");
            Logger.Log();
        }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
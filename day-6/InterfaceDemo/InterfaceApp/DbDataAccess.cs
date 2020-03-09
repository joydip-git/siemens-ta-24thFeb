namespace InterfaceApp
{
    interface IResource
    {
        void GetData();
    }
    interface IDataAccess : IResource
    {
        void Print();
    }
    interface ISettings
    {
        void ChangePath(string newPath);
    }
    class ResourceConfiguration
    {
        protected string defaultPath = "./";
    }
    abstract class DbDataAccess : ResourceConfiguration, IDataAccess, ISettings
    {
        string dbConnectionPath;
        public DbDataAccess(string path = null)
        {
            if (path != null)
                this.dbConnectionPath = path;
            else
                this.dbConnectionPath = this.defaultPath;
        }
        //implicit implementation
        //public void GetData()
        //{

        //}
        public abstract void GetData();
        //explicit implementation (can be called only explicitly--through interface variable)
        void IDataAccess.Print() { }
        //implicit implementation (can be called implicitly as well explicitly--through class variable as well as through interface variable)
        public void ChangePath(string newPath)
        {
            this.defaultPath = this.dbConnectionPath;
        }
    }
    class SqlDbDataAccess : DbDataAccess
    {
        public override void GetData()
        {

        }
    }
    class FileDataAccess : IDataAccess, ISettings
    {
        string filePath;
        //implicit implementation
        public void GetData()
        {

        }
        public void ChangePath(string newPath) { }
        public void Print() { }
    }
}

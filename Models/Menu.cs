namespace dotnet_rpg.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string Logo { get; set; }
        public List<parmItem> dbnames { get; set; }
        public string Language { get; set; }
        public string FullName { get; set; }
        public partial class parmItem
        {
            public string cod_APPL { get; set; }

            public string APP_NAME { get; set; }
        }
        public partial class MenuItem
        {
            public int id { get; set; }
            public object? ParentID { get; set; }
            public string Title { get; set; }
            public string Url { get; set; }

        }


    }
}

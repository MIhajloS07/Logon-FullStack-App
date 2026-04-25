namespace LOGON_APP
{
    internal class Note
    {
        public int Id { get; set; }
        public string Content { get; set; } = "";
        public override string ToString() => Content;
    }
}

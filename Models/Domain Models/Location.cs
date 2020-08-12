namespace Models.Domain_Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public int LocationOwner { get; set; }

        public virtual Person LocationOwnerNavigation { get; set; }
    }
}

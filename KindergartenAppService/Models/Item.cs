namespace KindergartenAppService.Models
{
    public abstract class Item:UniqueEntity
    {
        public string Reference { get; set; }
    }
}
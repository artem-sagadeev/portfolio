namespace Portfolio.Api.Entities
{
    public class Case
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public string ShortDescription { get; set; }
        
        public Guid PreviewImageId { get; set; }
        
        public Image PreviewImage { get; set; }
        
        public Guid MainImageId { get; set; }
        
        public Image MainImage { get; set; }
    }
}
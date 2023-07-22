namespace Portfolio.Api.Models
{
    public class CasePreviewModel
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string PreviewImagePath { get; set; }
    }
}
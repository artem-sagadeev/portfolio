namespace Portfolio.Api.Models
{
    public class CaseModel
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string PreviewImagePath { get; set; }
        
        public string MainImagePath { get; set; }
    }
}
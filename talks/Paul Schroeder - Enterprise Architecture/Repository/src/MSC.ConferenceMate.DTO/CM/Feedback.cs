// <auto-generated> - Template:DTO, Version:1.1, Id:58fa7ee2-89f7-41e6-85ed-8d4482653990
namespace MSC.ConferenceMate.DTO.CM
{
	public partial class Feedback
	{
		public Feedback()
		{
			InitializePartial();
		}

		public System.Guid FeedbackId { get; set; } // Primary key
		public int UserProfileId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int FeedbackTypeId { get; set; }
		public int FeedbackInitiatorTypeId { get; set; }
		public string Source { get; set; }
		public string RatingValue { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public bool Dispositioned { get; set; }
		public int? SessionId { get; set; }
		public int? FeaturedEventId { get; set; }
		public bool IsPublic { get; set; }
		public bool? IsChat { get; set; }
		public int DataVersion { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public string CreatedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public string ModifiedBy { get; set; }
		public bool IsDeleted { get; set; }
		// public virtual FeaturedEvent FeaturedEvent { get; set; }  -- Excluded navigation property per configuration.
		public virtual FeedbackInitiatorType FeedbackInitiatorType { get; set; } 
		public virtual FeedbackType FeedbackType { get; set; } 
		// public virtual Session Session { get; set; }  -- Excluded navigation property per configuration.
		public virtual UserProfile UserProfile { get; set; } 


		partial void InitializePartial();

	}
}
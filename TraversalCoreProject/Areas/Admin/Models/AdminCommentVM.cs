namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminCommentVM
    {
        public int ID { get; set; }
        public string CommentUser { get; set; }
        public string CommentContent { get; set; }
        public int DestinationID { get; set; }
        public int AppUserID { get; set; }
        public string AppUserName { get; set; }
        public string AppUserSurname { get; set; }

        public string DestinationName { get; set; }
        public string CreatedDate { get; set; }
        public string ModifedDate { get; set; }
        public string CommentReply { get; set; }

        public string Status { get; set; }

    }
}

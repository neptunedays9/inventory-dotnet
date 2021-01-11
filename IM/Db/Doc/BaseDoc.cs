namespace IM.Db.Doc
{
    public class BaseDoc
    {
        public ObjectId _id { get; set;}

        public BsonDateTime CreatedAt {get; set;}

        public BsonDateTime UpdatedAt {get; set;}
    }
}
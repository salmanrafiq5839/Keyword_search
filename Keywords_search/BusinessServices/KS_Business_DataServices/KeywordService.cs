using KS_Business_Model;

namespace KS_Business_DataServices
{
    public class KeywordService
    {
        private List<Keyword_Model> keyword = new List<Keyword_Model>();

        public List<Keyword_Model> GetAll()
        {
            keyword.Add(new Keyword_Model { id = 1, keywords = "youtube" });
            keyword.Add(new Keyword_Model { id = 2, keywords = "youtube search" });
            keyword.Add(new Keyword_Model { id = 3, keywords = "youtube topic" });
            keyword.Add(new Keyword_Model { id = 4, keywords = "youtube keywords" });
            return keyword;
        }
        


    }
}
namespace BGMSTORE.Module
{
    //API 사용 시 Post로 보낼 데이터를 담는 클래스
    //원래는 Json이나 C#에는 이를 표현할 방법이 크게 없으므로
    //Class로 Json 데이터를 정의하고, 나중에 Class를 Json 으로 직렬화(변환) 해서 전송한다.
    // {get; set;} 을 활용해 프로퍼티를 생성하면 컴파일러가 내부적으로 Getter / Setter 을 만들어
    // 간편하게 속성(멤버 변수)을 이용할 수 있다.
    public class PostData
    {
        public string operationName { get; set; }
        public Variables variables { get; set; }

        public string query =
            "query bgmDocuments($separator: String!, $category: String, $limit: Int!, $page: Int!, $searchQuery: String, $searchQueryType: String, $userId: String, $isComposition: Boolean, $sortBy: String, $sortOrder: Int) {\n  bgmDocuments(\n    separator: $separator\n    category: $category\n    limit: $limit\n    page: $page\n    searchQuery: $searchQuery\n    searchQueryType: $searchQueryType\n    userId: $userId\n    isComposition: $isComposition\n    sortBy: $sortBy\n    sortOrder: $sortOrder\n  ) {\n    _id\n    keyVal\n    user {\n      _id\n      email\n      nickname\n      signature\n      point\n      profileImageUrl\n      profileIconUrl\n      __typename\n    }\n    title\n    content\n    filename\n    category\n    upVoteCnt\n    commentCnt\n    isProcessing\n    queueJobProgress\n    albumartImageUrl\n    isComposition\n    ccl\n    duration\n    __typename\n  }\n}";

    }

    public class Variables
    {
        public string separator { get; set; }
        public int limit { get; set; }
        public int page { get; set; }

        public string searchQuery { get; set; }
        public string searchQueryType { get; set; }

        public bool isComposition { get; set; }


        /*
        public string query = "query bgmDocuments(" +
                              "$separator: String!, " +
                              "$category: String, " +
                              "$limit: Int!, " +
                              "$page: Int!, " +
                              "$searchQuery: String, " +
                              "$searchQueryType: String, " +
                              "$userId: String, " +
                              "$isComposition: Boolean, " +
                              "$sortBy: String, " +
                              "$sortOrder: Int" +
                              ") {\n  bgmDocuments(" +
                              "\n    separator: $separator\n    " +
                              "category: $category\n    " +
                              "limit: $limit\n    " +
                              "page: $page\n    " +
                              "searchQuery: " +
                              "$searchQuery\n    " +
                              "searchQueryType: " +
                              "$searchQueryType\n    " +
                              "userId: $userId\n    " +
                              "isComposition: $isComposition\n    " +
                              "sortBy: $sortBy\n    " +
                              "sortOrder: $sortOrder\n  " +
                              ") {\n    " +
                              "_id\n    " +
                              "keyVal\n    " +
                              "user {\n      " +
                              "_id\n      " +
                              "email\n      " +
                              "nickname\n      " +
                              "signature\n      " +
                              "point\n      " +
                              "profileImageUrl\n      " +
                              "profileIconUrl\n      " +
                              "__typename\n    }\n    " +
                              "title\n    " +
                              "content\n    " +
                              "filename\n    " +
                              "category\n    " +
                              "upVoteCnt\n    " +
                              "commentCnt\n    " +
                              "isProcessing\n    " +
                              "queueJobProgress\n    " +
                              "albumartImageUrl\n    " +
                              "isComposition\n    " +
                              "ccl\n    " +
                              "duration\n    " +
                              "__typename\n  " +
                              "}\n}";
        */



    }
}

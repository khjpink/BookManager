using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; } // 빌린 사람의 id
        public string UserName { get; set; } // 빌린 사람의 이름
        public bool IsBorrowed { get; set; } // 대여 여부 
        public DateTime BorrowedAt { get; set; } // 언제 빌렸는지
    }
}

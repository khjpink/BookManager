using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookManager
{
    public class DataManager
    {
        public static List<Book> books = new List<Book>();
        public static List<User> users = new List<User>();
        const string ISBN = "isbn";
        const string NAME = "name";
        const string USERID = "userId";
        const string USERNAME = "userName";
        const string ISBORROWED = "isBorrowed";
        const string BORROWEDAT = "borrowedAt";
        const string ID = "id";
        const string UNAME = "uName";
        const string BFILE = "./Books.xml";
        const string UFILE = "./Users.xml";

        static bool CheckBorrow(string isBorrowed) // 대여 여부 
        {
            return isBorrowed.Equals("1") ? true : false;
        }

        static int CheckBorrow(bool isBorrowed)  // 대여 여부  
        {
            return isBorrowed ? 1 : 0;
        }
        static string MakeTag(string tag, string contents)
        {
            return $"<{tag}>{contents}</{tag}>\n";
        }


        // 정적 생성자 : 딱 한번만 호출됨
        static DataManager() 
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string bOutput = File.ReadAllText(BFILE);
                XElement bx = XElement.Parse(bOutput);
                books.Clear();
                foreach(var item in bx.Descendants("book"))
                {
                    Book b = new Book();
                    b.Isbn = item.Element(ISBN).Value;
                    b.Name = item.Element(NAME).Value;
                    b.UserId = item.Element(USERID).Value;
                    b.UserName = item.Element(USERNAME).Value;
                    b.IsBorrowed = CheckBorrow(item.Element(ISBORROWED).Value);
                    b.BorrowedAt = DateTime.Parse(item.Element(BORROWEDAT).Value);
                    books.Add(b);

                }
                string uOutput = File.ReadAllText(UFILE);
                XElement ux = XElement.Parse(uOutput);
                users = (from user in ux.Descendants("user")
                        select new User()
                        {
                            Id=user.Element(ID).Value,
                            Name=user.Element(UNAME).Value,
                        }).ToList();
            }
            catch (Exception)
            {
                Save();
                Load();
            }

        }
        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<books>\n";
            foreach(var item in books)
            {
                booksOutput += "\t<book>" + Environment.NewLine;
                booksOutput += "\t\t" + MakeTag(ISBN, item.Isbn);
                booksOutput += "\t\t" + MakeTag(NAME, item.Name);
                booksOutput += "\t\t" + MakeTag(USERID, item.UserId);
                booksOutput += "\t\t" + MakeTag(USERNAME, item.UserName);
                booksOutput += "\t\t" + MakeTag(ISBORROWED, CheckBorrow(item.IsBorrowed).ToString());
                booksOutput += "\t\t" + MakeTag(BORROWEDAT, item.BorrowedAt.ToString());
                booksOutput += "\t</book>" + Environment.NewLine;
            }
            booksOutput += "</books>\n";
            File.WriteAllText(BFILE, booksOutput); // 기존 내용 지우고 새로운 내용으로 채워넣음

            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach(var item in users)
            {
                usersOutput += "\t<user>\n";
                usersOutput += "\t\t" + MakeTag(ID, item.Id);
                usersOutput += "\t\t" + MakeTag(UNAME, item.Name);
                usersOutput += "\t</user>\n";
            }
            usersOutput += "</users>\n";
            File.WriteAllText(UFILE, usersOutput);
        }
    }
}

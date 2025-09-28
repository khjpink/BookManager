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

        static bool checkBorrow(string isBorrowed)
        {
            return isBorrowed.Equals("1") ? true : false;
        }

        static int checkBorrow(bool isBorrowed)
        {
            return isBorrowed ? 1 : 0;
        }
        static string makeTag(string tag, string contents)
        {
            return $"<{tag}>{contents}</{tag}>\n";
        }

        static DataManager() // 정적 생성자 : 딱 한번만 호출됨
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
                    b.isbn = item.Element(ISBN).Value;
                    b.name = item.Element(NAME).Value;
                    b.userId = item.Element(USERID).Value;
                    b.userName = item.Element(USERNAME).Value;
                    b.isBorrowed = checkBorrow(item.Element(ISBORROWED).Value);
                    b.borrowedAt = DateTime.Parse(item.Element(BORROWEDAT).Value);
                    books.Add(b);

                }
                string uOutput = File.ReadAllText(UFILE);
                XElement ux = XElement.Parse(uOutput);
                users = (from user in ux.Descendants("user")
                        select new User()
                        {
                            id=user.Element(ID).Value,
                            name=user.Element(UNAME).Value,
                        }).ToList();
            }
            catch (Exception e)
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
                booksOutput += "\t\t" + makeTag(ISBN, item.isbn);
                booksOutput += "\t\t" + makeTag(NAME, item.name);
                booksOutput += "\t\t" + makeTag(USERID, item.userId);
                booksOutput += "\t\t" + makeTag(USERNAME, item.userName);
                booksOutput += "\t\t" + makeTag(ISBORROWED, checkBorrow(item.isBorrowed).ToString());
                booksOutput += "\t\t" + makeTag(BORROWEDAT, item.borrowedAt.ToString());
                booksOutput += "\t</book>" + Environment.NewLine;
            }
            booksOutput += "</books>\n";
            File.WriteAllText(BFILE, booksOutput); // 기존 내용 지우고 새로운 내용으로 채워넣음

            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach(var item in users)
            {
                usersOutput += "\t<user>\n";
                usersOutput += "\t\t" + makeTag(ID, item.id);
                usersOutput += "\t\t" + makeTag(UNAME, item.name);
                usersOutput += "\t</user>\n";
            }
            usersOutput += "</users>\n";
            File.WriteAllText(UFILE, usersOutput);
        }
    }
}

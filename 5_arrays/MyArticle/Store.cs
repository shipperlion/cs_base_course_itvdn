using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArticle
{
    class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index].Info();
                return "Index out of range";
            }
        }

        public void AddArticle(Article value, int index)
        {
            if (index >= 0 && index < articles.Length)
                articles[index] = value;
            else
                Console.WriteLine("Index out of range");
        }

        public string this[string index]
        {
            get
            {
                for(int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name == index)
                        return articles[i].Info();
                }
                return string.Format("\"{0}\" нет в наличии", index);
            }
        }

        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
                Console.WriteLine(articles[i].Info());
        }

        public void Sort()
        {
            for (int i = 0; i <= articles.Length - 1; i++)
            {
                for (int q = 0; q <= articles.Length - 1; q++)
                {
                    if (articles[i].Price <= articles[q].Price)
                    {
                        Article g = articles[i];
                        articles[i] = articles[q];
                        articles[q] = g;
                    }
                }


            }
        }
    }
}

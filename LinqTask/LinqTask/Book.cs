using System;
using System.Collections.Generic;
using System.Text;

namespace LINQtoObject
{
  public class Book : IComparable<Book>
  {
    public IEnumerable<Author> Authors {get; set;}
    public String Isbn {get; set;}
    public String Notes {get; set;}
    public Int32 PageCount {get; set;}
    public Decimal Price {get; set;}
    public DateTime PublicationDate {get; set;}
    public Publisher Publisher {get; set;}
		public IEnumerable<Review> Reviews {get; set;}
    public Subject Subject {get; set;}
    public String Summary {get; set;}
    public String Title {get; set;}

        public int CompareTo(Book? other)
        {
            return 0;
        }

        public override String ToString()
    {
      return $"Title {Title} :  Price : {Price} ";
    }
  }
}
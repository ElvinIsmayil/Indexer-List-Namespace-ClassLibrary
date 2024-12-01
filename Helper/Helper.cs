namespace PB503Helper;

public static class Helper
{

    public static string CreateBookCode(string bookname, int id)
    {
        string bookCode = string.Empty;
        
        if(!string.IsNullOrEmpty(bookname))
        {
            if (bookname.Length > 2)
            {
                bookCode = bookname.Substring(0, 2).ToUpper() + id;
                return bookCode;
            }
        }

        return null;

    }


}

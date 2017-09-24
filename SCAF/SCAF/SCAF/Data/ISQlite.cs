using SQLite;

namespace SCAF.Data
{
    public interface ISQlite
    {
        SQLiteConnection GetConnection();
    }
}

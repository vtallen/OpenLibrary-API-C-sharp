namespace BookTracker.OpenLibraryAPI;

public class OpenLibraryAPI
{
   private HttpClient _httpClient = new()
   {
      BaseAddress = new Uri("https://openlibrary.org")
   };

   public OpenLibraryAPI(string appName, double appVersion, string developerContact)
   {
      // Identifies this application to the OpenLibrary API as per their terms
      this._httpClient.DefaultRequestHeaders.Add("User-Agent", $"{appName}/{appVersion} ({developerContact})");
      
      
   }
   
   /* ==========================================================
    * Public functions
    * ========================================================== 
    */
   public List<SearchResult> Search(string query)
   {
      return [];
   }

}
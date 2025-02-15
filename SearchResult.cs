namespace BookTracker.OpenLibraryAPI;

public class SearchResult
{
    // A list of variations of the author's name (pseudonyms, translations, mispellings)
    public List<string>? AuthorAlternativeNames { get; set; } 

    // The unique identifier for this author in OpenLibrary system
    // key value: author_key 
    public List<string>? AuthorKeys { get; set; } 

    // The primary name of the author
    // key value: author_name
    public List<string>? AuthorNames { get; set; } 

    // A List of collaborators on the book
    // key value: contributor
    public List<string>? ContributorNames { get; set; } 
    
    // The dewey decimal classification numbers associated with the book
    // key value: ddc
    public List<string>? DeweyDecimalClassification { get; set; } 
    
    // The first sentence of the book
    // key value: first_sentence
    public List<string>? FirstSentences { get; set; } 
    
    // A list of formats in which the book is available
    // key value: format
    public List<string>? Formats { get; set; } 
    
    // A list of collections in the Internet Archive where the book is available
    // key value: ia_collection
    public List<string>? InternetArchiveCollections { get; set; } 
    
    // A semicolon-seperated list of collections in the Internet Archive where this books is available
    // key value: ia_collection_s
    public string? InternetArchiveCollectionsString { get; set; }
    
    // A list of identifiers for this book in the Internet Archive
    // key value: ia
    public List<string>? InternetArchiveKeys { get; set; }
    
    // Library of congress classification numbers for this book
    // key value: lcc
    public List<string>? LibraryOfCongressClassificationNumbers { get; set; } 
    
    // Library of congress control numbers associated with this book
    // key value: lccn
    public List<string>? LibraryOfCongressControlNumbers { get; set; } 
    
    
    
    // A list of ISBNs associated with this book
    // key value: isbn
    public List<string>? ISBNs { get; set; } 
       
    // A list of languages in which this book is available
    // key value: language
    public List<string>? Languages { get; set; }
    
    // A list of all OCLC numbers associated with the book
    // key value: oclc
    public List<string>? OCLCNumbers { get; set; } 
    
    // A list of publication dates for various editions of the book
    // key value: publish_date
    public List<string>? PublishDates { get; set; } 
    
    // A list of places where the book was published
    // key value: publish_place
    public List<string>? PublishPlaces { get; set; } 
    
    // A list of years in which this book was published
    // key value: publish_year
    public List<int>? PublishYears { get; set; } 
    
    // A list of publishers associated with this book
    // key value: publisher 
    public List<string>? Publishers { get; set; } 
    
    // A list of seed values used for generating URLs in the OpenLibrary system
    // key value: seed
    public List<string>? Seeds { get; set; } 
    
    // A list of unique identifiers for each edition of this book
    // key value: edition_key
    public List<string>? EditionKeys { get; set; } 
    
    // The goodreads ids for the book
    // key value: id_goodreads
    public List<string>? GoodreadsIds { get; set; }
    
    // The LibraryThing identifiers for this book
    // key value: id_librarything
    public List<string>? LibraryThingIds { get; set; }
    
    // A list of Deutsche Nationalbibliothek (DNB) identifiers for this book
    // key value: id_dnb
    public List<string>? DNBIds { get; set; }
    
    // A list of digital object identifiers for this book
    // key value: id_doi
    public List<string>? DigitalObjectIds { get; set; }
    
    // A list of amazon identifiers for this book
    // key value: id_amazon
    public List<string>? AmazonIds { get; set; }
    
    // A list of legal deposit identifiers for the book
    // key value: id_deposito_legal
    public List<string>?  LegalDepositIdentifiers { get; set; }
    
    // A list of albris identifiers for this book
    // key value: id_alibris_id
    public List<string>? AlbrisIds { get; set; }
    
    // A list of google books identifiers
    // key value: id_google
    public List<string>? GoogleIds { get; set; }
    
    // A list of paperback swap identifiers for this book
    // key value: id_paperback_swap
    public List<string>? PaperbackSwapIds { get; set; }
    
    // A list of wikidata ids for this book
    // key value: id_wikidata
    public List<string>? WikidataIds { get; set; }
    
    // A list of better world books ids for this book
    // key value: id_better_world_books
    public List<string>? BetterWorldBooksIds { get; set; }
    
    // A list of overdrive identifiers for this book
    // key value: id_overdirve
    public List<string>? OverdriveIds { get; set; }
    
    
    
    // The unique identifier of the edition of the book used for the default cover image 
    // key value: cover_edition_key
    public string? CoverEditionKey { get; set; }

    // The unique identifier for this cover 
    // cover_i
    public int? CoverKey { get; set; }

    // Indicates if an ebook is available
    // key value: ebook_access
    public string? EbookAccess { get; set; }

    // The number of ebook editions of this book
    // key value: ebook_count_i 
    public int? NumberOfEbookEditions { get; set; }
    
    // The number of editions of this book in OpenLibrary
    // key value: edition_count
    public int? NumberOfEditions { get; set; }
    
    // The first year this book was published
    // key value: first_publish_year
    public int? FirstPublicationYear { get; set; }
    
    // Whether the full text of this book is available in the OpenLibrary system 
    // key value: has_fulltext
    public bool? HasFullText { get; set; }
    
    // A unique identifier for this book in OpenLibrary
    // key value: key
    public string? Key { get; set;}
    
    // A timestamp when this record was last modified         
    // key value: last_modified_i
    public int? RecordLastModifiedTime { get; set; } 
    
    // The identifier for the edition of the book that is available for lending
    // key value: lending_edition_s
    public string? LendingEditionKey { get; set; }
    
    // The unique identifier for the book in the lending library system
    // key value: lending_identifier_s
    public string? LendingSystemKey { get; set; }
    
    // The median number of pages across all editions of the book
    // key value: number_of_pages_median
    public int? MedianNumberPages { get; set; }
    
    // The number of Open Syllabus Project citations for the book
    // key value: osp_count
    public int? OpenSyllabusProjectCount { get; set; }
    
    // A semi-colon seperated list of edition keys for accessible versions of this book
    // key value: printdisabled_s
    public string? AccessibleEditionsString { get; set; }
    
    // Indicates whether the book is publicly available for scanning
    // key value: public_scan_b
    public bool? IsPublicallyScannable { get; set; }
    
    // Subtitle of the book
    // key value: subtitle
    public string? Subtitle { get; set; }
    
    // Title of the book
    // key value: title
    public string? Title { get; set; }
    
    // A normalized version of the title used for sorting
    // key value: title_sort
    public string? TitleSort { get; set; }
    
    // A suggested title for the book
    // key value: title_string
    public string? TitleSuggest { get; set; } 
    
    // The type for the record
    // key value: type
    public string? Type { get; set; }
    
}

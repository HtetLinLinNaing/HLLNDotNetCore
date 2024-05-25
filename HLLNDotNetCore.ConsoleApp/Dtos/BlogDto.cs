
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HLLNDotNetCore.ConsoleApp.Dtos;

[Table("Tbl_blog")]  
public class BlogDto {
    [Key]   
    public int BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set; }
    public string BlogContent { get; set; }

}

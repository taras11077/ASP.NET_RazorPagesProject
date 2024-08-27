using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Products = new List<Product>();
    }

    public List<Product> Products { get; set; }
    
    public void OnGet()
    {
        
        
    }
    
    
}
{{~ if Bag.PagesFolder; pagesNamespace = Bag.PagesFolder + "."; end ~}}
using System.Threading.Tasks;
{{~ if Option.CreateGetListInput ~}}
using {{ ProjectInfo.FullName }}.Web.Pages.{{ pagesNamespace }}{{ EntityInfo.RelativeNamespace}}.{{ EntityInfo.Name }}.ViewModels;
{{~ end ~}}

namespace {{ ProjectInfo.FullName }}.Web.Pages.{{ pagesNamespace }}{{ EntityInfo.RelativeNamespace }}.{{ EntityInfo.Name }};

public class IndexModel : {{ ProjectInfo.Name }}PageModel
{
    {{~ if Option.CreateGetListInput ~}}
    public {{ EntityInfo.Name }}GetListInputModel {{ EntityInfo.Name }}Filter { get; set; }
    {{~ end ~}}
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}
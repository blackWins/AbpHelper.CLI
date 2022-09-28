{{- SKIP_GENERATE = !Option.CreateGetListInput -}}
using System;
{{~ if !Option.SkipLocalization ~}}
using System.ComponentModel;
{{~ end ~}}
using AutoFilterer.Enums;
using AutoFilterer.Types;
using AutoFilterer.Attributes;
using Volo.Abp.Application.Dtos;
namespace {{ EntityInfo.Namespace }}.Dtos;

public class {{ EntityInfo.Name }}GetListInput: FilterBase, IPagedAndSortedResultRequest
{
    public virtual int SkipCount { get; set; }
    public virtual int MaxResultCount { get; set; }
    public virtual string Sorting { get; set; }

    {{~ for prop in EntityInfo.Properties ~}}
    {{~ if prop | abp.is_ignore_property; continue; end ~}}
    {{~ if !Option.SkipLocalization ~}}
    [DisplayName("{{ EntityInfo.Name + prop.Name}}")]
    {{~ end ~}}
    {{~ if prop.Type=="string" ~}}
    [StringFilterOptions(StringFilterOption.Contains)]
    {{~ else ~}}
    [OperatorComparison(OperatorType.Equal)]
    {{~ end ~}}
    [CompareTo(nameof({{ EntityInfo.Name}}Dto.{{ prop.Name }}))]
    public {{ prop.Type}}{{~ if prop.Type!="string"; "?"; end}} {{ prop.Name }} { get; set; }
    {{~ if !for.last ~}}

    {{~ end ~}}
    {{~ end ~}}
}
using System;
using {{ EntityInfo.Namespace }}.Dtos;
{{~ if !Option.CreateGetListInput ~}}
using Volo.Abp.Application.Dtos;
{{~ end ~}}
using Volo.Abp.Application.Services;

namespace {{ EntityInfo.Namespace }};

public interface I{{ EntityInfo.Name }}AppService :
    ICrudAppService< 
        {{ DtoInfo.ReadTypeName }}, 
        {{ EntityInfo.PrimaryKey ?? EntityInfo.CompositeKeyName }}, 
        {{~ if Option.CreateGetListInput ~}} 
        {{EntityInfo.Name}}GetListInput,
        {{~ else ~}}
        PagedAndSortedResultRequestDto, 
        {{end ~}}
        {{ DtoInfo.CreateTypeName }},
        {{ DtoInfo.UpdateTypeName }}>
{

}
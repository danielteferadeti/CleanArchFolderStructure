using CleanArch.Application.Features._Indices.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Features._Indices.CQRS.Queries
{
    public class Get_IndexListQuery: IRequest<List<_IndexDto>>
    {
    }
}

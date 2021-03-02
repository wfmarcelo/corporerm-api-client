using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporeRMApi.Models.Educacional;
using Uniarp.Util;

namespace CorporeRMApi.DataServer
{
    public class EduAtividadeProfessorData : DataServer<SAtividadeProfessor>
    {
        public EduAtividadeProfessorData(CorporeRMApiClient corporeRMApiClient) 
            : base(corporeRMApiClient, nameof(EduAtividadeProfessorData))
        {
        }
    }
}
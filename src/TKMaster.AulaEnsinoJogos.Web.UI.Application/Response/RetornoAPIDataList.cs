using System.Collections.Generic;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Application.Response
{
    public class RetornoAPIDataList<T> : RetornoAPI
    {
        public List<T> Data { get; set; }
    }
}

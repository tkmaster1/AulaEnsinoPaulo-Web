namespace TKMaster.AulaEnsinoJogos.Web.UI.Application.BaseService
{
    public class Notification
    {
        #region properties

        public string Key { get; }

        public string Message { get; }

        #endregion

        #region Constructor

        public Notification(string key, string message)
        {
            Key = key;
            Message = message;
        }

        #endregion
    }
}

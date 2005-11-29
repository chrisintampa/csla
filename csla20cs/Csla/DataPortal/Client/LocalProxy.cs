using System;
using Csla.Server;

namespace Csla.DataPortalClient
{
  public class LocalProxy : DataPortalClient.IDataPortalProxy
  {
    private Server.IDataPortalServer _portal;

    private Server.IDataPortalServer Portal
    {
      get
      {
        if (_portal == null)
          _portal = new Server.DataPortal();
        return _portal;
      }
    }

    public DataPortalResult Create(
      Type objectType, object criteria, DataPortalContext context)
    {
      return Portal.Create(objectType, criteria, context);
    }

    public DataPortalResult Fetch(object criteria, DataPortalContext context)
    {
      return Portal.Fetch(criteria, context);
    }

    public DataPortalResult Update(object obj, DataPortalContext context)
    {
      return Portal.Update(obj, context);
    }

    public DataPortalResult Delete(object criteria, DataPortalContext context)
    {
      return Portal.Delete(criteria, context);
    }

    public bool IsServerRemote
    {
      get { return false; }
    }

  }
}

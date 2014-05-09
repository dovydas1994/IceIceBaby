using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceSubs.Models
{
    public class MediaRepository : IDisposable
    {
        IceSubsContext1 m_db = new IceSubsContext1();
        public IQueryable<Medium> GetAllMedia()
        {
            return m_db.Media;
        }

        public void Dispose()
        {
            m_db.Dispose();
        }
    }
}
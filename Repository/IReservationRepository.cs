﻿using Agentie_turism_transport_csharp.Domain;
using Agentie_turism_transport_csharp.Repository;

namespace Agentie_turism_transport_csharp.repository
{
    public interface IReservationRepository : IRepository<long, Reservation>
    {
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NServiceBus
{
    /// <summary>
    /// Contains extension methods to NServiceBus.Configure.
    /// </summary>
    public static class ConfigureSagas
    {
        /// <summary>
        /// Configure this endpoint to support sagas.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static Configure Sagas(this Configure config)
        {
            NServiceBus.Saga.Configure
                .With(config.Configurer, config.Builder)
                .SagasIn(Configure.TypesInCurrentDirectory);

            return config;
        }
    }
}
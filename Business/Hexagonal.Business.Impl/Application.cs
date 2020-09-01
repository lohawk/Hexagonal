using Hexagonal.Business.Impl.Item;
using Hexagonal.Business.Interface;
using Hexagonal.Business.Interface.Item;
using Hexagonal.Persistence.Interface;
using System;

namespace Hexagonal.Business.Impl
{
    public class Application : IApplication
    {
        private readonly IHandleItemState _stateManager;

        public Application(IHandleItemState stateManager) => 
            _stateManager = stateManager;

        // Generic dispatch handler
        public TResp Dispatch<TReq, TResp>(TReq request)
            where TResp : IApplicationResponse
            where TReq : IApplicationRequest
        {
            // Map all the domain handlers 
            // Normally we'd use infrastructure / framework to do this like Mediatr
            return request switch
            {
                CreateItem ci => ItemCommands.Execute(ci, _stateManager) as TResp,
                ItemQuery q => ItemQueries.Query(q, _stateManager) as TResp,

                _ => throw new NotImplementedException(),
            };
        }
    }
}

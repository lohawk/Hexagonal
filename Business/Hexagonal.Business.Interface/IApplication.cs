﻿namespace Hexagonal.Business.Interface
{
    public interface IApplication
    {
        TResp Dispatch<TReq, TResp>(TReq request)
            where TResp : IApplicationResponse
            where TReq : IApplicationRequest;
    }

    public abstract class IApplicationResponse { }
    public abstract class IApplicationRequest { }
    public abstract class IApplicationCommand : IApplicationRequest { }
    public abstract class IApplicationQuery : IApplicationRequest { }
}

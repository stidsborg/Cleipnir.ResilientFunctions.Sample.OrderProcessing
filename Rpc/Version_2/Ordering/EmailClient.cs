﻿using Serilog;

namespace Sample.WebApi.Ordering;

public interface IEmailClient
{
    Task SendOrderConfirmation(Guid customerId, IEnumerable<Guid> productIds);
}

public class EmailClientStub : IEmailClient
{
    public Task SendOrderConfirmation(Guid customerId, IEnumerable<Guid> productIds)
        => Task.Delay(100).ContinueWith(_ => 
            Log.Logger.Information("EMAIL_SERVER: Order confirmation emailed")
        );
}
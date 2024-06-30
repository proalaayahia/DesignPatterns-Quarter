namespace StatePattern.Core;

internal enum OrderState
{
    Draft,
    Confirmed,
    UnderProcessing,
    Shipped,
    Delivered,
    Returned,
    Canceled
}

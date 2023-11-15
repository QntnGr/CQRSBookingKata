
namespace CQRSBookingKata.Booking;

public interface IBookingHandler<in T>
{
    ValueTask Handle(T command, CancellationToken token);
}

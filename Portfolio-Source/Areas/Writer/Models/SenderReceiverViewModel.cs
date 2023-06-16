using EntityLayer.Concrete;

namespace Portfolio_Source.Areas.Writer.Models
{
    public class SenderReceiverViewModel
    {
        public List<WriterMessage> SentMessages { get; set; }
        public List<WriterMessage> ReceivedMessages { get; set; }
    }
}

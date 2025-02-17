﻿
namespace Post.Common.Events
{
    public class CommentUpdatedEvent : BaseEvent
    {
        public CommentUpdatedEvent() : base(nameof(CommentUpdatedEvent))
        {
        }

        public Guid CommentId {  get; set; }
        public string Comment { get; set; } = default!;
        public string Usename { get; set; } = default!;
        public DateTime EditDate {  get; set; }
    }
}

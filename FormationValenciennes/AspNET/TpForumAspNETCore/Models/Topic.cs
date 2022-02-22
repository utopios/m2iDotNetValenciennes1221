using System.Collections.Generic;
using System;

namespace TpForumAspNETCore.Models
{
    public class Topic
    {
        private int id;
        private DateTime dateCreation;
        private User author;
        private string subject;
        private string text;
        private List<Message> messages;
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace MessageBoard.Data
{
    public class MessageBoardMigrationsConfiguration
        : DbMigrationsConfiguration<MessageBoardContext>
    {
        public MessageBoardMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MessageBoardContext context)
        {
            base.Seed(context);
#if DEBUG
            if (context.Topics.Count() == 0)
            {
                var topic = new Topic()
                {
                    Title = "Test Topic",
                    Created = DateTime.Now,
                    Body = "This is test this is test this is test this is test this is test this is test this is test this is test",
                    Replies = new List<Reply>() 
                    {
                        new Reply() 
                        {
                            Body = "Test reply!",
                            Created = DateTime.Now
                        },
                        new Reply() 
                        {
                            Body = "Test reply!",
                            Created = DateTime.Now
                        },
                        new Reply() 
                        {
                            Body = "Test reply!",
                            Created = DateTime.Now
                        }
                    }
                };

                context.Topics.Add(topic);

                var anotherTopic = new Topic()
                {
                    Title = "Test Another Topic",
                    Created = DateTime.Now,
                    Body = "This is another topic this is another topic this is another topic this is another topic this is another topic",
                };

                context.Topics.Add(anotherTopic);

                

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    var msg = ex.Message;
                }

            }
#endif
        }
    }
}

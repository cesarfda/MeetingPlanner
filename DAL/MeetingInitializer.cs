using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MeetingPlanner.Models;

namespace MeetingPlanner.DAL
{
    public class MeetingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MeetingContext>
    {
        protected override void Seed(MeetingContext context)
        {
            var hymns = new List<Hymn>
            {
            new Hymn{Number=1,Title="Hymn 1"},
            new Hymn{Number=2,Title="Hymn 2"},
            new Hymn{Number=3,Title="Hymn 3"},
            new Hymn{Number=4,Title="Hymn 4"},
            new Hymn{Number=5,Title="Hymn 5" },
            new Hymn{Number=6,Title="Hymn 6"},
            new Hymn{Number=7,Title="Hymn 7"},
            new Hymn{Number=8,Title="Hymn 8"}
            };

            hymns.ForEach(s => context.Hymns.Add(s));
            context.SaveChanges();

            var leaders = new List<Leader>
            {
            new Leader{Name="Alexander"},
            new Leader{Name="Alonso"},
            new Leader{Name="Anand"},
            new Leader{Name="Barzdukas"},
            new Leader{Name="Li" },
            new Leader{Name="Justice"},
            new Leader{Name="Norman"},
            new Leader{Name="Olivetto"}
            };
            leaders.ForEach(s => context.Leaders.Add(s));
            context.SaveChanges();



            var subjects = new List<Subject>
            {
            new Subject{SpeakerName="Olivetto", SubjectTitle="Fatih"},
            new Subject{SpeakerName="Olivetto", SubjectTitle="Repentance"},
            new Subject{SpeakerName="Olivetto", SubjectTitle="Baptism"},
            new Subject{SpeakerName="Olivetto", SubjectTitle="Holy Ghost"},
            new Subject{SpeakerName="Olivetto", SubjectTitle="Endure to the end"}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
        }
    }
}
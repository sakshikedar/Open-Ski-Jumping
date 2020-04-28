using System;
using System.Collections.Generic;
using OpenSkiJumping.Competition.Persistent;
using OpenSkiJumping.Hills;

namespace OpenSkiJumping.UI.CalendarEditor.Events
{
    public interface ICalendarEditorEventsView
    {
        EventInfo SelectedEvent { get; set; }
        IEnumerable<EventInfo> Events { set; }

        EventRoundsInfo SelectedRoundsInfo { get; set; }
        IEnumerable<EventRoundsInfo> RoundsInfos { set; }

        IEnumerable<ClassificationInfo> SelectedClassifications { get; set; }
        IEnumerable<ClassificationInfo> Classifications { set; }

        IEnumerable<ProfileData> Hills { set; }
        ProfileData SelectedHill { get; set; }

        int EventType { get; set; }
        int QualRankType { get; set; }
        string QualRankId { get; set; }
        int OrdRankType { get; set; }
        string OrdRankId { get; set; }
        int InLimitType { get; set; }
        int InLimit { get; set; }

        event Action OnSelectionChanged;
        event Action OnCurrentEventChanged;
        event Action OnAdd;
        event Action OnRemove;
        event Action OnMoveUp;
        event Action OnMoveDown;
        event Action OnDataReload;
        bool EventInfoEnabled { set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MoviesRanker.Enums
{
    public enum Genre
    {
        Absurdist,
        Surreal,
        Whimsical,
        Action,
        Adventure,
        Animation,
        Biography,
        Comedy,
        Crime,
        Documentary,
        Drama,
        Family,
        Fantasy,
        [Description("Film Noir")]
        FilmNoir,
        [Description("Game Show")]
        GameShow,
        History,
        [Description("Historical Fiction")]
        HistoricalFiction,
        Horror,
        [Description("Magical Realism")]
        MagicalRealism,
        Musical,
        Mystery,
        News,
        Paranoid,
        Philosophical,
        Political,
        [Description("Reality TV")]
        RealityTV,
        Romance,
        Saga,
        Satire,
        [Description("Sci Fi")]
        SciFi,
        [Description("Slice Of Life")]
        SliceOfLife,
        Social,
        Speculative,
        Sport,
        [Description("Talk Show")]
        TalkShow,
        Thriller,
        Urban,
        War,
        Western
    }
}
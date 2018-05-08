﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando:SpecialisedSoldier,ICommando
{
    private List<IMission> missions;

    public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
    {
        missions = new List<IMission>();
    }

    public IReadOnlyCollection<IMission> Missions
    {
        get { return this.missions; }
    }
    public void AddMission(IMission mission)
    {
        this.missions.Add(mission);
    }
    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine("Missions:");

        this.missions
            .ForEach(m => builder.AppendLine(m.ToString()));

        return builder.ToString().TrimEnd();
    }
}
CREATE TABLE [dbo].[task] (
    [taskid]            INT           IDENTITY (1, 1) NOT NULL,
    [taskname]          VARCHAR (20)  NOT NULL,
    [taskdesc]          VARCHAR (200) NULL,
    [project_projectid] INT           NOT NULL,
    [estdtime]          DATETIME      NULL,
    [startdate]         DATETIME      NOT NULL,
    [team_teamid]       INT           NULL,
    CONSTRAINT [task_pk] PRIMARY KEY CLUSTERED ([taskid] ASC),
    CONSTRAINT [task_project_fk] FOREIGN KEY ([project_projectid]) REFERENCES [dbo].[project] ([projectid]) ON DELETE CASCADE,
    CONSTRAINT [task_team_fk] FOREIGN KEY ([team_teamid]) REFERENCES [dbo].[team] ([teamid])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [task__idx]
    ON [dbo].[task]([team_teamid] ASC);


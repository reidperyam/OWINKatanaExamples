This Project was build from the following tutorial

http://www.asp.net/aspnet/overview/owin-and-katana/owin-middleware-in-the-iis-integrated-pipeline

Stage Marker Rules

Owin middleware components (OMC) can be configured to run at the following OWIN pipeline stage events:
public enum PipelineStage
{
    Authenticate = 0,
    PostAuthenticate = 1,
    Authorize = 2,
    PostAuthorize = 3,
    ResolveCache = 4,
    PostResolveCache = 5,
    MapHandler = 6,
    PostMapHandler = 7,
    AcquireState = 8,
    PostAcquireState = 9,
    PreHandlerExecute = 10,
}
1.By default, OMCs run at the last event (PreHandlerExecute). That's why our first example code displayed "PreExecuteRequestHandler".
2.You can use the app.UseStageMarker method to register a OMC to run earlier, at any stage of the OWIN pipeline listed in the  PipelineStage enum.
3.The OWIN pipeline and the IIS pipeline is ordered, therefore calls to app.UseStageMarker must be in order. You cannot set the event handler to an event that precedes the last event registered with to app.UseStageMarker. For example, after calling:

app.UseStageMarker(PipelineStage.Authorize);

 calls to app.UseStageMarker passing Authenticate or PostAuthenticate will not be honored, and no exception will be thrown. OMCs run at the latest stage, which  by default is  PreHandlerExecute. The stage markers are used to make them to run earlier. If you specify stage markers out of order, we round to the earlier marker. In other words, adding a stage marker says "Run no later than stage X". OMC's run at the earliest stage marker added after them in the OWIN pipeline.
4.The earliest stage of calls  to app.UseStageMarker wins. For example, if you switch the order of  app.UseStageMarker calls from our previous example:


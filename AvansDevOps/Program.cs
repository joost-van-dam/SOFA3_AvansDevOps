// See https://aka.ms/new-console-template for more information
using AvansDevOps.Domain.CompositeAndVisitor;

Pipeline pipeline = new Pipeline("release pipeline");

Stage stage1 = new Stage("Sources");
Stage stage2 = new Stage("Packages");
Stage stage3 = new Stage("Build");
Stage stage4 = new Stage("Test");
Stage stage5 = new Stage("Analyse");
Stage stage6 = new Stage("Deploy");
Stage stage7 = new Stage("Utility");
pipeline.AddComponent(stage1);
pipeline.AddComponent(stage2);
pipeline.AddComponent(stage3);
pipeline.AddComponent(stage4);
pipeline.AddComponent(stage5);
pipeline.AddComponent(stage6);
pipeline.AddComponent(stage7);

stage1.AddComponent(new Command("nuget install package1"));
stage1.AddComponent(new Command("nuget install package2"));
stage1.AddComponent(new Command("nuget install package3"));
stage1.AddComponent(new Command("nuget install package4"));

stage2.AddComponent(new Command("dotnet download packages part 1"));
stage2.AddComponent(new Command("dotnet download packages part 2"));
stage2.AddComponent(new Command("dotnet download packages part 3"));

stage3.AddComponent(new Command("dotnet build"));

stage4.AddComponent(new Command("dotnet test"));

stage5.AddComponent(new Command("dotnet generate test raport -advanced"));
stage5.AddComponent(new Command("dotnet publish test rapport"));

stage6.AddComponent(new Command("dotnet push container-registry-123"));

stage7.AddComponent(new Command("copy files 123"));
stage7.AddComponent(new Command("execute script 456"));

ExecutionVisitor executionVisitor = new ExecutionVisitor();
pipeline.AcceptVisitor(executionVisitor);
//pipeline.AcceptVisitor(new DryRunVisitor());












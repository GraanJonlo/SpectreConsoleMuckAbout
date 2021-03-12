open System

open Spectre.Console

[<EntryPoint>]
let main _ =
    let table = new Table()
    table.AddColumn(new TableColumn(new Markup("[yellow]Foo[/]"))) |> ignore
    table.AddColumn(new TableColumn("[blue]Bar[/]")) |> ignore
    let row = new TableRow([new Markup("[yellow]Foo[/]"); new Markup("[yellow]Foo[/]")])
    table.AddRow(row) |> ignore
    AnsiConsole.Render(table)

    AnsiConsole.Markup("[underline green]Hello[/] ")
    AnsiConsole.MarkupLine("[bold]World[/]")

    AnsiConsole.Markup("[bold yellow on blue]Hello[/] ")
    AnsiConsole.MarkupLine("[default on blue]World[/]")

    AnsiConsole.MarkupLine("Hello :sparkles:!")

    let image = new CanvasImage("cake.png")
    image.MaxWidth <- 16
    AnsiConsole.Render(image)

    0

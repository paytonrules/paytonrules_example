#load "../siteModel.fsx"

open Html
open SiteModel

let biography = "I sling code, teach developers, and speak at conferences. Occasionally I write on this blog, usually about things I just learned myself."

let defaultPage (siteModel : SiteModel) pageTitle content =
    html [] [
        head [] [
            meta [CharSet "utf-8"]
            title [] [ (!! pageTitle) ]
            link [ Rel "stylesheet"; Type "text/css"; Href "/css/style.css" ]
            link [ Rel "alternate"; Type "application/atom+xml"; Href "/feed.xml"; HtmlProperties.Title "News Feed" ]
            link [ Rel "shortcut icon"; Href "/images/favicon.ico"]
        ]
        body [] [
            div [Class "wrapper"] [
                div [Class "hero-image-background"] [
                    div [Class "hero"] [
                        header [] [
                            a [ Href "/" ] [ !! (siteModel.title)]
                            a [ Href "/archive.html"] [ !! "Archive"]
                        ]
                        img [ Class "headshot"; Src "/images/square-head.jpeg" ]
                        span [] [
                            h1 [] [!! "Eric Smith"]
                            h2 [] [!! biography]
                        ]
                    ]
                ]

                div [ Id "content"] content
            ]
        ]
    ]
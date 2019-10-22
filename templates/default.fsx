#load "../siteModel.fsx"

open Html
open SiteModel

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
                        span [] []
                        span [] [
                            h1 [] [!! "Eric Smith"]
                            h2 [] [!! "I am the shiznit"]
                        ]
                    ]
                ]

                div [ Id "content"] content
            ]
        ]
    ]
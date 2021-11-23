# TennoTab

Tenno Tab is a companion webb-application for the game Warframe. Looking at the game's website, [https://www.warframe.com/] it's already apparent that the game has a lot of content, and it can be difficult to choose what to do next. The core forcus of Warframe is collecting items, and this is where Tenno Tab can help.

Tenno Tab is designed to help users determine which Warframe content to play next by providing clear goals. Every item in the game is outlined and searchable, and each user can keep their own wishlist to track the items they are going for next.

The project is hosted on Github Pages at [https://jimmyhaglund.github.io/TennoTab].

## Features

### Collectibles List

A filterable and searchable list of every collectible in Warframe, providing users with a quick and easy way to get an overview of the items in and outside of their collection. Users can easily check each collectible off as obtained, making tracking their progress simple.

### Wishlist

Users can add collectibles to their wishlist, allowing them to track the items they are going for next. Viewing the wishlist provides information on how to obtain each ite.

### Details view

Every collectible has a details view which contains information on how to obtain the item. The details view is a good way to quickly get an idea of if it's viable to try to get an item now versus later.

## Development Details

Tenno Tab is a web application that has been developed in two main parts - a frontend client developed using Angular, and a backend webserver API leveraging Asp .net core API. Additionally, the project database uses seed data that was scraped from the Warframe fandom wiki [https://warframe.fandom.com/wiki/WARFRAME_Wiki] and then cleaned using some Python scripts. The database itself leverages SQLite.

The Angular client is hosted using Github Pages, and the API backend is hosted on a rasberry pi running raspbian with nginx. An https connection between the client and backend is established using DuckDNS along with EasyCert. Of course, as the project is openly available here on Github, anyone could setup their own hosting solution.

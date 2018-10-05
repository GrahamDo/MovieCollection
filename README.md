# MovieCollection

## Setup

1. Create a database on your SQL server (preferably called MovieCollection)
1. Execute the script in the file database-scripts.sql against your newly created database. If your database is not called MovieCollection, change the name at the top of the file first
1. If your database is not called MovieCollection, or your SQL server is not running on your local machine, change the connectionstring attribute of MovieCollectionEntities in app.config to reflect your environment
1. By default, only 200 movies are displayed at a time in the main grid. If you want to change this, edit the value of the MaxResultsAllowed setting in app.config. Set this to 0 to allow an infinite number of results

## Usage

1. Run the application from code (Visual Studio 2017 is required)
1. Click Locations, and add some (e.g. DVD, Downloaded, etc). Specify which locations (e.g. Downloaded) will require you to specify a URL when they're used on a movie. Locations are required to add movies
1. Optionally, add actors and directors (a person can be either an actor, a director, or both)
1. Add some movies
1. Enter text in the Title or Year textboxes, and select values in the Actor, Director, and Location dropdowns to filter your list of movies
1. Double-click a movie to edit it

## Next Steps

For next steps, see the TODOs at the top of MainForm.cs

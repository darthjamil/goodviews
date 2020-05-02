# Domain Model
## SOA Boundaries
The first step was to identify the major pieces of functionality.
These include being able to find a movie to watch or to comment on
and rate. This can be done via search, browse & explore / filter,
trending carousels, etc. Users can also create curated lists that they
can optionally share. Users also see a feed of friends activity.  

Then we identify bounded contexts. A client UI can read from multiple
bounded contexts in order to show a coherent UI. But one bounded context
should not require request/response-ing with other bounded contexts; as 
soon as that seems like a requirement, it's a sign that the SOA boundaries
are not correct. The various contexts should be passing messages back and 
forth instead.  

So we ended up with the following boundaries:
- Users (account info, privacy settings, etc.)
- Movies (movie details)
- Discovery (search criteria, user lists, curated lists, trending carousels)
- Ratings (movie stats, ratings, comments)
- Feeds (user feed events)  

## Domain Events
None of these require request/response between one another. They pass the
following events:
- User Deactivated (required for deactivating lists and so on)
- List Created/Amended (required for feeds)
- Rating or Comment Added (required for feeds)

# What I'm Learning
- Domain modeling

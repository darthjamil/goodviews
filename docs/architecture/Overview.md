# Architecture Log

## Breaking Down the Work
We want to deliver some value as quickly as possible. The original idea was
to allow as much as possible to unauthenticated users. But
that involves things like search, auto-updated lists, ML reccos. All of that
is high-cost to build. So we'll start with
- some blank-ish unauthenticated homepage

Then we'll move to things that don't require movie data
- authentication (Google Sign-In)
- ability to add friends

Before we move any further, we need a movies database.  

After that, we'll add the following major features, in the order that 
delivers the most number of complete use cases the quickest.
- browse by genre
- search (so you can find movies you've seen to rate them)
- the ability to rate and comment
- friends feeds
- movie summary pages
- carousels
- account settings
- personalized lists (shareable)
- ML-generated reccos
- ...

# What I'm Learning
... from an architectural perspective
- Agile SDLC principles in practice
- SOA and domain modeling
- DDD in practice
- data storage mechanisms
- search, indexing
- machine learning
- systems architecture, solutions architecture

... from a technology perspective
- CSS Grid
- React
- Software licensing
- SEO

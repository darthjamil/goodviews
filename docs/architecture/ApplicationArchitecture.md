# Application Architecture
Originally, the plan was to go with a DDD-based architecture,
with a separate UI layer, services layer, and data provider layer.
The worker would handle messages going back and forth between
bounded contexts, such as needing to deactivate user-lists when
a user account is closed. The service layer would have all the logic,
minus authentication, logging, and all such concerns that belong
along the boundaries. Finally, the provider layer would be
responsible for fetching and updating data against the data store,
to hide the details of that from the rest of the app.  

There is also a scheduler which periodically uses event data to 
pre-generate feeds for users to see. This is so that when they get to
the site, they already have a feed that can simply be loaded. We will
not generate feeds on the fly. Note, the feeds UI can poll the server,
and new feeds may be generated as the user is watching the page.  

However, although we will retain the UI/API layer, the worker, and the
scheduler, we'll collapse all "back-end" layers into one. The reasoning
is that the app is small enough to warrant this; and if it gets to
big, we'll divided it into microservices that are themselves very small.
Secondly, it's pretty much impossible to hide the details of a data store
entirely behind an application layer: You need to set up dependency injection
and app settings values and so on.

# What I'm Learning
- Application architecture
- Where to bend the rules

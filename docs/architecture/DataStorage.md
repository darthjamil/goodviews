# Data Storage
We'll be using RavenDB 4.x. The reason for this is that there
is no real need for a relational database. Furthermore, RavenDB
offers incredible performance out of the box, and can be used as
a cache, thus eliminating much of the need for a server-side cache.
Although we will still consider client-side, edge, and output caching.
RavenDB also operates well in a highly distributed, clustered
environment, with out-of-the-box replication, master/master clusters,
failover options, and more. It's also fully ACID. And it offers
rich querying capabilities, including MapReduce functionality.

# What I'm Learning
- RavenDB (see _Inside RavenDB 4.0_ by Oren Eini)

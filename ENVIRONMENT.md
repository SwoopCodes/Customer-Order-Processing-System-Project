# Environment configuration

The database connection string (including the password) is no longer hard-coded
in `Database.cs`. It is read from the `ORDER_DB_CONNECTION` environment variable.

## Set it before running the app

Windows (persists for your user):

    setx ORDER_DB_CONNECTION "Data Source=localhost/orcl;User Id=C##user1;Password=YOUR_NEW_PASSWORD"

Then restart Visual Studio so it picks up the new variable.

## Important

The old password (`REDACTED`) was committed to this repository's history.
Change the Oracle account's password to a new value and use that new value above.
Removing it from the current file does not remove it from past commits — see the
history-purge steps provided separately.

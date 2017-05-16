# SQL_Read_Write_MVC

This has turned into a secret word guessing game.
when the user enters a word that matches a word foiund in a SQL table, an animated .gif is displayed.
The past guesses and their date and time are saved in a SQL table and displayed along with the result.

Challenges:
1. Timezones
      A big challenge for me was displaying back the date and time with the correct time zone.
      - worked great locally, but when uploaded to a remote server in a different timezone the date time did not displayy correctly.
      - Studied best practices for storing and retrieving Date-Time from SQL.
      - Best practice appears to be storing as format UTC.
      - To display Date-Time correctly you must get the timezone offset from the users browser with javascript and then subtract it from           the stored Date-Time.
      
2. Formatting for both Desktop and Mobile<br>
      - lots of experimenting with CSS

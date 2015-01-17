# JRADataCleaner
a address cleanup wrapper for melissa data personator
This project attempst to improve on the Melissa data web services by encapsulating some of the gritty details and also allowing you to use a dictionary of errors which can be edited to address specific functional needs. 
MelissaCodes.json has a boolean FatalAddressError that is associated with each code.  

The main groovinesss is the fact that you can configure MelissaCodes.Json to decide which of the 100+ error codes you want to consider a ‘FatalAddressError’ -- meaning the record is not usable. I did what I thought was reasonable and similar to the conditions specified in the Melissa sample code. It throws an exception if the configuration and or the web service just won’t work. Otherwise each OutputStreetAddress has an array of ParseResult called Results. You can also get the Errors  as an array of ParseResult.




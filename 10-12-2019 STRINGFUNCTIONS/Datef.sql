Select getdate() as currentdatetime
/*it returns the current data and time */

Select datepart(day, getdate()) as currentdate;

SELECT DATEPART(MONTH,GETDATE()) AS CURRENTMONTH;

Select dateadd(day, 15, getdate()) as after15days ; /*it prints the date of after 15 days */
/*It will display the date and time by add or subtract date and time interval.
Syntax for the above function ?
DATEADD(datepart, number, datecolumnname)
*/
SELECT DATEADD(DAY,-5,GETDATE()) AS BEFORE5DAYSFROMNOW

Select datediff(HOUR, 1998-11-22, 2019-11-22) as DIFFERENCE /*It will display the date and time between two dates. */

SELECT CONVERT(VARCHAR(19),GETDATE())  /*it will dispaly the date with time */
SELECT CONVERT(VARCHAR(10),GETDATE(),10) /* it will print like year name like 19 */
SELECT CONVERT(VARCHAR(10),GETDATE(),110) /*it will print year completely like 2019 */
 

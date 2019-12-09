CREATE TABLE TBLGETDATE
(
    id         INT IDENTITY, 
    msg        VARCHAR(255) NOT NULL, 
    created_at DATETIME NOT NULL
                DEFAULT CURRENT_TIMESTAMP, 
    PRIMARY KEY(id)
);

INSERT INTO TBLGETDATE(msg)
VALUES('This is the first message.');
 
INSERT INTO TBLGETDATE(msg)
VALUES('TBLGETDATE');

SELECT 
    id, 
    msg, 
    created_at
FROM TBLGETDATE

DECLARE 
    @start_dt DATETIME2= '2019-12-31 23:59:59.9999999', 
    @end_dt DATETIME2= '2020-01-01 00:00:00.0000000';
 
SELECT /*difference between the start_date and end_date, with the unit specified by date_part.*/


    DATEDIFF(year, @start_dt, @end_dt) diff_in_year, 
    DATEDIFF(quarter, @start_dt, @end_dt) diff_in_quarter, 
    DATEDIFF(month, @start_dt, @end_dt) diff_in_month, 
    DATEDIFF(dayofyear, @start_dt, @end_dt) diff_in_dayofyear, 
    DATEDIFF(day, @start_dt, @end_dt) diff_in_day, 
    DATEDIFF(week, @start_dt, @end_dt) diff_in_week, 
    DATEDIFF(hour, @start_dt, @end_dt) diff_in_hour, 
    DATEDIFF(minute, @start_dt, @end_dt) diff_in_minute, 
    DATEDIFF(second, @start_dt, @end_dt) diff_in_second, 
    DATEDIFF(millisecond, @start_dt, @end_dt) diff_in_millisecond;
CREATE PROCEDURE [dbo].[spAddNewEmpPerson]
(

@Name varchar (200),
@Salary varchar(150),
@StartDate date,
@Gender varchar(1),
@ContactNumber varchar(10),
@Address varchar(50),
@Pay int,
@Deduction int,
@Texable int,
@IncomeTax int,
@NetPay int
	)
	
AS
SET XACT_ABORT on;
SET NOCOUNT ON;
BEGIN
BEGIN TRY
BEGIN TRANSACTION;
	SET NOCOUNT ON;
	DECLARE @new_identity INTEGER = 0;
	DECLARE @result bit = 0;
	INSERT INTO EmpDetail(Name, Salary, StartDate, Gender, ContactNumber, Address, Pay, Deduction, Texable, IncomeTax, NetPay)
	VALUES (@Name, @Salary, @StartDate, @Gender, @ContactNumber, @Address, @Pay, @Deduction, @Texable,@IncomeTax,@NetPay)
	SELECT @new_identity = @@IDENTITY;
	COMMIT TRANSACTION
	SET @result = 1;
	RETURN @result;
	END TRY
	BEGIN CATCH

	IF(XACT_STATE()) = -1
		BEGIN
		PRINT
		'Transaction is uncommitable' + ' Rolling back transaction'
		ROLLBACK TRANSACTION;
		RETURN @result;		
		END
	ELSE IF(XACT_STATE()) = 1
		BEGIN
		PRINT
		'Transaction is commitable' + ' Commiting back transaction'
		COMMIT TRANSACTION;
		SET @result = 1;
	    RETURN @result;
	END; 
	END CATCH
END
GO
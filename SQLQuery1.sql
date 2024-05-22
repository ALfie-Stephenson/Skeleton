USE [p2526198]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_FilterByCustomerNo]
		@CustomerNo = 2

SELECT	@return_value as 'Return Value'

GO
